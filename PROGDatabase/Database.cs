using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    class Database
    {
        private List<ItemStats> _items;

        public Database()
        {
            _items = new List<ItemStats>();
        }

        public void AddData(ItemStats item)
        {
            _items.Add(item);
        }

        public List<ItemStats> RetrieveData()
        {
            return _items;
        }

       
        public ItemStats[] GetItemsByType(string type)
        {
            List<ItemStats> filteredItems = new List<ItemStats>();
            foreach(ItemStats item in _items)
            {
                if (item.Type == type)
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems.ToArray();
        }
    }
}

