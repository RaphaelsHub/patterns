namespace Creational.Singleton;

public class DeviceModel(string deviceName, string operatingSystem, int storage)
{
    public string DeviceName { get; private set; } = deviceName;
    public string OperatingSystem { get; private set; } = operatingSystem;
    public int Storage { get; private set; } = storage;
}