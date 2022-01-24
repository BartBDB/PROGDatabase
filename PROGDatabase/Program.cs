using System;
using System.Collections.Generic;

namespace PROGDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            ItemStats woodenSword = new WoodenSword("Wooden sword",
            "A very basic wooden sword. Does the job either as a weapon or as firewood. It may be wood, but sitting on top of it is not recommended.",
            2,
            "Weapons");

            database.AddData(woodenSword);

            List<ItemStats> items = database.RetrieveData();
            
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Name);
            }
        }
    }
}
