using AutoMapper;
using ProductOrderManagement.Application.DTO;
using ProductOrderManagement.Application.Services.Interfaces;
using ProductOrderManagement.Domain.Entities;
using ProductOrderManagement.Domain.IRepositories;

namespace ProductOrderManagement.Application.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public OrderItemService(
            IOrderItemRepository orderItemRepository,
            IMapper mapper) 
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public void AddOrderItem(OrderItemDto orderItemDto)
        {
            OrderItem orderItem = _mapper.Map<OrderItem>(orderItemDto);
            _orderItemRepository.Add(orderItem);
        }

        public List<OrderItemDto> GetOrderItem(Guid orderId)
        {
            List<OrderItemDto> orderItemsFromOrder = _mapper.Map<List<OrderItemDto>>(_orderItemRepository.GetOrderItemsFromOrderId(orderId));
            return orderItemsFromOrder;
        }
    }
}
