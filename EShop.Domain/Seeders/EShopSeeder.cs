using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using EShop.Domain;
using EShop.Domain.Seeders;
using EShop.Domain.Models;

namespace EShop.Domain.Seeders
{
    public static class EShopSeeder
    {
        public static List<Product> GetInitialProducts()
        {
            return new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Smartphone XYZ",
                        Ean = "1234567890123",
                        Price = 299.99m,
                        Stock = 50,
                        Sku = "SMXYZ123",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Laptop ABC",
                        Ean = "9876543210987",
                        Price = 799.99m,
                        Stock = 30,
                        Sku = "LPTABC987",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Headphones 123",
                        Ean = "3216549876543",
                        Price = 99.99m,
                        Stock = 100,
                        Sku = "HP123456",
                        CategoryId = 3
                    }
                };
        }
    }
}
