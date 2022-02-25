using System.Security.Claims;
using Tests.Spec;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		return new AuthBuilder().WithEmailAddress().Build();
	}
}
