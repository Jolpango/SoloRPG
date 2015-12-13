using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using SoloRPG;
using System.IO;

namespace ItemCreator
{
    public partial class Form1 : Form
    {
        Weapon tempWeapon;
        
        public Form1()
        {
            tempWeapon = new Weapon();
            tempWeapon.image = new SoloRPG.Image();
            InitializeComponent();
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            tempWeapon.Damage = Convert.ToInt32(textBoxDamage.Text);
            tempWeapon.image.Path = textBoxPath.Text;
            tempWeapon.information = textBoxInformation.Text;
            tempWeapon.name = textBoxName.Text;
            tempWeapon.price = Convert.ToInt32(textBoxPrice.Text);
            tempWeapon.rarity = comboBoxRarity.Text;
            SoloRPG.XmlManager<Weapon> x = new XmlManager<Weapon>();
            if (!Directory.Exists("Weapons"))
                Directory.CreateDirectory("Weapons");

            x.Save("Weapons" + textBoxName.Text + ".xml", tempWeapon);
        }

        private void buttonGenerateArmour_Click(object sender, EventArgs e)
        {
            Armour tempArmour = new Armour();
            if (comboBoxType.Text == "Head")
            {
                tempArmour = new Head();
            }
            else if (comboBoxType.Text == "Chest")
            {
                tempArmour = new Chest();

            }
            else if (comboBoxType.Text == "Offhand")
            {
                tempArmour = new Offhand();

            }
            else if (comboBoxType.Text == "Feet")
            {
                tempArmour = new Feet();
            }
            tempArmour.image = new SoloRPG.Image();

            tempArmour.ArmourValue = Convert.ToInt32(textBoxArmour.Text);
            tempArmour.image.Path = textBoxPath2.Text;
            tempArmour.information = textBoxInformation2.Text;
            tempArmour.name = textBoxName2.Text;
            tempArmour.price = Convert.ToInt32(textBoxPrice2.Text);
            tempArmour.rarity = comboBoxRarity2.Text;
            if (!Directory.Exists("Armours"))
                Directory.CreateDirectory("Armours");

            if (comboBoxType.Text == "Head")
            {
                XmlManager<Head> xh = new XmlManager<Head>();
                xh.Save("Armours/" + tempArmour.name + ".xml", tempArmour);
            }
            else if (comboBoxType.Text == "Chest")
            {
                XmlManager<Chest> xh = new XmlManager<Chest>();
                xh.Save("Armours/" + tempArmour.name + ".xml", tempArmour);
            }
            else if (comboBoxType.Text == "Offhand")
            {
                XmlManager<Offhand> xh = new XmlManager<Offhand>();
                xh.Save("Armours/" + tempArmour.name + ".xml", tempArmour);
            }
            else if (comboBoxType.Text == "Feet")
            {
                XmlManager<Feet> xh = new XmlManager<Feet>();
                xh.Save("Armours/" + tempArmour.name + ".xml", tempArmour);
            }
        }
    }
}
