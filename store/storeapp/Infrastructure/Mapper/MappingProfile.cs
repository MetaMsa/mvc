using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace StoreApp.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDtoForInsertion, Product>();
            CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
        }   
    }
}