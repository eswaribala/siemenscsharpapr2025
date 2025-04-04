using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Models
{
    class ProductSorter : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Price.Notes.CompareTo(y.Price.Notes);
        }
    }
}
