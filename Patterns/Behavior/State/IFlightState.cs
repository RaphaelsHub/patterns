namespace Behavior.State;

public interface IFlightState
{
    string StatusText { get; }
    bool CanBeEdited();
}