using DemonstrateBuilders;
using FluentAssertions;
using Xunit;

namespace Tests
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
