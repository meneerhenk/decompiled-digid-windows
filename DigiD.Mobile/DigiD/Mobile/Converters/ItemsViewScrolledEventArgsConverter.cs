using System.Globalization;
using CommunityToolkit.Maui.Converters;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace DigiD.Mobile.Converters;

[AcceptEmptyServiceProvider]
public class ItemsViewScrolledEventArgsConverter : BaseConverterOneWay<ItemsViewScrolledEventArgs, object?>
{
	public override object? DefaultConvertReturnValue { get; set; } = null;

	public override object? ConvertFrom(ItemsViewScrolledEventArgs? value, CultureInfo? culture)
	{
		return value?.CenterItemIndex;
	}
}
