using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Mobile.Pages;

public class PinCodePage : BasePage<PinCodeViewModel>
{
	private readonly ILogger<PinCodePage> logger;

	private readonly Grid _grid;

	private readonly Grid _meldingContainer;

	private readonly Image _logo;

	private readonly Image _errorImage;

	private readonly VerticalStackLayout _helpText;

	private readonly Label _meldingLabel;

	private readonly Label _pinTiles2Label;

	private readonly NumberPad _numPad;

	private readonly ScrollView _scrollView;

	private readonly PinViewTiles _pinTiles1;

	private readonly PinViewTiles _pinTiles2;

	private readonly VerticalStackLayout _repeatPinCodeContainer;

	private readonly VerticalStackLayout _verticalStackLayoutInScrollView;

	private static readonly IA11YService A11YService = ((IApp)Application.Current).A11YService;

	public PinCodePage(ILogger<PinCodePage> logger)
		: base((PinCodeViewModel?)null)
	{
		this.logger = logger;
		bool flag = DeviceDisplay.MainDisplayInfo.Orientation != DisplayOrientation.Landscape || DisplayHelper.IsTablet;
		bool isRightHanded = DeviceDisplay.MainDisplayInfo.Rotation == DisplayRotation.Rotation90;
		if (DeviceInfo.Platform == DevicePlatform.MacCatalyst || DeviceInfo.Platform == DevicePlatform.WinUI)
		{
			flag = false;
			isRightHanded = true;
		}
		base.ControlTemplate = TemplateSelector.NoScrollViewTemplate;
		Grid obj = new Grid
		{
			RowDefinitions = CreateRowDefinitions(flag),
			ColumnDefinitions = CreateColumnDefinitions(flag),
			HorizontalOptions = LayoutOptions.Center,
			RowSpacing = (double)Application.Current.Resources["DefaultRowSpacing"]
		};
		IList<IView> children = obj.Children;
		ScrollView scrollView = new ScrollView();
		VerticalStackLayout obj2 = new VerticalStackLayout
		{
			Spacing = (double)Application.Current.Resources["DefaultRowSpacing"],
			Children = 
			{
				(IView)new Label
				{
					Style = (Style)Application.Current.Resources["LabelHeader"]
				}.Bind(Label.TextProperty, "HeaderText").Bind(VisualElement.IsVisibleProperty, "IsHeaderVisible"),
				(IView)new Image
				{
					Source = "afbeelding_digid_officiele_app.png"
				}.Assign<Image, Image>(out _logo).AutomationIsInAccessibleTree(true).Bind(VisualElement.IsVisibleProperty, "IsAppAuthentication")
					.CenterHorizontal()
					.SemanticDescription("DigiD logo")
					.Top()
			}
		};
		IList<IView> children2 = obj2.Children;
		Grid grid = new Grid();
		InlineArray2<GridLength> buffer = default(InlineArray2<GridLength>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<GridLength>, GridLength>(ref buffer, 0) = 25.0;
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<GridLength>, GridLength>(ref buffer, 1) = GridRowsColumns.Star;
		grid.ColumnDefinitions = GridRowsColumns.Columns.Define(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray2<GridLength>, GridLength>(in buffer, 2));
		grid.ColumnSpacing = 0.0;
		grid.Children.Add(new Image
		{
			Source = "icon_foutmelding_kritiek.png",
			VerticalOptions = LayoutOptions.Start,
			HeightRequest = 20.0,
			WidthRequest = 20.0
		}.Assign<Image, Image>(out _errorImage).Margin(new Thickness(0.0, 0.0, 5.0, 0.0)));
		grid.Children.Add(new Label().AutomationIsInAccessibleTree(false).Column(1).Bind(Label.TextProperty, "MessageText.Localized"));
		children2.Add(grid.Assign<Grid, Grid>(out _meldingContainer).AutomationIsInAccessibleTree(true).Bind(SemanticProperties.DescriptionProperty, "AccessibilityMessageText")
			.Bind(VisualElement.IsVisibleProperty, "IsError"));
		obj2.Children.Add(new Label().Assign<Label, Label>(out _meldingLabel).AutomationIsInAccessibleTree(false).Bind(Label.TextProperty, "MessageText.Localized")
			.Bind(VisualElement.IsVisibleProperty, "IsError", BindingMode.Default, new InvertedBoolConverter()));
		obj2.Children.Add(new PinViewTiles().Assign<PinViewTiles, PinViewTiles>(out _pinTiles1).AutomationIsInAccessibleTree(true).Bind(VisualElement.IsEnabledProperty, "PinLocked", BindingMode.Default, new InvertedBoolConverter())
			.Bind(PinViewTiles.HidePinStarProperty, "IsCANInput")
			.Bind(PinViewTiles.LockedProperty, "PinLocked")
			.Bind(PinViewTiles.NumberOfTilesProperty, "NumberOfTiles")
			.Bind(PinViewTiles.PinProperty, "Pin1")
			.Bind(SemanticProperties.DescriptionProperty, "MessageText.Localized")
			.FillHorizontal());
		obj2.Children.Add(new VerticalStackLayout
		{
			Children = 
			{
				(IView)new Label().Assign<Label, Label>(out _pinTiles2Label).AutomationIsInAccessibleTree(false).Text(DigiDAppResources.DG016B_Intro),
				(IView)new PinViewTiles().Assign<PinViewTiles, PinViewTiles>(out _pinTiles2).AutomationIsInAccessibleTree(true).Bind(PinViewTiles.HidePinStarProperty, "IsCANInput")
					.Bind(PinViewTiles.NumberOfTilesProperty, "NumberOfTiles")
					.Bind(PinViewTiles.PinProperty, "Pin2")
					.FillHorizontal()
					.SemanticDescription(DigiDAppResources.DG016B_Intro),
				(IView)new LinkLabel
				{
					AutomationId = "ChoosePincodeAgainLink",
					CommandArguments = true,
					Text = CommonResources.Alg_ResetPincodeInput
				}.AutomationIsInAccessibleTree(true).Bind(LinkLabel.CommandProperty, "ResetPinCodeCommand").CenterHorizontal()
			},
			Spacing = 10.0
		}.Assign<VerticalStackLayout, VerticalStackLayout>(out _repeatPinCodeContainer).AutomationIsInAccessibleTree(false).Bind(VisualElement.IsVisibleProperty, "PinLocked"));
		obj2.Children.Add(new LinkLabel
		{
			AutomationId = "PinCodeForgottenLink"
		}.Bind(VisualElement.IsVisibleProperty, "PinCodeForgottenVisible").Bind(LinkLabel.CommandProperty, "PinCodeForgottenCommand").Bind(LinkLabel.TextProperty, "ForgotPasswordText.Localized")
			.CenterHorizontal()
			.Bottom());
		obj2.Children.Add(new VerticalStackLayout
		{
			new Label().Bind(AutomationProperties.IsInAccessibleTreeProperty, "HelpTextVisible").SemanticDescription($"{CommonResources.Alg_List}, {string.Format(CommonResources.Alg_NrOfItemsInList, 2)}, {DigiDAppResources.DG016_Helptekst}").Text(DigiDAppResources.DG016_Helptekst),
			new Label().Bind(AutomationProperties.IsInAccessibleTreeProperty, "HelpTextVisible").SemanticDescription(DigiDAppResources.DG016_Helptekst1 + ", 1 " + CommonResources.Alg_Of + " 2").Text(DigiDAppResources.DG016_Helptekst1),
			new Label().Bind(AutomationProperties.IsInAccessibleTreeProperty, "HelpTextVisible").SemanticDescription(DigiDAppResources.DG016_Helptekst2 + ", 2 " + CommonResources.Alg_Of + " 2").Text(DigiDAppResources.DG016_Helptekst2)
		}.Assign<VerticalStackLayout, VerticalStackLayout>(out _helpText).AutomationIsInAccessibleTree(false).Bind(VisualElement.IsVisibleProperty, "HelpTextVisible")
			.Bottom());
		obj2.Children.Add(new Image
		{
			Margin = new Thickness(0.0, 0.0, 0.0, 0.0),
			IsVisible = (EIDSession.Card != null)
		}.Bind(Image.SourceProperty, "ImageSource").Top());
		scrollView.Content = obj2.Assign<VerticalStackLayout, VerticalStackLayout>(out _verticalStackLayoutInScrollView).FillHorizontal().AutomationIsInAccessibleTree(false);
		children.Add(scrollView.Assign<ScrollView, ScrollView>(out _scrollView).AutomationIsInAccessibleTree(false).Column(GetPinTilesColumn(flag, isRightHanded))
			.Padding(new Thickness(20.0, 0.0, 20.0, 0.0))
			.Row(0)
			.Fill());
		obj.Children.Add(new NumberPad().Assign<NumberPad, NumberPad>(out _numPad).CenterHorizontal().Row(flag ? 1 : 0)
			.Column(GetNumberPadColumn(flag, isRightHanded)));
		base.Content = obj.Assign<Grid, Grid>(out _grid).AutomationIsInAccessibleTree(false).Fill();
		_grid.MinimumWidthRequest = DisplayHelper.MinContentWidth;
		_grid.MaximumWidthRequest = DisplayHelper.MaxContentWidth;
		_logo.MinimumHeightRequest = 48.0;
		_logo.MinimumWidthRequest = 48.0;
		_logo.MaximumHeightRequest = 104.0;
		_logo.MaximumWidthRequest = 104.0;
		AutomationProperties.SetLabeledBy(_pinTiles1, _meldingLabel);
		AutomationProperties.SetLabeledBy(_pinTiles2, _pinTiles2Label);
		WeakReferenceMessenger.Default.Register(_numPad, delegate(object recipient, NumberPadIsTappedMessage _)
		{
			if (recipient is NumberPad && !_repeatPinCodeContainer.IsVisible)
			{
				bool flag2 = DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Portrait;
				double num = _pinTiles1.Y + _pinTiles1.Bounds.Height;
				if ((flag2 && num > _numPad.Y) || (!flag2 && num > DisplayHelper.Height))
				{
					_scrollView.ScrollToAsync(0.0, _pinTiles1.Y, animated: true);
				}
			}
		});
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			_numPad.AutomationIsInAccessibleTree(false).SemanticDescription(CommonResources.AccessibilityPincodeIntro);
		}
		ChangeAppearance(flag);
		ChangeLogoAppearance(flag);
		_pinTiles2Label.Behaviors.Add(new LabelLiveTextBehavior());
		_pinTiles2.PropertyChanged += OnPropertyChanged;
		_repeatPinCodeContainer.PropertyChanged += OnPropertyChanged;
		_helpText.PropertyChanged += OnPropertyChanged;
		_errorImage.PropertyChanged += OnPropertyChanged;
		_meldingLabel.PropertyChanged += OnPropertyChanged;
		_scrollView.SetDynamicResource(VisualElement.BackgroundColorProperty, "AppPageBackground");
		if (!flag)
		{
			SetLandscape();
		}
	}

