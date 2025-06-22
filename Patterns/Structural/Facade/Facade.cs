namespace Structural.Facade;

using System;
using System.Threading.Tasks;

public class AuthFacade
{
    private readonly AuthorizationService _authService;
    private readonly CookieService _cookieService;
    private readonly TokenService _tokenService;

    public AuthFacade()
    {
        _authService = new AuthorizationService();
        _cookieService = new CookieService();
        _tokenService = new TokenService();
    }

    public async Task<bool> Login(string username, string password, bool rememberMe)
    {
        var user = await _authService.Login(username, password);

        if (user == null)
            return false;

        await SetCookies(user, rememberMe);
        return true;
    }

    public async Task<bool> Register(string username, string password)
    {
        var user = await _authService.Register(username, password);

        await SetCookies(user, true);
        return true;
    }

    public async Task Logout()
    {
        await _cookieService.Remove("user_id");
        await _cookieService.Remove("token");
    }

    private async Task SetCookies(User user, bool remember)
    {
        var expires = remember ? DateTime.UtcNow.AddDays(30) : DateTime.UtcNow.AddHours(1);

        await _cookieService.Set("user_id", user.Id.ToString(), expires);
        var token = await _tokenService.Generate(user);
        await _cookieService.Set("token", token, expires);
    }
}







