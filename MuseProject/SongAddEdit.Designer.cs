namespace MuseProject
{
    partial class SongAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongAddEdit));
            this.btnChooseAlbumArt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.btnChooseMp3 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtDisplayMP3 = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.pictureboxAlbumArt = new System.Windows.Forms.PictureBox();
            this.pictureBoxBottomGradient = new System.Windows.Forms.PictureBox();
            this.pictureBoxLyricsGlow = new System.Windows.Forms.PictureBox();
            this.lblSongInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottomGradient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLyricsGlow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseAlbumArt
            // 
            this.btnChooseAlbumArt.Location = new System.Drawing.Point(59, 473);
            this.btnChooseAlbumArt.Name = "btnChooseAlbumArt";
            this.btnChooseAlbumArt.Size = new System.Drawing.Size(175, 29);
            this.btnChooseAlbumArt.TabIndex = 0;
            this.btnChooseAlbumArt.Text = "Choose Album Art";
            this.btnChooseAlbumArt.UseVisualStyleBackColor = true;
            this.btnChooseAlbumArt.Click += new System.EventHandler(this.btnChooseAlbumArt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(607, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtLyrics
            // 
            this.txtLyrics.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyrics.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtLyrics.Location = new System.Drawing.Point(414, 69);
            this.txtLyrics.Multiline = true;
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyrics.Size = new System.Drawing.Size(340, 388);
            this.txtLyrics.TabIndex = 5;
            // 
            // btnChooseMp3
            // 
            this.btnChooseMp3.AutoSize = true;
            this.btnChooseMp3.BackColor = System.Drawing.Color.White;
            this.btnChooseMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseMp3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnChooseMp3.Location = new System.Drawing.Point(53, 67);
            this.btnChooseMp3.Name = "btnChooseMp3";
            this.btnChooseMp3.Size = new System.Drawing.Size(94, 30);
            this.btnChooseMp3.TabIndex = 7;
            this.btnChooseMp3.Text = "Choose MP3";
            this.btnChooseMp3.UseVisualStyleBackColor = false;
            this.btnChooseMp3.Click += new System.EventHandler(this.btnChooseMp3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(98, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 25);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArtist.Location = new System.Drawing.Point(91, 136);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(56, 25);
            this.lblArtist.TabIndex = 9;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAlbum.Location = new System.Drawing.Point(79, 166);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(68, 25);
            this.lblAlbum.TabIndex = 10;
            this.lblAlbum.Text = "Album";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblYear.Location = new System.Drawing.Point(94, 202);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(53, 25);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Year";
            // 
            // txtDisplayMP3
            // 
            this.txtDisplayMP3.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtDisplayMP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayMP3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDisplayMP3.Location = new System.Drawing.Point(159, 67);
            this.txtDisplayMP3.Name = "txtDisplayMP3";
            this.txtDisplayMP3.ReadOnly = true;
            this.txtDisplayMP3.Size = new System.Drawing.Size(207, 30);
            this.txtDisplayMP3.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTitle.Location = new System.Drawing.Point(159, 104);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(207, 30);
            this.txtTitle.TabIndex = 14;
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtArtist.Location = new System.Drawing.Point(159, 136);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(207, 30);
            this.txtArtist.TabIndex = 15;
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAlbum.Location = new System.Drawing.Point(159, 166);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(207, 30);
            this.txtAlbum.TabIndex = 16;
            // 
            // numericYear
            // 
            this.numericYear.BackColor = System.Drawing.SystemColors.Desktop;
            this.numericYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYear.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.numericYear.Location = new System.Drawing.Point(159, 202);
            this.numericYear.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(90, 30);
            this.numericYear.TabIndex = 17;
            this.numericYear.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyrics.ForeColor = System.Drawing.Color.Thistle;
            this.lblLyrics.Location = new System.Drawing.Point(531, 15);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(105, 34);
            this.lblLyrics.TabIndex = 13;
            this.lblLyrics.Text = "Lyrics";
            // 
            // pictureboxAlbumArt
            // 
            this.pictureboxAlbumArt.Location = new System.Drawing.Point(45, 248);
            this.pictureboxAlbumArt.Name = "pictureboxAlbumArt";
            this.pictureboxAlbumArt.Size = new System.Drawing.Size(204, 198);
            this.pictureboxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxAlbumArt.TabIndex = 6;
            this.pictureboxAlbumArt.TabStop = false;
            // 
            // pictureBoxBottomGradient
            // 
            this.pictureBoxBottomGradient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBottomGradient.Image")));
            this.pictureBoxBottomGradient.Location = new System.Drawing.Point(-5, 273);
            this.pictureBoxBottomGradient.Name = "pictureBoxBottomGradient";
            this.pictureBoxBottomGradient.Size = new System.Drawing.Size(802, 392);
            this.pictureBoxBottomGradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBottomGradient.TabIndex = 18;
            this.pictureBoxBottomGradient.TabStop = false;
            // 
            // pictureBoxLyricsGlow
            // 
            this.pictureBoxLyricsGlow.Location = new System.Drawing.Point(414, -17);
            this.pictureBoxLyricsGlow.Name = "pictureBoxLyricsGlow";
            this.pictureBoxLyricsGlow.Size = new System.Drawing.Size(395, 406);
            this.pictureBoxLyricsGlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLyricsGlow.TabIndex = 19;
            this.pictureBoxLyricsGlow.TabStop = false;
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.AutoSize = true;
            this.lblSongInfo.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongInfo.ForeColor = System.Drawing.Color.Thistle;
            this.lblSongInfo.Location = new System.Drawing.Point(155, 18);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(163, 34);
            this.lblSongInfo.TabIndex = 20;
            this.lblSongInfo.Text = "Song Info";
            // 
            // SongAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(797, 573);
            this.Controls.Add(this.lblSongInfo);
            this.Controls.Add(this.pictureboxAlbumArt);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.txtDisplayMP3);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnChooseMp3);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChooseAlbumArt);
            this.Controls.Add(this.pictureBoxLyricsGlow);
            this.Controls.Add(this.pictureBoxBottomGradient);
            this.Name = "SongAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Song Form or Edit Form";
            this.Load += new System.EventHandler(this.SongAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottomGradient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLyricsGlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseAlbumArt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.PictureBox pictureboxAlbumArt;
        private System.Windows.Forms.Button btnChooseMp3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtDisplayMP3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.PictureBox pictureBoxBottomGradient;
        private System.Windows.Forms.PictureBox pictureBoxLyricsGlow;
        private System.Windows.Forms.Label lblSongInfo;
    }
}

