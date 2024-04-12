using CoffeeShop.Menu.Dtos;
using CoffeeShop.Menu.Mokups;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Menu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly ProductMokaup _productMokaup;

        public MenuController(ProductMokaup productMokaup) => _productMokaup = productMokaup;

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> Get()
            => await Task.Run(() => _productMokaup.GetProducts());

        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<ProductDto>> Get(int id) => await Task.Run(() => _productMokaup.GetProducts()[id - 1]);
    }
}
