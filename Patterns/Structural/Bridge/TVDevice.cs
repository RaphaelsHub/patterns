namespace Structural.Bridge;

public class TvDevice : ITechDevice
{
    public void TurnOff()
    {
        Console.WriteLine("Turning off the TV.");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on the TV.");
    }
}