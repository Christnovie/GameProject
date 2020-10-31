using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Media;
using System.Security.Cryptography.Xml;
using System.Threading;


namespace GamePads
{
    public class PadsCase
    {
        public Texture2D padcase;
        private PadsGraphique game;
        private Vector2 vector;
        private Song sound;
        private string place;
        private Rectangle size;
        private float ration;
        private SoundPlayer soundPlayer; 
        
        
        public PadsCase(Texture2D padcase, object game, Song sound,Vector2 vector = new Vector2())
        {
            this.vector = vector;
            this.game = (PadsGraphique)game;            
            this.padcase = padcase;
            this.sound = sound;
            ration = this.padcase.Width / this.game.WindowsSize[0] + 0.001f;
            size = new Rectangle((int)vector.X, (int)vector.Y, (int)(this.game.WindowsSize[0] * ration), (int)(this.game.WindowsSize[1] * ration));
            ration = size.Width / this.game.WindowsSize[0] + 0.001f;
        }
        public PadsCase(Texture2D padcase, object game, Song sound, string vector)
        {
            
            this.game = (PadsGraphique)game;
            this.padcase = padcase;
            this.sound = sound;
            place = vector;
            this.vector = new Vector2(this.game.WindowsSize[0], this.game.WindowsSize[1]);
            ration = this.padcase.Width / this.game.WindowsSize[0] + 0.001f;
        }

        public void Play()
        {
            if (Collider2D.Is_Clicked_Mouse(vector,Size))
            {
                if (State)
                {
                    string sounder = Path.GetFullPath(game.Content.RootDirectory) + "/UndertaleUndyne.wma";
                    soundPlayer = new SoundPlayer(Path.GetFullPath( game.Content.RootDirectory)+"/UndertaleUndyne.wma");
                    soundPlayer.Play();
                    
                }
                else
                {
                    MediaPlayer.Stop();
                    MediaPlayer.Play(sound);
                }
            }
        }
        public Rectangle Size
        {
            get
            {
                size = new Rectangle((int)vector.X,(int)vector.Y,(int)(game.WindowsSize[0]*ration),(int)(game.WindowsSize[1] * ration));                
                return size;
            }
            set
            {
                size = value;
                ration = size.Width / game.WindowsSize[0] + 0.001f;
            }
        }
        public bool State
        {            
            get {
                if (MediaPlayer.State == MediaState.Playing)
                {
                    return true;
                }
                else return false;
            }       
        }
      
        public Vector2 Position
        {
            get { return vector; }
            set { vector = value; }
        }
    }
}
