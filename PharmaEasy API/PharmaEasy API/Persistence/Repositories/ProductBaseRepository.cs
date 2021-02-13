using PharmaEasy_API.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Persistence.Repositories
{
    public abstract  class ProductBaseRepository
    {
        protected readonly AppDbContext _context;

        public ProductBaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
