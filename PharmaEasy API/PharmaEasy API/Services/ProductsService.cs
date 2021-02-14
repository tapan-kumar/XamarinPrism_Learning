using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Domain.Repositories;
using PharmaEasy_API.Domain.Services;
using PharmaEasy_API.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Services
{
    public class ProductsService : IProductService
    {
        private readonly IProductRespository _productRespository;
        private readonly IUnitOfWork _unitOfWork;

        public async Task<IEnumerable<Products>> ProductListAsync()
        {
           return await _productRespository.RepoListAsync();
        }

        public async Task<SaveProductsResponse> SaveAsync(Products products)
        {
            try
            {
                await _productRespository.AddAsync(products);
                await _unitOfWork.CompleteAsync();

                return new SaveProductsResponse(products);
            }
            catch (Exception ex)
            {

                return new SaveProductsResponse($"An error occurred when saving the products:{ex.Message}");
            }
        }

        public async Task<SaveProductsResponse> UpdateAsync(int id, Products products)
        {
            var existingProducts = await _productRespository.FindByIdAsync(id);
            if(existingProducts==null)
            {
                return new SaveProductsResponse("Product not foun");
            }
            existingProducts.Name = products.Name;


            try
            {
                _productRespository.Update(existingProducts);
                await _unitOfWork.CompleteAsync();

                return new SaveProductsResponse(existingProducts);
            }
            catch (Exception ex)
            {

                return new SaveProductsResponse($"An error occurred when updating the products:{ex.Message}");
            }
        }

        public ProductsService(IProductRespository productRespository, IUnitOfWork unitOfWork)
        {
            _productRespository = productRespository;
            this._unitOfWork = unitOfWork;
        }
    }
}
