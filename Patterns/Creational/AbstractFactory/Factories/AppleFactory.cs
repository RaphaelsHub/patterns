using Creational.AbstractFactory.Interfaces;
using Creational.AbstractFactory.Systems.AppleSystems;


namespace Creational.AbstractFactory.Factories;

public class AppleFactory : IOsFactory
{
    public IFileSystem GetFileSystem() => new AppleFileSystem();
    public IAntivirusSystem GetAntivirusSystem() => new AppleAntivirusSystem();
}