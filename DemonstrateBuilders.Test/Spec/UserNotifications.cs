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
			testSubject.Should().NotBeNull();
		}
	}
}
