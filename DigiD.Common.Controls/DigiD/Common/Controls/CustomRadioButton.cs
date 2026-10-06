using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
[XamlFilePath("CustomRadioButton.xaml")]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class CustomRadioButton : Grid
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CustomRadioButton), string.Empty, BindingMode.OneWay, null, TextPropertyChanged);

	public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(CustomRadioButton), false, BindingMode.TwoWay, null, IsCheckedPropertyChanged);

	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(CustomRadioButton), null, BindingMode.OneTime);

	public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(CustomRadioButton), null, BindingMode.OneTime);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Image img;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label lbl;

	public string Text
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

	public bool? IsChecked
	{
		get
		{
			return (bool?)GetValue(IsCheckedProperty);
		}
		set
		{
			SetValue(IsCheckedProperty, value);
		}
	}

	public ICommand? Command
	{
		get
		{
			return (ICommand)GetValue(CommandProperty);
		}
		set
		{
			SetValue(CommandProperty, value);
		}
	}

	public object CommandParameter
	{
		get
		{
			return GetValue(CommandParameterProperty);
		}
		set
		{
			SetValue(CommandParameterProperty, value);
		}
	}

	private static void TextPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (newValue is string text)
		{
			((CustomRadioButton)bindable).SetText(text);
		}
	}

	private static void IsCheckedPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (newValue is bool state)
		{
			((CustomRadioButton)bindable).SetState(state);
		}
	}

	public CustomRadioButton()
	{
		InitializeComponent();
		SetState(newValue: false);
	}

	public void SetState(bool newValue)
	{
		if (!newValue)
		{
			lbl.SetDynamicResource(Label.TextColorProperty, "FontTextColor");
			img.SetDynamicResource(Image.SourceProperty, "RadioButtonAppOff");
		}
		else
		{
			lbl.SetDynamicResource(Label.TextColorProperty, "PrimaryColor");
			img.SetDynamicResource(Image.SourceProperty, "RadioButtonAppOn");
		}
		SetAutomationText(newValue);
	}

	private void SetAutomationText(bool newValue)
	{
		string text = (newValue ? (", " + CommonResources.AccessibilitySelected) : "");
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			SemanticProperties.SetDescription(lbl, lbl.Text + " " + text);
		}
		else
		{
			SemanticProperties.SetDescription(this, lbl.Text + " " + text);
		}
	}

	public void SetText(string newText)
	{
		lbl.Text = newText;
		SetAutomationText(IsChecked ?? false);
	}

	private void TapGestureRecognizer_OnTapped(object? sender, EventArgs e)
	{
		if (Command != null && Command.CanExecute(CommandParameter))
		{
			Command.Execute(CommandParameter);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("img")]
	[MemberNotNull("lbl")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomRadioButton).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomRadioButton)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 10);
		DynamicResource dynamicResource = new DynamicResource("RadioButtonAppOff");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 9);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 6);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 9);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		tapGestureRecognizer.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		nameScope.RegisterName("img", image);
		Image image2 = image;
		if (image2.StyleId == null)
		{
			string text = (image2.StyleId = "img");
		}
		label.transientNamescope = nameScope;
		nameScope.RegisterName("lbl", label);
		Label label2 = label;
		if (label2.StyleId == null)
		{
			string text = (label2.StyleId = "lbl");
		}
		img = image;
		lbl = label;
		SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		SetValue(Grid.ColumnSpacingProperty, 10.0);
		tapGestureRecognizer.SetValue(TapGestureRecognizer.NumberOfTapsRequiredProperty, 1);
		tapGestureRecognizer.Tapped += TapGestureRecognizer_OnTapped;
		GestureRecognizers.Add(tapGestureRecognizer);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 20.0);
		((IDynamicResourceHandler)image).SetDynamicResource(Image.SourceProperty, dynamicResource.Key);
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		image.SetValue(VisualElement.WidthRequestProperty, 20.0);
		Children.Add(image);
		label.SetValue(Grid.ColumnProperty, 1);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 40.0, 0.0));
		staticResourceExtension.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { label, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 9)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomRadioButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 9);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		Children.Add(label);
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
	[MemberNotNull("img")]
	[MemberNotNull("lbl")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomRadioButton));
		img = this.FindByName<Image>("img");
		lbl = this.FindByName<Label>("lbl");
	}
}
