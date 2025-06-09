using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Systems.WindowsSystems;

public class WindowsAntivirusSystem : IAntivirusSystem
{
    public bool CheckIfIsSave(string path) => true;

}