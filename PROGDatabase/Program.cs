using System;
using System.Collections.Generic;

namespace PROGDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            database.AddData(new Item("Cat"));
            database.AddData(new Item("Dog"));

            List<Item> items = database.RetrieveData();
            
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].name);
            }           
        }
    }
}
