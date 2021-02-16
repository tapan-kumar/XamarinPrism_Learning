using Microsoft.EntityFrameworkCore;
using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Domain.Repositories;
using PharmaEasy_API.Persistence.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PharmaEasy_API.Persistence.Repositories
{
    public class ProductsRepository : ProductBaseRepository, IProductRespository
    {
        public ProductsRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Products>> RepoListAsync()
        {
            return await _context.ProductsSet.ToListAsync();   
        }

       public  async Task AddAsync(Products products)
        {
            await _context.ProductsSet.AddAsync(products);
        }

        public async Task<Products> FindByIdAsync(int id)
        {
            return await _context.ProductsSet.FindAsync(id);
        }

        public void Update(Products products)
        {
            _context.ProductsSet.Update(products);
        }

        public void Remove(Products products)
        {
            _context.ProductsSet.Remove(products);
        }
    }
}
