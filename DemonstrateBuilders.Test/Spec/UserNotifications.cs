using DemonstrateBuilders;
using System.Threading.Tasks;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec;

public class UserNotifications : IncludesGoldenMasterTests
{
	[Fact]
	public void AskingForHelpShouldSendHowToEmail()
	{
		var loggedInUser = Make.Authentication()
			.WithFirstName(Arbitrary.String())
			.WithEmailAddress(Arbitrary.Email)
			.Build();
		var testSubject = new SomePage(loggedInUser);
		var result = testSubject.CreateHowToEmail();

		result.Should()
			.BeTo(Arbitrary.Email)
			.And.BeFrom("customer.support@example.com")
			.And.HaveContent(Mailings.HowTo("Sam", "Wednesday"));
	}

	[Fact]
	public Task HowToEmailShouldHaveRightContents()
	{
		var testSubject = Mailings.HowTo("[your first name]", "[day you requested help]");
		return Verify(testSubject);
	}
}
