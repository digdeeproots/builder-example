using DemonstrateBuilders;
using FluentAssertions;
using FluentAssertions.Primitives;
using System.Linq;
using System.Net.Mail;

namespace Tests.TestSupport;

internal class MailMessageAssertions : ReferenceTypeAssertions<MailMessage, MailMessageAssertions>
{
	public MailMessageAssertions(MailMessage subject) : base(subject) { }

	protected override string Identifier => "mail message";

	public AndConstraint<MailMessageAssertions> BeTo(params string[] recipients)
	{
		var email = Subject;
		email.To.Should()
			.BeEquivalentTo(recipients.Select(r => new {Address = r}), options => options.ExcludingMissingMembers());
		return this.AllowingAnd();
	}

	public AndConstraint<MailMessageAssertions> BeFrom(string sender)
	{
		var email = Subject;
		email.From.Should()
			.Be(sender);
		return this.AllowingAnd();
	}

	public AndConstraint<MailMessageAssertions> HaveContent(Mailing expected)
	{
		var email = Subject;
		email.Body.Should()
			.Be(expected.Body);
		email.Subject.Should()
			.Be(expected.SubjectLine);
		email.IsBodyHtml.Should()
			.BeTrue();
		return this.AllowingAnd();
	}
}
