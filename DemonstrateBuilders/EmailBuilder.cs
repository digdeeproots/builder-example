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

	public MailMessage Build()
	{
		return _mailMessage;
	}

	public MailMessage WithMessage(Mailing content)
	{
		var email = Build();
		email.IsBodyHtml = true;
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}
}
