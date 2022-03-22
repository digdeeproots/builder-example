using FluentAssertions;
using System.Net.Mail;

namespace Tests.TestSupport;

internal static class TestExtensions
{
	public static MailMessageAssertions Should(this MailMessage subject)
	{
		return new MailMessageAssertions(subject);
	}

	public static AndConstraint<T> AllowingAnd<T>(this T assertions)
	{
		return new AndConstraint<T>(assertions);
	}
}
