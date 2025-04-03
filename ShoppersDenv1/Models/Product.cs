using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenv1.Models
{
    class Product
    {
        public Product(Money money)
        {
            this.Price = money;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Money Price { get; }
        public Description Description { get; set; }
        public int Quantity { get; set; }


        public override string ToString()
        {
            return Id + " " + Name + " " + Description + " " + Price.Notes + "." + Price.Coins + " " + Quantity;
        }
    }
}
