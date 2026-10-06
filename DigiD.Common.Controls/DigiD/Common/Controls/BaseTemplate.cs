using System;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Helpers;
using DigiD.Common.Models.Messages;
using DigiD.Common.Preferences;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Controls;

public class BaseTemplate : Grid
{
	private readonly View? demoBar;

	private static StackLayout CreateDemoBar()
	{
		StackLayout stackLayout = new StackLayout
		{
			Style = (Style)Application.Current.Resources["DemoBar"]
		};
		Label label = new Label
		{
			Style = (Style)Application.Current.Resources["DemoBarLabel"],
			Text = "Demo-Mode",
			IsEnabled = false
		};
		stackLayout.Children.Add(label);
		if (DemoSettings.IsDemoModeEnabled)
		{
			TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, new Binding("Parent.BindingContext.DemoBarPressed", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
			stackLayout.GestureRecognizers.Add(tapGestureRecognizer);
		}
		AutomationProperties.SetIsInAccessibleTree(label, false);
		AutomationProperties.SetIsInAccessibleTree(stackLayout, false);
		return stackLayout;
	}

	protected BaseTemplate(bool insideScroll)
	{
		base.RowDefinitions.Add(new RowDefinition
		{
			Height = GridLength.Auto
		});
		base.RowDefinitions.Add(new RowDefinition
		{
			Height = GridLength.Auto
		});
		base.RowDefinitions.Add(new RowDefinition
		{
			Height = GridLength.Star
		});
		base.RowSpacing = 0.0;
		ContentPresenter contentPresenter = new ContentPresenter
		{
			Margin = new Thickness(0.0, 8.0, 0.0, 0.0)
		};
		AutomationProperties.SetIsInAccessibleTree(contentPresenter, false);
		GridExtensions.Add(this, new HeaderView(insideScroll));
		if (insideScroll)
		{
			ScrollView view = new ScrollView
			{
				Content = contentPresenter,
				MinimumWidthRequest = DisplayHelper.MinContentWidth
			};
			this.Add(view, 0, 2);
		}
		else
		{
			this.Add(contentPresenter, 0, 2);
		}
		AutomationProperties.SetIsInAccessibleTree(this, false);
		WeakReferenceMessenger.Default.Register(this, delegate(object _, PresentingModeMessage m)
		{
			try
			{
				View? view2 = demoBar;
				if (view2 != null)
				{
					view2.IsVisible = !m.IsPresentingMode;
				}
			}
			catch (Exception)
			{
			}
		});
		if (DemoSettings.IsDemoModeEnabled)
		{
			demoBar = CreateDemoBar();
			this.Add(demoBar, 0, 1);
		}
		if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
		{
			contentPresenter.MinimumWidthRequest = DisplayHelper.MinContentWidth;
			contentPresenter.MaximumWidthRequest = DisplayHelper.MaxContentWidth;
			contentPresenter.MinimumHeightRequest = DisplayHelper.MinContentHeight;
		}
	}
}
