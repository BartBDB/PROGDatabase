﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGDatabase
{
    public abstract class ItemStats
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Type { get; private set; }

        protected ItemStats(string name, string description, string type)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
        }
    }
}