	private void PinLinkTapped()
	{
		Task.Run(async delegate
		{
			_pinTiles1.Focus();
			await Task.Delay(100);
			_pinTiles1.SetSemanticFocus();
		});
	}

	private static int GetNumberPadColumn(bool isPortrait, bool isRightHanded)
	{
		if (DeviceInfo.Idiom == DeviceIdiom.Phone && !isPortrait && isRightHanded)
		{
			return 1;
		}
		return 0;
	}

	private static int GetPinTilesColumn(bool isPortrait, bool isRightHanded)
	{
		if (DeviceInfo.Idiom == DeviceIdiom.Phone && !isPortrait && !isRightHanded)
		{
			return 1;
		}
		return 0;
	}

	private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
	{
		bool? flag = base.BindingContext?.IsError;
		if (flag.HasValue && flag == true && sender == _meldingLabel)
		{
			SetTextMessageContainer();
		}
		if (sender == _repeatPinCodeContainer && e.PropertyName == "IsVisible" && _repeatPinCodeContainer.IsVisible)
		{
			A11YService.Speak(_pinTiles2Label.Text, 1000);
		}
	}

	private void SetTextMessageContainer()
	{
		SemanticProperties.SetDescription(_meldingContainer, base.BindingContext.AccessibilityMessageText);
		if (_meldingContainer.IsVisible)
		{
			A11YService.Speak(base.BindingContext.AccessibilityMessageText, 1000);
		}
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		base.BindingContext.PinUpdateEvent += BindingContext_PinUpdateEvent;
		base.BindingContext.PinFocusChangedEvent += BindingContext_PinFocusChangedEvent;
		base.BindingContext.ChangeFocus += delegate
		{
			PinLinkTapped();
		};
	}

