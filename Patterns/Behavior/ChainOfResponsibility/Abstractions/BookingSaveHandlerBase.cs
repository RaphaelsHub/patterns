using Behavior.ChainOfResponsibility.Model;

namespace Behavior.ChainOfResponsibility.Abstractions;

public abstract class BookingSaveHandlerBase
{
    protected BookingSaveHandlerBase? NextHandler { get; set; } = null;

    public void SetNext(BookingSaveHandlerBase nextHandler) =>
        NextHandler = nextHandler;

    public virtual bool Handle(BookingModel booking)
    {
        var isValid = Process(booking);

        if (!isValid)
            return false;

        if (NextHandler != null)
        {
            return NextHandler.Handle(booking);
        }

        return true;
    }

    public abstract bool Process(BookingModel booking);
}