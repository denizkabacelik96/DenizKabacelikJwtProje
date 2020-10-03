using AutoMapper;
using DenizKabacelik.JwtProje.Entities.Concrete;
using DenizKabacelik.JwtProje.Entities.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenizKabacelik.JwtProje.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {

        public MapProfile()
        {
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();
            CreateMap<ProductUpdateDto, Product>();  
            CreateMap<Product, ProductUpdateDto>();
           


        }
    }
}
