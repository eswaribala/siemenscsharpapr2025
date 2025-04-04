using ShoppersDenV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Repositories
{
    interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(long ProductId, Money money);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(long ProductId);
        bool DeleteProduct(long ProductId);
    }
}
