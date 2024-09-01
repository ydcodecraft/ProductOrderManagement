﻿using ProductOrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderManagement.Domain.IRepositories
{
    public interface IOrderItemRepository : IBaseRepository<OrderItem>
    {
        public List<OrderItem> GetOrderItemsFromOrderId(Guid orderId);
    }
}
