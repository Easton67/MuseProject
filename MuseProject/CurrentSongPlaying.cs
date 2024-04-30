using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using LogicLayer;

namespace MuseProject
{
    public partial class CurrentSongPlaying : Form
    {
        string albumImagePath = System.Windows.Forms.Application.StartupPath + @"\MuseConfig\albumart\";
        SongListManipulator _songListManipulator;
        int _songIndex;
        Lyrics _lyrics;

        public CurrentSongPlaying(SongListManipulator songListManipulator, int songIndex)
        {
            InitializeComponent();
            _songListManipulator = songListManipulator;
            _songIndex = songIndex;
        }

        private void CurrentSongPlaying_Load(object sender, EventArgs e)
        {
            DisplaySongAndLyrics();
        }

        private void DisplaySongAndLyrics()
        {
            try
            {
                _lyrics = _songListManipulator.FindLyics(_songIndex);
                this.lblSongTitle.Text = _songListManipulator.SongList[_songIndex].Title;
                this.lblSongArtist.Text = _songListManipulator.SongList[_songIndex].Artist;
                this.lblSongAlbum.Text = _songListManipulator.SongList[_songIndex].Album;
                this.pictureBoxAlbumArt.Image = System.Drawing.Image.FromFile(albumImagePath + _songListManipulator.SongList[_songIndex].AlbumArtFileName);
                this.txtLyrics.Text = _lyrics.SongLyrics;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
