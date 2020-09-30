using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework.Content;

namespace TestGame01
{
    public class MusicGame
    {
        private string rootRepository;
        private string songFile= "SongList.txt";
        public MusicGame(string rootRepository)
        {
            this.rootRepository = rootRepository;
        }
        
        public List<Song> LoadPlaylist(ContentManager content)
        {
            try
            {
                List<Song> songsLoaded = new List<Song>();
                string[] songs = File.ReadAllLines(rootRepository + "\\" + songFile);
                foreach (string song in songs)
                {
                    songsLoaded.Add(content.Load<Song>(song));
                }
                return songsLoaded;
            }
            catch (FileNotFoundException)
            {
                
                throw new FileNotFoundException();
            }
            
           
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
                File.WriteAllLines(rootRepository+"\\"+songFile, songName);
            }
            catch(FileNotFoundException )
            {
                throw new FileNotFoundException();
            }

        }
        public void SaveSongFile()
        {

        }


    }
}
