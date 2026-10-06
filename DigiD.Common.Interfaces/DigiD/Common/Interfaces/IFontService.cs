using DigiD.Common.Models.Enums;

namespace DigiD.Common.Interfaces;

public interface IFontService
{
	FontSize SelectedFontSize { get; set; }

	bool UseDyslexiaFont { get; set; }

	void SetFontSize();

	void SetFontFamily();

	void Init();
}
