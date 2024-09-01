using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Application.Services.Interfaces;
using ProductOrderManagement.Domain.Entities;
using ProductOrderManagement.Domain.IRepositories;

namespace ProductOrderManagement.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        private readonly IMapper _mapper;

        public CustomerService(
            ICustomerRepository customerRepository,
            IMapper mapper) 
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public void CreateCustomer(CustomerDto customerDto)
        {
            Customer customer = _mapper.Map<Customer>(customerDto);
            _customerRepository.Add(customer);
        }

        public CustomerDto? GetCustomer(Guid id)
        {
            Customer? customer = _customerRepository.GetById(id);
            if (customer == null)
            {
                return null;
            }

            CustomerDto customerDto = _mapper.Map<CustomerDto>(customer);
            return customerDto;
        }

    }
}
