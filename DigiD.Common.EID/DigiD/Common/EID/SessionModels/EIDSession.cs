using System.Collections.Generic;
using DigiD.Common.EID.Models;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.EID.SessionModels;

public static class EIDSession
{
	public static string? SessionId { get; set; }

	public static string? Host { get; set; }

	public static Card? Card { get; set; }

	public static string[]? CommandAPDUs { get; set; }

	public static List<byte[]> ResponseAPDUs { get; set; } = new List<byte[]>();

	public static CardState CardState { get; set; } = new CardState();

	public static EIDActivationState ActivationState { get; set; }

	public static bool TransportPINChange { get; set; }
}
