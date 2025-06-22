namespace Structural.Facade;

public class CookieService
{
    public Task Set(string key, string value, DateTime expires)
    {
        Console.WriteLine($"Set cookie: {key}={value}, expires at {expires}");
        return Task.CompletedTask;
    }

    public Task Remove(string key)
    {
        Console.WriteLine($"Remove cookie: {key}");
        return Task.CompletedTask;
    }
}