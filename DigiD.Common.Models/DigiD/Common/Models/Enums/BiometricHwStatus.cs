namespace DigiD.Common.Models.Enums;

public enum BiometricHwStatus
{
	NoHardware,
	Unavailable,
	Unsupported,
	NotEnrolled,
	Success,
	Failure,
	SecurityUpdateRequired,
	LockedOut,
	PermissionNotGiven
}
