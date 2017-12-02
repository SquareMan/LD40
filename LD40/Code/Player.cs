using System;
using System.CodeDom;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.TextureAtlases;
using MonoGame.Extended.Input;
using MonoGame.Extended.Input.InputListeners;

namespace LD40
{
    public class Player : IEntity
    {
        private Map map;
        private Tile tile;

        private Rectangle drawRect;

        public Player()
        {
            InputHelper.KeyboardListener.KeyPressed += ProcessInput;
        }

        public void SetTile(Tile t)
        {
            if(tile != null)
                tile.EntityInTile = null;
            tile = t;
            tile.EntityInTile = this;
            drawRect = new Rectangle(tile.x * TextureHelper.tileSize, tile.y * TextureHelper.tileSize, TextureHelper.tileSize, TextureHelper.tileSize);
        }

        public void SetMap(Map m)
        {
            map = m;
        }

        public void ProcessInput(Object sender, KeyboardEventArgs e)
        {
            Debug.WriteLine(e.Key);
            if (e.Key == Keys.D)
            {
                Tile t = map.GetTile(tile.x + 1, tile.y);

                if (t != null && t.isPassible)
                {
                    SetTile(t);
                }
            } else if (e.Key == Keys.A)
            {
                Tile t = map.GetTile(tile.x - 1, tile.y);

                if (t != null && t.isPassible)
                {
                    SetTile(t);
                }
            }

            if (e.Key == Keys.S)
            {
                Tile t = map.GetTile(tile.x, tile.y + 1);

                if (t != null && t.isPassible)
                {
                    SetTile(t);
                }
            } else if (e.Key == Keys.W)
            {
                Tile t = map.GetTile(tile.x, tile.y - 1);

                if (t != null && t.isPassible)
                {
                    SetTile(t);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(TextureHelper.GetPlayerTexture(), drawRect, Color.White);
        }
    }
}