using WebShoppie.Api.Contracts.Customer;
using WebShoppieAalst.Domain.Services.Interfaces;

namespace WebShoppieAalst.Domain.Services.Implementations;

public class CustomerService : ICustomerService
{
    public CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate)
    {
        return new CustomerResponseContract()
        {
            Id = 1,
            FirstName = customerToCreate.FirstName,
            LastName = customerToCreate.LastName,
            DateOfBirth = customerToCreate.DateOfBirth!.Value,
            Email = customerToCreate.Email,
            Addressline1 = customerToCreate.Addressline1,
            Addressline2 = customerToCreate.Addressline2,
            Addressline3 = customerToCreate.Addressline3,
            Country = customerToCreate.Country,
        };
    }

    public CustomerResponseContract? GetCustomerById(int id)
    {
        if (id == 1)
            return new CustomerResponseContract()
            {
                Id = 1,
                FirstName = "Fake"
            };
        
        //bestaat zogezegd niet in database
        return null; 
    }
}