using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Models.Messages;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Devices;

namespace DigiD.Common.BaseClasses;

public abstract class BasePage<TViewModel> : CommonBaseContentPage<TViewModel> where TViewModel : CommonBaseViewModel
{
	protected BasePage(TViewModel? viewModel = null)
		: base(viewModel)
	{
		On<iOS>().SetPrefersHomeIndicatorAutoHidden(value: true);
		On<iOS>().SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.None);
		Microsoft.Maui.Controls.NavigationPage.SetHasNavigationBar(this, value: false);
		SetDynamicResource(Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, "AppPageBackground");
		ConfigContentWidth(new DisplayInfoChangedEventArgs(DeviceDisplay.MainDisplayInfo));
		base.HideSoftInputOnTapped = true;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, ChangeColor);
		SetSwipeLeftForThisPage();
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		SetSwipeLeftForThisPage();
	}

	private void SetSwipeLeftForThisPage()
	{
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		WeakReferenceMessenger.Default.Unregister<ThemeChangedMessage>(this);
	}

	private static void ChangeColor(object recipient, ThemeChangedMessage message)
	{
	}
}
