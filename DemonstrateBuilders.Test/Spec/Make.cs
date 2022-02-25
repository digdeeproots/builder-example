using System.Security.Claims;

namespace Tests.Spec
{
	internal static class Make
	{
		public static ClaimsPrincipal Authentication()
		{
			return new AuthBuilder().WithEmailAddress().Build();
		}
	}
}
