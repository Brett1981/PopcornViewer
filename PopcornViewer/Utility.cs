﻿using System;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using Google.YouTube;

namespace PopcornViewer
{
    public partial class MainForm
    {
        // URL Conversion Tools
        private string ConvertURLToEmbeded(string url)
        {
            url = url.Replace("/watch?", "/");
            url = url.Replace('=', '/');
            url = url + "?version=3&enablejsapi=1";
            return url;
        }

        private string ConvertURLToBrowser(string url)
        {
            url = url.Replace("?version=3&enablejsapi=1", "");
            url = url.Replace("/v/", "/watch?v=");
            return url;
        }


        // Adds videos to Playlist given a browser URL
        private bool AddToPlaylist(string url)
        {
            if (IsYoutubeURL(url))
            {
                PlaylistURLs.Add(ConvertURLToEmbeded(url));
                Video video = RequestFromYoutube(url);
                Playlist.Items.Add(video.Title);
                UpdatePlaylistCount();
                if (Hosting)
                {
                    Broadcast("has added " + video.Title + " to the playlist", NicknameLabel.Text, false);
                    BroadcastPlaylist();
                }
                return true;
            }
            else return false;
        }

        // Changes the text on the PlaylistLabel to reflect number of videos added
        private void UpdatePlaylistCount()
        {
            PlaylistLabel.Text = PlaylistLabel.Text.Substring(0, PlaylistLabel.Text.Length - 1);
            PlaylistLabel.Text = PlaylistLabel.Text + Playlist.Items.Count;
        }

