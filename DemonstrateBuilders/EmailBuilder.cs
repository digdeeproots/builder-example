using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class EmailBuilder
{
	private readonly ClaimsPrincipal _recipient;
	private readonly MailMessage _mailMessage;

	public EmailBuilder(ClaimsPrincipal recipient)
	{
		_recipient = recipient;
		_mailMessage = new MailMessage("customer.support@example.com", _recipient.ValueFor(ClaimTypes.Email));
	}

	public MailMessage Build()
	{
		return _mailMessage;
	}
}
