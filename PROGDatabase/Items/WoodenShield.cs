using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class WoodenShield : ItemStats
    {
        private int defense;
        public WoodenShield(string name, string description, int defense, string type) : base(name, description, type)
        {
            this.defense = defense;
        }
    }
}
