using DemonstrateBuilders;
using FluentAssertions;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec;

public class UserNotifications
{
	[Fact]
	public void AskingForHelpShouldSendHowToEmail()
	{
		var loggedInUser = Make.Authentication()
			.WithEmailAddress(Arbitrary.Email)
			.Build();
		var testSubject = new SomePage(loggedInUser);
		var result = testSubject.CreateHowToEmail();

		result.Should()
			.NotBeNull();
		result.ShouldL()
			.BeTo(Arbitrary.Email);
		result.From.Should()
			.Be("customer.support@example.com");
	}
}
