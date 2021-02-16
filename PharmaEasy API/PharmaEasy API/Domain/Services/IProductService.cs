using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Domain.Services
{
   public interface IProductService
    {
        Task<IEnumerable<Products>> ProductListAsync();                //  <GET ALL PRODUCTS>
        Task<ProductsResponse> SaveAsync(Products products);          // <SAVE PRODUCTS>
       

        Task<ProductsResponse> UpdateAsync(int id, Products products); // <UPDATE PRODUCTS>

        Task<ProductsResponse> DeleteAsync(int id);                    // <DELETE PRODUCTS>
    }
}
