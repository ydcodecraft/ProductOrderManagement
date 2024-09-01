using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderManagement.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
