using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class ItemInstanciate
    {
        ItemStats woodenSword = new WoodenSword("Wooden Sword",
            "A very basic wooden sword. Does the job either as a weapon or as firewood. It may be wood, but sitting on top of it is not recommended.",
            2,
            "Weapons");

        ItemStats woodenShield = new WoodenShield("Wooden Shield",
            "A very basic wooden shield. Won't do much for you, apart from being a great seat for when you are tired.",
            2,
            "Shields");
    }
}
