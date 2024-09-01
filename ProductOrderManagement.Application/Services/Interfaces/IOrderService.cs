using ProductOrderManagement.Application.DTO;

namespace ProductOrderManagement.Application.Services.Interfaces
{
    public interface IOrderService
    {
        public void CreateOrder(OrderDto newOrder);
    }
}
