using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGamePlatformer
{
    public class Platformer_Game : Game
    {
        // Constants

        public const int HD_Height = 720;
        public const int HD_Width = 1280;

        // Attributes/variables 

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D playerImage;

        private Texture2D walkDownImage;
        private Texture2D walkUpImage;
        private Texture2D walkRightImage;
        private Texture2D walkLeftImage;

        private Texture2D backgorundImage;

        public Platformer_Game()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = HD_Width;
            _graphics.PreferredBackBufferHeight = HD_Height;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            playerImage = Content.Load<Texture2D>("Player/player");

            walkDownImage = Content.Load<Texture2D>("Player/walkDown");
            walkUpImage = Content.Load<Texture2D>("Player/walkUp");
            walkLeftImage = Content.Load<Texture2D>("Player/walkLeft");
            walkRightImage = Content.Load<Texture2D>("Player/walkRight");

            backgorundImage = Content.Load<Texture2D>("Background/Cartoon_Forest_BG_01");


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

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
