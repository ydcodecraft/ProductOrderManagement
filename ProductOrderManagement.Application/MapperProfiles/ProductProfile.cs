using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Domain.Entities;

namespace ProductOrderManagement.Application.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
        }
    }
}