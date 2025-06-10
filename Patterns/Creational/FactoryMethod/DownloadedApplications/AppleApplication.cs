using Creational.FactoryMethod.Interfaces;

namespace Creational.FactoryMethod.DownloadedApplications;

public class AppleApplication : IApplication
{
    public void InstallApp() =>
        Console.WriteLine("Installing application on Apple");

    public void UninstallApp() =>
        Console.WriteLine("Uninstalling application on Apple");
}