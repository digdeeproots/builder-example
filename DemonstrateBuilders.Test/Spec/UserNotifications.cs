using DemonstrateBuilders;
using System.Threading.Tasks;
using Tests.TestSupport;
using VerifyTests;
using VerifyXunit;
using Xunit;

namespace Tests.Spec;

public class UserNotifications : VerifyBase
{
	public UserNotifications(VerifySettings? settings = null) : base(settings)
	{
	}

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
	public Task HowToEmailShouldHaveRightContents()
	{
		var testSubject = Mailings.HowTo();
		return Verify(testSubject);
	}
}
