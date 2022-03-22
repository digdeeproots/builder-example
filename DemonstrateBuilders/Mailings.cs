namespace DemonstrateBuilders;

public static class Mailings
{
	public static Mailing HowTo(string firstName, string requestDay)
	{
		return new Mailing($"<p>Hello, {firstName}.</p><p>Here's some help using <i>our awesome tool</i>.</p>",
			$"Help you requested on {requestDay}");
	}
}
