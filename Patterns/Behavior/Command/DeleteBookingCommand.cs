using Behavior.ChainOfResponsibility.Model;

namespace Behavior.Command;

public class DeleteBookingCommand : ICommand
{
    private readonly BookingModel _booking;

    public DeleteBookingCommand(BookingModel booking)
    {
        _booking = booking;
    }

    public void Execute()
    {
        Console.WriteLine($"Booking deleted for {_booking.CustomerName} with price {_booking.Price}");
    }
}
