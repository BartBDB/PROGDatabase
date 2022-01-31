using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class Input
    {
        public int InputCommand(int maxInput)
        {
            int input;
            ItemInstanciate instanciate = new ItemInstanciate();

            instanciate.AddItems();

            for (int i = 0; i < instanciate.types.Count; i++)
            {
                Console.WriteLine(i + ": " + instanciate.types[i]);   
                
            }
            Console.WriteLine("Type het getal in van welk item je wilt");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input < maxInput)
                {
                    if (input == 0) //weapons
                    {
                        Console.WriteLine("0");
                    }
                    
                    if (input == 1) //shields
                    {
                        Console.WriteLine("1");
                    }

                    else //potions
                    {
                        Console.WriteLine("2");
                    }

                    return input;
                }
                Console.WriteLine("Invalid input. Choose a lower number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please put in a number.");
            }
            return InputCommand(maxInput);
        }
    }
}