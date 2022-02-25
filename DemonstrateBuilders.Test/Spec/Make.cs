using System.Collections.Generic;
using System.Security.Claims;
using Tests.TestSupport;

internal static class Make
{
	public static ClaimsPrincipal Authentication()
	{
		var tempQualifier = new AuthBuilder();
		tempQualifier.WithEmailAddress();
		return tempQualifier.Build();
	}
}

internal class AuthBuilder
{
	private readonly List<Claim> _claims;

	public AuthBuilder()
	{
		_claims = new List<Claim>();
	}

	public void WithEmailAddress()
	{
		_claims.Add(new Claim(ClaimTypes.Email, Arbitrary.Email));
	}

	public ClaimsPrincipal Build()
	{
		return new ClaimsPrincipal(new ClaimsIdentity(_claims));
	}
}
