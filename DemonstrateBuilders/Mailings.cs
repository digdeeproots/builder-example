namespace DemonstrateBuilders;

public static class Mailings
{
	public static Mailing HowTo() { return new Mailing("<p>This is the email <b>body.</b></p>", string.Empty); }
}
