using DemonstrateBuilders;
using FluentAssertions;
using System.Linq;
using System.Security.Claims;
using Xunit;

namespace Tests.Spec
{
	public class UserNotifications
	{
		[Fact]
		public void AskingForHelpShouldSendHowToEmail()
		{
			var arbitraryEmailExampleCom = "arbitrary.email@example.com";
			var loggedInUser =
				new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {new(ClaimTypes.Email, arbitraryEmailExampleCom)}));
			var testSubject = new SomePage(loggedInUser);
			var result = testSubject.CreateHowToEmail();
			result.Should().NotBeNull();
			result.To.Should().HaveCount(1);
			result.To.First().Should().BeEquivalentTo(new {Address = arbitraryEmailExampleCom},
				options => options.ExcludingMissingMembers());
			result.From.Should().Be("customer.support@example.com");
		}
	}
}
