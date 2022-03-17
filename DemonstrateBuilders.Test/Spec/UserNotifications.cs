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

		AssertionExtensions.Should(result)
			.NotBeNull();
		result.Should()
			.BeTo(Arbitrary.Email)
			.And.BeFrom("customer.support@example.com");
	}
}
