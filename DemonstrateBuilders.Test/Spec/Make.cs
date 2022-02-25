using System.Security.Claims;
using Tests.TestSupport;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		return Build();
	}

	private static ClaimsPrincipal Build()
	{
		return new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {new(ClaimTypes.Email, Arbitrary.Email)}));
	}
}
