using DigiD.Common.Models.Enums;

namespace DigiD.Common.Models.Messages;

public record AppStateChangedMessage(AppActivationState State);
