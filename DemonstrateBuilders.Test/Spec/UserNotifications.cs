using DemonstrateBuilders;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec;

public class UserNotifications : IncludesGoldenMasterTests
{
	[Fact]
	public void AskingForHelpShouldSendHowToEmail()
	{
		ClaimsPrincipal applesauce(string s)
		{
			var claimsPrincipal = Make.Authentication()
				.WithFirstName(s)
				.WithEmailAddress(Arbitrary.Email)
				.Build();
			return claimsPrincipal;
		}

		var firstName = Arbitrary.String();
		var loggedInUser = applesauce(firstName);
		var testSubject = new SomePage(loggedInUser);
		var result = testSubject.CreateHowToEmail();

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
