using System.Net.Mail;

namespace Tests.TestSupport
{
	internal static class TestExtensions
	{
		public static MailMessage ShouldL(MailMessage subject) { return subject; }
	}
}
