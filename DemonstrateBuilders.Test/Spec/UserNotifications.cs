using DemonstrateBuilders;
using FluentAssertions;
using System.Linq;
using System.Net.Mail;
using Tests.TestSupport;
using Xunit;

namespace Tests.Spec
{
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
			BeTo(result, Arbitrary.Email);
			result.From.Should()
				.Be("customer.support@example.com");
		}

		private static void BeTo(MailMessage result, string recipient)
		{
			result.To.Should()
				.HaveCount(1);
			result.To.First()
				.Should()
				.BeEquivalentTo(new {Address = recipient}, options => options.ExcludingMissingMembers());
		}
	}
}
