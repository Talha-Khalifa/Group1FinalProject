using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BounceBattle
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Paddle_Player paddlePlayer;
        Texture2D paddleTexture;
        Rectangle screen;
        Ball ball;
        Texture2D ballTexture;
        Paddle_AI paddleAI;
        Texture2D paddleAI_Texture;
        int offSetPaddle = 5;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            screen = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            paddleTexture = Content.Load<Texture2D>("paddle");
            paddlePlayer = new Paddle_Player(paddleTexture, new Vector2(offSetPaddle, screen.Height / 2 - paddleTexture.Height / 2), Vector2.Zero, 5f, screen);

            ballTexture = Content.Load<Texture2D>("ball");
            ball = new Ball(ballTexture, new Vector2(screen.Width / 2 - ballTexture.Width / 2, screen.Height / 2 - ballTexture.Height / 2), Vector2.Zero, 0f, screen);

            paddleAI_Texture = Content.Load<Texture2D>("paddleAI");
            paddleAI = new Paddle_AI(paddleAI_Texture, new Vector2(screen.Width - paddleAI_Texture.Width - offSetPaddle, screen.Height / 2 - paddleAI_Texture.Height / 2), Vector2.Zero, 5f, screen);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            paddlePlayer.Update(gameTime);
            paddleAI.Update(gameTime);
            ball.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkOliveGreen);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            paddlePlayer.Draw(_spriteBatch);
            paddleAI.Draw(_spriteBatch);
            ball.Draw(_spriteBatch);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
