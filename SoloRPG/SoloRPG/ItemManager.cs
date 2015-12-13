using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    public class ItemManager
    {
        public List<Item> allItems = new List<Item>();
        XmlManager<Weapon> xmlWeaponManager = new XmlManager<Weapon>();
        XmlManager<Head> xmlHeadManager = new XmlManager<Head>();
        XmlManager<Chest> xmlChestManager = new XmlManager<Chest>();
        XmlManager<Offhand> xmlOffhandManager = new XmlManager<Offhand>();
        XmlManager<Feet> xmlFeetManager = new XmlManager<Feet>();

        private static ItemManager instance;

        public static ItemManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemManager();
                return instance;
            }
        }

        private ItemManager()
        {

        }

        public void LoadContent()
        {
            string[] weaponFiles = Directory.GetFiles("Load/Weapons");
            foreach(string file in weaponFiles)
            {
                allItems.Add(xmlWeaponManager.Load(file));
            }

            string[] armourHeadFiles = Directory.GetFiles("Load/Armours/Head");
            foreach (string file in armourHeadFiles)
            {
                allItems.Add(xmlHeadManager.Load(file));
            }

            string[] armourChestFiles = Directory.GetFiles("Load/Armours/Chest");
            foreach (string file in armourChestFiles)
            {
                allItems.Add(xmlChestManager.Load(file));
            }

            string[] armourOffhandFiles = Directory.GetFiles("Load/Armours/Offhand");
            foreach (string file in armourOffhandFiles)
            {
                allItems.Add(xmlOffhandManager.Load(file));
            }

            string[] armourFeetFiles = Directory.GetFiles("Load/Armours/Feet");
            foreach (string file in armourFeetFiles)
            {
                allItems.Add(xmlFeetManager.Load(file));
            }
        }
    }
}
