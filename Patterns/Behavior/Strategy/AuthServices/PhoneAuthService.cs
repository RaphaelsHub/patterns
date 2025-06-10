using Behavior.Strategy.Interfaces;

namespace Behavior.Strategy.AuthServices;

public class PhoneAuthService : IAuthService
{
    public bool LoginAsync(string phoneNumber, string verificationCode)
    {
        if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(verificationCode))
        {
            Console.WriteLine("Phone number or verification code cannot be empty.");
            return false;
        }

        Console.WriteLine($"Logging in with Phone: {phoneNumber}");
        return true;
    }
}
