using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    public class Item
    {
        public string name;
        public string information;
        public Image image;
        public int price;
        public string rarity;
        private Color rarityColor;

        public Item()
        {

        }

        public virtual void LoadContent()
        {
            image.LoadContent();
            if (rarity == "Common")
                rarityColor = Color.White;
            else if (rarity == "Rare")
                rarityColor = Color.Blue;
            else if (rarity == "Epic")
                rarityColor = Color.Fuchsia;
            else if (rarity == "Legendary")
                rarityColor = Color.DarkOrange;
            image.color = rarityColor;
        }

        public virtual void UnloadContent()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            image.Draw(spriteBatch);
        }
    }
}
