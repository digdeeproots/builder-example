using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders;

public class SomePage
{
	private readonly Action<MailMessage> _sendEmail;
	private readonly ClaimsPrincipal _user;

	public SomePage(ClaimsPrincipal user, Action<MailMessage> sendEmail)
	{
		_user = user;
		_sendEmail = sendEmail;
	}

	public void CreateHowToEmail()
	{
		var content = Mailings.HowTo(_user.ValueFor(ClaimTypes.GivenName), DateTime.Now.DayOfWeek.ToString());
		var builder = new EmailTo(_user).WithContent(content);
		Send(builder);
	}

	private void Send(EmailTo builder) { _sendEmail(builder.Build()); }
}
