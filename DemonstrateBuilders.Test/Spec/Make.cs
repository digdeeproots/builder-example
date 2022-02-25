using System.Security.Claims;

namespace Tests.Spec
{
	internal static class Make
	{
		public static ClaimsPrincipal AuthOuter()
		{
			return new AuthBuilder().WithEmailAddress().Build();
		}
	}
}
