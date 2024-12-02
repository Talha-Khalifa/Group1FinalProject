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
        }

    }
}
