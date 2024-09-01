using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProductOrderManagement.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Order))]
        public Guid OrderId { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
