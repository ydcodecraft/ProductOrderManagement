using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Domain.Entities;

namespace ProductOrderManagement.Application.MapperProfiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() 
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
