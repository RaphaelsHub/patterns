using Behavior.Strategy.Interfaces;

namespace Behavior.Strategy;

public class AuthContext
{
    private readonly IAuthService _loginStrategy;

    public AuthContext(IAuthService loginStrategy)
    {
        _loginStrategy = loginStrategy ?? throw new ArgumentNullException(nameof(loginStrategy));
    }

    public bool Login(string identifier, string password)
    {
        return _loginStrategy.LoginAsync(identifier, password);
    }
}