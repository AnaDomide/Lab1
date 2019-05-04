using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ProductsDbSeeder
    {
        public static void Initialize(ProductsDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            context.Products.AddRange(
                new Product
                {
                    Name = "Masina",
                    Description = "Family",
                    Category = "Sport",
                    Price = 100.5
                },
                new Product
                {
                    Name = "Telefon",
                    Description = "Smart",
                    Category = "Small",
                    Price = 200.5
                }
            );
            context.SaveChanges();
        }
    }
}

