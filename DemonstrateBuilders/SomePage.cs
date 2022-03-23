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
		var content = Mailings.HowTo(_user.ValueFor(ClaimTypes.GivenName), DateTime.Now.DayOfWeek.ToString());
		var emailBuilder = new EmailBuilder(_user);
		var email = WithMessage(emailBuilder, content);
		return email;
	}

	private static MailMessage WithMessage(EmailBuilder emailBuilder, Mailing content)
	{
		var email = emailBuilder.Build();
		email.IsBodyHtml = true;
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}
}
