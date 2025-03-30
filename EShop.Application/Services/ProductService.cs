using System;
using System.Collections.Generic;
using EShop.Domain.Seeders;
using EShop.Domain.Models;
using EShop.Domain.Repositories;


namespace EShop.Domain.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found");
            }
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public void AddProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name) || product.Price <= 0)
            {
                throw new ArgumentException("Invalid product data");
            }
            _productRepository.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _productRepository.GetById(product.Id);
            if (existingProduct == null)
            {
                throw new KeyNotFoundException("Product not found");
            }
            _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                throw new KeyNotFoundException("Product not found");
            }
            _productRepository.Delete(id);
        }
    }
}
