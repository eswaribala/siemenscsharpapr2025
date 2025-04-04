using ShoppersDenV3.Exceptions;
using ShoppersDenV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3.Repositories
{
    class ProductRepository : IProductRepository
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool DeleteProduct(long ProductId)
        {
            return products.Remove(products.FirstOrDefault(p => p.Id == ProductId));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(long ProductId)
        {
            return products.Find(p => p.Id == ProductId);
        }

        public void UpdateProduct(long ProductId, Money money)
        {
            Product product= products.Find(p => p.Id == ProductId);
            if (product != null)
            {
                product.Price = money;
            }
            else
            {
                throw new ProductNotFoundException("Product not found");
            }
        }
    }
}
