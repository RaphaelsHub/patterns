using Behavior.ChainOfResponsibility.Model;

namespace Behavior.Observer;

public class BookingObserver
{
    private readonly List<IBookingObserverService> _observers = new List<IBookingObserverService>();

    public void Subscribe(IBookingObserverService observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IBookingObserverService observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(BookingModel booking)
    {
        foreach (var observer in _observers)
        {
            observer.OnBookingCreated(booking);
        }
    }
}