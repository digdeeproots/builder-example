using DemonstrateBuilders;
using FluentAssertions;
using System.Linq;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec
{
	public class UserNotifications
	{
		[Fact]
		public void AskingForHelpShouldSendHowToEmail()
		{
			var loggedInUser = Make.Authentication();
			var testSubject = new SomePage(loggedInUser);
			var result = testSubject.CreateHowToEmail();
			result.Should().NotBeNull();
			result.To.Should().HaveCount(1);
			result.To.First().Should().BeEquivalentTo(new {Address = Arbitrary.Email},
				options => options.ExcludingMissingMembers());
			result.From.Should().Be("customer.support@example.com");
		}
	}
}
