using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Models
{
    class Product
    {
      

        public int Id { get; set; }
        public string Name { get; set; }
        public Money Price { get; set; }
        public Description Description { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, Money price, Description description, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Description + " " + Price.Notes + "." + Price.Coins + " " + Quantity;
        }
    }
}
