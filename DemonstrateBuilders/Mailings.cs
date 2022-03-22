namespace DemonstrateBuilders;

public static class Mailings
{
	public static Mailing HowTo()
	{
		return new Mailing($"<p>Hello, {"Sam"}.</p><p>Here's some help using <i>our awesome tool</i>.</p>",
			$"Help you requested on {"Wednesday"}");
	}
}
