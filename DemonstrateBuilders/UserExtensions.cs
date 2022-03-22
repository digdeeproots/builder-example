using System.Security.Claims;

namespace DemonstrateBuilders;

internal static class UserExtensions
{
	public static string ValueFor(ClaimsPrincipal user, string claimType)
	{
		return user.Claims.First(cl => cl.Type == claimType)
			.Value;
	}
}
