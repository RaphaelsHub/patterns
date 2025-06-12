using Behavior.State;

namespace Behavior.State;

public class FlightStateContext
{
    private IFlightState? _state;

    public void SetState(IFlightState state) => _state = state;

    public bool CanEdit() => _state.CanBeEdited();
    public string GetStatus() => _state.StatusText;
}