using WebShoppie.Api.Contracts.Customer;

namespace WebShoppieAalst.Domain.Services.Interfaces;

public interface ICustomerService
{
    CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate);
    CustomerResponseContract? GetCustomerById(int id);
}