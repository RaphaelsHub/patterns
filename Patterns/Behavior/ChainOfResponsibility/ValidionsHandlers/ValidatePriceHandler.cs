using Behavior.ChainOfResponsibility.Abstractions;

namespace Behavior.ChainOfResponsibility.ValidionsHandlers;

public class ValidatePriceHandler : BookingSaveHandlerBase
{
    public override bool Process(Model.BookingModel booking)
    {
        if (booking.Price <= 0)
        {
            Console.WriteLine("Price must be greater than zero.");
            return false;
        }

        if (booking.Price > 10000)
        {
            Console.WriteLine("Price cannot exceed 10,000.");
            return false;
        }

        return true;
    }
}