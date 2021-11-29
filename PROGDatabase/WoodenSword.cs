using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    public class WoodenSword : ItemStats
    {
        private int damage = 2;
        public WoodenSword(string name, string description) : base(name, description)
        {
        }
    }
}
