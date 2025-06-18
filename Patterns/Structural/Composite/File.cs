namespace Structural.Composite;

public class File : IFileItem
{
    private string _name;
    public File(string name) => _name = name;

    public void Display(string indent = "") => Console.WriteLine($"{indent}- File: {_name}");
}



