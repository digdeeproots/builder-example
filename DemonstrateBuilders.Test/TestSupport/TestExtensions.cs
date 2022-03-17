using FluentAssertions;
using System.Linq;
using System.Net.Mail;

namespace Tests.TestSupport
{
	internal static class TestExtensions
	{
		public static MailMessageAssertions ShouldL(this MailMessage subject)
		{
			return new MailMessageAssertions(subject);
		}
	}

	internal class MailMessageAssertions
	{
		public MailMessageAssertions(MailMessage subject) { Subject = subject; }
		public MailMessage Subject { get; }

		public void BeTo(string recipient)
		{
			Subject.To.Should()
				.HaveCount(1);
			Subject.To.First()
				.Should()
				.BeEquivalentTo(new {Address = recipient}, options => options.ExcludingMissingMembers());
		}
	}
}
