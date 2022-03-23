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
		var email = new EmailBuilder(_user).WithMessage(content);
		return email;
	}
}
