using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static System.Formats.Asn1.AsnWriter;

namespace BounceBattle
{
    class Paddle_AI : Sprite
    {
        public Paddle_AI(Texture2D texture, Vector2 position, Vector2 direction, float speed, Rectangle screen) : base
            (texture, position, direction, speed, screen)
        {
            Score = 0;

        }

        public void AI_Movement(Ball ball)
        {
            if (ball.Direction.X > 0 && Direction.Y > 0)
                direction.Y = 1;
            else if (ball.Direction.X > 0 && Direction.Y > 0)
                direction.Y = -1;
            else 
                direction = Vector2.Zero;

        }
        private void BoundsRestrictions()
        {
            if (position.Y < 0)
                position.Y = 0;
            if (position.Y > screen.Height - texture.Height)
                position.Y = screen.Height - texture.Height;
        }
    }
}
