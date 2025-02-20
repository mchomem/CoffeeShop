using CoffeeShop.Customer.Modups;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Customer.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly CustomerMokup _customerMokup;

    public CustomerController(CustomerMokup customerMokup)
    {
        _customerMokup = customerMokup;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var customers = await Task.Run(() => _customerMokup.GetCustomers());
        return Ok(customers);
    }

    [HttpGet("{id}", Name = "Get")]
    public async Task<IActionResult> Get(int id)
    {
        var customer = await Task.Run(() => _customerMokup.GetCustomers()[id - 1]);
        return Ok(customer);
    }
}
