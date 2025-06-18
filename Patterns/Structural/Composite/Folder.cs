using Structural.Composite;

namespace Structural.Composite;

public class Folder : IFileItem
{
    private string _name;
    private List<IFileItem> _items = new();

    public Folder(string name) => _name = name;

    public void Add(IFileItem item) => _items.Add(item);

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}+ Folder: {_name}");
        foreach (var item in _items)
        {
            item.Display(indent + "  ");
        }
    }
}