	private async void BindingContext_PinFocusChangedEvent(object? sender, PinType e)
	{
		try
		{
			if (base.BindingContext?.IsError ?? false)
			{
				A11YService.Speak(base.BindingContext.AccessibilityMessageText, 555);
			}
			if (DeviceInfo.Platform == DevicePlatform.iOS)
			{
				if (e == PinType.Secondary)
				{
					_pinTiles1.Update(next: false);
				}
				return;
			}
			await Task.Delay(100);
			if (e == PinType.Primary)
			{
				await _scrollView.ScrollToAsync(0.0, _meldingLabel.Y, animated: false);
			}
			else
			{
				await _scrollView.ScrollToAsync(0.0, _pinTiles2.Y, animated: false);
			}
		}
		catch (Exception ex)
		{
			Exception exception = ex;
			logger.LogError(exception, "Error occurred while handling PinFocusChangedEvent");
		}
	}

	private static ColumnDefinitionCollection CreateColumnDefinitions(bool isPortrait)
	{
		ColumnDefinitionCollection result;
		if (!isPortrait)
		{
			InlineArray2<GridLength> buffer = default(InlineArray2<GridLength>);
			global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<GridLength>, GridLength>(ref buffer, 0) = GridRowsColumns.Star;
			global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<GridLength>, GridLength>(ref buffer, 1) = GridRowsColumns.Star;
			result = GridRowsColumns.Columns.Define(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray2<GridLength>, GridLength>(in buffer, 2));
		}
		else
		{
			GridLength reference = GridRowsColumns.Star;
			result = GridRowsColumns.Columns.Define(new ReadOnlySpan<GridLength>(in reference));
		}
		return result;
	}

