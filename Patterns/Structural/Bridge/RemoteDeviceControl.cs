namespace Structural.Bridge;

public class RemoteDeviceControl : TechDeviceBase
{
    public RemoteDeviceControl(ITechDevice techDevice) : base(techDevice)
    {
    }

    public void SetDevice(ITechDevice techDevice)
    {
        _techDevice = techDevice;
    }

    public void TogglePower(bool isOn)
    {
        if (isOn)
            TurnOn();
        else
            TurnOff();
    }
}