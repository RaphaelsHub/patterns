using Behavior.Strategy.Interfaces;

namespace Behavior.Strategy.AuthServices;

public class EmailAuthService : IAuthService
{
    public bool LoginAsync(string identifier, string password)
    {
        if (string.IsNullOrEmpty(identifier) || string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Identifier or password cannot be empty.");
            return false;
        }

        Console.WriteLine($"Logging in with Email: {identifier}");
        return true;
    }
}