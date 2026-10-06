using System;
using System.Globalization;
using DigiD.Common.Models;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Converters;

internal class ToastBackgroundColorConverter : IValueConverter
{
	public object Convert(object? value, Type? targetType, object? parameter, CultureInfo culture)
	{
		if (value is ToastType toastType)
		{
			switch (toastType)
			{
			case ToastType.Success:
				return Application.Current.Resources["ToastSuccessBackgroundColor"];
			case ToastType.Warning:
				return Application.Current.Resources["ToastWarningBackgroundColor"];
			case ToastType.Error:
				return Application.Current.Resources["ToastErrorBackgroundColor"];
			case ToastType.Neutral:
				return Application.Current.Resources["ToastNeutralBackgroundColor"];
			}
		}
		throw new NotImplementedException();
	}

	public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
