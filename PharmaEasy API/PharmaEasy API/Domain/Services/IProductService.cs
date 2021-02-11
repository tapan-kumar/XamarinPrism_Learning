using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Domain.Services
{
   public interface IProductService
    {
        Task<IEnumerable<Products>> ProductListAsync();
    }
}
