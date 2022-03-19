using FluentAssertions;
using FluentAssertions.Primitives;
using System.Linq;
using System.Net.Mail;
using Tests.Spec;

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

internal class MailMessageAssertions : ReferenceTypeAssertions<MailMessage, MailMessageAssertions>
{
	public MailMessageAssertions(MailMessage subject) : base(subject) { }

	protected override string Identifier => "mail message";

	public AndConstraint<MailMessageAssertions> BeTo(params string[] recipients)
	{
		Subject.To.Should()
			.BeEquivalentTo(recipients.Select(r => new {Address = r}), options => options.ExcludingMissingMembers());
		return this.AllowingAnd();
	}

	public AndConstraint<MailMessageAssertions> BeFrom(string sender)
	{
		Subject.From.Should()
			.Be(sender);
		return this.AllowingAnd();
	}

	public AndConstraint<MailMessageAssertions> HaveContent(Mailing expected)
	{
		return this.AllowingAnd();
	}
}
