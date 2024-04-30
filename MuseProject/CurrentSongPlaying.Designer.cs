namespace MuseProject
{
    partial class CurrentSongPlaying
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
            this.pictureBoxAlbumArt = new System.Windows.Forms.PictureBox();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.lblSongArtist = new System.Windows.Forms.Label();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.lblSongAlbum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbumArt
            // 
            this.pictureBoxAlbumArt.Location = new System.Drawing.Point(1, 146);
            this.pictureBoxAlbumArt.Name = "pictureBoxAlbumArt";
            this.pictureBoxAlbumArt.Size = new System.Drawing.Size(553, 562);
            this.pictureBoxAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumArt.TabIndex = 0;
            this.pictureBoxAlbumArt.TabStop = false;
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSongTitle.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Location = new System.Drawing.Point(12, 9);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(178, 38);
            this.lblSongTitle.TabIndex = 1;
            this.lblSongTitle.Text = "SongTitle";
            // 
            // lblSongArtist
            // 
            this.lblSongArtist.AutoSize = true;
            this.lblSongArtist.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSongArtist.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongArtist.ForeColor = System.Drawing.Color.Thistle;
            this.lblSongArtist.Location = new System.Drawing.Point(14, 62);
            this.lblSongArtist.Name = "lblSongArtist";
            this.lblSongArtist.Size = new System.Drawing.Size(136, 26);
            this.lblSongArtist.TabIndex = 3;
            this.lblSongArtist.Text = "SongArtist";
            // 
            // txtLyrics
            // 
            this.txtLyrics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyrics.Location = new System.Drawing.Point(577, -2);
            this.txtLyrics.Multiline = true;
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.ReadOnly = true;
            this.txtLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyrics.Size = new System.Drawing.Size(526, 718);
            this.txtLyrics.TabIndex = 4;
            // 
            // lblSongAlbum
            // 
            this.lblSongAlbum.AutoSize = true;
            this.lblSongAlbum.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSongAlbum.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSongAlbum.Location = new System.Drawing.Point(14, 103);
            this.lblSongAlbum.Name = "lblSongAlbum";
            this.lblSongAlbum.Size = new System.Drawing.Size(146, 26);
            this.lblSongAlbum.TabIndex = 5;
            this.lblSongAlbum.Text = "SongAlbum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(550, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 718);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CurrentSongPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1103, 711);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSongAlbum);
            this.Controls.Add(this.lblSongArtist);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.pictureBoxAlbumArt);
            this.Name = "CurrentSongPlaying";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CurrentSongPlaying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbumArt;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.Label lblSongArtist;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.Label lblSongAlbum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}