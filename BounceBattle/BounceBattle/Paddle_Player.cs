using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BounceBattle
{
    class Paddle_Player : Sprite
    {
        public Paddle_Player(Texture2D texture, Vector2 position, Vector2 direction, float speed, Rectangle screen) : base
            (texture, position, direction, speed, screen)
        {
            Score = 0;

        }
        public override void Update(GameTime gameTime)
        {
            direction = Vector2.Zero;
            InputKeyboard();
            BoundsRestrictions();
            base.Update(gameTime);
        }
        private void BoundsRestrictions()
        {
            if (position.Y < 0)
                position.Y = 0;
            if (position.Y > screen.Height - texture.Height)
                position.Y = screen.Height - texture.Height;
        }

        private void InputKeyboard()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
                direction.Y = -1;
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
                direction.Y = 1;
        }
    }
}
