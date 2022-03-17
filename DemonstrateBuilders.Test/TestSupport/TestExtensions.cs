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
	}
}
