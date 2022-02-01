using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class Input
    {
        public int InputCommand(int maxCategories, int maxItems)
        {
            int input;
            ItemInstanciate instanciate = new ItemInstanciate();
            Database data = instanciate.AddItems();
           

            for (int i = 0; i < instanciate.types.Count; i++)
            {
                Console.WriteLine(i+1 + ": " + instanciate.types[i]);    
            }

            Console.WriteLine("Type in the number of the category you want to see.");

            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < maxCategories)
                {
                    input -= 1;
                    if (input == 0) //weapons
                    {
                        Console.WriteLine("\nAvailable weapons in the database:");
                        var filteredItems = data.GetItemsByType("weapons");
                        for (int i = 0; i < filteredItems.Length; i++) //scan through available weapons
                        {
                            Console.WriteLine(i + 1 + ": " + filteredItems[i].Name);
                        }

                        if (int.TryParse(Console.ReadLine(), out input))
                        {
                            if (input < maxItems)
                            { 
                                input -= 1;
                                if (input == 0) //weapon 1
                                {
                                    Console.WriteLine();
                                }
                                if (input == 1) //weapon 2
                                {
                                    Console.WriteLine();
                                }

                                return input;
                            }
                        }
                    }  

                    if (input == 1) //shields
                    {
                        Console.WriteLine("\nAvailable weapons in the database:");
                        var filteredItems = data.GetItemsByType("weapons");
                        for (int i = 0; i < filteredItems.Length; i++) //scan through available weapons
                        {
                            Console.WriteLine(i + 1 + ": " + filteredItems[i]);
                        }

                        if (int.TryParse(Console.ReadLine(), out input))
                        {
                            if (input < maxItems)
                            {
                                input -= 1;
                                if (input == 0) //weapon 1
                                {
                                    Console.WriteLine();
                                }
                                if (input == 1) //weapon 2
                                {
                                    Console.WriteLine();
                                }

                                return input;
                            }
                        }
                    }

                    if (input == 2) //potions
                    {
                        Console.WriteLine("\nAvailable weapons in the database:");
                        var filteredItems = data.GetItemsByType("weapons");
                        for (int i = 0; i < filteredItems.Length; i++) //scan through available weapons
                        {
                            Console.WriteLine(i + 1 + ": " + filteredItems[i]);
                        }

                        if (int.TryParse(Console.ReadLine(), out input))
                        {
                            if (input < maxItems)
                            {
                                input -= 1;
                                if (input == 0) //weapon 1
                                {
                                    Console.WriteLine();
                                }
                                if (input == 1) //weapon 2
                                {
                                    Console.WriteLine();
                                }

                                return input;
                            }
                        }
                    }

                    return input;
                }
                Console.WriteLine("Invalid input. Choose a lower number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please put in a number.");
            }
            return InputCommand(maxCategories, maxItems);
        }
    }
}