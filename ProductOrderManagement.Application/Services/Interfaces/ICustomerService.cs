using ProductOrderManagement.Application.DTO;

namespace ProductOrderManagement.Application.Services.Interfaces
{
    public interface ICustomerService
    {
        public void CreateCustomer(CustomerDto customerDto);

        public CustomerDto? GetCustomer(Guid id);
    }
}
