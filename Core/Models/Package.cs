﻿namespace Core.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<FoodPackage> FoodPackages { get; set;}
    }
}
