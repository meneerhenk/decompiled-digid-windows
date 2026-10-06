using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using Microsoft.Maui.Controls;

namespace DigiD.Mobile.Services;

public class DisplayService(IFontService fontService) : IDisplayService
{
	private double Factor => fontService.SelectedFontSize switch
	{
		FontSize.Small => 0.8, 
		FontSize.Large => 2.0, 
		FontSize.Medium => 1.25, 
		_ => 1.0, 
	};

	public double Width
	{
		get
		{
			if (fontService.UseDyslexiaFont)
			{
				return DisplayHelper.MaxContentWidth * Factor;
			}
			return DisplayHelper.MinContentWidth * Factor;
		}
	}

	public double Height
	{
		get
		{
			if (fontService.UseDyslexiaFont)
			{
				return DisplayHelper.MaxContentHeight * Factor;
			}
			return DisplayHelper.MinContentHeight * Factor;
		}
	}

	public void SetDisplaySize()
	{
		if (Application.Current != null && Application.Current.Windows.Count > 0)
		{
			Application.Current.Windows[0].Width = Width;
			Application.Current.Windows[0].Height = Height;
		}
	}
}
