using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class EmailBuilder
{
	private readonly MailMessage _email;

	public EmailBuilder(ClaimsPrincipal recipient)
	{
		_email = new MailMessage("customer.support@example.com", recipient.ValueFor(ClaimTypes.Email));
	}

	public EmailBuilder ForMailing(Mailing content)
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
}
