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
    public class PadsGraphique : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D background;
        private PadsCase beats;
        private List<PadsCase> padsCases = new List<PadsCase>();
        private PadsCannevas gamePadsCanv;


        public PadsGraphique()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            _graphics.PreferredBackBufferWidth = _graphics.PreferredBackBufferWidth + _graphics.PreferredBackBufferWidth / 2;
            _graphics.PreferredBackBufferHeight = _graphics.PreferredBackBufferHeight + _graphics.PreferredBackBufferHeight / 2;
            _graphics.ApplyChanges();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            background = Content.Load<Texture2D>("backimagehd");
            int place = 0;
            for (int i = 1; i < 4; i++)
            {
                beats = new PadsCase(Content.Load<Texture2D>("Beats"), this, Content.Load<Song>("UndertaleUndyne"), new Vector2(place, place * i));
                beats.Size = new Rectangle((int)beats.Position.X, (int)beats.Position.Y, 100, 120);
                padsCases.Add(beats);
                place += beats.Size.Y + 10;
            }
            gamePadsCanv = new PadsCannevas(padsCases, this);


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                foreach (PadsCase padsCase in padsCases)
                {
                    padsCase.Play();
                }
            }
            if (Mouse.GetState().X == (int)WindowsSize[0] && Mouse.GetState().LeftButton == ButtonState.Pressed) { }
            if (Keyboard.GetState().IsKeyDown(Keys.P))
            {
                _graphics.PreferredBackBufferWidth = System.Windows.Forms.SystemInformation.VirtualScreen.Width;
                _graphics.PreferredBackBufferHeight = System.Windows.Forms.SystemInformation.VirtualScreen.Height;
                _graphics.ApplyChanges();
            }


                // TODO: Add your update logic here

                base.Update(gameTime);
        }

         protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(background, new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight), Color.White);
            gamePadsCanv.Draw();
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        public float[] WindowsSize
        {
            get
            {
                return new float[2] { _graphics.PreferredBackBufferWidth - 0.001f, _graphics.PreferredBackBufferHeight - 0.001f };
            }
        }
        public SpriteBatch Sprite{
            get {return _spriteBatch; }
            
        }
    }
}
