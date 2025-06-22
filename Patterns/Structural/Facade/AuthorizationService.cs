namespace Structural.Facade;

public class AuthorizationService
{
    public Task<User> Login(string username, string password)
    {
        return Task.FromResult(new User { Id = 1, Name = username });
    }

    public Task<User> Register(string username, string password)
    {
        return Task.FromResult(new User { Id = 2, Name = username });
    }
}
