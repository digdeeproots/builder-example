using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class EmailBuilder
{
	private readonly MailMessage _mailMessage;

	public EmailBuilder(ClaimsPrincipal recipient)
	{
		_mailMessage = new MailMessage("customer.support@example.com", recipient.ValueFor(ClaimTypes.Email));
	}

	public EmailBuilder ForMailing(Mailing content)
	{
		_mailMessage.IsBodyHtml = true;
		_mailMessage.Body = content.Body;
		_mailMessage.Subject = content.SubjectLine;
		return this;
	}

	public MailMessage Build()
	{
		return _mailMessage;
	}
}
