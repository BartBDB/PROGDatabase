using System;
using System.Collections.Generic;

namespace PROGDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            ItemStats woodenSword = new WoodenSword("Wooden Sword",
                "A very basic wooden sword. Does the job either as a weapon or as firewood. It may be wood, but sitting on top of it is not recommended.");

            ItemStats woodenShield = new WoodenShield("Wooden Shield",
                "A very basic wooden shield. Won't do much for you, apart from being a great seat for when you are tired.");
            
            database.AddData(new Item("Sword"));
            database.AddData(new Item("Shield"));

            List<Item> items = database.RetrieveData();
            
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].name);
            }
        }
    }
}