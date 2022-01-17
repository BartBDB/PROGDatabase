using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class WoodenShield : ItemStats
    {
        private int defense = 2;
        public WoodenShield(string name, string description) : base(name, description)
        {
        }
    }
}
