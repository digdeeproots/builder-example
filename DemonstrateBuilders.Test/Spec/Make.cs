using System.Security.Claims;
using Tests.TestSupport;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		return Build(new AuthBuilder());
	}

	private static ClaimsPrincipal Build(AuthBuilder authBuilder)
	{
		return new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {new(ClaimTypes.Email, Arbitrary.Email)}));
	}
}

internal class AuthBuilder
{
}
