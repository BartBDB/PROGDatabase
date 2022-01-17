using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class WoodenSword : ItemStats
    {
        private int damage;
        public WoodenSword(string name, string description, int damage, string type) : base(name, description, type)
        {
            this.damage = damage;
        }
    }
}
