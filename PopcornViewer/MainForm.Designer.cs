﻿namespace PopcornViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.YoutubeVideo = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.ChatLabel = new System.Windows.Forms.TextBox();
            this.ChatMembers = new System.Windows.Forms.ListBox();
            this.NicknameLabel = new System.Windows.Forms.TextBox();
            this.ChatHistory = new System.Windows.Forms.RichTextBox();
            this.ChatBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PlaylistLabel = new System.Windows.Forms.TextBox();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.PlaylistContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playPlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoPlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalFilesLabel = new System.Windows.Forms.TextBox();
            this.GroupFiles = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostingOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popcornHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPopcornViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YoutubeVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.PlaylistContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(834, 487);
            this.splitContainer1.SplitterDistance = 668;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.YoutubeVideo);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(668, 487);
            this.splitContainer3.SplitterDistance = 331;
            this.splitContainer3.TabIndex = 0;
            // 
            // YoutubeVideo
            // 
            this.YoutubeVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YoutubeVideo.Enabled = true;
            this.YoutubeVideo.Location = new System.Drawing.Point(12, 4);
            this.YoutubeVideo.Name = "YoutubeVideo";
            this.YoutubeVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("YoutubeVideo.OcxState")));
            this.YoutubeVideo.Size = new System.Drawing.Size(652, 328);
            this.YoutubeVideo.TabIndex = 0;
            this.YoutubeVideo.FlashCall += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEventHandler(this.YoutubeVideo_FlashCall);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ChatLabel);
            this.splitContainer4.Panel1.Controls.Add(this.ChatMembers);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.NicknameLabel);
            this.splitContainer4.Panel2.Controls.Add(this.ChatHistory);
            this.splitContainer4.Panel2.Controls.Add(this.ChatBox);
            this.splitContainer4.Size = new System.Drawing.Size(668, 152);
            this.splitContainer4.SplitterDistance = 164;
            this.splitContainer4.TabIndex = 0;
            // 
            // ChatLabel
            // 
            this.ChatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ChatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChatLabel.Location = new System.Drawing.Point(12, 3);
            this.ChatLabel.Name = "ChatLabel";
            this.ChatLabel.ReadOnly = true;
            this.ChatLabel.Size = new System.Drawing.Size(149, 20);
            this.ChatLabel.TabIndex = 2;
            this.ChatLabel.Text = "Chatting: 0";
            this.ChatLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChatLabel.WordWrap = false;
            // 
            // ChatMembers
            // 
            this.ChatMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatMembers.FormattingEnabled = true;
            this.ChatMembers.IntegralHeight = false;
            this.ChatMembers.Location = new System.Drawing.Point(12, 29);
            this.ChatMembers.Name = "ChatMembers";
            this.ChatMembers.Size = new System.Drawing.Size(149, 111);
            this.ChatMembers.TabIndex = 0;
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NicknameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NicknameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NicknameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NicknameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameLabel.Location = new System.Drawing.Point(4, 123);
            this.NicknameLabel.MaxLength = 12;
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.ReadOnly = true;
            this.NicknameLabel.Size = new System.Drawing.Size(58, 13);
            this.NicknameLabel.TabIndex = 3;
            this.NicknameLabel.Text = "Guest:";
            this.NicknameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChatHistory
            // 
            this.ChatHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatHistory.BackColor = System.Drawing.SystemColors.Window;
            this.ChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChatHistory.Location = new System.Drawing.Point(4, 6);
            this.ChatHistory.Name = "ChatHistory";
            this.ChatHistory.ReadOnly = true;
            this.ChatHistory.Size = new System.Drawing.Size(493, 108);
            this.ChatHistory.TabIndex = 2;
            this.ChatHistory.Text = "";
            this.ChatHistory.TextChanged += new System.EventHandler(this.ChatHistory_TextChanged);
            // 
            // ChatBox
            // 
            this.ChatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatBox.Location = new System.Drawing.Point(67, 120);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(429, 20);
            this.ChatBox.TabIndex = 0;
            this.ChatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatBox_KeyDown);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PlaylistLabel);
            this.splitContainer2.Panel1.Controls.Add(this.Playlist);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LocalFilesLabel);
            this.splitContainer2.Panel2.Controls.Add(this.GroupFiles);
            this.splitContainer2.Size = new System.Drawing.Size(162, 487);
            this.splitContainer2.SplitterDistance = 333;
            this.splitContainer2.TabIndex = 0;
            // 
            // PlaylistLabel
            // 
            this.PlaylistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PlaylistLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlaylistLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PlaylistLabel.Location = new System.Drawing.Point(3, 3);
            this.PlaylistLabel.Name = "PlaylistLabel";
            this.PlaylistLabel.ReadOnly = true;
            this.PlaylistLabel.Size = new System.Drawing.Size(147, 20);
            this.PlaylistLabel.TabIndex = 0;
            this.PlaylistLabel.Text = "Playlist Count: 0";
            this.PlaylistLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlaylistLabel.WordWrap = false;
            // 
            // Playlist
            // 
            this.Playlist.AllowDrop = true;
            this.Playlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Playlist.ContextMenuStrip = this.PlaylistContextMenu;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.HorizontalScrollbar = true;
            this.Playlist.IntegralHeight = false;
            this.Playlist.Location = new System.Drawing.Point(3, 29);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(147, 301);
            this.Playlist.TabIndex = 0;
            this.Playlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.Playlist_DragDrop);
            this.Playlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.Playlist_DragEnter);
            this.Playlist.DragOver += new System.Windows.Forms.DragEventHandler(this.Playlist_DragOver);
            this.Playlist.DoubleClick += new System.EventHandler(this.Playlist_DoubleClick);
            this.Playlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Playlist_KeyDown);
            this.Playlist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Playlist_MouseDown);
            this.Playlist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playlist_MouseMove);
            this.Playlist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Playlist_MouseUp);
            // 
            // PlaylistContextMenu
            // 
            this.PlaylistContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPlaylistMenuItem,
            this.copyPlaylistMenuItem,
            this.deletePlaylistMenuItem,
            this.addVideoPlaylistMenuItem});
            this.PlaylistContextMenu.Name = "PlaylistContextMenu";
            this.PlaylistContextMenu.Size = new System.Drawing.Size(214, 92);
            this.PlaylistContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.PlaylistContextMenu_Opening);
            // 
            // playPlaylistMenuItem
            // 
            this.playPlaylistMenuItem.Name = "playPlaylistMenuItem";
            this.playPlaylistMenuItem.Size = new System.Drawing.Size(213, 22);
            this.playPlaylistMenuItem.Text = "Play";
            this.playPlaylistMenuItem.Click += new System.EventHandler(this.playPlaylistMenuItem_Click);
            // 
            // copyPlaylistMenuItem
            // 
            this.copyPlaylistMenuItem.Name = "copyPlaylistMenuItem";
            this.copyPlaylistMenuItem.Size = new System.Drawing.Size(213, 22);
            this.copyPlaylistMenuItem.Text = "Copy";
            this.copyPlaylistMenuItem.Click += new System.EventHandler(this.copyPlaylistMenuItem_Click);
            // 
            // deletePlaylistMenuItem
            // 
            this.deletePlaylistMenuItem.Name = "deletePlaylistMenuItem";
            this.deletePlaylistMenuItem.Size = new System.Drawing.Size(213, 22);
            this.deletePlaylistMenuItem.Text = "Delete";
            this.deletePlaylistMenuItem.Click += new System.EventHandler(this.deletePlaylistMenuItem_Click);
            // 
            // addVideoPlaylistMenuItem
            // 
            this.addVideoPlaylistMenuItem.Name = "addVideoPlaylistMenuItem";
            this.addVideoPlaylistMenuItem.Size = new System.Drawing.Size(213, 22);
            this.addVideoPlaylistMenuItem.Text = "Add Video from Clipboard";
            this.addVideoPlaylistMenuItem.Click += new System.EventHandler(this.addVideoPlaylistMenuItem_Click);
            // 
            // LocalFilesLabel
            // 
            this.LocalFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocalFilesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.LocalFilesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalFilesLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LocalFilesLabel.Location = new System.Drawing.Point(3, 3);
            this.LocalFilesLabel.Name = "LocalFilesLabel";
            this.LocalFilesLabel.ReadOnly = true;
            this.LocalFilesLabel.Size = new System.Drawing.Size(147, 20);
            this.LocalFilesLabel.TabIndex = 1;
            this.LocalFilesLabel.Text = "Local Files: 0";
            this.LocalFilesLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LocalFilesLabel.WordWrap = false;
            // 
            // GroupFiles
            // 
            this.GroupFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupFiles.Location = new System.Drawing.Point(3, 29);
            this.GroupFiles.Name = "GroupFiles";
            this.GroupFiles.Size = new System.Drawing.Size(147, 109);
            this.GroupFiles.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.pasteToolStripMenuItem.Text = "Add Video to Playlist";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatOneToolStripMenuItem,
            this.repeatAllToolStripMenuItem,
            this.shuffleToolStripMenuItem,
            this.playNextToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.toolsToolStripMenuItem.Text = "Playback";
            // 
            // repeatOneToolStripMenuItem
            // 
            this.repeatOneToolStripMenuItem.Name = "repeatOneToolStripMenuItem";
            this.repeatOneToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.repeatOneToolStripMenuItem.Text = "Repeat One";
            this.repeatOneToolStripMenuItem.Click += new System.EventHandler(this.repeatOneToolStripMenuItem_Click);
            // 
            // repeatAllToolStripMenuItem
            // 
            this.repeatAllToolStripMenuItem.Name = "repeatAllToolStripMenuItem";
            this.repeatAllToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.repeatAllToolStripMenuItem.Text = "Repeat All";
            this.repeatAllToolStripMenuItem.Click += new System.EventHandler(this.repeatAllToolStripMenuItem_Click);
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            this.shuffleToolStripMenuItem.Click += new System.EventHandler(this.shuffleToolStripMenuItem_Click);
            // 
            // playNextToolStripMenuItem
            // 
            this.playNextToolStripMenuItem.Checked = true;
            this.playNextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playNextToolStripMenuItem.Name = "playNextToolStripMenuItem";
            this.playNextToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.playNextToolStripMenuItem.Text = "Play Next";
            this.playNextToolStripMenuItem.Click += new System.EventHandler(this.playNextToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pauseToolStripMenuItem.Text = "Pause After Playback";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostingOptionsToolStripMenuItem,
            this.manageGroupToolStripMenuItem,
            this.chatOptionsToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // hostingOptionsToolStripMenuItem
            // 
            this.hostingOptionsToolStripMenuItem.Name = "hostingOptionsToolStripMenuItem";
            this.hostingOptionsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hostingOptionsToolStripMenuItem.Text = "Network List";
            this.hostingOptionsToolStripMenuItem.Click += new System.EventHandler(this.hostingOptionsToolStripMenuItem_Click);
            // 
            // manageGroupToolStripMenuItem
            // 
            this.manageGroupToolStripMenuItem.Name = "manageGroupToolStripMenuItem";
            this.manageGroupToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.manageGroupToolStripMenuItem.Text = "Manage Group";
            // 
            // chatOptionsToolStripMenuItem
            // 
            this.chatOptionsToolStripMenuItem.Name = "chatOptionsToolStripMenuItem";
            this.chatOptionsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.chatOptionsToolStripMenuItem.Text = "Chat Options";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popcornHomepageToolStripMenuItem,
            this.aboutPopcornViewerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // popcornHomepageToolStripMenuItem
            // 
            this.popcornHomepageToolStripMenuItem.Name = "popcornHomepageToolStripMenuItem";
            this.popcornHomepageToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.popcornHomepageToolStripMenuItem.Text = "Popcorn Homepage";
            // 
            // aboutPopcornViewerToolStripMenuItem
            // 
            this.aboutPopcornViewerToolStripMenuItem.Name = "aboutPopcornViewerToolStripMenuItem";
            this.aboutPopcornViewerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.aboutPopcornViewerToolStripMenuItem.Text = "About Popcorn Viewer";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(834, 487);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(834, 511);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "Popcorn Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YoutubeVideo)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.PlaylistContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView GroupFiles;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private AxShockwaveFlashObjects.AxShockwaveFlash YoutubeVideo;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox ChatMembers;
        private System.Windows.Forms.TextBox PlaylistLabel;
        private System.Windows.Forms.TextBox LocalFilesLabel;
        private System.Windows.Forms.TextBox ChatLabel;
        private System.Windows.Forms.TextBox ChatBox;
        private System.Windows.Forms.RichTextBox ChatHistory;
        private System.Windows.Forms.ContextMenuStrip PlaylistContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyPlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVideoPlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPlaylistMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem repeatAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popcornHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutPopcornViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostingOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ListBox Playlist;
        public System.Windows.Forms.TextBox NicknameLabel;

    }
}

