using Microsoft.Maui.Hosting;
using Plugin.Maui.BottomSheet.Hosting;

namespace DigiD.Common.Controls.Extensions;

public static class BottomSheetExtensions
{
	public static MauiAppBuilder ConfigureBottomSheets(this MauiAppBuilder builder)
	{
		builder.Services.AddBottomSheet<CustomBottomSheet, BottomSheetViewModel>("CustomBottomSheet");
		return builder;
	}
}
