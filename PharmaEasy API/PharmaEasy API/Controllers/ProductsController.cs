using Microsoft.AspNetCore.Mvc;
using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IEnumerable<Products>> GetAllProductsAsync()
        {
             var products=await _productService.ProductListAsync();
            return products;
        }
    }
}
