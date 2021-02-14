using PharmaEasy_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public short Quantity { get; set; }
        public int Price { get; set; }
        //public EUnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
