using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SharpDX.Direct3D11;
using SharpDX.XAPO.Fx;

namespace TestGame01
{
    public class MusicGame
    {
        public MusicGame()
        {

        }
        
        public List<Song> LoadPlaylist()
        {
            throw new NotImplementedException();
        }
        public void SaveSong(List<Song> songs)
        {
           
            try
            {
                string[] songName = new string[songs.Count];


                int index = 0;
                foreach (Song song in songs)
                {
                    songName[index] = song.Name;
                }
                File.WriteAllLines("C:/GameProject/TestGame01/TestGame01/TestGame01/Content/SongList.txt", songName);
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }
        public void SaveSongFile()
        {

        }


    }
}
