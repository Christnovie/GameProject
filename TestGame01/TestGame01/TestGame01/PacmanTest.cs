using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;



namespace TestGame01
{
    public class PacmanTest : Game
    {
        private int[] resolution = { 1800,1400};//x and y size resolution
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public Texture2D hero;
        private Vector2 position;
        private Move move;
        private int x = 6;
        private int y = 6;
        private string moveMode = "close";
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
            _graphics.ApplyChanges();
            // TODO: Add your initialization logic here

            base.Initialize();
           
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            hero = Content.Load<Texture2D>("PacmanAvatar");//load image texture for avatar an create sprite
            move = new Move(moveMode, resolution, position);
            position = new Vector2(0, 0);//Initialising a vector for prite
           /** FileStream fileStream = new FileStream("../../../Image/PacmanHero.svg.png",FileMode.Open);
            hero = Texture2D.FromStream(GraphicsDevice, fileStream);
            fileStream.Dispose();
           **/
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            //Code for move a sprite avatar
            //When press right
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if (moveMode == "close") move.CloseMove(x, y);
                if (moveMode == "infinity") move.CloseMove(x, y);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.M))
            {
                wnd_MenuGame form = new wnd_MenuGame();
                
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(hero,position,Color.Yellow);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
