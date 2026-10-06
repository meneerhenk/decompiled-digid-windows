using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls.Converters;

public class AllTrueMultiConverter : IMultiValueConverter
{
	public object Convert(object[]? values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || !targetType.IsAssignableFrom(typeof(bool)))
		{
			return false;
		}
		for (int i = 0; i < values.Length; i++)
		{
			if (!(values[i] is bool flag) || 1 == 0)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
		}
		return true;
	}

	public object[]? ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		if (!(value is bool flag) || targetTypes.Any((Type t) => !t.IsAssignableFrom(typeof(bool))))
		{
			return Array.Empty<object>();
		}
		if (flag)
		{
			return ((IEnumerable<Type>)targetTypes).Select((Func<Type, object>)((Type t) => true)).ToArray();
		}
		return Array.Empty<object>();
	}
}
