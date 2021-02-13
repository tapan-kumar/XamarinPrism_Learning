using AutoMapper;
using PharmaEasy_API.Domain.Models;
using PharmaEasy_API.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaEasy_API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveProductResource, Products>();
        }
    }
}
