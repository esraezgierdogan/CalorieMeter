﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.Model.Entitites
{
    public class Category
    {
        public Category()
        {
            Foods = new HashSet<Food>();
        }
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
