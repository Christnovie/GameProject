using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Threading;


namespace GamePads
{
    public class PadsCase
    {
        public Texture2D padcase;
        private PadsGraphique game;
        private Vector2 vector;
        private Song sound;        
        public PadsCase(Texture2D padcase, object game, Song sound,Vector2 vector = new Vector2())
        {
            this.vector = vector;
            this.game = (PadsGraphique)game;            
            this.padcase = padcase;
            this.sound = sound;    
            
        }
        public bool Is_clicked()
        {
            bool state = false;
            for (int ver = (int)vector.X; ver < padcase.Width; ver++) {
                for (int hor = (int)vector.X; hor < padcase.Width; hor++)
                {
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed && new Vector2(Mouse.GetState().X, Mouse.GetState().Y) == new Vector2(hor, ver))
                    {
                        state = true;
                        return true;                        
                    }
                }
            }         
            return false;              
        }
        public void Play()
        {
            if (Is_clicked())
            {
                if (State)
                {
                    MediaPlayer.Play(sound);
                }
                else
                {
                    MediaPlayer.Stop();
                    MediaPlayer.Play(sound);
                }
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
