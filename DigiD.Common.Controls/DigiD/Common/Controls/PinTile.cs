using System;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Controls;

public class PinTile : Grid
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(PinTile), null, BindingMode.OneWay, null, TextPropertyChanged);

	private readonly Image _star;

	private readonly Label _label;

	private readonly Image _background = new Image();

	private readonly bool _constructed;

	private PinTileState _state;

	public string? Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetTextVisibility(!string.IsNullOrEmpty(value));
			SetValue(TextProperty, value);
		}
	}

	public PinTileState State
	{
		get
		{
			return _state;
		}
		set
		{
			bool flag = _state != value;
			_state = value;
			if (flag)
			{
				SetBackground();
			}
		}
	}

	private static void TextPropertyChanged(BindableObject binding, object oldValue, object newValue)
	{
		((PinTile)binding).SetText((string)newValue);
	}

	public void SetText(string value)
	{
		_label.Text = value;
		_label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		if (_state == PinTileState.Active)
		{
			SetStarVisibility(string.IsNullOrEmpty(value));
		}
	}

	private void SetStarVisibility(bool isVisible)
	{
		if (!_constructed)
		{
			return;
		}
		if (((IApp)Application.Current).A11YService.HideAnimations)
		{
			_star.Scale = (isVisible ? 0.8 : 0.5);
			_star.Opacity = (isVisible ? 1 : 0);
			return;
		}
		try
		{
			_star.FadeToAsync(isVisible ? 1 : 0, 200u);
			_star.ScaleToAsync(isVisible ? 0.8 : 0.5, 200u);
		}
		catch (ArgumentException)
		{
			_star.Opacity = (isVisible ? 1 : 0);
			_star.Scale = (isVisible ? 0.8 : 0.5);
		}
	}

	private void SetTextVisibility(bool isVisible)
	{
		if (((IApp)Application.Current).A11YService.HideAnimations)
		{
			_label.IsVisible = isVisible;
			_label.Opacity = (isVisible ? 1 : 0);
			_label.Scale = (isVisible ? 1.0 : 0.5);
			return;
		}
		try
		{
			_label.Opacity = ((!isVisible) ? 1 : 0);
			_label.FadeToAsync(isVisible ? 1 : 0, 200u);
		}
		catch (ArgumentException)
		{
			_label.Opacity = (isVisible ? 1 : 0);
			_label.Scale = (isVisible ? 1.0 : 0.5);
		}
	}

	private void SetBackground()
	{
		switch (_state)
		{
		case PinTileState.Active:
			_background.SetDynamicResource(Image.SourceProperty, "pincode_on");
			break;
		case PinTileState.Current:
			_background.SetDynamicResource(Image.SourceProperty, "pincode_active");
			if (!((IApp)Application.Current).A11YService.HideAnimations)
			{
				base.TranslationY = -5.0;
				try
				{
					this.TranslateToAsync(0.0, 0.0);
				}
				catch (ArgumentException)
				{
					base.TranslationY = 0.0;
				}
			}
			break;
		case PinTileState.Inactive:
			_background.SetDynamicResource(Image.SourceProperty, "pincode_inactive");
			break;
		case PinTileState.Locked:
			_background.SetDynamicResource(Image.SourceProperty, "pincode_locked");
			_star.Opacity = 0.0;
			return;
		}
		SetStarVisibility(_state == PinTileState.Active);
	}

	public PinTile(int numberOfTiles, int index, bool hideStar = false, bool setBinding = false)
	{
		base.HorizontalOptions = LayoutOptions.Fill;
		base.VerticalOptions = LayoutOptions.Start;
		Grid grid = new Grid
		{
			BackgroundColor = Colors.Transparent,
			HorizontalOptions = LayoutOptions.Fill,
			VerticalOptions = LayoutOptions.Fill,
			ColumnSpacing = 0.0,
			RowSpacing = 0.0
		};
		_star = new Image
		{
			Source = "icon_pinster.png",
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Center,
			Margin = 5.0,
			Opacity = 0.0,
			Scale = 0.5,
			IsVisible = !hideStar
		};
		if (DeviceInfo.Platform == DevicePlatform.Android || DeviceInfo.Platform == DevicePlatform.iOS)
		{
			_star.WidthRequest = ((numberOfTiles == 5 || DeviceInfo.Idiom == DeviceIdiom.Phone) ? 50 : 30);
			_star.HeightRequest = ((numberOfTiles == 5 || DeviceInfo.Idiom == DeviceIdiom.Phone) ? 50 : 30);
		}
		_label = new Label
		{
			VerticalOptions = LayoutOptions.Center,
			HorizontalOptions = LayoutOptions.Fill,
			TextColor = (Color)Application.Current.Resources["PinTileTextColor"],
			HorizontalTextAlignment = TextAlignment.Center,
			VerticalTextAlignment = TextAlignment.Center,
			FontSize = 17.0,
			ZIndex = 1
		};
		_label.SetDynamicResource(Label.FontFamilyProperty, "FontBold");
		State = PinTileState.Inactive;
		AutomationProperties.SetIsInAccessibleTree(_label, false);
		AutomationProperties.SetIsInAccessibleTree(_star, false);
		AutomationProperties.SetIsInAccessibleTree(_background, false);
		if (setBinding)
		{
			this.SetBinding(TextProperty, $"Pin{index + 1}Text");
		}
		grid.Add(_label);
		grid.Add(_star);
		Add(_background);
		Add(grid);
		AutomationProperties.SetIsInAccessibleTree(grid, false);
		AutomationProperties.SetIsInAccessibleTree(this, false);
		_constructed = true;
		SetBackground();
	}
}
