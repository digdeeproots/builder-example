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
		var email = new MailMessage("customer.support@example.com", UserClaim(_user, ClaimTypes.Email));
		email.IsBodyHtml = true;
		var content = Mailings.HowTo(_user.Claims.First(cl => cl.Type == ClaimTypes.GivenName)
			.Value, "Wednesday");
		email.Body = content.Body;
		email.Subject = content.SubjectLine;
		return email;
	}

	private static string UserClaim(ClaimsPrincipal user, string claimType)
	{
		return user.Claims.First(cl => cl.Type == claimType)
			.Value;
	}
}
