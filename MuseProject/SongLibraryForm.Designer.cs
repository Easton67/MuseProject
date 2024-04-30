namespace MuseProject
{
    partial class SongLibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongLibraryForm));
            this.lblSongPlayingTitleWithArtist = new System.Windows.Forms.Label();
            this.lblAddSong = new System.Windows.Forms.Label();
            this.listViewSongs = new System.Windows.Forms.ListView();
            this.colAlbumArt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripSelectedSong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListAlbumArt = new System.Windows.Forms.ImageList(this.components);
            this.lblCurrentSongtime = new System.Windows.Forms.Label();
            this.SongTimeElapsed = new System.Windows.Forms.Timer(this.components);
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.progressBarCurrentSongPlaying = new System.Windows.Forms.ProgressBar();
            this.pictureBoxNavBar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAddButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxResumeButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxRestartButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxNextButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbumArt = new System.Windows.Forms.PictureBox();
            this.pictureBoxMuseLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPauseButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxDropShadow = new System.Windows.Forms.PictureBox();
            this.pictureBoxNavBar = new System.Windows.Forms.PictureBox();
            this.lblSongLibrary = new System.Windows.Forms.Label();
            this.lblSongLength = new System.Windows.Forms.Label();
            this.pictureBoxPlayButton = new System.Windows.Forms.PictureBox();
            this.contextMenuStripSelectedSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMuseLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDropShadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSongPlayingTitleWithArtist
            // 
            this.lblSongPlayingTitleWithArtist.AutoSize = true;
            this.lblSongPlayingTitleWithArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblSongPlayingTitleWithArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongPlayingTitleWithArtist.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSongPlayingTitleWithArtist.Location = new System.Drawing.Point(497, 19);
            this.lblSongPlayingTitleWithArtist.Name = "lblSongPlayingTitleWithArtist";
            this.lblSongPlayingTitleWithArtist.Size = new System.Drawing.Size(0, 32);
            this.lblSongPlayingTitleWithArtist.TabIndex = 1;
            // 
            // lblAddSong
            // 
            this.lblAddSong.AutoSize = true;
            this.lblAddSong.BackColor = System.Drawing.Color.Transparent;
            this.lblAddSong.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSong.ForeColor = System.Drawing.Color.Thistle;
            this.lblAddSong.Location = new System.Drawing.Point(89, 393);
            this.lblAddSong.Name = "lblAddSong";
            this.lblAddSong.Size = new System.Drawing.Size(125, 26);
            this.lblAddSong.TabIndex = 2;
            this.lblAddSong.Text = "Add Song";
            // 
            // listViewSongs
            // 
            this.listViewSongs.BackColor = System.Drawing.SystemColors.Desktop;
            this.listViewSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAlbumArt,
            this.colTitle,
            this.colArtist,
            this.colYear});
            this.listViewSongs.ContextMenuStrip = this.contextMenuStripSelectedSong;
            this.listViewSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSongs.ForeColor = System.Drawing.SystemColors.Control;
            this.listViewSongs.HideSelection = false;
            this.listViewSongs.LargeImageList = this.imageListAlbumArt;
            this.listViewSongs.Location = new System.Drawing.Point(284, 341);
            this.listViewSongs.MultiSelect = false;
            this.listViewSongs.Name = "listViewSongs";
            this.listViewSongs.RightToLeftLayout = true;
            this.listViewSongs.Size = new System.Drawing.Size(686, 334);
            this.listViewSongs.SmallImageList = this.imageListAlbumArt;
            this.listViewSongs.TabIndex = 21;
            this.listViewSongs.UseCompatibleStateImageBehavior = false;
            this.listViewSongs.View = System.Windows.Forms.View.Tile;
            this.listViewSongs.DoubleClick += new System.EventHandler(this.listViewSongs_DoubleClick);
            this.listViewSongs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSongs_MouseClick);
            // 
            // colAlbumArt
            // 
            this.colAlbumArt.Text = "Album Art";
            this.colAlbumArt.Width = 100;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 167;
            // 
            // colArtist
            // 
            this.colArtist.Text = "Artist";
            this.colArtist.Width = 127;
            // 
            // colYear
            // 
            this.colYear.Text = "Year";
            this.colYear.Width = 195;
            // 
            // contextMenuStripSelectedSong
            // 
            this.contextMenuStripSelectedSong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripSelectedSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSongToolStripMenuItem});
            this.contextMenuStripSelectedSong.Name = "contextMenuStripSelectedSong";
            this.contextMenuStripSelectedSong.Size = new System.Drawing.Size(143, 28);
            // 
            // editSongToolStripMenuItem
            // 
            this.editSongToolStripMenuItem.Name = "editSongToolStripMenuItem";
            this.editSongToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.editSongToolStripMenuItem.Text = "Edit Song";
            this.editSongToolStripMenuItem.Click += new System.EventHandler(this.editSongToolStripMenuItem_Click);
            // 
            // imageListAlbumArt
            // 
            this.imageListAlbumArt.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListAlbumArt.ImageSize = new System.Drawing.Size(50, 50);
            this.imageListAlbumArt.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblCurrentSongtime
            // 
            this.lblCurrentSongtime.AutoSize = true;
            this.lblCurrentSongtime.Location = new System.Drawing.Point(925, 61);
            this.lblCurrentSongtime.Name = "lblCurrentSongtime";
            this.lblCurrentSongtime.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentSongtime.TabIndex = 22;
            // 
            // SongTimeElapsed
            // 
            this.SongTimeElapsed.Tick += new System.EventHandler(this.SongTimeElapsed_Tick);
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.BackColor = System.Drawing.Color.Black;
            this.labelTimeElapsed.ForeColor = System.Drawing.Color.White;
            this.labelTimeElapsed.Location = new System.Drawing.Point(447, 59);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(0, 16);
            this.labelTimeElapsed.TabIndex = 25;
            // 
            // progressBarCurrentSongPlaying
            // 
            this.progressBarCurrentSongPlaying.BackColor = System.Drawing.Color.Plum;
            this.progressBarCurrentSongPlaying.ForeColor = System.Drawing.Color.Plum;
            this.progressBarCurrentSongPlaying.Location = new System.Drawing.Point(502, 61);
            this.progressBarCurrentSongPlaying.Name = "progressBarCurrentSongPlaying";
            this.progressBarCurrentSongPlaying.Size = new System.Drawing.Size(403, 14);
            this.progressBarCurrentSongPlaying.TabIndex = 20;
            // 
            // pictureBoxNavBar2
            // 
            this.pictureBoxNavBar2.Location = new System.Drawing.Point(12, 133);
            this.pictureBoxNavBar2.Name = "pictureBoxNavBar2";
            this.pictureBoxNavBar2.Size = new System.Drawing.Size(1240, 59);
            this.pictureBoxNavBar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNavBar2.TabIndex = 38;
            this.pictureBoxNavBar2.TabStop = false;
            // 
            // pictureBoxAddButton
            // 
            this.pictureBoxAddButton.Location = new System.Drawing.Point(106, 278);
            this.pictureBoxAddButton.Name = "pictureBoxAddButton";
            this.pictureBoxAddButton.Size = new System.Drawing.Size(96, 94);
            this.pictureBoxAddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddButton.TabIndex = 33;
            this.pictureBoxAddButton.TabStop = false;
            this.pictureBoxAddButton.Click += new System.EventHandler(this.pictureBoxAddButton_Click);
            // 
            // pictureBoxResumeButton
            // 
            this.pictureBoxResumeButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxResumeButton.Location = new System.Drawing.Point(663, 85);
            this.pictureBoxResumeButton.Name = "pictureBoxResumeButton";
            this.pictureBoxResumeButton.Size = new System.Drawing.Size(53, 55);
            this.pictureBoxResumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResumeButton.TabIndex = 31;
            this.pictureBoxResumeButton.TabStop = false;
            this.pictureBoxResumeButton.Click += new System.EventHandler(this.pictureBoxResumeButton_Click);
            // 
            // pictureBoxRestartButton
            // 
            this.pictureBoxRestartButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRestartButton.Location = new System.Drawing.Point(583, 91);
            this.pictureBoxRestartButton.Name = "pictureBoxRestartButton";
            this.pictureBoxRestartButton.Size = new System.Drawing.Size(48, 43);
            this.pictureBoxRestartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRestartButton.TabIndex = 30;
            this.pictureBoxRestartButton.TabStop = false;
            this.pictureBoxRestartButton.Click += new System.EventHandler(this.pictureBoxRestartButton_Click);
            // 
            // pictureBoxNextButton
            // 
            this.pictureBoxNextButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNextButton.Location = new System.Drawing.Point(747, 91);
            this.pictureBoxNextButton.Name = "pictureBoxNextButton";
            this.pictureBoxNextButton.Size = new System.Drawing.Size(48, 43);
            this.pictureBoxNextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNextButton.TabIndex = 29;
            this.pictureBoxNextButton.TabStop = false;
            this.pictureBoxNextButton.Click += new System.EventHandler(this.pictureBoxNextButton_Click);
            // 
            // pictureBoxAlbumArt
            // 
            this.pictureBoxAlbumArt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAlbumArt.Location = new System.Drawing.Point(284, 10);
            this.pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            this.pictureBoxAlbumArt.Size = new System.Drawing.Size(151, 145);
            this.pictureBoxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumArt.TabIndex = 19;
            this.pictureBoxAlbumArt.TabStop = false;
            // 
            // pictureBoxMuseLogo
            // 
            this.pictureBoxMuseLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMuseLogo.Location = new System.Drawing.Point(23, 19);
            this.pictureBoxMuseLogo.Name = "pictureBoxMuseLogo";
            this.pictureBoxMuseLogo.Size = new System.Drawing.Size(252, 108);
            this.pictureBoxMuseLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMuseLogo.TabIndex = 35;
            this.pictureBoxMuseLogo.TabStop = false;
            // 
            // pictureBoxPauseButton
            // 
            this.pictureBoxPauseButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPauseButton.Location = new System.Drawing.Point(663, 85);
            this.pictureBoxPauseButton.Name = "pictureBoxPauseButton";
            this.pictureBoxPauseButton.Size = new System.Drawing.Size(53, 55);
            this.pictureBoxPauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPauseButton.TabIndex = 28;
            this.pictureBoxPauseButton.TabStop = false;
            this.pictureBoxPauseButton.Click += new System.EventHandler(this.pictureBoxPauseButton_Click);
            // 
            // pictureBoxDropShadow
            // 
            this.pictureBoxDropShadow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDropShadow.Location = new System.Drawing.Point(162, 232);
            this.pictureBoxDropShadow.Name = "pictureBoxDropShadow";
            this.pictureBoxDropShadow.Size = new System.Drawing.Size(931, 560);
            this.pictureBoxDropShadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDropShadow.TabIndex = 34;
            this.pictureBoxDropShadow.TabStop = false;
            // 
            // pictureBoxNavBar
            // 
            this.pictureBoxNavBar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNavBar.Location = new System.Drawing.Point(433, 497);
            this.pictureBoxNavBar.Name = "pictureBoxNavBar";
            this.pictureBoxNavBar.Size = new System.Drawing.Size(410, 59);
            this.pictureBoxNavBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNavBar.TabIndex = 37;
            this.pictureBoxNavBar.TabStop = false;
            // 
            // lblSongLibrary
            // 
            this.lblSongLibrary.AutoSize = true;
            this.lblSongLibrary.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSongLibrary.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongLibrary.ForeColor = System.Drawing.Color.Thistle;
            this.lblSongLibrary.Location = new System.Drawing.Point(277, 241);
            this.lblSongLibrary.Name = "lblSongLibrary";
            this.lblSongLibrary.Size = new System.Drawing.Size(138, 38);
            this.lblSongLibrary.TabIndex = 39;
            this.lblSongLibrary.Text = "Library";
            // 
            // lblSongLength
            // 
            this.lblSongLength.AutoSize = true;
            this.lblSongLength.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSongLength.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblSongLength.Location = new System.Drawing.Point(911, 61);
            this.lblSongLength.Name = "lblSongLength";
            this.lblSongLength.Size = new System.Drawing.Size(0, 16);
            this.lblSongLength.TabIndex = 40;
            // 
            // pictureBoxPlayButton
            // 
            this.pictureBoxPlayButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayButton.Location = new System.Drawing.Point(663, 85);
            this.pictureBoxPlayButton.Name = "pictureBoxPlayButton";
            this.pictureBoxPlayButton.Size = new System.Drawing.Size(53, 55);
            this.pictureBoxPlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayButton.TabIndex = 41;
            this.pictureBoxPlayButton.TabStop = false;
            this.pictureBoxPlayButton.Click += new System.EventHandler(this.pictureBoxPlayButton_Click);
            // 
            // SongLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1237, 934);
            this.Controls.Add(this.pictureBoxPlayButton);
            this.Controls.Add(this.lblSongLength);
            this.Controls.Add(this.pictureBoxAddButton);
            this.Controls.Add(this.pictureBoxResumeButton);
            this.Controls.Add(this.pictureBoxRestartButton);
            this.Controls.Add(this.pictureBoxNextButton);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.lblCurrentSongtime);
            this.Controls.Add(this.listViewSongs);
            this.Controls.Add(this.progressBarCurrentSongPlaying);
            this.Controls.Add(this.pictureBoxAlbumArt);
            this.Controls.Add(this.lblAddSong);
            this.Controls.Add(this.lblSongPlayingTitleWithArtist);
            this.Controls.Add(this.pictureBoxMuseLogo);
            this.Controls.Add(this.pictureBoxPauseButton);
            this.Controls.Add(this.pictureBoxNavBar2);
            this.Controls.Add(this.pictureBoxNavBar);
            this.Controls.Add(this.lblSongLibrary);
            this.Controls.Add(this.pictureBoxDropShadow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SongLibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Muse";
            this.Load += new System.EventHandler(this.SongLibraryForm_Load);
            this.contextMenuStripSelectedSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMuseLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDropShadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSongPlayingTitleWithArtist;
        private System.Windows.Forms.Label lblAddSong;
        private System.Windows.Forms.PictureBox pictureBoxAlbumArt;
        private System.Windows.Forms.ListView listViewSongs;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colArtist;
        private System.Windows.Forms.ColumnHeader colAlbumArt;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.ImageList imageListAlbumArt;
        private System.Windows.Forms.Label lblCurrentSongtime;
        private System.Windows.Forms.Timer SongTimeElapsed;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.PictureBox pictureBoxPauseButton;
        private System.Windows.Forms.PictureBox pictureBoxNextButton;
        private System.Windows.Forms.PictureBox pictureBoxRestartButton;
        private System.Windows.Forms.PictureBox pictureBoxResumeButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSelectedSong;
        private System.Windows.Forms.ToolStripMenuItem editSongToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxAddButton;
        private System.Windows.Forms.PictureBox pictureBoxDropShadow;
        private System.Windows.Forms.PictureBox pictureBoxMuseLogo;
        private System.Windows.Forms.ProgressBar progressBarCurrentSongPlaying;
        private System.Windows.Forms.PictureBox pictureBoxNavBar;
        private System.Windows.Forms.PictureBox pictureBoxNavBar2;
        private System.Windows.Forms.Label lblSongLibrary;
        private System.Windows.Forms.Label lblSongLength;
        private System.Windows.Forms.PictureBox pictureBoxPlayButton;
    }
}