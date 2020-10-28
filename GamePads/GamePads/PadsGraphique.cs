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
        public Texture2D background;
        private Texture2D beats;
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
            beats = Content.Load<Texture2D>("Beats");
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(background,new Rectangle(0,0,_graphics.PreferredBackBufferWidth,_graphics.PreferredBackBufferHeight),Color.White);
            _spriteBatch.Draw(beats, new Rectangle(_graphics.PreferredBackBufferWidth / 2 ,_graphics.PreferredBackBufferHeight / 2, 100, 80), Color.Gold);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
