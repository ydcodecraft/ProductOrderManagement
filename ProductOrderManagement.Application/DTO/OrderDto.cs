using ProductOrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderManagement.Application.DTO
{
    public class OrderDto
    {
        public Guid Id { get; set; }

        public required CustomerDto customer { get; set; }

        public required List<OrderItemDto> items { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
