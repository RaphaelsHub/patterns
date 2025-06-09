namespace Creational.AbstractFactory.Interfaces;

public interface IOsFactory
{
    IFileSystem GetFileSystem();
    IAntivirusSystem GetAntivirusSystem();
}