using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Domain.Entities;

namespace ProductOrderManagement.Application.MapperProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {            
            CreateMap<OrderDto, Order>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate));
            
            CreateMap<Order, OrderDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate));
        }
    }
}
