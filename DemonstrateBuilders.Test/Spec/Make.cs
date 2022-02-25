using System.Security.Claims;

namespace Tests.Spec
{
	internal static class Make
	{
		public static ClaimsPrincipal AuthOuter()
		{
			return Authentication().WithEmailAddress().Build();
		}

		public static AuthBuilder Authentication()
		{
			return new AuthBuilder();
		}
	}
}
