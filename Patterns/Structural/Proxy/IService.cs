namespace Structural.Proxy;

public interface IService
{
    Task<List<string>> GetData();
    Task<string> AddData(string item);
}