using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Converters;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Converters;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Handlers;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace DigiD.Common.Controls;

[XamlFilePath("CustomEntryField.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class CustomEntryField : VerticalStackLayout
{
	public static readonly BindableProperty IsValidProperty = BindableProperty.Create("IsValid", typeof(bool), typeof(CustomEntryField), false, BindingMode.TwoWay, null, IsValidPropertyChanged);

	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CustomEntryField), string.Empty, BindingMode.TwoWay, null, TextPropertyChanged);

	public static readonly BindableProperty TitleTextProperty = BindableProperty.Create("TitleText", typeof(string), typeof(CustomEntryField), null, BindingMode.OneTime, null, TitleTextPropertyChanged);

	public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create("Placeholder", typeof(string), typeof(CustomEntryField), null, BindingMode.OneWay, null, PlaceholderPropertyChanged);

	public static readonly BindableProperty KeyboardProperty = BindableProperty.Create("Keyboard", typeof(Keyboard), typeof(CustomEntryField), Microsoft.Maui.Keyboard.Default, BindingMode.OneTime, null, KeyboardPropertyChanged);

	public static readonly BindableProperty ErrorTextProperty = BindableProperty.Create("ErrorText", typeof(string), typeof(CustomEntryField), null, BindingMode.OneTime);

	public static readonly BindableProperty HelpTextProperty = BindableProperty.Create("HelpText", typeof(string), typeof(CustomEntryField));

	public static readonly BindableProperty ShowErrorLabelProperty = BindableProperty.Create("ShowErrorLabel", typeof(bool), typeof(CustomEntryField), false, BindingMode.TwoWay);

	public static readonly BindableProperty ShowCounterProperty = BindableProperty.Create("ShowCounter", typeof(bool), typeof(CustomEntryField), false, BindingMode.OneTime, null, ShowCounterPropertyChanged);

	public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create("ReturnType", typeof(ReturnType), typeof(CustomEntryField), ReturnType.Default, BindingMode.OneWay, null, ReturnTypePropertyChanged);

	public static readonly BindableProperty ReturnCommandProperty = BindableProperty.Create("ReturnCommand", typeof(IAsyncRelayCommand), typeof(CustomEntryField), null, BindingMode.OneWay, null, ReturnCommandPropertyChanged);

	public static readonly BindableProperty ReturnCommandParameterProperty = BindableProperty.Create("ReturnCommandParameter", typeof(object), typeof(CustomEntryField), null, BindingMode.OneWay, null, ReturnCommandParameterPropertyChanged);

	public static readonly BindableProperty AutoDismissKeyboardProperty = BindableProperty.Create("AutoDismissKeyboard", typeof(bool), typeof(CustomEntryField));

	private bool? _isPassword;

	private readonly IA11YService _a11YService;

	private readonly ILocalizationResourceManager localizationManager;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout @this;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryFieldLabel TitleLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border border;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Microsoft.Maui.Controls.Entry Entry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private PasswordToggle PasswordToggle;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryImage EntryImage;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryFieldLabel CounterLabel;

	public bool AutoDismissKeyboard
	{
		get
		{
			return (bool)GetValue(AutoDismissKeyboardProperty);
		}
		set
		{
			SetValue(AutoDismissKeyboardProperty, value);
		}
	}

	public string? TitleText
	{
		get
		{
			return (string)GetValue(TitleTextProperty);
		}
		set
		{
			SetValue(TitleTextProperty, value);
		}
	}

	public string? ErrorText
	{
		get
		{
			return (string)GetValue(ErrorTextProperty);
		}
		set
		{
			SetValue(ErrorTextProperty, value);
		}
	}

	public string? HelpText
	{
		get
		{
			return (string)GetValue(HelpTextProperty);
		}
		set
		{
			SetValue(HelpTextProperty, value);
		}
	}

	public string? Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public string? Placeholder
	{
		get
		{
			return (string)GetValue(PlaceholderProperty);
		}
		set
		{
			SetValue(PlaceholderProperty, value);
		}
	}

	public ReturnType ReturnType
	{
		get
		{
			return (ReturnType)GetValue(ReturnTypeProperty);
		}
		set
		{
			SetValue(ReturnTypeProperty, value);
		}
	}

	public IAsyncRelayCommand ReturnCommand
	{
		get
		{
			return (IAsyncRelayCommand)GetValue(ReturnCommandProperty);
		}
		set
		{
			SetValue(ReturnCommandProperty, value);
		}
	}

	public object ReturnCommandParameter
	{
		get
		{
			return GetValue(ReturnCommandParameterProperty);
		}
		set
		{
			SetValue(ReturnCommandParameterProperty, value);
		}
	}

	[TypeConverter(typeof(KeyboardTypeConverter))]
	public Keyboard Keyboard
	{
		get
		{
			return (Keyboard)GetValue(KeyboardProperty);
		}
		set
		{
			SetValue(KeyboardProperty, value);
		}
	}

	public bool IsPassword
	{
		get
		{
			return _isPassword ?? false;
		}
		set
		{
			Entry.IsPassword = value;
			if (!_isPassword.HasValue)
			{
				_isPassword = value;
				PasswordToggle.IsVisible = value;
			}
		}
	}

	public int MaxLength
	{
		get
		{
			return Entry?.MaxLength ?? int.MaxValue;
		}
		set
		{
			Entry.MaxLength = value;
		}
	}

	public bool IsValid
	{
		get
		{
			return (bool)GetValue(IsValidProperty);
		}
		set
		{
			SetValue(IsValidProperty, value);
		}
	}

	public bool ShowErrorLabel
	{
		get
		{
			return (bool)GetValue(ShowErrorLabelProperty);
		}
		set
		{
			SetValue(ShowErrorLabelProperty, value);
		}
	}

	public bool ShowCounter
	{
		get
		{
			return (bool)GetValue(ShowCounterProperty);
		}
		set
		{
			SetValue(ShowCounterProperty, value);
		}
	}

	public int? MinLength { get; set; }

	public bool IsRequired { get; set; } = true;

	public bool ShowValidIcon { get; set; }

	private static void KeyboardPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue is Keyboard keyboard)
		{
			customEntryField.Keyboard = keyboard;
		}
	}

	private static void IsValidPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (!(bindable is CustomEntryField customEntryField) || !(newValue is bool flag))
		{
			return;
		}
		CustomEntryImage entryImage = customEntryField.EntryImage;
		if (entryImage != null)
		{
			entryImage.IsVisible = flag && customEntryField.ShowValidIcon;
		}
		CustomEntryFieldLabel counterLabel = customEntryField.CounterLabel;
		if (counterLabel != null)
		{
			counterLabel.IsVisible = !flag || !customEntryField.ShowValidIcon;
		}
		if (flag)
		{
			((IApp)Microsoft.Maui.Controls.Application.Current).A11YService.Speak(string.Format(customEntryField.localizationManager["Alg_InputCorrect"], customEntryField.TitleText, customEntryField.Entry.Text));
			if (customEntryField.MaxLength == customEntryField.Text?.Length)
			{
				customEntryField.Entry_Completed(customEntryField.Entry, EventArgs.Empty);
			}
		}
	}

	private static void PlaceholderPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomEntryField customEntryField)
		{
			if (newValue is string placeholder)
			{
				customEntryField.Entry.Placeholder = placeholder;
			}
			else
			{
				customEntryField.Entry.Placeholder = string.Empty;
			}
		}
	}

	private static void ShowCounterPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue is bool flag)
		{
			AutomationProperties.SetIsInAccessibleTree(customEntryField.CounterLabel, flag);
			if (flag)
			{
				customEntryField.CounterLabel.Text = $"0/{customEntryField.MaxLength}";
			}
		}
	}

	private static void TitleTextPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue is string value && !string.IsNullOrEmpty(value))
		{
			AutomationProperties.SetLabeledBy(customEntryField.Entry, customEntryField.TitleLabel);
		}
	}

	private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue is string text)
		{
			customEntryField.Entry.Text = text;
			if (customEntryField != null && customEntryField.ShowCounter && customEntryField.MaxLength > 0)
			{
				customEntryField.CounterLabel.Text = $"{text.Length}/{customEntryField.MaxLength}";
				string text2 = string.Format(CommonResources.Alg_InputLengthFromMaxLength, customEntryField.Entry.Text.Length, (customEntryField.Keyboard == Microsoft.Maui.Keyboard.Numeric) ? customEntryField.localizationManager["Alg_Numbers"] : customEntryField.localizationManager["Alg_Characters"], customEntryField.MaxLength);
				((IApp)Microsoft.Maui.Controls.Application.Current).A11YService.Speak(text2);
			}
			customEntryField.UpdatePasswordToggleIcon();
		}
	}

	protected override void OnPropertyChanged(string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if (propertyName == "AutomationId")
		{
			Entry.AutomationId = "Entry_" + base.AutomationId;
			PasswordToggle.AutomationId = "Toggle_" + base.AutomationId;
		}
		else if (propertyName == "MaxLength" && ShowCounter && MaxLength > 0)
		{
			CounterLabel.Text = $"0/{MaxLength}";
		}
	}

	private static void ReturnTypePropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue is ReturnType returnType)
		{
			customEntryField.Entry.ReturnType = returnType;
		}
	}

	private static void ReturnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue is IAsyncRelayCommand returnCommand)
		{
			customEntryField.Entry.ReturnCommand = returnCommand;
		}
	}

	private static void ReturnCommandParameterPropertyChanged(BindableObject bindable, object oldValue, object? newValue)
	{
		if (bindable is CustomEntryField customEntryField && newValue != null)
		{
			customEntryField.Entry.ReturnCommandParameter = newValue;
		}
	}

	public CustomEntryField()
	{
		_a11YService = ((IApp)Microsoft.Maui.Controls.Application.Current).A11YService;
		localizationManager = ((IApp)Microsoft.Maui.Controls.Application.Current).ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		InitializeComponent();
		Initialize();
		Text = string.Empty;
		Entry.PlaceholderColor = Microsoft.Maui.Graphics.Colors.Transparent;
		Entry.HandlerChanged += Entry_HandlerChanged;
		Entry.Completed += Entry_Completed;
		Entry.MaxLength = MaxLength;
		PasswordToggle.Command = new Command((Action)delegate
		{
			_a11YService.Speak(Entry.IsPassword ? localizationManager["Alg_ShowingPassword"] : localizationManager["Alg_HidingPassword"]);
			Entry.IsPassword = !Entry.IsPassword;
			if (!Entry.IsPassword)
			{
				SemanticProperties.SetDescription(PasswordToggle, localizationManager["Alg_ReleasePasswordImage"]);
				if (DeviceInfo.Platform == DevicePlatform.iOS)
				{
					SemanticProperties.SetDescription(Entry, localizationManager["AccessibilityPassword"]);
				}
			}
			else
			{
				SemanticProperties.SetDescription(PasswordToggle, localizationManager["Alg_PressPasswordImage"]);
			}
			UpdatePasswordToggleIcon();
		});
	}

	public new void Focus()
	{
		Entry.Focus();
		if (ShowErrorLabel)
		{
			border.Stroke = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldFrameRequiredBorderColor"];
		}
	}

	private async void Entry_Completed(object? sender, EventArgs? e)
	{
		try
		{
			if (sender == Entry)
			{
				Entry.Unfocus();
				await Task.Delay(500);
				if (AutoDismissKeyboard)
				{
					await Entry.HideKeyboardAsync(CancellationToken.None);
				}
			}
		}
		catch
		{
		}
	}

	private void Entry_Unfocused(object? sender, FocusEventArgs e)
	{
		if (_a11YService.IsInVoiceOverMode)
		{
			if (IsRequired)
			{
				string? text = Text;
				if (text != null && text.Length == 0)
				{
					string text2 = ((Keyboard == Microsoft.Maui.Keyboard.Numeric) ? CommonResources.Alg_Numbers : CommonResources.Alg_Characters);
					string arg = string.Format(localizationManager["Alg_MaxValue"], MaxLength, text2);
					IsValid = false;
					if (MinLength.HasValue)
					{
						_a11YService.Speak(string.Format(localizationManager["Alg_MinMaxValue"], MinLength ?? 0, arg, text2));
					}
					else
					{
						_a11YService.Speak(localizationManager["Alg_RequiredInputField"]);
					}
				}
			}
			ShowErrorLabel = !IsValid && !string.IsNullOrEmpty(ErrorText);
			if (ShowErrorLabel)
			{
				_a11YService.Speak(ErrorText, 1000);
				Entry.SetSemanticFocus();
			}
		}
		ArgumentNullException.ThrowIfNull(Microsoft.Maui.Controls.Application.Current, "Application.Current");
		if (ShowErrorLabel)
		{
			border.Stroke = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldFrameRequiredBorderColor"];
		}
		else if (string.IsNullOrWhiteSpace(Entry.Text))
		{
			border.Stroke = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldFrameBorderColorNoFocus"];
			border.BackgroundColor = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldInactiveBackgroundColor"];
		}
		else
		{
			border.Stroke = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldFrameBorderColorNoFocus"];
			border.BackgroundColor = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldTextEnteredBackgroundColor"];
		}
		UpdatePasswordToggleIcon();
	}

	private void Entry_Focused(object? sender, FocusEventArgs e)
	{
		ShowErrorLabel = false;
		ArgumentNullException.ThrowIfNull(Microsoft.Maui.Controls.Application.Current, "Application.Current");
		border.Stroke = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldFrameBorderColor"];
		border.BackgroundColor = (Color)Microsoft.Maui.Controls.Application.Current.Resources["CustomEntryFieldActiveBackgroundColor"];
		UpdatePasswordToggleIcon();
	}

	private void UpdatePasswordToggleIcon()
	{
		string text = (Entry.IsPassword ? "PasswordToggleOffIcon" : "PasswordToggleOnIcon");
		if (Entry.IsFocused || !string.IsNullOrWhiteSpace(Entry.Text))
		{
			Microsoft.Maui.Controls.Application? current = Microsoft.Maui.Controls.Application.Current;
			if (current != null && current.Resources.TryGetValue(text + "Focused", out var _))
			{
				text += "Focused";
			}
		}
		PasswordToggle.SetDynamicResource(Image.SourceProperty, text);
	}

	protected void Initialize()
	{
		EntryHandler.Mapper.AppendToMapping("Entry", delegate(IEntryHandler handler, IEntry _)
		{
			Microsoft.UI.Xaml.Media.SolidColorBrush solidColorBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Transparent);
			handler.PlatformView.BorderBrush = null;
			handler.PlatformView.Background = solidColorBrush;
			handler.PlatformView.BorderThickness = new Microsoft.UI.Xaml.Thickness(0.0);
			handler.PlatformView.Resources["TextControlBackground"] = solidColorBrush;
			handler.PlatformView.Resources["TextControlBackgroundFocused"] = solidColorBrush;
			handler.PlatformView.Resources["TextControlBackgroundPointerOver"] = solidColorBrush;
			handler.PlatformView.Resources["TextControlBackgroundDisabled"] = solidColorBrush;
			handler.PlatformView.Resources["TextControlBorderBrushFocused"] = solidColorBrush;
			handler.PlatformView.Resources["TextControlBorderBrushPointerOver"] = solidColorBrush;
		});
	}

	private void Entry_HandlerChanged(object? sender, EventArgs? e)
	{
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("this")]
	[MemberNotNull("TitleLabel")]
	[MemberNotNull("border")]
	[MemberNotNull("Entry")]
	[MemberNotNull("PasswordToggle")]
	[MemberNotNull("EntryImage")]
	[MemberNotNull("CounterLabel")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomEntryField).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomEntryField)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 5);
		AllTrueMultiConverter allTrueMultiConverter = new AllTrueMultiConverter();
		VisualDiagnostics.RegisterSourceInfo(allTrueMultiConverter, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 10);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 9);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 9);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 9);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 9);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 9);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 9);
		DynamicResource dynamicResource = new DynamicResource("CustomEntryFieldHeaderTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 9);
		CustomEntryFieldLabel customEntryFieldLabel = new CustomEntryFieldLabel();
		VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 6);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 9);
		DynamicResource dynamicResource2 = new DynamicResource("CustomEntryFieldInactiveBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 9);
		DynamicResource dynamicResource3 = new DynamicResource("CustomEntryFieldFrameBorderColorNoFocus");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 9);
		OnPlatformExtension onPlatformExtension3 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 15);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 17);
		ReferenceExtension referenceExtension4 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 17);
		AppThemeBindingExtension appThemeBindingExtension = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 17);
		ReferenceExtension referenceExtension5 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 17);
		ReferenceExtension referenceExtension6 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension6, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 25);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 25);
		ReferenceExtension referenceExtension7 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension7, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 75);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 75);
		Microsoft.Maui.Controls.Setter setter = new Microsoft.Maui.Controls.Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 26);
		DataTrigger dataTrigger = new DataTrigger(typeof(Microsoft.Maui.Controls.Entry));
		VisualDiagnostics.RegisterSourceInfo(dataTrigger, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 22);
		ReferenceExtension referenceExtension8 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension8, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 25);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 25);
		ReferenceExtension referenceExtension9 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension9, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 94);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 94);
		Microsoft.Maui.Controls.Setter setter2 = new Microsoft.Maui.Controls.Setter();
		VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 26);
		DataTrigger dataTrigger2 = new DataTrigger(typeof(Microsoft.Maui.Controls.Entry));
		VisualDiagnostics.RegisterSourceInfo(dataTrigger2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 22);
		Microsoft.Maui.Controls.Entry entry = new Microsoft.Maui.Controls.Entry();
		VisualDiagnostics.RegisterSourceInfo(entry, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 14);
		ReferenceExtension referenceExtension10 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension10, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 17);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 17);
		string alg_PressPasswordImage = CommonResources.Alg_PressPasswordImage;
		VisualDiagnostics.RegisterSourceInfo(alg_PressPasswordImage, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 17);
		DynamicResource dynamicResource4 = new DynamicResource("PasswordToggleOffIcon");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 78, 17);
		PasswordToggle passwordToggle = new PasswordToggle();
		VisualDiagnostics.RegisterSourceInfo(passwordToggle, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 70, 14);
		ReferenceExtension referenceExtension11 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension11, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 92, 51);
		BindingExtension bindingExtension11 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 92, 26);
		string alg_ValidInput = CommonResources.Alg_ValidInput;
		VisualDiagnostics.RegisterSourceInfo(alg_ValidInput, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 93, 34);
		BindingExtension bindingExtension12 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 93, 26);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 91, 22);
		CustomEntryImage customEntryImage = new CustomEntryImage();
		VisualDiagnostics.RegisterSourceInfo(customEntryImage, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 14);
		OnPlatformExtension onPlatformExtension4 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 105, 17);
		DynamicResource dynamicResource5 = new DynamicResource("CustomEntryFieldCounterTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 110, 17);
		CustomEntryFieldLabel customEntryFieldLabel2 = new CustomEntryFieldLabel();
		VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 98, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 10);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 6);
		RelativeBindingSource self = RelativeBindingSource.Self;
		VisualDiagnostics.RegisterSourceInfo(self, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 119, 9);
		BindingExtension bindingExtension13 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 119, 9);
		DynamicResource dynamicResource6 = new DynamicResource("CustomEntryFieldHelpLabelBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource6, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 120, 9);
		OnPlatformExtension onPlatformExtension5 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 122, 9);
		ReferenceExtension referenceExtension12 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension12, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 127, 9);
		BindingExtension bindingExtension14 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension14, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 127, 9);
		DynamicResource dynamicResource7 = new DynamicResource("FontColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource7, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 128, 9);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 133, 27);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 135, 21);
		ReferenceExtension referenceExtension13 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension13, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 137, 21);
		BindingExtension bindingExtension15 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension15, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 134, 18);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 139, 21);
		ReferenceExtension referenceExtension14 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension14, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 141, 21);
		BindingExtension bindingExtension16 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension16, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 138, 18);
		MultiBinding multiBinding2 = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 133, 14);
		CustomEntryFieldLabel customEntryFieldLabel3 = new CustomEntryFieldLabel();
		VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 117, 6);
		ReferenceExtension referenceExtension15 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension15, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 152, 9);
		BindingExtension bindingExtension17 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension17, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 152, 9);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 153, 10);
		ReferenceExtension referenceExtension16 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension16, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 158, 13);
		BindingExtension bindingExtension18 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension18, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 158, 13);
		ReferenceExtension referenceExtension17 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension17, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 161, 13);
		BindingExtension bindingExtension19 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension19, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 161, 13);
		ReferenceExtension referenceExtension18 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension18, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 162, 13);
		BindingExtension bindingExtension20 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension20, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 162, 13);
		DynamicResource dynamicResource8 = new DynamicResource("CustomEntryFieldEntryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource8, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 163, 13);
		CustomEntryFieldLabel customEntryFieldLabel4 = new CustomEntryFieldLabel();
		VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 155, 10);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 147, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("this", this);
		if (StyleId == null)
		{
			string text = (StyleId = "this");
		}
		customEntryFieldLabel.transientNamescope = nameScope;
		nameScope.RegisterName("TitleLabel", customEntryFieldLabel);
		CustomEntryFieldLabel customEntryFieldLabel5 = customEntryFieldLabel;
		if (customEntryFieldLabel5.StyleId == null)
		{
			string text = (customEntryFieldLabel5.StyleId = "TitleLabel");
		}
		border.transientNamescope = nameScope;
		nameScope.RegisterName("border", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "border");
		}
		grid.transientNamescope = nameScope;
		entry.transientNamescope = nameScope;
		nameScope.RegisterName("Entry", entry);
		Microsoft.Maui.Controls.Entry entry2 = entry;
		if (entry2.StyleId == null)
		{
			string text = (entry2.StyleId = "Entry");
		}
		passwordToggle.transientNamescope = nameScope;
		nameScope.RegisterName("PasswordToggle", passwordToggle);
		PasswordToggle passwordToggle2 = passwordToggle;
		if (passwordToggle2.StyleId == null)
		{
			string text = (passwordToggle2.StyleId = "PasswordToggle");
		}
		customEntryImage.transientNamescope = nameScope;
		nameScope.RegisterName("EntryImage", customEntryImage);
		CustomEntryImage customEntryImage2 = customEntryImage;
		if (customEntryImage2.StyleId == null)
		{
			string text = (customEntryImage2.StyleId = "EntryImage");
		}
		customEntryFieldLabel2.transientNamescope = nameScope;
		nameScope.RegisterName("CounterLabel", customEntryFieldLabel2);
		customEntryFieldLabel5 = customEntryFieldLabel2;
		if (customEntryFieldLabel5.StyleId == null)
		{
			string text = (customEntryFieldLabel5.StyleId = "CounterLabel");
		}
		customEntryFieldLabel3.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		customEntryFieldLabel4.transientNamescope = nameScope;
		this.@this = this;
		TitleLabel = customEntryFieldLabel;
		this.border = border;
		Entry = entry;
		PasswordToggle = passwordToggle;
		EntryImage = customEntryImage;
		CounterLabel = customEntryFieldLabel2;
		onPlatformExtension.Android = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(11, 5)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 5);
		}
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		Resources["AllTrueConverter"] = allTrueMultiConverter;
		customEntryFieldLabel.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(0.0, 0.0, 0.0, 2.0));
		customEntryFieldLabel.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		customEntryFieldLabel.SetValue(Label.HorizontalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Start);
		referenceExtension.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 9);
		}
		bindingExtension.Source = this;
		staticResourceExtension.Key = "IsStringNotNullOrWhiteSpaceConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[3] { bindingExtension, customEntryFieldLabel, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 9)));
		object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 9);
		}
		bindingExtension.Converter = (IValueConverter)obj2;
		bindingExtension.Path = "TitleText";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 9);
		}
		customEntryFieldLabel.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, binding);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[2] { customEntryFieldLabel, this }, Microsoft.Maui.Controls.VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 9)));
		object obj3 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 9);
		}
		customEntryFieldLabel.SetValue(Microsoft.Maui.Controls.VisualElement.StyleProperty, obj3);
		referenceExtension2.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 9);
		}
		bindingExtension2.Source = this;
		bindingExtension2.Path = "TitleText";
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 9);
		}
		customEntryFieldLabel.SetBinding(Label.TextProperty, binding2);
		((IDynamicResourceHandler)customEntryFieldLabel).SetDynamicResource(Label.TextColorProperty, dynamicResource.Key);
		customEntryFieldLabel.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		customEntryFieldLabel.SetValue(Label.VerticalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Start);
		Children.Add(customEntryFieldLabel);
		border.SetValue(Border.PaddingProperty, new Microsoft.Maui.Thickness(10.0, 0.0, 1.0, 0.0));
		onPlatformExtension2.Android = "False";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[2] { border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 9)));
		object obj4 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 9);
		}
		border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj4);
		((IDynamicResourceHandler)border).SetDynamicResource(Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, dynamicResource2.Key);
		((IDynamicResourceHandler)border).SetDynamicResource(Border.StrokeProperty, dynamicResource3.Key);
		onPlatformExtension3.Android = "False";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[3] { grid, border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 15)));
		object obj5 = ((IMarkupExtension)onPlatformExtension3).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 15);
		}
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj5);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(Microsoft.Maui.GridLength.Star), new ColumnDefinition(new Microsoft.Maui.GridLength(48.0, Microsoft.Maui.GridUnitType.Absolute))));
		entry.SetValue(Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.Entry.ImeOptionsProperty, ImeFlags.Done);
		entry.Focused += Entry_Focused;
		entry.HandlerChanged += Entry_HandlerChanged;
		entry.SetValue(Microsoft.Maui.Controls.Entry.HorizontalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Start);
		entry.SetValue(InputView.IsSpellCheckEnabledProperty, false);
		referenceExtension3.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 17);
		}
		bindingExtension3.Source = this;
		bindingExtension3.Path = "Keyboard";
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 17);
		}
		entry.SetBinding(Microsoft.Maui.Controls.Entry.KeyboardProperty, binding3);
		referenceExtension4.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 17);
		}
		bindingExtension4.Source = this;
		bindingExtension4.Path = "MaxLength";
		Binding binding4 = new Binding(bindingExtension4.Path, bindingExtension4.Mode, bindingExtension4.Converter, bindingExtension4.ConverterParameter, bindingExtension4.StringFormat, bindingExtension4.Source)
		{
			UpdateSourceEventName = bindingExtension4.UpdateSourceEventName,
			FallbackValue = bindingExtension4.FallbackValue,
			TargetNullValue = bindingExtension4.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 17);
		}
		entry.SetBinding(InputView.MaxLengthProperty, binding4);
		entry.SetValue(Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, 48.0);
		appThemeBindingExtension.Dark = ".9";
		appThemeBindingExtension.Light = "1";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[4] { entry, grid, border, this }, Microsoft.Maui.Controls.VisualElement.OpacityProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(44, 17)));
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)appThemeBindingExtension).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 17);
		}
		entry.SetBinding(Microsoft.Maui.Controls.VisualElement.OpacityProperty, bindingBase);
		referenceExtension5.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 17);
		}
		bindingExtension5.Source = this;
		bindingExtension5.Path = "Text";
		Binding binding5 = new Binding(bindingExtension5.Path, bindingExtension5.Mode, bindingExtension5.Converter, bindingExtension5.ConverterParameter, bindingExtension5.StringFormat, bindingExtension5.Source)
		{
			UpdateSourceEventName = bindingExtension5.UpdateSourceEventName,
			FallbackValue = bindingExtension5.FallbackValue,
			TargetNullValue = bindingExtension5.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding5, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 17);
		}
		entry.SetBinding(Microsoft.Maui.Controls.Entry.TextProperty, binding5);
		entry.SetValue(Microsoft.Maui.Controls.Entry.TextColorProperty, Microsoft.Maui.Graphics.Colors.Black);
		entry.Unfocused += Entry_Unfocused;
		entry.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		entry.SetValue(Microsoft.Maui.Controls.Entry.VerticalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Center);
		entry.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 5);
		referenceExtension6.Name = "TitleLabel";
		CustomEntryFieldLabel customEntryFieldLabel6 = customEntryFieldLabel;
		if (VisualDiagnostics.GetSourceInfo(customEntryFieldLabel6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel6, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 25);
		}
		bindingExtension6.Source = customEntryFieldLabel6;
		bindingExtension6.Path = "IsVisible";
		Binding binding6 = new Binding(bindingExtension6.Path, bindingExtension6.Mode, bindingExtension6.Converter, bindingExtension6.ConverterParameter, bindingExtension6.StringFormat, bindingExtension6.Source)
		{
			UpdateSourceEventName = bindingExtension6.UpdateSourceEventName,
			FallbackValue = bindingExtension6.FallbackValue,
			TargetNullValue = bindingExtension6.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding6, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 25);
		}
		dataTrigger.Binding = binding6;
		dataTrigger.Value = "True";
		setter.Property = SemanticProperties.DescriptionProperty;
		referenceExtension7.Name = "TitleLabel";
		CustomEntryFieldLabel customEntryFieldLabel7 = customEntryFieldLabel;
		if (VisualDiagnostics.GetSourceInfo(customEntryFieldLabel7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel7, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 75);
		}
		bindingExtension7.Source = customEntryFieldLabel7;
		bindingExtension7.Path = "Text";
		Binding binding7 = new Binding(bindingExtension7.Path, bindingExtension7.Mode, bindingExtension7.Converter, bindingExtension7.ConverterParameter, bindingExtension7.StringFormat, bindingExtension7.Source)
		{
			UpdateSourceEventName = bindingExtension7.UpdateSourceEventName,
			FallbackValue = bindingExtension7.FallbackValue,
			TargetNullValue = bindingExtension7.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding7, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 75);
		}
		setter.Value = binding7;
		Microsoft.Maui.Controls.Setter setter3 = new Microsoft.Maui.Controls.Setter
		{
			Property = SemanticProperties.DescriptionProperty,
			Value = binding7
		};
		if (VisualDiagnostics.GetSourceInfo(setter3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 26);
		}
		dataTrigger.Setters.Add(setter3);
		IList<Microsoft.Maui.Controls.TriggerBase> list = (IList<Microsoft.Maui.Controls.TriggerBase>)entry.GetValue(Microsoft.Maui.Controls.VisualElement.TriggersProperty);
		list.Add(dataTrigger);
		referenceExtension8.Name = "TitleLabel";
		CustomEntryFieldLabel customEntryFieldLabel8 = customEntryFieldLabel;
		if (VisualDiagnostics.GetSourceInfo(customEntryFieldLabel8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel8, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 25);
		}
		bindingExtension8.Source = customEntryFieldLabel8;
		bindingExtension8.Path = "IsVisible";
		Binding binding8 = new Binding(bindingExtension8.Path, bindingExtension8.Mode, bindingExtension8.Converter, bindingExtension8.ConverterParameter, bindingExtension8.StringFormat, bindingExtension8.Source)
		{
			UpdateSourceEventName = bindingExtension8.UpdateSourceEventName,
			FallbackValue = bindingExtension8.FallbackValue,
			TargetNullValue = bindingExtension8.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding8, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 25);
		}
		dataTrigger2.Binding = binding8;
		dataTrigger2.Value = "False";
		setter2.Property = SemanticProperties.DescriptionProperty;
		referenceExtension9.Name = "Entry";
		Microsoft.Maui.Controls.Entry entry3 = entry;
		if (VisualDiagnostics.GetSourceInfo(entry3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(entry3, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 94);
		}
		bindingExtension9.Source = entry3;
		bindingExtension9.Path = "Placeholder";
		Binding binding9 = new Binding(bindingExtension9.Path, bindingExtension9.Mode, bindingExtension9.Converter, bindingExtension9.ConverterParameter, bindingExtension9.StringFormat, bindingExtension9.Source)
		{
			UpdateSourceEventName = bindingExtension9.UpdateSourceEventName,
			FallbackValue = bindingExtension9.FallbackValue,
			TargetNullValue = bindingExtension9.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding9, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 94);
		}
		setter2.Value = binding9;
		Microsoft.Maui.Controls.Setter setter4 = new Microsoft.Maui.Controls.Setter
		{
			Property = SemanticProperties.DescriptionProperty,
			Value = binding9
		};
		if (VisualDiagnostics.GetSourceInfo(setter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 26);
		}
		dataTrigger2.Setters.Add(setter4);
		list.Add(dataTrigger2);
		grid.Children.Add(entry);
		passwordToggle.SetValue(Grid.ColumnProperty, 1);
		passwordToggle.SetValue(Microsoft.Maui.Controls.ImageButton.AspectProperty, Aspect.Center);
		passwordToggle.SetValue(Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, Microsoft.Maui.Graphics.Colors.Transparent);
		passwordToggle.SetValue(Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, 48.0);
		referenceExtension10.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 17);
		}
		bindingExtension10.Source = this;
		bindingExtension10.Path = "IsPassword";
		Binding binding10 = new Binding(bindingExtension10.Path, bindingExtension10.Mode, bindingExtension10.Converter, bindingExtension10.ConverterParameter, bindingExtension10.StringFormat, bindingExtension10.Source)
		{
			UpdateSourceEventName = bindingExtension10.UpdateSourceEventName,
			FallbackValue = bindingExtension10.FallbackValue,
			TargetNullValue = bindingExtension10.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding10, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 17);
		}
		passwordToggle.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, binding10);
		passwordToggle.SetValue(SemanticProperties.DescriptionProperty, alg_PressPasswordImage);
		((IDynamicResourceHandler)passwordToggle).SetDynamicResource(Microsoft.Maui.Controls.ImageButton.SourceProperty, dynamicResource4.Key);
		passwordToggle.SetValue(Microsoft.Maui.Controls.VisualElement.WidthRequestProperty, 48.0);
		passwordToggle.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 20);
		grid.Children.Add(passwordToggle);
		customEntryImage.SetValue(Grid.ColumnProperty, 1);
		customEntryImage.SetValue(Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, 48.0);
		customEntryImage.SetValue(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		customEntryImage.SetValue(Image.SourceProperty, Microsoft.Maui.Controls.ImageSource.FromFile("afbeelding_icon_success.png"));
		customEntryImage.SetValue(Microsoft.Maui.Controls.VisualElement.WidthRequestProperty, 48.0);
		customEntryImage.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 15);
		multiBinding.StringFormat = "{0} {1}";
		bindingExtension11.Path = "TitleText";
		referenceExtension11.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 92, 51);
		}
		bindingExtension11.Source = this;
		Binding binding11 = new Binding(bindingExtension11.Path, bindingExtension11.Mode, bindingExtension11.Converter, bindingExtension11.ConverterParameter, bindingExtension11.StringFormat, bindingExtension11.Source)
		{
			UpdateSourceEventName = bindingExtension11.UpdateSourceEventName,
			FallbackValue = bindingExtension11.FallbackValue,
			TargetNullValue = bindingExtension11.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding11, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 92, 26);
		}
		multiBinding.Bindings.Add(binding11);
		bindingExtension12.Source = alg_ValidInput;
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension12);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 93, 26);
		}
		multiBinding.Bindings.Add(bindingBase2);
		customEntryImage.SetBinding(SemanticProperties.DescriptionProperty, multiBinding);
		grid.Children.Add(customEntryImage);
		customEntryFieldLabel2.SetValue(Grid.ColumnProperty, 1);
		customEntryFieldLabel2.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(0.0));
		customEntryFieldLabel2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		customEntryFieldLabel2.SetValue(Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, Microsoft.Maui.Graphics.Colors.Transparent);
		customEntryFieldLabel2.SetValue(Label.FontAutoScalingEnabledProperty, false);
		onPlatformExtension4.Android = "14";
		onPlatformExtension4.iOS = "13";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[4] { customEntryFieldLabel2, grid, border, this }, Label.FontSizeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(105, 17)));
		object obj6 = ((IMarkupExtension)onPlatformExtension4).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 105, 17);
		}
		customEntryFieldLabel2.SetValue(Label.FontSizeProperty, obj6);
		customEntryFieldLabel2.SetValue(Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, 48.0);
		customEntryFieldLabel2.SetValue(Label.HorizontalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Center);
		customEntryFieldLabel2.SetValue(Microsoft.Maui.Controls.VisualElement.IsEnabledProperty, false);
		((IDynamicResourceHandler)customEntryFieldLabel2).SetDynamicResource(Label.TextColorProperty, dynamicResource5.Key);
		customEntryFieldLabel2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		customEntryFieldLabel2.SetValue(Label.VerticalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Center);
		customEntryFieldLabel2.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 10);
		grid.Children.Add(customEntryFieldLabel2);
		border.SetValue(Border.ContentProperty, grid);
		Children.Add(border);
		customEntryFieldLabel3.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(0.0, 5.0, 0.0, 0.0));
		bindingExtension13.Source = self;
		bindingExtension13.Path = "IsVisible";
		Binding binding12 = new Binding(bindingExtension13.Path, bindingExtension13.Mode, bindingExtension13.Converter, bindingExtension13.ConverterParameter, bindingExtension13.StringFormat, bindingExtension13.Source)
		{
			UpdateSourceEventName = bindingExtension13.UpdateSourceEventName,
			FallbackValue = bindingExtension13.FallbackValue,
			TargetNullValue = bindingExtension13.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding12, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 119, 9);
		}
		customEntryFieldLabel3.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, binding12);
		((IDynamicResourceHandler)customEntryFieldLabel3).SetDynamicResource(Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, dynamicResource6.Key);
		customEntryFieldLabel3.SetValue(Label.FontAutoScalingEnabledProperty, true);
		onPlatformExtension5.iOS = "13";
		onPlatformExtension5.Android = "14";
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[2] { customEntryFieldLabel3, this }, Label.FontSizeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(122, 9)));
		object obj7 = ((IMarkupExtension)onPlatformExtension5).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 122, 9);
		}
		customEntryFieldLabel3.SetValue(Label.FontSizeProperty, obj7);
		customEntryFieldLabel3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		customEntryFieldLabel3.SetValue(Label.HorizontalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Start);
		customEntryFieldLabel3.SetValue(Microsoft.Maui.Controls.VisualElement.IsEnabledProperty, false);
		referenceExtension12.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 127, 9);
		}
		bindingExtension14.Source = this;
		bindingExtension14.Path = "HelpText";
		Binding binding13 = new Binding(bindingExtension14.Path, bindingExtension14.Mode, bindingExtension14.Converter, bindingExtension14.ConverterParameter, bindingExtension14.StringFormat, bindingExtension14.Source)
		{
			UpdateSourceEventName = bindingExtension14.UpdateSourceEventName,
			FallbackValue = bindingExtension14.FallbackValue,
			TargetNullValue = bindingExtension14.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding13, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 127, 9);
		}
		customEntryFieldLabel3.SetBinding(Label.TextProperty, binding13);
		((IDynamicResourceHandler)customEntryFieldLabel3).SetDynamicResource(Label.TextColorProperty, dynamicResource7.Key);
		customEntryFieldLabel3.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		customEntryFieldLabel3.SetValue(Label.VerticalTextAlignmentProperty, Microsoft.Maui.TextAlignment.Start);
		customEntryFieldLabel3.SetValue(Microsoft.Maui.Controls.VisualElement.ZIndexProperty, 10);
		staticResourceExtension3.Key = "AllTrueConverter";
		AllTrueMultiConverter allTrueMultiConverter2 = allTrueMultiConverter;
		if (VisualDiagnostics.GetSourceInfo(allTrueMultiConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(allTrueMultiConverter2, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 133, 27);
		}
		multiBinding2.Converter = allTrueMultiConverter2;
		staticResourceExtension4.Key = "BooleanInvertConverter";
		XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service9 = new SimpleValueTargetProvider(new object[4] { bindingExtension15, multiBinding2, customEntryFieldLabel3, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
		xamlServiceProvider9.Add(typeof(IProvideValueTarget), service9);
		xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(135, 21)));
		object obj8 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider9);
		if (VisualDiagnostics.GetSourceInfo(obj8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 135, 21);
		}
		bindingExtension15.Converter = (IValueConverter)obj8;
		bindingExtension15.Path = "ShowErrorLabel";
		referenceExtension13.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 137, 21);
		}
		bindingExtension15.Source = this;
		Binding binding14 = new Binding(bindingExtension15.Path, bindingExtension15.Mode, bindingExtension15.Converter, bindingExtension15.ConverterParameter, bindingExtension15.StringFormat, bindingExtension15.Source)
		{
			UpdateSourceEventName = bindingExtension15.UpdateSourceEventName,
			FallbackValue = bindingExtension15.FallbackValue,
			TargetNullValue = bindingExtension15.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding14, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 134, 18);
		}
		multiBinding2.Bindings.Add(binding14);
		staticResourceExtension5.Key = "IsStringNotNullOrWhiteSpaceConverter";
		XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service10 = new SimpleValueTargetProvider(new object[4] { bindingExtension16, multiBinding2, customEntryFieldLabel3, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
		xamlServiceProvider10.Add(typeof(IProvideValueTarget), service10);
		xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(139, 21)));
		object obj9 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider10);
		if (VisualDiagnostics.GetSourceInfo(obj9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj9, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 139, 21);
		}
		bindingExtension16.Converter = (IValueConverter)obj9;
		bindingExtension16.Path = "HelpText";
		referenceExtension14.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 141, 21);
		}
		bindingExtension16.Source = this;
		Binding binding15 = new Binding(bindingExtension16.Path, bindingExtension16.Mode, bindingExtension16.Converter, bindingExtension16.ConverterParameter, bindingExtension16.StringFormat, bindingExtension16.Source)
		{
			UpdateSourceEventName = bindingExtension16.UpdateSourceEventName,
			FallbackValue = bindingExtension16.FallbackValue,
			TargetNullValue = bindingExtension16.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding15, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 138, 18);
		}
		multiBinding2.Bindings.Add(binding15);
		customEntryFieldLabel3.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, multiBinding2);
		Children.Add(customEntryFieldLabel3);
		grid2.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(0.0, 10.0, 0.0, 0.0));
		grid2.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new Microsoft.Maui.GridLength(15.0, Microsoft.Maui.GridUnitType.Absolute)), new ColumnDefinition(Microsoft.Maui.GridLength.Star)));
		grid2.SetValue(Grid.ColumnSpacingProperty, 5.0);
		grid2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		referenceExtension15.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 152, 9);
		}
		bindingExtension17.Source = this;
		bindingExtension17.Path = "ShowErrorLabel";
		Binding binding16 = new Binding(bindingExtension17.Path, bindingExtension17.Mode, bindingExtension17.Converter, bindingExtension17.ConverterParameter, bindingExtension17.StringFormat, bindingExtension17.Source)
		{
			UpdateSourceEventName = bindingExtension17.UpdateSourceEventName,
			FallbackValue = bindingExtension17.FallbackValue,
			TargetNullValue = bindingExtension17.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding16) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding16, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 152, 9);
		}
		grid2.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, binding16);
		image.SetValue(Image.SourceProperty, Microsoft.Maui.Controls.ImageSource.FromFile("icon_foutmelding_kritiek.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid2.Children.Add(image);
		customEntryFieldLabel4.SetValue(Grid.ColumnProperty, 1);
		customEntryFieldLabel4.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(0.0, -5.0, 0.0, 0.0));
		referenceExtension16.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 158, 13);
		}
		bindingExtension18.Source = this;
		bindingExtension18.Path = "ShowErrorLabel";
		Binding binding17 = new Binding(bindingExtension18.Path, bindingExtension18.Mode, bindingExtension18.Converter, bindingExtension18.ConverterParameter, bindingExtension18.StringFormat, bindingExtension18.Source)
		{
			UpdateSourceEventName = bindingExtension18.UpdateSourceEventName,
			FallbackValue = bindingExtension18.FallbackValue,
			TargetNullValue = bindingExtension18.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding17) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding17, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 158, 13);
		}
		customEntryFieldLabel4.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, binding17);
		customEntryFieldLabel4.SetValue(Label.FontAutoScalingEnabledProperty, true);
		customEntryFieldLabel4.SetValue(Microsoft.Maui.Controls.VisualElement.IsEnabledProperty, false);
		referenceExtension17.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 161, 13);
		}
		bindingExtension19.Source = this;
		bindingExtension19.Path = "ShowErrorLabel";
		Binding binding18 = new Binding(bindingExtension19.Path, bindingExtension19.Mode, bindingExtension19.Converter, bindingExtension19.ConverterParameter, bindingExtension19.StringFormat, bindingExtension19.Source)
		{
			UpdateSourceEventName = bindingExtension19.UpdateSourceEventName,
			FallbackValue = bindingExtension19.FallbackValue,
			TargetNullValue = bindingExtension19.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding18) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding18, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 161, 13);
		}
		customEntryFieldLabel4.SetBinding(Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, binding18);
		referenceExtension18.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 162, 13);
		}
		bindingExtension20.Source = this;
		bindingExtension20.Path = "ErrorText";
		Binding binding19 = new Binding(bindingExtension20.Path, bindingExtension20.Mode, bindingExtension20.Converter, bindingExtension20.ConverterParameter, bindingExtension20.StringFormat, bindingExtension20.Source)
		{
			UpdateSourceEventName = bindingExtension20.UpdateSourceEventName,
			FallbackValue = bindingExtension20.FallbackValue,
			TargetNullValue = bindingExtension20.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding19) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding19, new Uri("CustomEntryField.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 162, 13);
		}
		customEntryFieldLabel4.SetBinding(Label.TextProperty, binding19);
		((IDynamicResourceHandler)customEntryFieldLabel4).SetDynamicResource(Label.TextColorProperty, dynamicResource8.Key);
		grid2.Children.Add(customEntryFieldLabel4);
		Children.Add(grid2);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<CustomEntryField, CustomEntryField> setter5 = null;
			return new TypedBinding<CustomEntryField, CustomEntryField>((CustomEntryField source) => (value: source, success: true), setter5, new Tuple<Func<CustomEntryField, object>, string>[0])
			{
				Source = extension.Source
			};
		}
		static string? getPathForType(Type type)
		{
			Assembly assembly = type.Assembly;
			foreach (XamlResourceIdAttribute customAttribute in assembly.GetCustomAttributes<XamlResourceIdAttribute>())
			{
				if (customAttribute.Type == type)
				{
					return customAttribute.Path;
				}
			}
			return null;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("this")]
	[MemberNotNull("TitleLabel")]
	[MemberNotNull("border")]
	[MemberNotNull("Entry")]
	[MemberNotNull("PasswordToggle")]
	[MemberNotNull("EntryImage")]
	[MemberNotNull("CounterLabel")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomEntryField));
		this.@this = this.FindByName<VerticalStackLayout>("this");
		TitleLabel = this.FindByName<CustomEntryFieldLabel>("TitleLabel");
		border = this.FindByName<Border>("border");
		Entry = this.FindByName<Microsoft.Maui.Controls.Entry>("Entry");
		PasswordToggle = this.FindByName<PasswordToggle>("PasswordToggle");
		EntryImage = this.FindByName<CustomEntryImage>("EntryImage");
		CounterLabel = this.FindByName<CustomEntryFieldLabel>("CounterLabel");
	}
}
