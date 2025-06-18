namespace Structural.Proxy;

public interface IAuthService
{
    Task<bool> IsAuthorized();
}
