using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    public class Player
    {
        public List<Item> inventory;
        public Head currentHead;
        public Chest currentChest;
        public Offhand currentOffhand;
        public Feet currentFeet;
        public Weapon currentWeapon;


        bool showInventory;

        public void EquipItem(Item item, int index)
        {
            if (item.GetType() == typeof(Weapon))
            {
                if (currentWeapon != null)
                    inventory.Add(currentWeapon);
                currentWeapon = (Weapon)item;
                inventory.RemoveAt(index);
            }
            else if (item.GetType() == typeof(Head))
            {
                if (currentHead != null)
                    inventory.Add(currentHead);
                currentHead = (Head)item;
                inventory.RemoveAt(index);
            }
            else if (item.GetType() == typeof(Chest))
            {
                if (currentChest != null)
                    inventory.Add(currentChest);
                currentChest = (Chest)item; 
                inventory.RemoveAt(index);
            }
            else if (item.GetType() == typeof(Offhand))
            {
                if (currentOffhand != null)
                    inventory.Add(currentOffhand);
                currentOffhand = (Offhand)item;
                inventory.RemoveAt(index);
            }
            else if (item.GetType() == typeof(Feet))
            {
                if (currentFeet != null)
                    inventory.Add(currentFeet);
                currentFeet = (Feet)item;
                inventory.RemoveAt(index);
            }
        }

        public void LoadContent()
        {
            showInventory = false;
            if (inventory == null)
                inventory = new List<Item>();
            inventory = ItemManager.Instance.allItems;
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
