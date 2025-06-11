namespace Behavior.ChainOfResponsibility.Model;

public class BookingModel(string customerName, decimal price)
{
    public string CustomerName { get; set; } = customerName;
    public decimal Price { get; set; } = price;
}