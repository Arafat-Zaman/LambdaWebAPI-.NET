using LambdaWebAPI.Models;
using LambdaWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LambdaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController()
        {
            _productService = new ProductService();
        }

        // Endpoint to get all products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts() =>
            Ok(_productService.GetAllProducts());

        // Endpoint to get products by category
        [HttpGet("category/{category}")]
        public ActionResult<IEnumerable<Product>> GetProductsByCategory(string category) =>
            Ok(_productService.GetProductsByCategory(category));

        // Endpoint to get total price by category
        [HttpGet("category/{category}/totalprice")]
        public ActionResult<decimal> GetTotalPriceByCategory(string category) =>
            Ok(_productService.GetTotalPriceByCategory(category));

        // Endpoint to get sorted products by price
        [HttpGet("sortedByPrice")]
        public ActionResult<IEnumerable<Product>> GetProductsSortedByPrice() =>
            Ok(_productService.GetProductsSortedByPrice());
    }
}
