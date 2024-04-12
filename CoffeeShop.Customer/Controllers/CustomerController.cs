using CoffeeShop.Customer.Dtos;
using CoffeeShop.Customer.Modups;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerMokup _customerMokup;

        public CustomerController(CustomerMokup customerMokup) => _customerMokup = customerMokup;

        [HttpGet]
        public async Task<ActionResult<List<CustomerDto>>> Get() => await Task.Run(() => _customerMokup.GetCustomers());

        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<CustomerDto>> Get(int id) => await Task.Run(() => _customerMokup.GetCustomers()[id - 1]);
    }
}
