using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BounceBattle
{
    class Sprite
    {
        protected Texture2D texture;
        protected Vector2 position;

        public Vector2 Position { get { return position; } set { position = value; } }

        protected Vector2 direction;

        public Vector2 Direction { get { return direction; } set { direction = value; } }

        public int Score { get; set; }

        protected float speed;

        protected Rectangle screen;
        public Rectangle spriteBox { get { return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height); } }
        public Sprite(Texture2D texture, Vector2 position, Vector2 diretion, float speed, Rectangle screen)
        {
            this.texture = texture;
            this.position = position;
            this.direction = diretion;
            this.speed = speed;
            this.screen = screen;

        }
        public virtual void Update(GameTime gameTime)
        {
            position += direction * speed;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
