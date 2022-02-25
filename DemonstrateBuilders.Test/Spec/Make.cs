using System.Security.Claims;
using Tests.TestSupport;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		return new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {new(ClaimTypes.Email, Arbitrary.Email)}));
	}
}
