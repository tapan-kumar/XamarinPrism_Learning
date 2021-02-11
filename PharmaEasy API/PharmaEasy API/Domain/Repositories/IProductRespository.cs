﻿using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Domain.Repositories
{
   public interface IProductRespository
    {
        Task<IEnumerable<Products>> RepoListAsync();
    }
}
