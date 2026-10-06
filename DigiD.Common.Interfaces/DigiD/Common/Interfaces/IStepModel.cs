using LocalizationResourceManager.Maui;

namespace DigiD.Common.Interfaces;

public interface IStepModel
{
	int Index { get; set; }

	LocalizedString Title { get; }

	LocalizedString Text { get; }

	bool IsCompleted { get; }

	bool IsActive { get; }

	string ImageSource { get; }

	bool HasSkipped { get; }

	bool SubTextVisible { get; }
}
