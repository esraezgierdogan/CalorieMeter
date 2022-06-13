﻿using CaloriMeter.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.Model.Entitites
{
    public class Food
    {
        public Food()
        {
            MealDetails = new HashSet<MealDetail>();
        }

        public int FoodID { get; set; }
        public string Name { get; set; }
        public int Per100grCal { get; set; }
        public int Grams { get; set; }
        public bool State { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public PortionSize PortionSize { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }

        // Son olarak
    }
}
