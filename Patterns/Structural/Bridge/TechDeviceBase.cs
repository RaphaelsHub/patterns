namespace Structural.Bridge;

public abstract class TechDeviceBase
{
    protected ITechDevice _techDevice;

    protected TechDeviceBase(ITechDevice techDevice)
    {
        _techDevice = techDevice;
    }

    public void TurnOn()
    {
        _techDevice.TurnOn();
    }

    public void TurnOff()
    {
        _techDevice.TurnOff();
    }
}