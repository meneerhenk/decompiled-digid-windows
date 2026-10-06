using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("CustomPicker.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class CustomPicker : VerticalStackLayout
{
	public static readonly BindableProperty IsValidProperty = BindableProperty.Create("IsValid", typeof(bool), typeof(CustomPicker), true, BindingMode.TwoWay, null, IsValidPropertyChanged);

	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CustomPicker), null, BindingMode.TwoWay);

	public static readonly BindableProperty TitleTextProperty = BindableProperty.Create("TitleText", typeof(string), typeof(CustomPicker), null, BindingMode.OneTime, null, TitleTextPropertyChanged);

	public static readonly BindableProperty OptionsProperty = BindableProperty.Create("Options", typeof(IList<string>), typeof(CustomPicker));

	public static readonly BindableProperty NextControlProperty = BindableProperty.Create("NextControl", typeof(View), typeof(CustomPicker));

	private readonly IA11YService _a11YService;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout @this;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryFieldLabel TitleLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border border;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Picker Picker;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryImage EntryImage;

	public View? NextControl
	{
		get
		{
			return (View)GetValue(NextControlProperty);
		}
		set
		{
			SetValue(NextControlProperty, value);
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

	public bool IsRequired { get; set; } = true;

	public bool ShowValidIcon { get; set; }

	public IList<string> Options
	{
		get
		{
			return (IList<string>)GetValue(OptionsProperty);
		}
		set
		{
			SetValue(OptionsProperty, value);
		}
	}

	private static void IsValidPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomPicker customPicker && newValue is bool flag && customPicker.EntryImage != null)
		{
			customPicker.EntryImage.IsVisible = flag && customPicker.ShowValidIcon;
		}
	}

	private static void TitleTextPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomPicker customPicker && newValue is string value && !string.IsNullOrEmpty(value))
		{
			AutomationProperties.SetLabeledBy(customPicker.Picker, customPicker.TitleLabel);
		}
	}

	public CustomPicker()
	{
		_a11YService = ((IApp)Application.Current).A11YService;
		InitializeComponent();
	}

	public new void Focus()
	{
		Picker.Focus();
	}

	private void Picker_Unfocused(object? sender, FocusEventArgs e)
	{
		ArgumentNullException.ThrowIfNull(Application.Current, "Application.Current");
		if (Picker.SelectedItem == null)
		{
			border.Stroke = (Color)Application.Current.Resources["CustomEntryFieldFrameBorderColorNoFocus"];
			border.BackgroundColor = (Color)Application.Current.Resources["CustomEntryFieldInactiveBackgroundColor"];
		}
		else
		{
			border.Stroke = (Color)Application.Current.Resources["CustomEntryFieldFrameBorderColorNoFocus"];
			border.BackgroundColor = (Color)Application.Current.Resources["CustomEntryFieldTextEnteredBackgroundColor"];
		}
	}

	private void Picker_Focused(object? sender, FocusEventArgs e)
	{
		ArgumentNullException.ThrowIfNull(Application.Current, "Application.Current");
		_a11YService.Speak(CommonResources.Alg_ChooseFromList);
		border.Stroke = (Color)Application.Current.Resources["CustomEntryFieldFrameBorderColor"];
		border.BackgroundColor = (Color)Application.Current.Resources["CustomEntryFieldActiveBackgroundColor"];
	}

	private void Picker_OnSelectedIndexChanged(object? sender, EventArgs e)
	{
		NextControl?.Focus();
	}

	private void Border_HandlerChanged(object? sender, EventArgs e)
	{
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("this")]
	[MemberNotNull("TitleLabel")]
	[MemberNotNull("border")]
	[MemberNotNull("Picker")]
	[MemberNotNull("EntryImage")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomPicker).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomPicker)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 9);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 9);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 9);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 9);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 9);
		DynamicResource dynamicResource = new DynamicResource("CustomPickerHeaderTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 9);
		CustomEntryFieldLabel customEntryFieldLabel = new CustomEntryFieldLabel();
		VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 6);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 9);
		DynamicResource dynamicResource2 = new DynamicResource("CustomEntryFieldInactiveBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 9);
		DynamicResource dynamicResource3 = new DynamicResource("CustomEntryFieldFrameBorderColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 9);
		OnPlatformExtension onPlatformExtension3 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 15);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 17);
		ReferenceExtension referenceExtension4 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension4, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 17);
		ReferenceExtension referenceExtension5 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension5, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 46);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 26);
		string alg_ChooseFromList = CommonResources.Alg_ChooseFromList;
		VisualDiagnostics.RegisterSourceInfo(alg_ChooseFromList, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 34);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 26);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 22);
		Picker picker = new Picker();
		VisualDiagnostics.RegisterSourceInfo(picker, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 14);
		ReferenceExtension referenceExtension6 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension6, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 51);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 26);
		string alg_ValidInput = CommonResources.Alg_ValidInput;
		VisualDiagnostics.RegisterSourceInfo(alg_ValidInput, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 34);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 26);
		MultiBinding multiBinding2 = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 22);
		CustomEntryImage customEntryImage = new CustomEntryImage();
		VisualDiagnostics.RegisterSourceInfo(customEntryImage, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 49, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 10);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("this", this);
		if (StyleId == null)
		{
			string text = (StyleId = "this");
		}
		customEntryFieldLabel.transientNamescope = nameScope;
		nameScope.RegisterName("TitleLabel", customEntryFieldLabel);
		CustomEntryFieldLabel customEntryFieldLabel2 = customEntryFieldLabel;
		if (customEntryFieldLabel2.StyleId == null)
		{
			string text = (customEntryFieldLabel2.StyleId = "TitleLabel");
		}
		border.transientNamescope = nameScope;
		nameScope.RegisterName("border", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "border");
		}
		grid.transientNamescope = nameScope;
		picker.transientNamescope = nameScope;
		nameScope.RegisterName("Picker", picker);
		Picker picker2 = picker;
		if (picker2.StyleId == null)
		{
			string text = (picker2.StyleId = "Picker");
		}
		customEntryImage.transientNamescope = nameScope;
		nameScope.RegisterName("EntryImage", customEntryImage);
		CustomEntryImage customEntryImage2 = customEntryImage;
		if (customEntryImage2.StyleId == null)
		{
			string text = (customEntryImage2.StyleId = "EntryImage");
		}
		this.@this = this;
		TitleLabel = customEntryFieldLabel;
		this.border = border;
		Picker = picker;
		EntryImage = customEntryImage;
		onPlatformExtension.Android = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(9, 5)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		}
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		customEntryFieldLabel.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 2.0));
		customEntryFieldLabel.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		customEntryFieldLabel.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
		referenceExtension.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 9);
		}
		bindingExtension.Source = this;
		staticResourceExtension.Key = "IsStringNotNullOrWhiteSpaceConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[3] { bindingExtension, customEntryFieldLabel, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(15, 9)));
		object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 9);
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
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 9);
		}
		customEntryFieldLabel.SetBinding(VisualElement.IsVisibleProperty, binding);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[2] { customEntryFieldLabel, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 9)));
		object obj3 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		}
		customEntryFieldLabel.SetValue(VisualElement.StyleProperty, obj3);
		referenceExtension2.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 9);
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
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 9);
		}
		customEntryFieldLabel.SetBinding(Label.TextProperty, binding2);
		((IDynamicResourceHandler)customEntryFieldLabel).SetDynamicResource(Label.TextColorProperty, dynamicResource.Key);
		customEntryFieldLabel.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		customEntryFieldLabel.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
		Children.Add(customEntryFieldLabel);
		border.SetValue(Border.PaddingProperty, new Thickness(10.0, 0.0, 1.0, 0.0));
		onPlatformExtension2.Android = "False";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[2] { border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 9)));
		object obj4 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 9);
		}
		border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj4);
		((IDynamicResourceHandler)border).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource2.Key);
		((IDynamicResourceHandler)border).SetDynamicResource(Border.StrokeProperty, dynamicResource3.Key);
		onPlatformExtension3.Android = "False";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[3] { grid, border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(28, 15)));
		object obj5 = ((IMarkupExtension)onPlatformExtension3).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 15);
		}
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj5);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(new GridLength(48.0, GridUnitType.Absolute))));
		picker.Focused += Picker_Focused;
		picker.HandlerChanged += Border_HandlerChanged;
		referenceExtension3.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 17);
		}
		bindingExtension3.Source = this;
		bindingExtension3.Path = "Options";
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 17);
		}
		picker.SetBinding(Picker.ItemsSourceProperty, binding3);
		picker.SelectedIndexChanged += Picker_OnSelectedIndexChanged;
		referenceExtension4.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 17);
		}
		bindingExtension4.Source = this;
		bindingExtension4.Path = "Text";
		Binding binding4 = new Binding(bindingExtension4.Path, bindingExtension4.Mode, bindingExtension4.Converter, bindingExtension4.ConverterParameter, bindingExtension4.StringFormat, bindingExtension4.Source)
		{
			UpdateSourceEventName = bindingExtension4.UpdateSourceEventName,
			FallbackValue = bindingExtension4.FallbackValue,
			TargetNullValue = bindingExtension4.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding4, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 17);
		}
		picker.SetBinding(Picker.SelectedItemProperty, binding4);
		picker.SetValue(Picker.TextColorProperty, Colors.Black);
		picker.Unfocused += Picker_Unfocused;
		picker.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		picker.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
		picker.SetValue(VisualElement.ZIndexProperty, 7);
		multiBinding.StringFormat = "{0} {1}";
		bindingExtension5.Path = "Text";
		referenceExtension5.Name = "TitleLabel";
		CustomEntryFieldLabel customEntryFieldLabel3 = customEntryFieldLabel;
		if (VisualDiagnostics.GetSourceInfo(customEntryFieldLabel3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(customEntryFieldLabel3, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 46);
		}
		bindingExtension5.Source = customEntryFieldLabel3;
		Binding binding5 = new Binding(bindingExtension5.Path, bindingExtension5.Mode, bindingExtension5.Converter, bindingExtension5.ConverterParameter, bindingExtension5.StringFormat, bindingExtension5.Source)
		{
			UpdateSourceEventName = bindingExtension5.UpdateSourceEventName,
			FallbackValue = bindingExtension5.FallbackValue,
			TargetNullValue = bindingExtension5.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding5, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 26);
		}
		multiBinding.Bindings.Add(binding5);
		bindingExtension6.Source = alg_ChooseFromList;
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 26);
		}
		multiBinding.Bindings.Add(bindingBase);
		picker.SetBinding(SemanticProperties.DescriptionProperty, multiBinding);
		grid.Children.Add(picker);
		customEntryImage.SetValue(Grid.ColumnProperty, 1);
		customEntryImage.SetValue(VisualElement.HeightRequestProperty, 48.0);
		customEntryImage.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		customEntryImage.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_icon_success.png"));
		customEntryImage.SetValue(VisualElement.WidthRequestProperty, 48.0);
		customEntryImage.SetValue(VisualElement.ZIndexProperty, 15);
		multiBinding2.StringFormat = "{0} {1}";
		bindingExtension7.Path = "TitleText";
		referenceExtension6.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 51);
		}
		bindingExtension7.Source = this;
		Binding binding6 = new Binding(bindingExtension7.Path, bindingExtension7.Mode, bindingExtension7.Converter, bindingExtension7.ConverterParameter, bindingExtension7.StringFormat, bindingExtension7.Source)
		{
			UpdateSourceEventName = bindingExtension7.UpdateSourceEventName,
			FallbackValue = bindingExtension7.FallbackValue,
			TargetNullValue = bindingExtension7.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding6, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 26);
		}
		multiBinding2.Bindings.Add(binding6);
		bindingExtension8.Source = alg_ValidInput;
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension7(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("CustomPicker.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 26);
		}
		multiBinding2.Bindings.Add(bindingBase2);
		customEntryImage.SetBinding(SemanticProperties.DescriptionProperty, multiBinding2);
		grid.Children.Add(customEntryImage);
		border.SetValue(Border.ContentProperty, grid);
		Children.Add(border);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<CustomPicker, CustomPicker> setter = null;
			return new TypedBinding<CustomPicker, CustomPicker>((CustomPicker source) => (value: source, success: true), setter, new Tuple<Func<CustomPicker, object>, string>[0])
			{
				Source = extension.Source
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<CustomPicker, CustomPicker> setter = null;
			return new TypedBinding<CustomPicker, CustomPicker>((CustomPicker source) => (value: source, success: true), setter, new Tuple<Func<CustomPicker, object>, string>[0])
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
	[MemberNotNull("Picker")]
	[MemberNotNull("EntryImage")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomPicker));
		this.@this = this.FindByName<VerticalStackLayout>("this");
		TitleLabel = this.FindByName<CustomEntryFieldLabel>("TitleLabel");
		border = this.FindByName<Border>("border");
		Picker = this.FindByName<Picker>("Picker");
		EntryImage = this.FindByName<CustomEntryImage>("EntryImage");
	}
}
