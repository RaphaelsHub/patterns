using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Systems.AppleSystems;

public class AppleAntivirusSystem : IAntivirusSystem
{
    public bool CheckIfIsSave(string path) => true;
}