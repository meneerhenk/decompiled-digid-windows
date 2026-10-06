namespace DigiD.Common.Models;

public class Pin
{
	public string Hash { get; }

	public Pin(string hash)
	{
		Hash = hash;
	}
}
