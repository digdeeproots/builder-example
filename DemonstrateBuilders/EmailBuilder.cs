using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class EmailBuilder
{
	private ClaimsPrincipal _recipient;

	public MailMessage Build(ClaimsPrincipal user)
	{
		_recipient = user;
		return new MailMessage("customer.support@example.com", _recipient.ValueFor(ClaimTypes.Email));
	}
}
