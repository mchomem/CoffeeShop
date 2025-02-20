using CoffeeShop.Menu.Mokups;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Menu.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MenuController : ControllerBase
{
    private readonly ProductMokaup _productMokaup;

    public MenuController(ProductMokaup productMokaup)
    {
        _productMokaup = productMokaup;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var menus =  await Task.Run(() => _productMokaup.GetProducts());
        return Ok(menus);
    }

    [HttpGet("{id}", Name = "Get")]
    public async Task<IActionResult> Get(int id)
    {
        var menu = await Task.Run(() => _productMokaup.GetProducts()[id - 1]);
        return Ok(menu);
    }
}
