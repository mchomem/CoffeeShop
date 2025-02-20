using CoffeeShop.Menu.Dtos;

namespace CoffeeShop.Menu.Mokups;

public class ProductMokaup
{
    public List<ProductDto> GetProducts()
    {
        return new List<ProductDto>()
        {
            new ProductDto() { Id = 1, Name = "Latte", Description = "Latte", Price = 1.52m, Discount = 0.0m, Active = true},
            new ProductDto() { Id = 2, Name = "American", Description = "American" , Price = 3.65m, Discount = 0.0m, Active =  true },
            new ProductDto() { Id = 3, Name = "Express" , Description = "Express"  , Price = 4.12m, Discount = 0.0m, Active =  true },
            new ProductDto() { Id = 4, Name = "Mocha"   , Description = "Mocha"    , Price = 5.52m, Discount = 0.0m, Active =  true },
            new ProductDto() { Id = 5, Name = "Tea"     , Description = "Tea"      , Price = 0.98m, Discount = 0.0m, Active =  true }
        };
    }
}
