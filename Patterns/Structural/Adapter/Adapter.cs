namespace Structural.Adapter;

public class EmailAdapter : IEmailService
{
    private readonly ExternalMailSender _externalMailSender;

    public EmailAdapter(ExternalMailSender externalMailSender)
    {
        _externalMailSender = externalMailSender;
    }

    public Task SendEmail(string to, string subject, string body) =>
        _externalMailSender.Send(to, subject, body);
}