﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.Model.Entitites
{
    public class Meal
    {
        public Meal()
        {
            MealDetails = new HashSet<MealDetail>();
        }

        public int MealID { get; set; }
        public int MealTypeID { get; set; }
        public int UserID { get; set; }
        public DateTime RegisterationDate { get; set; }

        public virtual User User { get; set; }
        public virtual MealType MealType { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }
        // bu bir yorum satırıdır.
    }
}
