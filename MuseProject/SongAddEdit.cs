using LogicLayer;
using DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Resources;

namespace MuseProject
{
    public partial class SongAddEdit : Form
    {
        ResourceManager _rm = new ResourceManager(
           "MuseProject.Resource1", Assembly.GetExecutingAssembly());

        bool editMode;
        string Mp3FileName = "";
        string AlbumFileName = "";
        string albumArtDataPath = Application.StartupPath + @"\MuseConfig" + @"\albumart";


        SongListManipulator _songListManipulator;
        int _songIndex;

        public SongAddEdit()
        {
            editMode = false;
            _songListManipulator = new SongListManipulator();
            InitializeComponent();
        }
        public SongAddEdit(int songIndex, SongListManipulator songListManipulator)
        {
            editMode = true;
            _songIndex = songIndex;
            _songListManipulator = new SongListManipulator();
            InitializeComponent();
        }


        private void btnChooseMp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdMp3 = new OpenFileDialog();
            ofdMp3.FileName = "";
            ofdMp3.Multiselect = false;

            ofdMp3.Filter = "Mp3 files (*.mp3)|*.mp3";

            ofdMp3.InitialDirectory = albumArtDataPath;
            ofdMp3.ShowDialog(this);

            if (ofdMp3.FileName != null && ofdMp3.FileName != "")
            {
                txtDisplayMP3.Text = ofdMp3.SafeFileName;

                Mp3FileName = ofdMp3.SafeFileName;
            }
        }

        private void SongAddEdit_Load(object sender, EventArgs e)
        {
            pictureBoxBottomGradient.Image = (Image)_rm.GetObject("navBar2");
            pictureBoxLyricsGlow.Image = (Image)_rm.GetObject("libraryDropShadow");
            if (editMode == true)
            {
                this.txtTitle.Text = _songListManipulator.SongList[_songIndex].Title;
                this.txtAlbum.Text = _songListManipulator.SongList[_songIndex].Album;
                this.txtArtist.Text = _songListManipulator.SongList[_songIndex].Artist;
                this.numericYear.Value = decimal.Parse(_songListManipulator.SongList[_songIndex].Year);
                this.txtDisplayMP3.Text = _songListManipulator.SongList[_songIndex].Mp3FileName;

                AlbumFileName = _songListManipulator.SongList[_songIndex].AlbumArtFileName;
                pictureboxAlbumArt.Image = Image.FromFile(albumArtDataPath + @"\" + AlbumFileName);

                Lyrics lyrics = _songListManipulator.FindLyics(_songIndex);

                this.txtLyrics.Text = lyrics.SongLyrics;

                this.Text = "Edit a Song";
            }
            else
            {
                this.Text = "Add a Song";
            }
        }

        private void btnChooseAlbumArt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAlbum = new OpenFileDialog();
            ofdAlbum.FileName = "";
            ofdAlbum.Multiselect = false;

            ofdAlbum.Filter = "PNG|*.png|JPG|*.jpg;*.jpeg";

            ofdAlbum.InitialDirectory = albumArtDataPath;
            ofdAlbum.ShowDialog(this);

            if (ofdAlbum.FileName != null && ofdAlbum.FileName != "")
            {
                pictureboxAlbumArt.Image = Image.FromFile(ofdAlbum.FileName);

                AlbumFileName = ofdAlbum.SafeFileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDisplayMP3.Text == "")
            {
                MessageBox.Show("You Must Enter an Mp3 Song File");
                txtDisplayMP3.Focus();
                return;
            }

            if (txtTitle.Text == "")
            {
                txtTitle.Text = "Unknown";
            }

            if (txtArtist.Text == "")
            {
                // Applications like Apple Music will enter these fields as 
                // "unknown", so instead of not letting you enter the song, I 
                // use this point to set default values if nothing is entered

                txtArtist.Text = "Unknown";
            }

            if (txtAlbum.Text == "")
            {
                txtAlbum.Text = "Unknown";
            }

            if (txtLyrics.Text == "")
            {
                txtLyrics.Text = "No Lyrics Provided";
            }

            if(AlbumFileName == "")
            {
                AlbumFileName = "defaultAlbumImage.png";
            }

            var song = new Song();
            song.Mp3FileName = txtDisplayMP3.Text;
            song.Title = txtTitle.Text;
            song.Artist = txtArtist.Text;
            song.Album = txtAlbum.Text;
            song.Year = numericYear.Value.ToString();
            song.AlbumArtFileName = AlbumFileName;

            var lyrics = new Lyrics();
            lyrics.Title = song.Mp3FileName.Substring(0, song.Mp3FileName.Length - 4) + ".txt";
            lyrics.SongLyrics = txtLyrics.Text;

            if (editMode == true)
            {
                _songListManipulator.EditSong(song, lyrics, _songIndex);
                MessageBox.Show("Your song was updated.");
                this.Close();
            }
            else
            {
                int songCount = _songListManipulator.SongList.Count;
                var newSongList = _songListManipulator.AddSong(song, lyrics);
                if (newSongList.Count > songCount)
                {
                    MessageBox.Show("New Song added.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your Song Was Not Added");
                    this.Close();
                }
            }
        }
    }
}
