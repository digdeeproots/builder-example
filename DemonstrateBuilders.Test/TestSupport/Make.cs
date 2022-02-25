namespace Tests.TestSupport
{
	internal static class Make
	{
		public static AuthBuilder Authentication()
		{
			return new AuthBuilder();
		}
	}
}
