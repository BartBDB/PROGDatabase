using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class InvisibilityPotion : ItemStats
    {
        private string effect;
        public InvisibilityPotion(string name, string description, string effect, string type) : base(name, description, type)
        {
            this.effect = effect;
        }
    }
}
