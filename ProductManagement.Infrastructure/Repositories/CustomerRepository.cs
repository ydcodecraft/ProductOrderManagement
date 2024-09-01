using ProductOrderManagement.Domain.Entities;
using ProductOrderManagement.Domain.IRepositories;

namespace ProductOrderManagement.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ProductOrderManagementDbContext context) : base(context) {}
    }
}
