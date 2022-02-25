using System.Collections.Generic;
using System.Security.Claims;

namespace Tests.TestSupport
{
	internal class AuthBuilder
	{
		private readonly List<Claim> _claims;

		public AuthBuilder()
		{
			_claims = new List<Claim>();
		}

		public AuthBuilder WithEmailAddress(string address)
		{
			_claims.Add(new Claim(ClaimTypes.Email, address));
			return this;
		}

		public ClaimsPrincipal Build()
		{
			return new ClaimsPrincipal(new ClaimsIdentity(_claims));
		}
	}
}
