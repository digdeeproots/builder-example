using DemonstrateBuilders;
using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec;

public class UserNotifications : IncludesGoldenMasterTests
{
	[Fact]
	public void AskingForHelpShouldSendHowToEmail()
	{
		var firstName = Arbitrary.String();
		var loggedInUser = Make.Authentication()
			.WithFirstName(firstName)
			.WithEmailAddress(Arbitrary.Email)
			.Build();
		MailMessage? result = null;
		var testSubject = new SomePage(loggedInUser, email => result = email);
		testSubject.CreateHowToEmail();

		result.Should()
			.BeTo(Arbitrary.Email)
			.And.BeFrom("customer.support@example.com")
			.And.HaveContent(Mailings.HowTo(firstName, DateTime.Now.DayOfWeek.ToString()));
	}

	[Fact]
	public Task HowToEmailShouldHaveRightContents()
	{
		var testSubject = Mailings.HowTo("[your first name]", "[day you requested help]");
		return Verify(testSubject);
	}
}
