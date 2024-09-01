using ProductOrderManagement.Application.Services.Interfaces;
using ProductOrderManagement.Domain.IRepositories;

namespace ProductOrderManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }

        
    }
}
