using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class IronSword : ItemStats
    {
        private int damage;
        public IronSword(string name, string description, int damage, string type) : base(name, description, type)
        {
            this.damage = damage;
        }
    }
}
