using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Domain.Seeders;
using EShop.Domain.Models;

namespace EShop.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = EShopSeeder.GetInitialProducts();
        }

        public Product GetById(int id)
        {
            return _products.Find(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Ean = product.Ean;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
                existingProduct.Sku = product.Sku;
                existingProduct.CategoryId = product.CategoryId;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
