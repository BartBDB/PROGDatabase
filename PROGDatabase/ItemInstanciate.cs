using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class ItemInstanciate
    {
        Database database = new Database();
        public List<string> types = new List<string>();
        
        public void AddItems()
        {
            List<ItemStats> items = database.RetrieveData();

            ItemStats woodenSword = new WoodenSword("Wooden sword",
                "A very basic wooden sword. Does the job either as a weapon or as firewood. It may be wood, but sitting on top of it is not recommended.",
                2,
                "Weapons");

            ItemStats woodenShield = new WoodenShield("Wooden shield",
                "A very basic wooden shield. Won't do much for you, apart from being a great seat for when you are tired.",
                2,
                "Shields");

            ItemStats smallHealingPotion = new SmallHealingPotion("Small healing potion",
                "A small healing potion. Smells awful, tastes awful and isn't strong but it does its job.",
                "Heals the user for 20 damage",
                "Potions");

            ItemStats ironSword = new IronSword("Iron sword",
                "A rather sharp iron sword. Now this is something actually useful!",
                10,
                "Weapons");

            ItemStats ironShield = new WoodenShield("Iron shield",
                "A sturdy iron shield. This can actually protect you properly! It is a tad bit heavy though.",
                10,
                "Shields");

            ItemStats invisiblityPotion = new InvisibilityPotion("Invisibility potion",
                "Doesn't actually make you invisible. Why do the shopkeeps call it this again?",
                "Lowers detection rate of monsters by 90%, bosses excluded",
                "Potions");

            database.AddData(woodenSword);
            database.AddData(ironSword);
            database.AddData(woodenShield);
            database.AddData(ironShield);
            database.AddData(smallHealingPotion);
            database.AddData(invisiblityPotion);

            types.Add("Weapons");
            types.Add("Shields");
            types.Add("Potions");

            /*for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine(items[i].Name);
            }*/
        }
    }
}