using System;
using System.Globalization;
using DigiD.Common.Models;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Converters;

internal class ToastImageConverter : IValueConverter
{
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (value is ToastType toastType)
		{
			switch (toastType)
			{
			case ToastType.Success:
				return "digid_icon_toast_success.png";
			case ToastType.Warning:
				return "digid_icon_toast_warning.png";
			case ToastType.Error:
				return "digid_icon_toast_error.png";
			case ToastType.Neutral:
				return "digid_icon_toast_neutral.png";
			}
		}
		throw new NotImplementedException();
	}

	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
