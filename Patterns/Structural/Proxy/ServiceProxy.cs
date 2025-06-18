namespace Structural.Proxy;

public class ServiceProxy : IService
{
    private readonly IService _realService;
    private readonly IAuthService _authService;

    public ServiceProxy()
    {
        _realService = new RealService();
        _authService = new FakeAuthService();
    }

    private async Task CheckAuthorization()
    {
        if (!await _authService.IsAuthorized())
            throw new UnauthorizedAccessException("Access denied");
    }

    public async Task<List<string>> GetData()
    {
        await CheckAuthorization();
        return await _realService.GetData();
    }

    public async Task<string> AddData(string item)
    {
        await CheckAuthorization();
        return await _realService.AddData(item);
    }
}