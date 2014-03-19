using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name= "Type of Animal")]
        [DataType(DataType.Text)]
        public string AnimalType { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
    }
    public class AnimalDBContext : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
    }
}