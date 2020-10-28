﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Threading;


namespace TestGame01
{
    public class PacmanTest : Game
    {
        private int[] resolution = { System.Windows.Forms.SystemInformation.VirtualScreen.Width, System.Windows.Forms.SystemInformation.VirtualScreen.Height };//x and y size resolution
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public Texture2D hero;
        public Texture2D next;
        public Texture2D preview;
        public Texture2D play;
        private Vector2 position;       
        private Move move;
        private int x = 20;
        private int y = 20;
        private int jump = 50;
        public int gravity = 5;
        private string moveMode = "Close";
        private string screenMode = "Windows";
        public List<Song> songs = new List<Song>();
        private MusicGame listSong;
        public Video backvideo;
        public int  sound = 0;
        public GameCollider collision = new GameCollider();
        int countSnakeBouffie = 1;


        public PacmanTest()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
         
        protected override void Initialize()
        {
            // Initialise size of windows game
            _graphics.PreferredBackBufferWidth = resolution[0];
            _graphics.PreferredBackBufferHeight = resolution[1];
            if (screenMode == "Fullscreen")
            {
                _graphics.IsFullScreen = true;                
            }
            _graphics.ApplyChanges();
            // TODO: Add your initialization logic here

            base.Initialize();
           
        }

        protected override void LoadContent()
        {
          
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            hero = Content.Load<Texture2D>("PacmanAvatar");//load image texture for avatar an create sprite
            next = Content.Load<Texture2D>("Next");//load image texture for avatar an create sprite
            preview = Content.Load<Texture2D>("Preview");//load image texture for avatar an create sprite
            play = Content.Load<Texture2D>("PausePlay");//load image texture for avatar an create sprite
            
           

            
            move = new Move(hero.Width, resolution, position);
            position = new Vector2(0, 0);//Initialising a vector for prite
            /** FileStream fileStream = new FileStream("../../../Image/PacmanHero.svg.png",FileMode.Open);
             hero = Texture2D.FromStream(GraphicsDevice, fileStream);
             fileStream.Dispose();
            **/
            //Music Management
            string path = Path.GetFullPath(Content.RootDirectory);
            listSong = new MusicGame(path);
            songs = listSong.LoadPlaylist(Content); //load Music file 
            MediaPlayer.Play(songs[sound]);         //play actualy song in multimedia  
            MediaPlayer.IsRepeating = true;

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed )
                Exit();
            //Code for move a sprite avatar
            //When press right

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.Up)|| Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Left)) hero = Content.Load<Texture2D>("PacmanLeft");
                if (Keyboard.GetState().IsKeyDown(Keys.Right)) hero = Content.Load<Texture2D>("PacmanAvatar");
                if (moveMode == "Close") move.CloseMove(x, y);
                if (moveMode == "Infinity") move.InfinityMove(x, y);
                if (moveMode == "Jump")
                {
                    move.GraviteJump(x, jump);
                }
                position = move.Position;
            }
            if (moveMode == "Jump" && position.Y != resolution[1]-hero.Width) 
            {
               
                position.Y += 5;
                if (position.Y > resolution[1] - hero.Width) position.Y = resolution[1] - hero.Width;
                move.Position = position;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.F12))
            {
                if (_graphics.IsFullScreen)
                {
                    _graphics.IsFullScreen = false;
                    screenMode = "Windows";
                    
                    
                }
                else
                {
                    _graphics.IsFullScreen = true;
                    screenMode = "Fullscreen";
                    
                }
                Thread.Sleep(2000);
                _graphics.ApplyChanges();
               
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                _graphics.IsFullScreen = false;
                wnd_MenuGame form = new wnd_MenuGame(moveMode,screenMode,_graphics);
                
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    moveMode = form.MoveMode;
                    move.Resolution = form.Resolution;
                    screenMode = form.ScreenMode;
                    if (screenMode == "Fullscreen")
                    {
                        _graphics.IsFullScreen = true;                        
                    }
                    else
                    {
                        _graphics.IsFullScreen = false;                        
                    }
                    _graphics.ApplyChanges();
                }
                else
                {
                        Exit();
                       
                    }
  
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                _graphics.IsFullScreen = false;
                FormSong form = new FormSong(songs);

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (form.Song_Selected is null)
                    {

                    }
                        else {
                                if (form.Song_Selected != songs[sound])
                                {
                                    MediaPlayer.Play(form.Song_Selected);
                                    int soundIndex = 0;
                                    foreach (Song song in songs)
                                    {
                                        if (song == form.Song_Selected)
                                        {
                                            sound = soundIndex;
                                        }
                                        soundIndex++;
                                    }
                                }
                            }
                }
                if (screenMode == "Fullscreen")
                {
                    _graphics.IsFullScreen = true;
                    _graphics.ApplyChanges();
                }

            }
            if (Keyboard.GetState().IsKeyDown(Keys.P)|| collision.OnCollider(hero, play))
            {
                if (MediaPlayer.State == MediaState.Playing)
                {
                    MediaPlayer.Pause();
                    Thread.Sleep(300);
                }
                else
                if (MediaPlayer.State == MediaState.Paused)
                {
                    MediaPlayer.Resume();
                    Thread.Sleep(200);
                }
                
            }
            if (Keyboard.GetState().IsKeyDown(Keys.L))
            {
                MediaPlayer.Resume();                
            }            
            if (Keyboard.GetState().IsKeyDown(Keys.LeftControl) && Keyboard.GetState().IsKeyDown(Keys.S))
            {
                listSong.SaveSong(songs);
            }           
            if ((Keyboard.GetState().IsKeyDown(Keys.LeftControl) && Keyboard.GetState().IsKeyDown(Keys.N))||(collision.OnCollider(hero, next)))
            {
                sound++;
                if (sound > songs.Count - 1 )
                {
                    if (MediaPlayer.IsRepeating)
                    {
                        sound = 0;
                        MediaPlayer.Play(songs[sound]);
                    }
                    else MediaPlayer.Stop(); 
                }
                else MediaPlayer.Play(songs[sound]);
                Thread.Sleep(500);
            }
            if ((Keyboard.GetState().IsKeyDown(Keys.LeftControl) && Keyboard.GetState().IsKeyDown(Keys.P))||(collision.OnCollider(hero, preview)))
            {
                sound--;
                if (sound < 0 ) sound = songs.Count - 1;
                MediaPlayer.Play(songs[sound]);
                Thread.Sleep(500);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.T))
            {
                countSnakeBouffie++;
                Thread.Sleep(300);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(next,new Rectangle(WindowsResolution.X / 4 * 3 -125, WindowsResolution.Y/2 - 125,250,250),Color.White);
            _spriteBatch.Draw(preview,new Rectangle(WindowsResolution.X / 4 -125, WindowsResolution.Y / 2 -125, 250, 250), Color.White);
            _spriteBatch.Draw(play, new Rectangle(WindowsResolution.X / 2 -150, WindowsResolution.Y / 2 -150, 300, 300), Color.Black);
            int pos = 0;
            for(int i = 0; i < countSnakeBouffie; i++)
            {
                _spriteBatch.Draw(hero, position + new Vector2(pos,0), Color.Yellow);
                pos -= hero.Width;
            }          
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        public Point WindowsResolution
        {
            get { return new Point(System.Windows.Forms.SystemInformation.VirtualScreen.Width, System.Windows.Forms.SystemInformation.VirtualScreen.Height); }
        }
    }
}
