using ProductOrderManagement.Domain.Entities;
using ProductOrderManagement.Domain.IRepositories;

namespace ProductOrderManagement.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductOrderManagementDbContext context): base(context) { }
    }
}
