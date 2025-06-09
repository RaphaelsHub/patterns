namespace Creational.Singleton;

public class DeviceInfoProvider
{
    public DeviceModel GetDeviceModel() => new DeviceModel(
        Environment.MachineName,
        Environment.OSVersion.ToString(),
        GetTotalStorageMemoryInGB()
    );

    private short GetTotalStorageMemoryInGB()
    {
        long totalMemory = 0;

        foreach (var drive in System.IO.DriveInfo.GetDrives())
        {
            if (drive.IsReady)
            {
                totalMemory += drive.TotalSize;
            }
        }

        return (short)(totalMemory / (1024 * 1024 * 1024));
    }

}