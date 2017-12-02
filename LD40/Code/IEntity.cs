using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LD40
{
    public interface IEntity
    {
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }
}