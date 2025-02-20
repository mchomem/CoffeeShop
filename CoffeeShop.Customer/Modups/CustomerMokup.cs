using CoffeeShop.Customer.Dtos;

namespace CoffeeShop.Customer.Modups;

public class CustomerMokup
{
    public List<CustomerDto> GetCustomers()
    {
        return new List<CustomerDto>()
        {
            new CustomerDto(){ Id = 1, Name = "Mark Darius" },
            new CustomerDto(){ Id = 2, Name = "John Jacob" },
            new CustomerDto(){ Id = 3, Name = "Bea Tris" },
            new CustomerDto(){ Id = 4, Name = "Lea Sonda" },
            new CustomerDto(){ Id = 5, Name = "Sophia Star" },
            new CustomerDto(){ Id = 6, Name = "Ralph Milk" }
        };
    }
}
