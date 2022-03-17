using DemonstrateBuilders;
using FluentAssertions;
using System.Net.Mail;
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
			.BeTo(Arbitrary.Email);
		BeFrom(result, "customer.support@example.com");
	}

	private static void BeFrom(MailMessage result, string sender)
	{
		result.From.Should()
			.Be(sender);
	}
}
