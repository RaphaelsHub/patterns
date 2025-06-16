namespace Structural.Adapter;

public class ExternalMailSender
{
    public Task Send(string receiverAddress, string subjectLine, string htmlContent)
    {
        Console.WriteLine($"[EXTERNAL MAIL] To: {receiverAddress}, Subject: {subjectLine}");
        return Task.CompletedTask;
    }
}