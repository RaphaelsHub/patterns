using Behavior.ChainOfResponsibility.Model;

namespace Behavior.Observer;

public class EmailBookingNotificationService : IBookingObserverService
{
    public void OnBookingCreated(BookingModel booking)
    {
        Console.WriteLine($"[Email] Отправлено письмо на {booking.CustomerName}");
    }
}