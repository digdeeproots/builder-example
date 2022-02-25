using System.Net.Mail;
using System.Security.Claims;

namespace DemonstrateBuilders
{
	public class SomePage
	{
		private readonly ClaimsPrincipal _user;

		public SomePage(ClaimsPrincipal user)
		{
			_user = user;
		}

		public MailMessage CreateHowToEmail()
		{
			return new MailMessage();
		}
	}
}
