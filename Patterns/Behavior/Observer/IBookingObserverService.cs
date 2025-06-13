using Behavior.ChainOfResponsibility.Model;

public interface IBookingObserverService
{
    void OnBookingCreated(BookingModel booking);
}