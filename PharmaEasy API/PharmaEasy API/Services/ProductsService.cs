using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Domain.Repositories;
using PharmaEasy_API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Services
{
    public class ProductsService : IProductService
    {
        private readonly IProductRespository _productRespository;

        public async Task<IEnumerable<Products>> ProductListAsync()
        {
           return await _productRespository.RepoListAsync();
        }
        public ProductsService(IProductRespository productRespository)
        {
            _productRespository = productRespository;
        }
    }
}
