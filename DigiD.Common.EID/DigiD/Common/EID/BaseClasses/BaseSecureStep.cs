using DigiD.Common.EID.Interfaces;

namespace DigiD.Common.EID.BaseClasses;

internal class BaseSecureStep
{
	internal ISecureCardOperation Operation { get; }

	public BaseSecureStep(ISecureCardOperation operation)
	{
		Operation = operation;
	}
}
