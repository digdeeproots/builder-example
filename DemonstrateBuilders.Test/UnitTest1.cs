using System.Net.Mail;
using FluentAssertions;
using Xunit;

namespace DemonstrateBuilders.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            new Class1().Should().NotBeNull();
        }
    }
}