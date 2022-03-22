using System.Security.Claims;

internal static class UserExtensions
{
	public static string UserClaim(ClaimsPrincipal user, string claimType)
	{
		return user.Claims.First(cl => cl.Type == claimType)
			.Value;
	}
}
