using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using DigiD.Common.Interfaces;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
[XamlFilePath("CustomErrorLabel.xaml")]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class CustomErrorLabel : Grid
{
	public static readonly BindableProperty ErrorTextProperty = BindableProperty.Create("ErrorText", typeof(string), typeof(CustomErrorLabel), null, BindingMode.TwoWay, null, ErrorTextPropertyChanged);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid __parent__;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label __errorLabel__;

	public string ErrorText
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

	private static void ErrorTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		((CustomErrorLabel)bindable).__errorLabel__.Text = newValue.ToString();
	}

	public CustomErrorLabel()
	{
		InitializeComponent();
	}

	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		IA11YService a11YService = ((IApp)Application.Current).A11YService;
		if (!(propertyName == "IsVisible"))
		{
			if (propertyName == "ErrorText" && base.IsVisible)
			{
				a11YService.Speak(ErrorText, 1500);
			}
		}
		else if (base.IsVisible)
		{
			a11YService.Speak(ErrorText, 1500);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("__parent__")]
	[MemberNotNull("__errorLabel__")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomErrorLabel).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomErrorLabel)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 5);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 5);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 6);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 9);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 9);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 9);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("__parent__", this);
		if (StyleId == null)
		{
			string text = (StyleId = "__parent__");
		}
		image.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		nameScope.RegisterName("__errorLabel__", label);
		Label label2 = label;
		if (label2.StyleId == null)
		{
			string text = (label2.StyleId = "__errorLabel__");
		}
		__parent__ = this;
		__errorLabel__ = label;
		referenceExtension.Name = "__parent__";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 5);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "IsVisible";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 5);
		}
		SetBinding(AutomationProperties.IsInAccessibleTreeProperty, binding);
		SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(24.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
		referenceExtension2.Name = "__errorLabel__";
		Label label3 = label;
		if (VisualDiagnostics.GetSourceInfo(label3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		}
		bindingExtension2.Source = label3;
		bindingExtension2.Path = "Text";
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		}
		SetBinding(SemanticProperties.DescriptionProperty, binding2);
		image.SetValue(Grid.RowProperty, 0);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 5.0, 0.0));
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 20.0);
		image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_foutmelding_kritiek.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		image.SetValue(VisualElement.WidthRequestProperty, 20.0);
		Children.Add(image);
		label.SetValue(Grid.ColumnProperty, 1);
		staticResourceExtension.Key = "ErrorLabelStyle";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { label, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 9)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 9);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		referenceExtension3.Name = "__parent__";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 9);
		}
		bindingExtension3.Source = this;
		bindingExtension3.Path = "ErrorText";
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("CustomErrorLabel.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 9);
		}
		label.SetBinding(Label.TextProperty, binding3);
		label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
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
	[MemberNotNull("__parent__")]
	[MemberNotNull("__errorLabel__")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomErrorLabel));
		__parent__ = this.FindByName<Grid>("__parent__");
		__errorLabel__ = this.FindByName<Label>("__errorLabel__");
	}
}
