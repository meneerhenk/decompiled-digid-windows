namespace DigiD.Mobile.Models;

public class AccountBlockedModel
{
	public string since { get; set; } = string.Empty;

	public int count { get; set; } = 0;

	public string until { get; set; } = string.Empty;

	public int minutes { get; set; } = 0;
}
