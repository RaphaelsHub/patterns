namespace Behavior.State;

public class PlannedState : IFlightState
{
    public string StatusText => "Canceled";

    public bool CanBeEdited() => false;
}