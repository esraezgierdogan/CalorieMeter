﻿using CalorieMeter.DAL.EntityConfigurations;
using CaloriMeter.DAL.EntityConfigurations;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL
{
    public class CalorieMeterDbContext : DbContext
    {
        public CalorieMeterDbContext() : base("data source=DESKTOP-T1ES9FG;initial catalog=CalorieMeterDB;USER ID=sa;password=1907302;")
        {
            Database.SetInitializer(new CalorieMeterStrategy());
        }

        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealDetail> MealDetails { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ActivityTypeConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new MealTypeConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
        }

    }
}
