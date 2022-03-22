using ApprovalTests;
using DemonstrateBuilders;
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
			.BeTo(Arbitrary.Email)
			.And.BeFrom("customer.support@example.com")
			.And.HaveContent(Mailings.HowTo());
	}

	[Fact]
	public void HowToEmailShouldHaveRightContents()
	{
		var testSubject = Mailings.HowTo();
		Approvals.Verify(testSubject);
	}
}
