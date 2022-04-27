using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();

            products.Add(new Product()
            {
                Id = 1,
                Name = "Pilot Ball Pen",
                Description = "Writing Color: Black",
                Quantity = 5,
                Price = 50M,
                TotalAmount = 250M,
            });

            products.Add(new Product()
            {
                Id = 2,
                Name = "Staedtler Mechanical Pencil",
                Description = "Lead size: 0.5mm",
                Quantity = 3,
                Price = 285M,
                TotalAmount = 855M,
            });

            products.Add(new Product()
            {
                Id = 3,
                Name = "Staedtler Eraser",
                Description = "Color: White, Size: 28x20x11mm",
                Quantity = 4,
                Price = 15M,
                TotalAmount = 60M,
            });

            products.Add(new Product()
            {
                Id = 4,
                Name = "Hard Copy Bond Paper",
                Description = "Size: 8.5in x 11in, No. of sheets: 500",
                Quantity = 6,
                Price = 155M,
                TotalAmount = 930M,
            });

            products.Add(new Product()
            {
                Id = 5,
                Name = "Green Apply Spiral Notebook",
                Description = "Size: 5in x 7in, No.of pages : 80",
                Quantity = 10,
                Price = 40M,
                TotalAmount = 400M,
            });
        }

        public List<Product> GetCatalog()
        {
            return products;
        }

        public decimal GetGrandTotal()
        {
            decimal grandTotal = 0;
            foreach(var product in products)
			{
                grandTotal += product.TotalAmount;
			}
            return grandTotal;
        }
    }
}
