using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using SharpDX.MediaFoundation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Media;
using System.Net.NetworkInformation;
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
            ration = this.padcase.Width / this.game.gamePadsCanv.CanvasSize[0] + 0.001f;
            size = new Rectangle((int)vector.X, (int)vector.Y, (int)(this.game.gamePadsCanv.CanvasSize[0] * ration), (int)(this.game.gamePadsCanv.CanvasSize[1] * ration));
            ration = size.Width / this.game.gamePadsCanv.CanvasSize[0] + 0.001f;
        }
        public PadsCase(Texture2D padcase, object game, Song sound, string vector)
        {
            
            this.game = (PadsGraphique)game;
            this.padcase = padcase;
            this.sound = sound;
            place = vector;
            this.vector = new Vector2(this.game.gamePadsCanv.CanvasSize[0], this.game.gamePadsCanv.CanvasSize[1]);
            ration = this.padcase.Width / this.game.WindowsSize[0] + 0.001f;
        }

        public void Play()
        {
            if (Collider2D.Is_Clicked_Mouse(vector,Size))
            {              
                byte[] ipaddress ;
                ipaddress = new byte[4];
                ipaddress[0] = 8;
                ipaddress[1] = 8;
                ipaddress[2] = 8;
                ipaddress[3] = 8;
                PingReply ping = new Ping().Send(new System.Net.IPAddress(ipaddress));
                if (ping.Status == IPStatus.Success)
                {
                    System.Windows.Forms.MessageBox.Show("Connexion internet detecté");
                    Process.Start("C:/Program Files (x86)/Google/Chrome/Application/chrome.exe", "https://skarfoxgaming.com/");
                    Thread.Sleep(200);
                    if (State)
                    {
                        string sounder = Path.GetFullPath(game.Content.RootDirectory) + "/UndertaleUndyne.wma";
                        MediaPlayer.Play(sound);
                    }
                    else
                    {
                        MediaPlayer.Stop();
                        MediaPlayer.Play(sound);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Aucune connexion internet detecté");
                    Thread.Sleep(200);
                }                    
                   




            }
        }
        public Rectangle Size
        {
            get
            {
                size = new Rectangle((int)vector.X,(int)vector.Y,(int)(game.gamePadsCanv.CanvasSize[0]*ration),(int)(game.gamePadsCanv.CanvasSize[1] * ration));                
                return size;
            }
            set
            {
                size = value;
                ration = size.Width / game.gamePadsCanv.CanvasSize[0] + 0.001f;
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
