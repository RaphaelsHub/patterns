namespace Behavior.State;

public class CanceledState : IFlightState
{
    public string StatusText => "Canceled";

    public bool CanBeEdited() => false;
}