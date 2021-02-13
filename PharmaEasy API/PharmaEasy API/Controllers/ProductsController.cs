﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Domain.Services;
using PharmaEasy_API.Extensions;
using PharmaEasy_API.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductsResource>> GetAllProductsAsync() //// Fetching Data from the server
        {
            var products = await _productService.ProductListAsync();
            var resources = _mapper.Map<IEnumerable<Products>, IEnumerable<ProductsResource>>(products);
            return resources;
        }
        
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveProductResource resource)
        {
           if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            var postproduct = _mapper.Map<SaveProductResource, Products>(resource);
        }
      

    }
}

