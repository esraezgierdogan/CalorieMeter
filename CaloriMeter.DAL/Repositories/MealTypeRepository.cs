﻿using CaloriMeter.DAL;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieMeter.DAL.Repositories
{
    public class MealTypeRepository
    {
        CalorieMeterDbContext db;
        public MealTypeRepository()
        {
            db = new CalorieMeterDbContext();
        }

        public List<MealType> GetAllTypes()
        {
            return db.MealTypes.ToList();
        }

        public bool Insert(MealType entity)
        {
            db.MealTypes.Add(entity);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(MealType entity)
        {
            MealType mealType = db.MealTypes.Find(entity.MealTypeID);
            mealType.MealTypeName = entity.MealTypeName;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }
    }
}
