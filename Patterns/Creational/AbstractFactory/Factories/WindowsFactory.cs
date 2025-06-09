using Creational.AbstractFactory.Interfaces;
using Creational.AbstractFactory.Systems.WindowsSystems;

namespace Creational.AbstractFactory.Factories;

public class WindowsFactory : IOsFactory
{
    public IFileSystem GetFileSystem() => new WindowsFileSystem();
    public IAntivirusSystem GetAntivirusSystem() => new WindowsAntivirusSystem();
}