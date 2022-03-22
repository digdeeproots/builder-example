using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class SomePage
{
	private readonly ClaimsPrincipal _user;

	public SomePage(ClaimsPrincipal user)
	{
		_user = user;
	}

	public MailMessage CreateHowToEmail()
	{
		var email = new MailMessage("customer.support@example.com", _user.Claims.First(cl => cl.Type == ClaimTypes.Email)
			.Value);
		email.IsBodyHtml = true;
		var content = Mailings.HowTo("Sam", "Wednesday");
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}
}
