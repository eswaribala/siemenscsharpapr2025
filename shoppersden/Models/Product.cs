using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppersden.Models
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DOP { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return ProductId+ " " + Name + " " + Description + " " + Price + " " + Quantity + " " + DOP + " " + ImageUrl;
        }
    }
}
