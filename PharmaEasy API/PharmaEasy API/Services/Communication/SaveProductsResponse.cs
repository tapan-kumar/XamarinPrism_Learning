using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Services.Communication
{
    public class SaveProductsResponse : BaseResponse
    {
        public Products Products { get; private set; }

        private SaveProductsResponse(bool success, string message, Products products) : base(success,message)
        {
            Products = products;
        }

        public SaveProductsResponse(Products products) : this(true,string.Empty,products)
        {

        }

        public SaveProductsResponse(string message) : this(false, message, null)
        {

        }

    }
}
