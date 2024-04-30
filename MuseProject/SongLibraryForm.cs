using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using System.Windows.Forms;
using WMPLib;
using System.Resources;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataObjects;

namespace MuseProject
{
    public partial class SongLibraryForm : Form
    {
        ResourceManager _rm = new ResourceManager(
            "MuseProject.Resource1", Assembly.GetExecutingAssembly());

        private SongListManipulator _songListManipulator = new SongListManipulator();
        string mp3DataPath = Application.StartupPath + @"\MuseConfig\songfiles\";
        string albumImagePath = Application.StartupPath + @"\MuseConfig\albumart\";
        private WindowsMediaPlayer _player = new WindowsMediaPlayer();
        private double pausePosition = 0;
        private Timer timer;
        private int secondsElapsed = 0;
        int _songIndex;

        public SongLibraryForm()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += SongTimeElapsed_Tick;
            InitializeComponent();
        }

        private void SongTimeElapsed_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            labelTimeElapsed.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"mm\:ss");
            lblSongLength.Text =  TimeSpan.FromSeconds(songDuration()).ToString(@"mm\:ss");

            if (_player.playState == WMPPlayState.wmppsPlaying)
            {
                progressBarCurrentSongPlaying.Maximum = (int)songDuration();
                progressBarCurrentSongPlaying.Value = (int)currentPosition();
            }
        }
        private void SongLibraryForm_Load(object sender, EventArgs e)
        {
            LibraryView();
        }

        private void LibraryView()
        {
            // Load Form Backgorund Elements

            pictureBoxMuseLogo.Image = (Image)_rm.GetObject("museLogo");
            pictureBoxDropShadow.Image = (Image)_rm.GetObject("libraryDropShadow");
            pictureBoxNavBar.Image = (Image)_rm.GetObject("navBar");
            pictureBoxNavBar2.Image = (Image)_rm.GetObject("navBar2");

            // Load Up the Buttons

            pictureBoxRestartButton.Image = (Image)_rm.GetObject("restartButton");
            pictureBoxResumeButton.Image = (Image)_rm.GetObject("resumeButton");
            pictureBoxNextButton.Image = (Image)_rm.GetObject("nextButton");
            pictureBoxPauseButton.Image = (Image)_rm.GetObject("pauseButton");
            pictureBoxNextButton.Image = (Image)_rm.GetObject("nextButton");
            pictureBoxAddButton.Image = (Image)_rm.GetObject("addButton");
            pictureBoxPlayButton.Image = (Image)_rm.GetObject("playButton");
            
            progressBarCurrentSongPlaying.Visible = false;
            pictureBoxAlbumArt.Visible = false;
            pictureBoxRestartButton.Visible = false;
            pictureBoxPauseButton.Visible = false;
            pictureBoxResumeButton.Visible = false;
            pictureBoxNextButton.Visible = false;
            pictureBoxNextButton.Visible = false;
            pictureBoxPlayButton.Visible = false;

            // Load up the List

            listViewSongs.Items.Clear();

            ImageList imageListAlbumArt = new ImageList();
            for (int i = 0; i < _songListManipulator.SongList.Count; i++)
            {
                
                System.Drawing.Image myImage = Image.FromFile(albumImagePath + _songListManipulator.SongList[i].AlbumArtFileName);
                imageListAlbumArt.Images.Add(myImage);

            }
            listViewSongs.LargeImageList = imageListAlbumArt;
            listViewSongs.TileSize = new Size(200, 100);

            for (int i = 0; i < _songListManipulator.SongList.Count; i++)
            {
                ListViewItem l = new ListViewItem(_songListManipulator.SongList[i].Title, i);
                this.listViewSongs.Items.Add(l);
                this.listViewSongs.Items[this.listViewSongs.Items.Count - 1].SubItems.Add(_songListManipulator.SongList[i].Album);
                this.listViewSongs.Items[this.listViewSongs.Items.Count - 1].SubItems.Add(_songListManipulator.SongList[i].Artist);
                this.listViewSongs.Items[this.listViewSongs.Items.Count - 1].SubItems.Add(_songListManipulator.SongList[i].Year);
            }
        }
        private void pictureBoxAddButton_Click(object sender, EventArgs e)
        {
            var AddEditForm = new SongAddEdit();
            AddEditForm.ShowDialog();
            _songListManipulator = new SongListManipulator();
            LibraryView();
        }

        // Restart song controls

        private void pictureBoxRestartButton_Click(object sender, EventArgs e)
        {
            secondsElapsed = 0;
            timer.Start(); ;
            _songIndex--;
            if (_songIndex < 0)
            {
                _songIndex = _songListManipulator.SongList.Count - 1;
            }
            string filepath = mp3DataPath + _songListManipulator.SongList[_songIndex].Mp3FileName;
            lblSongPlayingTitleWithArtist.Text = _songListManipulator.SongList[_songIndex].Title + " - " + _songListManipulator.SongList[_songIndex].Artist; ;
            System.Drawing.Image myImage = Image.FromFile(albumImagePath + _songListManipulator.SongList[_songIndex].AlbumArtFileName);
            pictureBoxAlbumArt.Image = myImage;
            _player.URL = filepath;
            _player.controls.play();
            secondsElapsed = 0;
            pictureBoxResumeButton.Visible = false;
            pictureBoxPauseButton.Visible = true;
        }

        // Pause Song controls
        private void PauseSong()
        {
            if (_player.playState == WMPPlayState.wmppsPlaying)
            {
                pausePosition = _player.controls.currentPosition;
                _player.controls.pause();
            }
        }
        private void pictureBoxPauseButton_Click(object sender, EventArgs e)
        {
            pictureBoxResumeButton.Visible = true;
            timer.Stop();
            PauseSong();
        }
        
        // Resume Song Controls
        private void ResumeSong()
        {
            if (_player.playState == WMPPlayState.wmppsPaused)
            {
                _player.controls.currentPosition = pausePosition;
                _player.controls.play();
                songDuration();
                lblSongLength.Visible = true;
                timer.Start();
            }
        }
        private void pictureBoxResumeButton_Click(object sender, EventArgs e)
        {
            pictureBoxResumeButton.Visible = false;
            pictureBoxPauseButton.Visible = true;
            timer.Start();
            ResumeSong();
        }

        // Next Song Controls

        private void pictureBoxNextButton_Click(object sender, EventArgs e)
        {
            secondsElapsed = 0;
            timer.Start();
            _songIndex++;
            if (_songIndex > _songListManipulator.SongList.Count - 1)
            {
                _songIndex = 0;
            }
            string filepath = mp3DataPath + _songListManipulator.SongList[_songIndex].Mp3FileName;
            lblSongPlayingTitleWithArtist.Text = _songListManipulator.SongList[_songIndex].Title + " - " + _songListManipulator.SongList[_songIndex].Artist; ;
            System.Drawing.Image myImage = Image.FromFile(albumImagePath + _songListManipulator.SongList[_songIndex].AlbumArtFileName);
            pictureBoxAlbumArt.Image = myImage;
            _player.URL = filepath;
            _player.controls.play();
            pictureBoxResumeButton.Visible = false;
            pictureBoxPauseButton.Visible = true;
        }

        // Play specified song from Libary

        private void PlayAtIndicies()
        {
            if (this.listViewSongs.SelectedIndices.Count > 0)
            {
                pictureBoxAlbumArt.Visible = true;
                progressBarCurrentSongPlaying.Visible = true; 
                pictureBoxRestartButton.Visible = true;
                pictureBoxPauseButton.Visible = true;
                pictureBoxNextButton.Visible = true;

                secondsElapsed = 0;
                timer.Start();

                string filepath = mp3DataPath + _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].Mp3FileName;
                _player.URL = filepath;
                _player.controls.play();

                lblSongPlayingTitleWithArtist.Text = _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].Title + " - " + _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].Artist; ;
                System.Drawing.Image myImage = Image.FromFile(albumImagePath + _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].AlbumArtFileName);
                pictureBoxAlbumArt.Image = myImage;
            }
            else
            {
                MessageBox.Show("Nothing Selected", "Click on a song to play it");
            }
        }
        private void listViewSongs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                timer.Stop();
                PauseSong();
            }
            else
            {
                if (_player.playState == WMPPlayState.wmppsPaused)
                {
                    // This only occurs when you click on a song and you already have the player
                    // paused

                    if (this.listViewSongs.SelectedIndices.Count > 0)
                    {
                        pictureBoxAlbumArt.Visible = true;
                        progressBarCurrentSongPlaying.Visible = true;
                        lblCurrentSongtime.Visible = false;
                        lblSongLength.Visible = false;
                        pictureBoxRestartButton.Visible = true;
                        pictureBoxResumeButton.Visible = true;
                        pictureBoxNextButton.Visible = true;
                        pictureBoxPlayButton.Visible = true;

                        secondsElapsed = 0;
                        labelTimeElapsed.Visible = false;
                        progressBarCurrentSongPlaying.Value = 0;


                        lblSongPlayingTitleWithArtist.Text = _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].Title + " - " + _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].Artist; ;
                        System.Drawing.Image myImage = Image.FromFile(albumImagePath + _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].AlbumArtFileName);
                        pictureBoxAlbumArt.Image = myImage;

                    }
                }
                else
                {
                    pictureBoxResumeButton.Visible = false;
                    pictureBoxPauseButton.Visible = true;
                    labelTimeElapsed.Visible = true;
                    PlayAtIndicies();
                }
            }
        }

        private void listViewSongs_DoubleClick(object sender, EventArgs e)
        {
            PlayAtIndicies();
            pictureBoxPauseButton.Visible = true;
            pictureBoxPlayButton.Visible = false;
            var CurrentSongPlaying = new CurrentSongPlaying(_songListManipulator, listViewSongs.SelectedIndices[0]);
            CurrentSongPlaying.ShowDialog();
        }

        // Menustrip items

        private void editSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewSongs.SelectedIndices.Count > 0)
            {
                var editForm = new SongAddEdit(listViewSongs.SelectedIndices[0], _songListManipulator);
                editForm.ShowDialog();
                _songListManipulator = new SongListManipulator();
                LibraryView();
            }
            else
            {
                MessageBox.Show("Right click on the song you want to edit");
            }
        }

        private double currentPosition()
        {
            if (this.listViewSongs.SelectedIndices.Count > 0)
            {
                double currentTimeSeconds = _player.controls.currentPosition;
                TimeSpan currentTimeSecondsMinutes = TimeSpan.FromSeconds(currentTimeSeconds);
                return currentTimeSeconds;
            }
            else
            {
                return 0;
            }
        }

        private double songDuration()
        {
            if (this.listViewSongs.SelectedIndices.Count > 0)
            {
                string filepath = mp3DataPath + _songListManipulator.SongList[listViewSongs.SelectedIndices[0]].Mp3FileName;
                WindowsMediaPlayer player = new WindowsMediaPlayer();
                IWMPMedia mediaInfo = player.newMedia(filepath);
                double durationInSeconds = mediaInfo.duration;
                return durationInSeconds;
            }
            else
            {
                return 0;
            }
        }

        private void pictureBoxPlayButton_Click(object sender, EventArgs e)
        { 
            PlayAtIndicies();
            pictureBoxPlayButton.Visible = false;
            pictureBoxResumeButton.Visible = false;
            songDuration();
            lblSongLength.Visible = true;
            labelTimeElapsed.Visible = true;
            timer.Start();
        }
    }
}
