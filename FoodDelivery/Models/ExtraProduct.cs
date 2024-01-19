namespace FoodDelivery.Models;

public class ExtraProduct
{
    public int ProductId { get; set; }
    public required Product Product { get; set; }

    public int ExtraId { get; set; }
    public required Extra Extra { get; set; }
    
    
}