using System.Security.Claims;
using Tests.TestSupport;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		return new AuthBuilder().Build();
	}
}

internal class AuthBuilder
{
	public ClaimsPrincipal Build()
	{
		return new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {new(ClaimTypes.Email, Arbitrary.Email)}));
	}
}
