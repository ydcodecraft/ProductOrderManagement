using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Domain.Entities;

namespace ProductOrderManagement.Application.MapperProfiles
{
    public class OrderItemProfile : Profile
    {
        public OrderItemProfile() 
        {
            CreateMap<OrderItemDto, OrderItem>();
            CreateMap<OrderItem, OrderItemDto>();
        }
    }
}
