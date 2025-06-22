namespace Structural.Facade;

public class TokenService
{
    public Task<string> Generate(User user)
    {
        return Task.FromResult($"token_for_user_{user.Id}");
    }
}