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
        private int x = 20;
        private int y = 20;
        private int jump = 10;
        private string moveMode = "Close";
        private string screenMode = "Windows";
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
            move = new Move(hero.Width, resolution, position);
            position = new Vector2(0, 0);//Initialising a vector for prite
           /** FileStream fileStream = new FileStream("../../../Image/PacmanHero.svg.png",FileMode.Open);
            hero = Texture2D.FromStream(GraphicsDevice, fileStream);
            fileStream.Dispose();
           **/
          
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed )
                Exit();
            //Code for move a sprite avatar
            //When press right
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.Up)|| Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (moveMode == "Close") move.CloseMove(x, y);
                if (moveMode == "Infinity") move.InfinityMove(x, y);
                if (moveMode == "Jump") move.GraviteJump(x, y);
                position = move.Position;
            }
            if (moveMode == "Jump") position.Y -= 4;
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                wnd_MenuGame form = new wnd_MenuGame(moveMode,screenMode,_graphics);
                
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    moveMode = form.MoveMode;
                    move.Resolution = form.Resolution;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.M))
            {
                resolution[0] = 1400;
                resolution[1] = 1000;
                _graphics.PreferredBackBufferWidth = resolution[0];
                _graphics.PreferredBackBufferHeight = resolution[1];
                _graphics.ApplyChanges();
                

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
