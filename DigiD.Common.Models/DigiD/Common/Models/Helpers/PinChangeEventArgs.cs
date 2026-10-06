using DigiD.Common.Controls.Enums;

namespace DigiD.Common.Models.Helpers;

public record PinChangeEventArgs
{
	public PinType PinType { get; init; }

	public bool Next { get; init; }
}
