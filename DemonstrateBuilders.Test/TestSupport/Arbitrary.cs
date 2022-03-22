using System;

namespace Tests.TestSupport;

internal static class Arbitrary
{
	public const string Email = "arbitrary.email@example.com";

	public static string String()
	{
		return Guid.NewGuid()
			.ToString();
	}
}
