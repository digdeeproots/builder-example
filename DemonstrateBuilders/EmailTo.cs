using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class EmailTo
{
	private readonly MailMessage _email;

	public EmailTo(ClaimsPrincipal recipient)
	{
		_email = new MailMessage("customer.support@example.com", recipient.ValueFor(ClaimTypes.Email));
	}

	public EmailTo WithContent(Mailing content)
	{
		_email.IsBodyHtml = true;
		_email.Body = content.Body;
		_email.Subject = content.SubjectLine;
		return this;
	}

	public MailMessage Build()
	{
		return _email;
	}

	public void Send(Action<MailMessage> sendEmail) { sendEmail(_email); }
}
