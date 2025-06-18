namespace Structural.Proxy;

public class RealService : IService
{
    private readonly List<string> _storage = new();

    public Task<List<string>> GetData()
    {
        Console.WriteLine("RealService: Returning data...");
        return Task.FromResult(_storage);
    }

    public Task<string> AddData(string item)
    {
        _storage.Add(item);
        Console.WriteLine($"RealService: Added '{item}'");
        return Task.FromResult(item);
    }
}