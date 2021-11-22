using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class Database
    {
        private List<Item> _items;

        public Database()
        {
            _items = new List<Item>();
        }

        public void AddData(Item item)
        {
            _items.Add(item);
        }

        public List<Item> RetrieveData()
        {
            return _items;
        }
    }
}

