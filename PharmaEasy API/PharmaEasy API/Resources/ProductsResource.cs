using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Resources
{
    public class ProductsResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Quantity { get; set; }
        public int Price { get; set; }
       // public EUnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
