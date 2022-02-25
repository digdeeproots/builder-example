using System.Security.Claims;
using Tests.Spec;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		var tempQualifier = new AuthBuilder();
		tempQualifier.WithEmailAddress();
		return tempQualifier.Build();
	}
}
