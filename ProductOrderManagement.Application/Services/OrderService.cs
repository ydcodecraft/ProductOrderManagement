using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Application.Services.Interfaces;
using ProductOrderManagement.Domain.Entities;
using ProductOrderManagement.Domain.IRepositories;

namespace ProductOrderManagement.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public OrderService(
            IOrderRepository orderRepository,
            ICustomerService customerService,
            IMapper mapper)
        {
            _orderRepository = orderRepository;
            _customerService = customerService;
            _mapper = mapper;
        }

        public void CreateOrder(OrderDto newOrder)
        {
            // search for existing customer using customer id    
            CustomerDto? customerFound = _customerService.GetCustomer(newOrder.customer.Id);
            if (customerFound == null)
            {
                // create a new customer object first 
                _customerService.CreateCustomer(newOrder.customer);
            }
            
            Order order = _mapper.Map<Order>(newOrder);
            _orderRepository.Add(order);
            
        }
    }
}
