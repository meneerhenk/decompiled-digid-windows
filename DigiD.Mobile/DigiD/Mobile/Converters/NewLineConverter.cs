using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace DigiD.Mobile.Converters;

public class NewLineConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (string.IsNullOrEmpty(value as string))
		{
			return string.Empty;
		}
		return value.ToString()?.Replace("\\n", "\n");
	}

	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
