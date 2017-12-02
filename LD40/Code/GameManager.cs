using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LD40
{
    public class GameManager
    {
        public static GameManager Instance;

        private Player player;
        private Map map;

        private Action<GameTime> UpdateFunc; 

        public GameManager()
        {
            if (Instance != null)
            {
                throw new Exception("Can't Have two Game Managers");
            }
            Instance = this;

            player = new Player();
            map = new Map(10,10);

            player.SetMap(map);
            player.SetTile(map.GetTile(2,2));
        }

        public void Update(GameTime gameTime)
        {
            UpdateFunc?.Invoke(gameTime);
        }

        void Update_StateRunning(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch, gameTime);
        }

        void Draw_StateRunning(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
        }
    }
}