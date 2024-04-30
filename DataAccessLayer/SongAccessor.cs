using DataObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SongAccessor
    {
        public static List<Song> FindSongLibrary()
        {
            List<Song> songList = new List<Song>();

            char[] separator = { ',' };

            try
            {
                StreamReader fileReader = new StreamReader(MuseConfig.DataPath + @"\" + MuseConfig.LibraryFileName);
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts = line.Split(separator);
                        if (parts.Count() == 6)
                        {
                            Song newSong = new Song();
                            newSong.Title = parts[0];
                            newSong.Artist = parts[1];
                            newSong.Album = parts[2];
                            newSong.Year = parts[3];
                            newSong.AlbumArtFileName = parts[4];
                            newSong.Mp3FileName = parts[5];

                            songList.Add(newSong);
                        }
                }
                fileReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return songList;
        }

        public static Lyrics FindLyricsFile(Song song)
        {
            Lyrics newLyrics = new Lyrics();

            try
            {
                StreamReader fileReader = new StreamReader(MuseConfig.DataPath + @"\" + song.Mp3FileName.Substring(0, song.Mp3FileName.Length - 4) + ".txt");
                newLyrics.Title = fileReader.ReadLine();
                newLyrics.SongLyrics = fileReader.ReadToEnd();
                fileReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return newLyrics;
        }

        public static bool UpdateSong(int songIndex, Lyrics lyrics, List<Song> songList)
        {
            try
            {
                StreamWriter fileWriter = new StreamWriter(MuseConfig.DataPath + @"\" + songList[songIndex].Mp3FileName.Substring(0, songList[songIndex].Mp3FileName.Length - 4) + ".txt");
                fileWriter.WriteLine(lyrics.Title);
                fileWriter.WriteLine(lyrics.SongLyrics);
                fileWriter.Close();

                StreamWriter fileWriter2 = new StreamWriter(MuseConfig.DataPath + @"\" + MuseConfig.LibraryFileName);
                foreach (Song song in songList)
                {
                    fileWriter2.WriteLine(song.Title + "," +
                                        song.Artist + "," +
                                        song.Album + "," +
                                        song.Year + "," +
                                        song.AlbumArtFileName + "," +
                                        song.Mp3FileName);
                }

                fileWriter2.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool AddSong(Song song, Lyrics lyrics)
        {
            try
            {
                StreamWriter fileWriter = new StreamWriter(MuseConfig.DataPath + @"\" + song.Mp3FileName.Substring(0, song.Mp3FileName.Length - 4) + ".txt");
                fileWriter.WriteLine(lyrics.Title);
                fileWriter.Write(lyrics.SongLyrics);
                fileWriter.Close();
                StreamWriter fileWriter2 = new StreamWriter(MuseConfig.DataPath + @"\" + MuseConfig.LibraryFileName, true);
                fileWriter2.WriteLine(song.Title + "," +
                                    song.Artist + "," +
                                    song.Album + "," +
                                    song.Year + "," +
                                    song.AlbumArtFileName + "," +
                                    song.Mp3FileName);
                fileWriter2.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
