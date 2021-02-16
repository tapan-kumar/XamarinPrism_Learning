using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Domain.Repositories
{
   public interface IProductRespository
    {
        Task<IEnumerable<Products>> RepoListAsync();

        Task AddAsync(Products products);

        Task<Products> FindByIdAsync(int id);

        void Update(Products products);
        void Remove(Products products);
    }
}
