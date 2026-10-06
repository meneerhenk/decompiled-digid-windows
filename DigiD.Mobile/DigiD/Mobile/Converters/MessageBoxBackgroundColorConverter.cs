using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace DigiD.Mobile.Converters;

public class MessageBoxBackgroundColorConverter : IValueConverter
{
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		bool flag = default(bool);
		int num;
		if (value is bool)
		{
			flag = (bool)value;
			num = 1;
		}
		else
		{
			num = 0;
		}
		if (((uint)num & (flag ? 1u : 0u)) != 0)
		{
			return (Color)Application.Current.Resources["MessageBoxNewBackgroundColor"];
		}
		return (Color)Application.Current.Resources["MessageBoxBackgroundColor"];
	}

	public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
