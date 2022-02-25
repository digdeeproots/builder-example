using DemonstrateBuilders;
using FluentAssertions;
using Xunit;

namespace Tests.Spec
{
	public class UserNotifications
	{
		[Fact]
		public void AskingForHelpShouldSendHowToEmail()
		{
			var testSubject = new SomePage();
			var result = testSubject.CreateHowToEmail();
			result.Should().BeNull();
		}
	}
}
