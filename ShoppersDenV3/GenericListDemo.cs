

using Microsoft.VisualBasic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using ShoppersDenV3.Models;
using ShoppersDenV3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppersDenV3
{
    class GenericListDemo
    {
        static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository();
            for(int i = 0; i < Faker.RandomNumber.Next(2,50); i++)
            {
                var commerce = new Bogus.DataSets.Commerce();
                var date = new Bogus.DataSets.Date();

                Product product = new Product(Faker.RandomNumber.Next(10000, 100000), commerce.Product(),
                    new Money(Faker.RandomNumber.Next(100, 10000), Faker.RandomNumber.Next(100, 10000)),
                 new Description(commerce.ProductAdjective(),
                    commerce.ProductMaterial(),
                    commerce.ProductDescription()),Faker.RandomNumber.Next(100, 10000));
                productRepository.AddProduct(product);
            
            }

            Console.WriteLine($"No of Products{productRepository.GetAllProducts().Count()}");

       
            using (var fs = new FileStream("ProductsApr2025.xlsx", FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Products-Data");

                int rowIndex = 0;
                List<Product> ProductList = productRepository
                    .GetAllProducts().ToList();
                //sorting

                //ProductList.Sort(new ProductSorter());

                //LINQ
                ProductList=ProductList.ToList()
                    .OrderBy(p => p.Quantity).ToList();  

                foreach (var product in ProductList)
                {
                    Console.WriteLine($"Product={product}");
                    IRow row = sheet.CreateRow(rowIndex);
                    row.CreateCell(0).SetCellValue(product.Id);
                    row.CreateCell(1).SetCellValue(product.Name);
                    row.CreateCell(2).SetCellValue(product.Description.Title);
                    row.CreateCell(3).SetCellValue(product.Description.Specificaion);
                    row.CreateCell(4).SetCellValue(product.Description.Summary);
                    row.CreateCell(5).SetCellValue(product.Quantity);
                    row.CreateCell(6).SetCellValue(product.Price.Notes.ToString());
                    row.CreateCell(7).SetCellValue(product.Price.Coins.ToString());
                    rowIndex++;

                }
                workbook.Write(fs);
            }
              

        }
    }
}
