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
		var email = Build(_user, new EmailBuilder());
		email.IsBodyHtml = true;
		var content = Mailings.HowTo(_user.ValueFor(ClaimTypes.GivenName), DateTime.Now.DayOfWeek.ToString());
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}

	private static MailMessage Build(ClaimsPrincipal user, EmailBuilder emailBuilder)
	{
		return new MailMessage("customer.support@example.com", user.ValueFor(ClaimTypes.Email));
	}
}

public class EmailBuilder
{
}
