using ProductOrderManagement.Domain.Entities;
using ProductOrderManagement.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderManagement.Infrastructure.Repositories
{
    public class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
    {
        private readonly ProductOrderManagementDbContext _dbContext;

        public OrderItemRepository(ProductOrderManagementDbContext context) : base(context) 
        {
            _dbContext = context;
        }

        public List<OrderItem> GetOrderItemsFromOrderId(Guid orderId)
        {
            return _dbContext.OrderItems.Where(oi => oi.OrderId == orderId).ToList();
        }
    }
}
