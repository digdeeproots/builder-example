using FluentAssertions;
using FluentAssertions.Primitives;
using System.Linq;
using System.Net.Mail;

namespace Tests.TestSupport;

internal static class TestExtensions
{
	public static MailMessageAssertions ShouldL(this MailMessage subject)
	{
		return new MailMessageAssertions(subject);
	}
}

internal class MailMessageAssertions : ReferenceTypeAssertions<MailMessage, MailMessageAssertions>
{
	public MailMessageAssertions(MailMessage subject) : base(subject) { }

	protected override string Identifier => "mail message";

	public void BeTo(params string[] recipients)
	{
		Subject.To.Should()
			.BeEquivalentTo(recipients.Select(r => new {Address = r}), options => options.ExcludingMissingMembers());
	}
}
