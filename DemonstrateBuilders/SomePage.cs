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
		var email = new EmailBuilder().Build(_user);
		email.IsBodyHtml = true;
		var content = Mailings.HowTo(_user.ValueFor(ClaimTypes.GivenName), DateTime.Now.DayOfWeek.ToString());
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}
}

public class EmailBuilder
{
	private ClaimsPrincipal _recipient;

	public MailMessage Build(ClaimsPrincipal user)
	{
		_recipient = user;
		return new MailMessage("customer.support@example.com", _recipient.ValueFor(ClaimTypes.Email));
	}
}