        // Ensures that the given URL is actually for a Youtube video.
        private bool IsYoutubeURL(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return (response.ResponseUri.ToString().Contains("youtube.com") &&
                            response.ResponseUri.ToString().Contains("watch?v=") &&
                            // Makes sure playlists are not able to be added since they are not videos
                            !response.ResponseUri.ToString().Contains("&list"));
                }
            }
            catch { return false; }
        }

        // Code for handling Youtube requests from a specific URL. Requires a Youtube link be verrified first.
        private Video RequestFromYoutube(string url)
        {
            string uri = url.Remove(0, url.IndexOf('=') + 1);

            YouTubeRequestSettings settings = new YouTubeRequestSettings("Popcorn Viewer", DEV_STRING);
            YouTubeRequest req = new YouTubeRequest(settings);

            Uri videoEntryUrl = new Uri("http://gdata.youtube.com/feeds/api/videos/" + uri);

            return req.Retrieve<Video>(videoEntryUrl);
        }

        // Performs bundled functions to play a video at URL index
        private void PlayVideo(int Index)
        {
            CurrentlyPlaying = Index;
            if (YoutubeVideo.Movie == null)
            {
                YoutubeVideo.Movie = PlaylistURLs[Index];
            }
            YoutubeVideo_CallFlash("loadVideoByUrl(" + PlaylistURLs[Index] + ")");
            YoutubeVideo_CallFlash("playVideo()");

            Playlist.Refresh();
        }

        // Called in order to remove a video from the playlist given an index
        private void DeleteVideo(int Index)
        {
            string Title = Playlist.Items[Index].ToString();
            PlaylistURLs.RemoveAt(Index);
            Playlist.Items.RemoveAt(Index);
            UpdatePlaylistCount();

            if (Index == CurrentlyPlaying)
            {
                if (PlaylistURLs.Count <= Index && PlaylistURLs.Count != 0)
                {
                    PlayVideo(PlaylistURLs.Count - 1);
                }
                else if (PlaylistURLs.Count == 0)
                {
                    YoutubeVideo.Movie = null;
                }
                else PlayVideo(CurrentlyPlaying);
            }
            else if (Index < CurrentlyPlaying)
            {
                CurrentlyPlaying--;
                Playlist.Refresh();
            }
            if (Hosting)
            {
                Broadcast("has removed " + Title + " from the playlist", NicknameLabel.Text, false);
                BroadcastPlaylist();
            }
        }

        // Used to turn off all other checks in the playback toolstrip.
        private void UncheckPlaybackOptions()
        {
            repeatAllToolStripMenuItem.Checked = false;
            repeatOneToolStripMenuItem.Checked = false;
            shuffleToolStripMenuItem.Checked = false;
            playNextToolStripMenuItem.Checked = false;
            pauseToolStripMenuItem.Checked = false;
        }

        // Listener function. Host listens for incoming TCP connections and begins speak threads.
        public void Listen(object sender, DoWorkEventArgs e)
        {
            Chat("Initiating chat service...", "CONSOLE");

            ServerSocket = new TcpListener(IPAddress.Any, HostPort);
            ClientSocket = default(TcpClient);
            bool Started = true;

            ClientsList = new Hashtable();

            try { ServerSocket.Start(); }
            catch
            {
                Chat("Unable to bind to port.", "CONSOLE");
                Started = false;
            }

            Hosting = true;

            while (Started)
            {
                // Listen
                try { ClientSocket = ServerSocket.AcceptTcpClient(); }
                catch { return; }

                byte[] BytesIn = new byte[65536];
                string DataFromClient;

                // Get name of new client
                NetworkStream Stream = ClientSocket.GetStream();
                Stream.Read(BytesIn, 0, (int)ClientSocket.ReceiveBufferSize);
                DataFromClient = Decrypt(System.Text.Encoding.UTF8.GetString(BytesIn));

                // If somehow they have the same name as someone else
                try { ClientsList.Add(DataFromClient, ClientSocket); }
                catch
                {
                    Broadcast("Client hash colission! Host terminating session...", "CONSOLE", true);
                    return;
                }

                // Display appropriate messages
                Broadcast("has joined the room", DataFromClient, false);

                // Launch speaker thread
                Thread ChatThread2 = new Thread(() => Speak(ClientSocket, DataFromClient));
                ChatClient2Threads.Add(ChatThread2);
                ChatThread2.Start();

                // Send list of clients & playlist to everyone
                Thread.Sleep(200);
                BroadcastClientsList();
                Thread.Sleep(200);
                BroadcastPlaylist();
            }

            Hosting = false;

            try
            {
                ClientSocket.Close();
                ServerSocket.Stop();
            }
            catch { }
            Chat("Terminating chat service...", "CONSOLE");
        }

        // Host only function. Sends message over TCP to all connected entities.
        public static void Broadcast(string Message, string Entity, bool ClientFlag)
        {
            try
            {
                foreach (DictionaryEntry Item in ClientsList)
                {
                    TcpClient BroadcastSocket = (TcpClient)Item.Value;

                    NetworkStream BroadcastStream = BroadcastSocket.GetStream();
                    Byte[] BroadcastBytes;

                    // Empty entity is information transfer not to be displayed in chat
                    if (Entity == "")
                    {
                        string[] Command = Message.Split(' ');
                        switch (Command[0])
                        {
                            case "NEWCLIENTSLIST":
                            case "NEWPLAYLIST":
                                BroadcastBytes = Encoding.UTF8.GetBytes(Encrypt(Message) + "$");
                                break;
                            default:
                                BroadcastBytes = Encoding.UTF8.GetBytes(Encrypt("\n[" + DateTime.Now.ToString("HH:mm:ss") + "] CONSOLE: An unexpected error occured.") + "$");
                                break;
                        }
                    }
                    else
                    {
                        // When info sent is a message to be displayed client flag indicates ownership of message
                        if (ClientFlag)
                        {
                            BroadcastBytes = Encoding.UTF8.GetBytes(Encrypt("\n[" + DateTime.Now.ToString("HH:mm:ss") + "] " + Entity + ": " + Message) + "$");
                        }
                        else
                        {
                            BroadcastBytes = Encoding.UTF8.GetBytes(Encrypt("\n[" + DateTime.Now.ToString("HH:mm:ss") + "] " + Entity + " " + Message) + "$");
                        }
                    }

                    BroadcastStream.Write(BroadcastBytes, 0, BroadcastBytes.Length);
                    BroadcastStream.Flush();
                }
            }
            catch { }
        }

        // Used when clients join/leave. Allows chatting members to recieve list of who they speak to
        private void BroadcastClientsList()
        {
            string Clients = "NEWCLIENTSLIST ";
            foreach (DictionaryEntry Name in ClientsList)
            {
                Clients += Name.Key;
                Clients += " ";
            }

            Broadcast(Clients, "", false);
        }

        // Keeps playlist up to date in all clients
        private void BroadcastPlaylist()
        {
            string Playlist = "NEWPLAYLIST ";
            foreach (string url in PlaylistURLs)
            {
                Playlist += url;
                Playlist += " ";
            }

            Broadcast(Playlist, "", false);
        }

        // One function thread for each TCP connection host keeps track of. Used to recieve and process their messages.
        private void Speak(TcpClient ClientSocket, string Entity)
        {
            byte[] BytesFrom = new byte[65536];

            while (true)
            {
                try
                {
                    NetworkStream Stream = ClientSocket.GetStream();
                    Stream.Read(BytesFrom, 0, (int)ClientSocket.ReceiveBufferSize);
                    // Splits message on $ 
                    string[] Message = System.Text.Encoding.UTF8.GetString(BytesFrom).Split('$');
                    Message[1] = Decrypt(Message[1] + "$");
                    if (Message[0] == "" || Message[1] == "")
                    {
                        ClientsList.Remove(Entity);
                        Broadcast("has left the room", Entity, false);
                        BroadcastClientsList();
                        return;
                    }
                    // Client communication handling
                    else
                    {
                        switch (Message[0])
                        {
                            case "PLAYLIST":
                                break;
                            default:
                                Broadcast(Message[1], Entity, true);
                                break;
                        }
                    }
                }
                catch
                {
                    ClientsList.Remove(Entity);
                    Broadcast("has left the room", Entity, false);
                    BroadcastClientsList();
                    return;
                }
                Thread.Sleep(200);
            }
        }

        // Client function. Activates whenever clients are connected. Gets messages from host
        public void GetMessage(object sender, DoWorkEventArgs e)
        {
            while (SelfSocket != null && SelfSocket.Connected)
            {
                SelfStream = SelfSocket.GetStream();
                byte[] InStream = new byte[65536];
                try 
                {
                    if (SelfSocket.Connected)
                    {
                        SelfStream.Read(InStream, 0, SelfSocket.ReceiveBufferSize);
                    }
                }
                catch { break; }
                string Mess = Decrypt(Encoding.UTF8.GetString(InStream));
                string[] Message = Mess.Split(' ');

                // How to deal with message, first word delim by spaces determines message use
                switch (Message[0])
                {
                    // Incoming new list of chatting members
                    case "NEWCLIENTSLIST":
                        ClientListUpdate(Message);
                        break;
                    // Incoming new playlist information
                    case "NEWPLAYLIST":
                        PlaylistUpdate(Message);
                        break;
                    // The usual chat message
                    default:
                        string TotalMessage = "";
                        foreach (string s in Message)
                        {
                            TotalMessage += s;
                            TotalMessage += " ";
                        }
                        TotalMessage = TotalMessage.Substring(0, TotalMessage.Length - 1);
                        ClientChat(TotalMessage);
                        break;
                }
                Thread.Sleep(200);
            }
            Chat("Lost connection from server...", "CONSOLE");
        }

        // Called from inside non-main thread thus invoke required. Updates the chatting members when new list info is had.
        private void ClientListUpdate(string[] Message)
        {
            if (this.InvokeRequired)
            {
                try { this.Invoke(new Action<string[]>(ClientListUpdate), new object[] { Message }); }
                catch { return; }
            }
            else
            {
                ChatMembers.Items.Clear();
                for (int i = 1; i < Message.Length - 1; i++)
                {
                    ChatMembers.Items.Add(Message[i]);
                }
                ChatLabel.Text = "Chatting: " + ChatMembers.Items.Count;
            }
        }

        // Called from inside non-main thread thus invoke required. Updates the playlist when new list info is had.
        private void PlaylistUpdate(string[] Message)
        {
            if (this.InvokeRequired)
            {
                try { this.Invoke(new Action<string[]>(PlaylistUpdate), new object[] { Message }); }
                catch { return; }
            }
            else
            {
                PlaylistURLs.Clear();
                Playlist.Items.Clear();
                for (int i = 1; i < Message.Length - 1; i++)
                {
                    PlaylistURLs.Add(Message[i]);
                    Video video = RequestFromYoutube(ConvertURLToBrowser(Message[i]));
                    Playlist.Items.Add(video.Title);
                }
                PlaylistLabel.Text = "Playlist Count: " + Playlist.Items.Count;
            }
        }

        // Sends chat to chatbox. Thread safe.
        public void Chat(string Message, string Entity)
        {
            if (InvokeRequired)
            {
                try { this.Invoke(new Action<string, string>(Chat), new object[] { Message, Entity }); }
                catch { }
                return;
            }
            if (ChatHistory.Text == "")
                ChatHistory.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + Entity + ": " + Message);
            else ChatHistory.AppendText("\n[" + DateTime.Now.ToString("HH:mm:ss") + "] " + Entity + ": " + Message);
        }

        // Mostly deprecated. Use only for SELF sent messages. Seen by only the client this function is called in.
        private void ClientChat(string Msg)
        {
            if (Msg != "")
            {
                if (this.InvokeRequired)
                    try { this.Invoke(new Action<string>(ClientChat), new object[] { Msg }); }
                    catch { return; }
                else
                    ChatHistory.AppendText(Msg);
            }
        }
    }
}
