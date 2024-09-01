using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderManagement.Application.DTO
{
    public class ProductDto
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public string description { get; set; }

    }
}
