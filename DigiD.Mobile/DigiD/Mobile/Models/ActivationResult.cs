using DigiD.Common.Models.Enums;

namespace DigiD.Mobile.Models;

public class ActivationResult
{
	public ApiResult ApiResult { get; set; }

	public byte[]? IV { get; set; }
}
