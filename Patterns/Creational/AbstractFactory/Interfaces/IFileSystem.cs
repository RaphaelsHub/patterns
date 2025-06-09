namespace Creational.AbstractFactory.Interfaces;

public interface IFileSystem
{
    void CreateDirectory(string path);
    void DeleteDirectory(string path);
}