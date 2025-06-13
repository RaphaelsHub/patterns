using Behavior.ChainOfResponsibility.Model;

namespace Behavior.Observer;

public interface IBookingObserverService
{
    void OnBookingCreated(BookingModel booking);
}