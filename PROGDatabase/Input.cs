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

            instanciate.AddItems();

            for (int i = 0; i < instanciate.types.Count; i++)
            {
                Console.WriteLine(i+1 + ": " + instanciate.types[i]);   
                
            }
            Console.WriteLine("Type het getal in van welk soort item je wilt");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < maxCategories)
                {
                    input -= 1;
                    if (input == 0) //weapons
                    {
                        Console.WriteLine("Available weapons in the database:");
                        Console.WriteLine();
                    }
                    
                    if (input == 1) //shields
                    {
                        Console.WriteLine("Available shields in the database:");
                    }

                    if (input == 2) //potions
                    {
                        Console.WriteLine("Available potions in the database:");
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