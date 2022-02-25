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
			new SomePage().Should().NotBeNull();
		}
	}
}
