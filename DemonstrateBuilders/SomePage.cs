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
		var emailBuilder = new EmailBuilder(_user);
		var email = emailBuilder.Build();
		var content = Mailings.HowTo(_user.ValueFor(ClaimTypes.GivenName), DateTime.Now.DayOfWeek.ToString());
		email.IsBodyHtml = true;
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}
}
