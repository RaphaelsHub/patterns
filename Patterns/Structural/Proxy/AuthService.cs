namespace Structural.Proxy;

public class FakeAuthService : IAuthService
{
    public Task<bool> IsAuthorized()
    {
        return Task.FromResult(true);
    }
}