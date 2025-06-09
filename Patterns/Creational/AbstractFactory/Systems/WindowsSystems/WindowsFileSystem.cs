using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Systems.WindowsSystems;

public class WindowsFileSystem : IFileSystem
{
    public void CreateDirectory(string path) =>
        Console.WriteLine($"Creating directory {path} on Windows");

    public void DeleteDirectory(string path) =>
        Console.WriteLine($"Deleting directory {path} on Windows");
}