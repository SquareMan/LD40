using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.TextureAtlases;

namespace LD40
{
    public static class TextureHelper
    {
        public static readonly int tileSize = 16;

        public static Dictionary<string, TextureRegion2D> tileDictionary;

        private static TextureAtlas playerAtlas;
        private static TextureAtlas tileAtlas;

        public static void LoadTextures(ContentManager content)
        {
            playerAtlas = TextureAtlas.Create("Player", content.Load<Texture2D>("Textures/PlayerSheet"), tileSize, tileSize);
            tileAtlas = TextureAtlas.Create("Tiles", content.Load<Texture2D>("Textures/TileSheet"), tileSize, tileSize);

            ProcessPlayer();
            ProcessTiles();
        }

        public static TextureRegion2D GetPlayerTexture()
        {
            return playerAtlas.GetRegion(0);
        }

        static void ProcessPlayer()
        {

        }

        static void ProcessTiles()
        {
            tileDictionary = new Dictionary<string, TextureRegion2D>(tileAtlas.RegionCount);

            tileDictionary["Grass"] = tileAtlas.GetRegion(0);
        }
    }
}