using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    class Tile
    {
        public Rectangle sourceRectangle;
        Texture2D tileSet;
        Rectangle position;

        public Tile(Rectangle sourceRectangle, Texture2D tileSet, Rectangle position)
        {
            this.tileSet = tileSet;
            this.sourceRectangle = sourceRectangle;
            this.position = position;
        }

        public void LoadContent()
        {

        }
        public void UnloadContent()
        {

        }
        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tileSet, position, sourceRectangle, Color.White);
        }
    }
}
