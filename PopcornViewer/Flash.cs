﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Collections;
using System.Text.RegularExpressions;

namespace PopcornViewer
{
    public partial class MainForm
    {
        // Handles the Flash -> C# communication
        private void YoutubeVideo_FlashCall(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEvent e)
        {
            // Interpret the Command
            XmlDocument document = new XmlDocument();
            document.LoadXml(e.request);
            XmlAttributeCollection attributes = document.FirstChild.Attributes;
            string command = attributes.Item(0).InnerText;
            XmlNodeList list = document.GetElementsByTagName("arguments");
            List<string> listS = new List<string>();
            foreach (XmlNode l in list)
            {
                listS.Add(l.InnerText);
            }

            // Event Handler Flash -> C#
            switch (command)
            {
                // Initialize the Listeners
                case "onYouTubePlayerReady":
                    YoutubeVideo_CallFlash("addEventListener(\"onStateChange\",\"YTStateChange\")");
                    YoutubeVideo_CallFlash("addEventListener(\"onError\",\"YTError\")");
                    break;

                // On State Change
                case "YTStateChange":
                    switch (int.Parse(listS[0]))
                    {
                        // Not Started
                        case -1:
                            YoutubeVideo_CallFlash("playVideo()");
                            break;

                        // Ended
                        case 0:
                            // To avoid having clients finish shortly before/after
                            if (Hosting)
                            {
                                // Repeat All
                                if (repeatAllToolStripMenuItem.Checked)
                                {
                                    if (PlaylistURLs.Count - 1 > CurrentlyPlaying)
                                    {
                                        PlayVideo(CurrentlyPlaying + 1, false);
                                    }
                                    else PlayVideo(0, false);
                                }

                                // Play Next
                                else if (playNextToolStripMenuItem.Checked)
                                {
                                    if (PlaylistURLs.Count - 1 > CurrentlyPlaying)
                                    {
                                        PlayVideo(CurrentlyPlaying + 1, false);
                                    }
                                    else
                                    {
                                        Internal_Command = true;
                                        YoutubeVideo_CallFlash("seekTo(0, 0)");
                                        YoutubeVideo_CallFlash("pauseVideo()");
                                        Internal_Command = false;
                                    }
                                }

                                // Repeat One
                                else if (repeatOneToolStripMenuItem.Checked)
                                {
                                    PlayVideo(CurrentlyPlaying, false);
                                }

                                // Shuffle
                                else if (shuffleToolStripMenuItem.Checked)
                                {
                                    Random random = new Random();
                                    int nextVideo = random.Next(0, PlaylistURLs.Count);

                                    PlayVideo(nextVideo, false);
                                }
                                else
                                {
                                    Internal_Command = true;
                                    YoutubeVideo_CallFlash("seekTo(0, 0)");
                                    YoutubeVideo_CallFlash("pauseVideo()");
                                    Internal_Command = false;
                                }
                            }
                            else
                            {
                                    Internal_Command = true;
                                    YoutubeVideo_CallFlash("seekTo(0, 0)");
                                    YoutubeVideo_CallFlash("pauseVideo()");
                                    Internal_Command = false;
                            }
                            break;
                            
                        // Playing
                        case 1:
                            if (!Internal_Command)
                            {
                                Seek_Immunity = true;
                                string sTime = YoutubeVideo_CallFlash("getCurrentTime()");
                                sTime = sTime.Remove(sTime.Length - 9).Remove(0, 8);
                                if (Hosting) Broadcast("PLAY " + sTime, "", false);
                                else if (!First_Connect)
                                {
                                    ClientBroadcast("PLAY$" + sTime + "$");
                                }
                                else First_Connect = false;
                            }
                            First_Connect = false;
                            break;

                        // Paused
                        case 2:
                            if (!Internal_Command)
                            {
                                string CurrentTime = YoutubeVideo_CallFlash("getCurrentTime()");
                                CurrentTime = CurrentTime.Remove(CurrentTime.Length - 9).Remove(0, 8);
                                double iCurrentTime = Convert.ToDouble(CurrentTime);

                                string Duration = YoutubeVideo_CallFlash("getDuration()");
                                Duration = Duration.Remove(Duration.Length - 9).Remove(0, 8);
                                double iDuration = Convert.ToDouble(Duration);

                                double Difference = iDuration - iCurrentTime;

                                if (iCurrentTime != 0 && Difference >= 1)
                                {
                                    if (Hosting) Broadcast("PAUSE", "", false);
                                    else
                                    {
                                        ClientBroadcast("PAUSE$");
                                    }
                                }
                            }
                            break;

                        // Buffering
                        case 3:
                            if (!Internal_Command)
                            {
                                if (Seek_Immunity)
                                {
                                    Internal_Command = true;
                                    YoutubeVideo_CallFlash("playVideo()");
                                    Internal_Command = false;
                                }
                                else if (YoutubeVideo_CallFlash("getCurrentTime()") != YoutubeVideo_CallFlash("getDuration()") && YoutubeVideo_CallFlash("getCurrentTime()") != "<number>0</number>")
                                {
                                    if (Hosting) Broadcast("PAUSE", "", false);
                                    else
                                    {
                                        ClientBroadcast("PAUSE$");
                                    }
                                }
                            }
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        // Calls functions in the Flash Player
        private string YoutubeVideo_CallFlash(string function)
        {
            string flashXMLrequest = "";
            string response = "";
            string flashFunction = "";
            List<string> flashFunctionArgs = new List<string>();

            Regex func2xml = new Regex(@"([a-z][a-z0-9]*)(\(([^)]*)\))?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Match fmatch = func2xml.Match(function);

            // Bad Function Request String
            if (fmatch.Captures.Count != 1)
            {
                return "";
            }

            flashFunction = fmatch.Groups[1].Value.ToString();
            flashXMLrequest = "<invoke name=\"" + flashFunction + "\" returntype=\"xml\">";
            if (fmatch.Groups[3].Value.Length > 0)
            {
                flashFunctionArgs = parseDelimitedString(fmatch.Groups[3].Value);
                if (flashFunctionArgs.Count > 0)
                {
                    flashXMLrequest += "<arguments><string>";
                    flashXMLrequest += string.Join("</string><string>", flashFunctionArgs);
                    flashXMLrequest += "</string></arguments>";
                }
            }
            flashXMLrequest += "</invoke>";

            try
            {
                response = YoutubeVideo.CallFunction(flashXMLrequest);
            }
            catch { }

            return response;
        }

        // Creates flash args
        private static List<string> parseDelimitedString(string arguments, char delim = ',')
        {
            bool inQuotes = false;
            bool inNonQuotes = false;
            int whiteSpaceCount = 0;

            List<string> strings = new List<string>();

            StringBuilder sb = new StringBuilder();
            foreach (char c in arguments)
            {
                if (c == '\'' || c == '"')
                {
                    if (!inQuotes)
                        inQuotes = true;
                    else
                        inQuotes = false;

                    whiteSpaceCount = 0;
                }

                else if (c == delim)
                {
                    if (!inQuotes)
                    {
                        if (whiteSpaceCount > 0 && inQuotes)
                        {
                            sb.Remove(sb.Length - whiteSpaceCount, whiteSpaceCount);
                            inNonQuotes = false;
                        }
                        strings.Add(sb.Replace("'", string.Empty).Replace("\"", string.Empty).ToString());
                        sb.Remove(0, sb.Length);
                    }

                    else
                    {
                        sb.Append(c);
                    }
                    whiteSpaceCount = 0;
                }

                else if (char.IsWhiteSpace(c))
                {
                    if (inNonQuotes || inQuotes)
                    {
                        sb.Append(c);
                        whiteSpaceCount++;
                    }
                }

                else
                {
                    if (!inQuotes) inNonQuotes = true;
                    sb.Append(c);
                    whiteSpaceCount = 0;
                }
            }
            strings.Add(sb.Replace("'", string.Empty).Replace("\"", string.Empty).ToString());

            return strings;
        }
    }
}
