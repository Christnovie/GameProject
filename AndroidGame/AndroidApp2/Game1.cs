using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using AndroidGame;
using Android.Text.Method;
using Microsoft.Xna.Framework.Input.Touch;
using Android.Graphics.Drawables;

namespace AndroidApp2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int[] resolution;
        public Texture2D hero;
        public Move move;
        public Vector2 position;
        public int speed = 1000;
        public  string moveMode = "Close";
        public Icon icon;
        public Game1()
        {
            
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            resolution = new int[2];
            resolution[0] = _graphics.PreferredBackBufferWidth;
            resolution[1] = _graphics.PreferredBackBufferWidth;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            hero = Content.Load<Texture2D>("Pac-Man.svg");
            move = new Move(hero.Width,resolution,position);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
                
            Vector2 velocity = move.GetDesiredVelocityFromInput(position.X,position.Y,speed);

            position.X += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.Y += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            // temporary - we'll replace this with logic based off of which way the
            // character is moving when we add movement logic
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //_spriteBatch.Draw(next, new Rectangle(WindowsResolution.X / 4 * 3 - 125, WindowsResolution.Y / 2 - 125, 250, 250), Color.Red);
            //_spriteBatch.Draw(preview, new Rectangle(WindowsResolution.X / 4 - 125, WindowsResolution.Y / 2 - 125, 250, 250), Color.Red);
            //_spriteBatch.Draw(play, new Rectangle(WindowsResolution.X / 2 - 150, WindowsResolution.Y / 2 - 150, 300, 300), Color.Black);
            _spriteBatch.Draw(hero,position, Color.Yellow);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
        public int Speed
        {
            get { return speed; }
            set { Speed = value; }
        }
    }
}
