using DemonstrateBuilders;
using FluentAssertions;
using System.Net.Mail;
using System.Security.Claims;
using Xunit;

namespace Tests.Spec
{
	public class UserNotifications
	{
		[Fact]
		public void AskingForHelpShouldSendHowToEmail()
		{
			var loggedInUser =
				new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {new(ClaimTypes.Email, "arbitrary.email@example.com")}));
			var testSubject = new SomePage(loggedInUser);
			var result = testSubject.CreateHowToEmail();
			result.Should().NotBeNull();
			result.To.Should().BeEquivalentTo(new MailAddress[] { });
			result.From.Should().BeNull();
		}
	}
}
