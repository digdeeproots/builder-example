using FluentAssertions;
using Xunit;

namespace DemonstrateBuilders.Test
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			new SomePage().Should().NotBeNull();
		}
	}
}
