using Android.Views;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace AndroidGame
{
    public class AdroidApp : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private int[] resolution;
        public Texture2D hero;
        private Move move;
        private Vector2 position;
        private int x = 2;
        private int y = 2;
        private string moveMode = "Close";
        public AdroidApp()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()

        {
            resolution = new int[2];
            resolution[0] = _graphics.PreferredBackBufferWidth;
            resolution[1] = _graphics.PreferredBackBufferWidth;
            // TODO: Add your initialization logic here

            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            string path = System.IO.Path.GetFullPath(Content.RootDirectory);
            using (var stream = TitleContainer.OpenStream("D:/GamerRoom/GameProject/AndroidGame/AndroidGame/Content/PacManLeft.png"))
            {
                hero = Texture2D.FromStream(this.GraphicsDevice, stream);

            }
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
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            //_spriteBatch.Draw(next, new Rectangle(WindowsResolution.X / 4 * 3 - 125, WindowsResolution.Y / 2 - 125, 250, 250), Color.Red);
            //_spriteBatch.Draw(preview, new Rectangle(WindowsResolution.X / 4 - 125, WindowsResolution.Y / 2 - 125, 250, 250), Color.Red);
            //_spriteBatch.Draw(play, new Rectangle(WindowsResolution.X / 2 - 150, WindowsResolution.Y / 2 - 150, 300, 300), Color.Black);
            _spriteBatch.Draw(hero, position, Color.Yellow);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
