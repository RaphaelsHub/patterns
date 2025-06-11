using Behavior.ChainOfResponsibility.Model;

namespace Behavior.Command;

public class CreateBookingCommand : ICommand
{
    private readonly BookingModel _booking;

    public CreateBookingCommand(BookingModel booking)
    {
        _booking = booking;
    }

    public void Execute()
    {
        Console.WriteLine($"Booking created for {_booking.CustomerName} with price {_booking.Price}");
    }
}
