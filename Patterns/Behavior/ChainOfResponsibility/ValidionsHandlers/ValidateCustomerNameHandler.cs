using Behavior.ChainOfResponsibility.Abstractions;

namespace Behavior.ChainOfResponsibility.ValidionsHandlers;

public class ValidateCustomerNameHandler : BookingSaveHandlerBase
{
    public override bool Process(Model.BookingModel booking)
    {
        if (string.IsNullOrWhiteSpace(booking.CustomerName))
        {
            Console.WriteLine("Customer name is required.");
            return false;
        }

        if (booking.CustomerName.Length < 3)
        {
            Console.WriteLine("Customer name must be at least 3 characters long.");
            return false;
        }

        return true;
    }
}