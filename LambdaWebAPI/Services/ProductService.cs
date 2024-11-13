using LambdaWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace LambdaWebAPI.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 999.99m },
            new Product { Id = 2, Name = "Desk Chair", Category = "Furniture", Price = 149.99m },
            new Product { Id = 3, Name = "Smartphone", Category = "Electronics", Price = 699.99m },
            new Product { Id = 4, Name = "Coffee Table", Category = "Furniture", Price = 89.99m }
        };

        // Method to get all products
        public IEnumerable<Product> GetAllProducts() => _products;

        // Method to get filtered products by category using a lambda
        public IEnumerable<Product> GetProductsByCategory(string category) =>
            _products.Where(p => p.Category == category);

        // Method to calculate total price of products in a specific category
        public decimal GetTotalPriceByCategory(string category) =>
            _products.Where(p => p.Category == category).Sum(p => p.Price);

        // Method to sort products by price
        public IEnumerable<Product> GetProductsSortedByPrice() =>
            _products.OrderBy(p => p.Price);
    }
}
