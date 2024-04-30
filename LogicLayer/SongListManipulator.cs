using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;


namespace LogicLayer
{
    public class SongListManipulator
    { 

        List<Song> _songList;

        public SongListManipulator()
        {
            try
            {
                _songList = SongAccessor.FindSongLibrary();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Song> SongList
        {
            get { return _songList; }
        }

        public Lyrics FindLyics(int songIndex)
        {
            try
            {
                return SongAccessor.FindLyricsFile(_songList[songIndex]);
            }
            catch (Exception)
            {
                throw new ApplicationException("Could Not Find The Lyrics To Your Song");
            }
        }

        public List<Song> AddSong(Song song, Lyrics lyrics)
        {
            try
            {
                if (SongAccessor.AddSong(song, lyrics))
                {
                    _songList = SongAccessor.FindSongLibrary();
                }
                return _songList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Song> EditSong(Song song, Lyrics lyrics, int songIndex)
        {
            try
            {
                _songList[songIndex] = song;
                if (SongAccessor.UpdateSong(songIndex, lyrics, _songList))
                {
                    // I was having trouble with finding the lyrics file, and was not able to implement it in time.
                    _songList = SongAccessor.FindSongLibrary();
                    return _songList;
                }
                return _songList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
