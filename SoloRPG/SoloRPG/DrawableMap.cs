using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TiledSharp;

namespace SoloRPG
{
    class DrawableMap
    {
        TmxMap map;
        List<Texture2D> tilesets;
        int tileWidth;
        int tileHeight;
        int tilesetTilesWide;
        int tilesetTilesHigh;
        List<List<Tile>> tiles;

        public DrawableMap(string tilesetPath)
        {
            tiles = new List<List<Tile>>();
            map = new TmxMap(tilesetPath);
            tilesets = new List<Texture2D>();
            foreach (var path in map.Tilesets)
            {
                tilesets.Add(ScreenManager.Instance.Content.Load<Texture2D>(path.Name.ToString()));
            }

            tileWidth = map.Tilesets[0].TileWidth;
            tileHeight = map.Tilesets[0].TileHeight;

            tilesetTilesWide = tilesets[0].Width / tileWidth;
            tilesetTilesHigh = tilesets[0].Height / tileHeight;
        }

        public void LoadContent()
        {

            for (int layer = 0; layer < map.Layers.Count; layer++)
            {
                tiles.Add(new List<Tile>());
                for (var i = 0; i < map.Layers[layer].Tiles.Count; i++)
                {
                    int gid = map.Layers[layer].Tiles[i].Gid;

                    if (gid == 0)
                    {

                    }
                    else
                    {
                        int tileFrame = gid - 1;
                        int column = tileFrame % tilesetTilesWide;
                        int row = tileFrame / tilesetTilesWide;

                        float x = (i % map.Width) * map.TileWidth;
                        float y = (float)Math.Floor(i / (double)map.Width) * map.TileHeight;

                        Rectangle tilesetRec = new Rectangle(tileWidth * column, tileHeight * row, tileWidth, tileHeight);
                        tiles[layer].Add(new Tile(tilesetRec, tilesets[0], new Rectangle((int)x, (int)y, tileWidth, tileHeight)));
                    }
                } 
            }
            foreach (List<Tile> layer in tiles)
            {
                foreach (Tile tile in layer)
                {
                    tile.LoadContent();
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(List<Tile> layer in tiles)
            {
                foreach (Tile tile in layer)
                {
                    tile.Draw(spriteBatch);
                }
            }
        }
    }
}
