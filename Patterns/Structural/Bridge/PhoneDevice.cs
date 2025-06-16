namespace Structural.Bridge;

public class PhoneDevice : ITechDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Turning on the phone.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning off the phone.");
    }
}