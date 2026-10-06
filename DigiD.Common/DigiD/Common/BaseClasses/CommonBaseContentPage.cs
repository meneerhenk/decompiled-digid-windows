using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Helpers;
using DigiD.Common.Models.Messages;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Common.BaseClasses;

public class CommonBaseContentPage : ContentPage
{
	public static double ContentWidth { get; protected set; }

	protected CommonBaseContentPage()
	{
		EventToCommandBehavior eventToCommandBehavior = new EventToCommandBehavior
		{
			EventName = "Appearing"
		};
		EventToCommandBehavior eventToCommandBehavior2 = new EventToCommandBehavior
		{
			EventName = "Disappearing"
		};
		EventToCommandBehavior eventToCommandBehavior3 = new EventToCommandBehavior
		{
			EventName = "NavigatedTo"
		};
		EventToCommandBehavior eventToCommandBehavior4 = new EventToCommandBehavior
		{
			EventName = "NavigatedFrom"
		};
		eventToCommandBehavior.SetBinding(EventToCommandBehavior.CommandProperty, new Binding("AppearingCommand"));
		eventToCommandBehavior.SetBinding(BindableObject.BindingContextProperty, new Binding("BindingContext", BindingMode.Default, null, null, null, this));
		eventToCommandBehavior2.SetBinding(EventToCommandBehavior.CommandProperty, new Binding("DisappearingCommand"));
		eventToCommandBehavior2.SetBinding(BindableObject.BindingContextProperty, new Binding("BindingContext", BindingMode.Default, null, null, null, this));
		eventToCommandBehavior3.SetBinding(EventToCommandBehavior.CommandProperty, new Binding("NavigatedToCommand"));
		eventToCommandBehavior3.SetBinding(BindableObject.BindingContextProperty, new Binding("BindingContext", BindingMode.Default, null, null, null, this));
		eventToCommandBehavior4.SetBinding(EventToCommandBehavior.CommandProperty, new Binding("NavigatedFromCommand"));
		eventToCommandBehavior4.SetBinding(BindableObject.BindingContextProperty, new Binding("BindingContext", BindingMode.Default, null, null, null, this));
		base.Behaviors.Add(eventToCommandBehavior);
		base.Behaviors.Add(eventToCommandBehavior2);
		base.Behaviors.Add(eventToCommandBehavior3);
		base.Behaviors.Add(eventToCommandBehavior4);
	}
}
public class CommonBaseContentPage<TViewModel> : CommonBaseContentPage where TViewModel : CommonBaseViewModel
{
	public new TViewModel? BindingContext => (base.BindingContext != null) ? ((TViewModel)base.BindingContext) : null;

	protected CommonBaseContentPage(TViewModel? viewModel = null)
	{
		base.BindingContext = viewModel;
		ConfigContentWidth(new DisplayInfoChangedEventArgs(DeviceDisplay.MainDisplayInfo));
	}

	protected void ConfigContentWidth(DisplayInfoChangedEventArgs e)
	{
		CommonBaseContentPage.ContentWidth = DisplayHelper.Width;
		if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
		{
			if (e.DisplayInfo.Orientation == DisplayOrientation.Landscape)
			{
				double num = DisplayHelper.Width * 0.2;
				base.Padding = new Thickness(num, base.Padding.Top, num, base.Padding.Bottom);
				CommonBaseContentPage.ContentWidth = DisplayHelper.Width * 0.6;
				base.MinimumWidthRequest = CommonBaseContentPage.ContentWidth;
			}
			else
			{
				double num2 = DisplayHelper.Width * 0.15;
				base.Padding = new Thickness(num2, base.Padding.Top, num2, base.Padding.Bottom);
				CommonBaseContentPage.ContentWidth = DisplayHelper.Width * 0.7;
			}
		}
		else if (DeviceInfo.Idiom == DeviceIdiom.Phone && e.DisplayInfo.Orientation == DisplayOrientation.Landscape)
		{
			CommonBaseContentPage.ContentWidth = DisplayHelper.MaxContentWidth * 0.8;
		}
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			WeakReferenceMessenger.Default.Send(new ScrollViewSizeChangedMessage());
		}
	}

	protected override bool OnBackButtonPressed()
	{
		return BindingContext?.OnBackButtonPressed() ?? false;
	}
}
