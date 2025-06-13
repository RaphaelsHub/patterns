using Behavior.ChainOfResponsibility.Model;

public class LoggingBookingNotificationService : IBookingObserverService
{
    public void OnBookingCreated(BookingModel booking)
    {
        Console.WriteLine($"[Logging] Booking created for {booking.CustomerName}");
    }
}