	private static RowDefinitionCollection CreateRowDefinitions(bool isPortrait)
	{
		RowDefinitionCollection result;
		if (!isPortrait)
		{
			GridLength reference = GridRowsColumns.Star;
			result = GridRowsColumns.Rows.Define(new ReadOnlySpan<GridLength>(in reference));
		}
		else
		{
			InlineArray2<GridLength> buffer = default(InlineArray2<GridLength>);
			global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<GridLength>, GridLength>(ref buffer, 0) = GridRowsColumns.Star;
			global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<GridLength>, GridLength>(ref buffer, 1) = GridRowsColumns.Auto;
			result = GridRowsColumns.Rows.Define(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray2<GridLength>, GridLength>(in buffer, 2));
		}
		return result;
	}

	private void DeviceDisplay_MainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e)
	{
		bool flag = e.DisplayInfo.Rotation == DisplayRotation.Rotation90;
		DisplayRotation rotation = e.DisplayInfo.Rotation;
		bool flag2 = ((rotation == DisplayRotation.Rotation90 || rotation == DisplayRotation.Rotation270) ? true : false);
		bool flag3 = flag2;
		if (e.DisplayInfo.Rotation == DisplayRotation.Rotation0 || DisplayHelper.IsTablet)
		{
			A11YService.Speak(CommonResources.Alg_KeyboardPortrait, 1500);
		}
		else if (flag)
		{
			if (flag3)
			{
				A11YService.Speak(CommonResources.Alg_KeyboardLandscapeRight, 1500);
			}
		}
		else if (flag3)
		{
			A11YService.Speak(CommonResources.Alg_KeyboardLandscapeLeft, 1500);
		}
		SetGridOrientation();
	}

	private void SetGridOrientation()
	{
		switch (DeviceDisplay.MainDisplayInfo.Orientation)
		{
		case DisplayOrientation.Landscape:
			if (DeviceInfo.Idiom == DeviceIdiom.Phone)
			{
				SetLandscape();
			}
			else
			{
				SetPortrait();
			}
			break;
		case DisplayOrientation.Portrait:
			SetPortrait();
			break;
		}
	}

	private void SetPortrait()
	{
		if (DisplayHelper.IsTablet)
		{
			_grid.MinimumWidthRequest = DisplayHelper.MinContentWidth;
			_grid.MaximumWidthRequest = DisplayHelper.MaxContentWidth;
		}
		_grid.ColumnDefinitions.Clear();
		_grid.RowDefinitions.Clear();
		_grid.ColumnDefinitions = CreateColumnDefinitions(isPortrait: true);
		_grid.RowDefinitions = CreateRowDefinitions(isPortrait: true);
		_scrollView.Row(0).Column(0);
		_numPad.Row(1).Column(0).Bottom();
		_numPad.CenterHorizontal();
		ChangeAppearance(isPortrait: true);
		ChangeLogoAppearance(isPortrait: true);
	}

	private void SetLandscape()
	{
		_grid.MinimumWidthRequest = DisplayHelper.MinContentWidth;
		_grid.MaximumWidthRequest = DisplayHelper.MaxContentWidth;
		bool flag = DeviceDisplay.MainDisplayInfo.Rotation == DisplayRotation.Rotation90;
		if (DeviceInfo.Platform == DevicePlatform.MacCatalyst || DeviceInfo.Platform == DevicePlatform.WinUI)
		{
			flag = true;
		}
		_grid.RowDefinitions.Clear();
		_grid.ColumnDefinitions.Clear();
		_grid.ColumnDefinitions = CreateColumnDefinitions(isPortrait: false);
		_grid.RowDefinitions = CreateRowDefinitions(isPortrait: false);
		if (flag)
		{
			_scrollView.Row(0).Column(0);
			_numPad.Row(0).Column(1).Top()
				.End();
		}
		else
		{
			_numPad.Row(0).Column(0).Top()
				.Start();
			_scrollView.Row(0).Column(1);
		}
		ChangeAppearance(isPortrait: false);
		ChangeLogoAppearance(isPortrait: false);
	}

	private void BindingContext_PinUpdateEvent(object? sender, PinChangeEventArgs e)
	{
		switch (e.PinType)
		{
		case PinType.Primary:
		{
			_pinTiles1.Update(e.Next);
			SecureString? pin = _pinTiles1.Pin;
			if (pin != null && pin.ToPlain().Length == 1)
			{
				base.BindingContext.IsError = false;
			}
			break;
		}
		case PinType.Secondary:
			_pinTiles2.Update(e.Next);
			break;
		}
	}

	private void ChangeLogoAppearance(bool isPortrait)
	{
		_logo.Margin(isPortrait ? new Thickness(0.0, 20.0, 0.0, 0.0) : new Thickness(0.0, 5.0, 0.0, 0.0));
		_logo.MinHeight(isPortrait ? 80 : 60);
		_logo.MinWidth(isPortrait ? 80 : 60);
		UpdateScrollView();
	}

	private void ChangeAppearance(bool isPortrait)
	{
		if (DisplayHelper.IsTablet)
		{
			_numPad.Margin(new Thickness(1.0, 1.0, 1.0, 0.0));
			_verticalStackLayoutInScrollView.Spacing = (double)Application.Current.Resources["DefaultRowSpacing"];
		}
		else if (isPortrait)
		{
			if (DeviceInfo.Platform == DevicePlatform.iOS && DeviceInfo.Idiom == DeviceIdiom.Phone && DisplayHelper.Height < 568.0)
			{
				_scrollView.Padding(5.0, 0.0);
				_verticalStackLayoutInScrollView.Spacing = 5.0;
			}
			else
			{
				_scrollView.Padding(20.0, 0.0);
				_verticalStackLayoutInScrollView.Spacing = (double)Application.Current.Resources["DefaultRowSpacing"];
			}
		}
		else
		{
			_scrollView.Padding(20.0, 0.0);
			_verticalStackLayoutInScrollView.Spacing = 5.0;
		}
		UpdateScrollView();
	}

	private void UpdateScrollView()
	{
		if (!(DeviceInfo.Platform == DevicePlatform.Android))
		{
			_scrollView.IsVisible = false;
			_scrollView.IsVisible = true;
		}
	}
}
