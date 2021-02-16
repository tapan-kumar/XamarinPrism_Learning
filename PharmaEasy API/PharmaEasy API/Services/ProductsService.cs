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

        public async Task<ProductsResponse> SaveAsync(Products products)
        {
            try
            {
                await _productRespository.AddAsync(products);
                await _unitOfWork.CompleteAsync();

                return new ProductsResponse(products);
            }
            catch (Exception ex)
            {

                return new ProductsResponse($"An error occurred when saving the products:{ex.Message}");
            }
        }

        public async Task<ProductsResponse> UpdateAsync(int id, Products products)
        {
            var existingProducts = await _productRespository.FindByIdAsync(id);

            if(existingProducts==null)
            
                return new ProductsResponse("Product not found");
            
            existingProducts.Name = products.Name;


            try
            {
                _productRespository.Update(existingProducts);
                await _unitOfWork.CompleteAsync();

                return new ProductsResponse(existingProducts);
            }
            catch (Exception ex)
            {

                return new ProductsResponse($"An error occurred while updating the products:{ex.Message}");
            }
        }

        public async Task<ProductsResponse> DeleteAsync(int id)
        {
            var existingProducts = await _productRespository.FindByIdAsync(id);

            if (existingProducts == null)
                return new ProductsResponse("product not found");

            try
            {
                _productRespository.Remove(existingProducts);
                await _unitOfWork.CompleteAsync();

                return new ProductsResponse(existingProducts);
            }
            catch (Exception ex)
            {

                return new ProductsResponse($"An error occured when deleting the products{ex.Message}");
            }
        }

        public ProductsService(IProductRespository productRespository, IUnitOfWork unitOfWork)

           
        {
            _productRespository = productRespository;
            this._unitOfWork = unitOfWork;
        }
    }
}
