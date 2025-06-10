namespace Behavior.Strategy.Interfaces;

public interface IAuthService
{
    bool LoginAsync(string identifier, string password);
}