using Creational.FactoryMethod.Interfaces;

namespace Creational.FactoryMethod.DownloadedApplications;

public class MicrosoftApplication : IApplication
{
    public void InstallApp() =>
        Console.WriteLine("Installing Application on Windows");

    public void UninstallApp() =>
        Console.WriteLine("Uninstalling Application on Windows");
}