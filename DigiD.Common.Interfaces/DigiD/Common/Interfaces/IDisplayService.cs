namespace DigiD.Common.Interfaces;

public interface IDisplayService
{
	double Width { get; }

	double Height { get; }

	void SetDisplaySize();
}
