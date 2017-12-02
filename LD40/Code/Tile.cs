using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.TextureAtlases;

namespace LD40
{
    public class Tile
    {
        public static TileData Grass = new TileData("Grass", true);

        public string type;
        public bool isPassible;

        public IEntity EntityInTile;
        public int x;
        public int y;

        private Rectangle drawRect;
        private TextureRegion2D texture;

        public Tile(TileData data, int x, int y)
        {
            //Copy TileData
            this.type = data.type;
            this.isPassible = data.isPassable;

            this.x = x;
            this.y = y;
            this.texture = TextureHelper.tileDictionary[this.type];
            drawRect = new Rectangle(x * TextureHelper.tileSize, y * TextureHelper.tileSize, texture.Bounds.Width, texture.Bounds.Height);
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, drawRect, Color.White);
        }
    }

    public struct TileData
    {
        public string type;
        public bool isPassable;

        public TileData(string type, bool isPassable)
        {
            this.type = type;
            this.isPassable = isPassable;
        }
    }
}