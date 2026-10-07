using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts.Customer;
using WebShoppieAalst.Domain.Services.Interfaces;

namespace WebShoppieAalst.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomersController(ICustomerService _customerService) : ControllerBase
{
    // Maak klant
    [HttpPost]
    public ActionResult<CustomerResponseContract> CreateCustomer(
        [FromBody]CustomerRequestContract customer)
    {
        var created = _customerService.CreateCustomer(customer);
        return Ok(created);
    }

    [HttpGet("{id}")]
    public ActionResult<CustomerResponseContract> GetById([FromRoute]int id)
    {
        var customer = _customerService.GetCustomerById(id);
        if (customer is not null)
            return Ok(customer);
        return NotFound();
    }
}