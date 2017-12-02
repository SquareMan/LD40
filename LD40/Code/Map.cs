using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LD40
{
    public class Map
    {
        private Tile[,] tiles;

        public Map(int width, int height)
        {
            tiles = new Tile[width,height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    tiles[x,y] = new Tile(Tile.Grass, x, y);
                }
            }
        }

        public Tile GetTile(int x, int y)
        {
            return x >= 0 && x < tiles.GetLength(0) && y >= 0 && y < tiles.GetLength(1) ? tiles[x, y] : null;
        }

        public void SetTile(Tile t, int x, int y)
        {
            tiles[x, y] = t;
        }

        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    tiles[x,y].Draw(spriteBatch, gameTime);
                    tiles[x,y].EntityInTile?.Draw(spriteBatch, gameTime);
                }
            }
        }
    }
}