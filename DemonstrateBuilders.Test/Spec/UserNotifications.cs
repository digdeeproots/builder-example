using DemonstrateBuilders;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec;

public class Person
{
	public Person(string s) { S = s; }
	public string S { get; }
}

public class UserNotifications : IncludesGoldenMasterTests
{
	[Fact]
	public void AskingForHelpShouldSendHowToEmail()
	{
		ClaimsPrincipal appleSauce(Person person)
		{
			var claimsPrincipal = Make.Authentication()
				.WithFirstName(person.S)
				.WithEmailAddress(Arbitrary.Email)
				.Build();
			return claimsPrincipal;
		}

		var firstName = Arbitrary.String();
		// do some more custom code.
		// And more.
		var user = applesauce(firstName);
		var testSubject = new SomePage(user);
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
