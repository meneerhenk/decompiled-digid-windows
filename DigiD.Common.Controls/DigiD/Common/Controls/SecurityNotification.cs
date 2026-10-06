using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("SecurityNotification.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class SecurityNotification : Border
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(SecurityNotification), string.Empty, BindingMode.OneWay, null, TextPropertyChanged);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label __label__;

	public string Text { get; set; } = string.Empty;

	private static void TextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		((SecurityNotification)bindable).__label__.Text = (string)newValue;
	}

	public SecurityNotification()
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("__label__")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(SecurityNotification).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(SecurityNotification)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		string alg_SecurityNotification = CommonResources.Alg_SecurityNotification;
		VisualDiagnostics.RegisterSourceInfo(alg_SecurityNotification, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 22);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 14);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 34);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 14);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 10);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 10);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 13);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 10);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		grid.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		nameScope.RegisterName("__label__", label);
		Label label2 = label;
		if (label2.StyleId == null)
		{
			string text = (label2.StyleId = "__label__");
		}
		__label__ = label;
		SetValue(Border.PaddingProperty, new Thickness(10.0));
		SetValue(VisualElement.BackgroundColorProperty, new Color(0.88235295f, 79f / 85f, 73f / 85f, 1f));
		SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 4") as IShape);
		multiBinding.StringFormat = "{0} {1}";
		bindingExtension.Source = alg_SecurityNotification;
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 14);
		}
		multiBinding.Bindings.Add(binding);
		bindingExtension2.Path = "Text";
		referenceExtension.Name = "__label__";
		Label label3 = label;
		if (VisualDiagnostics.GetSourceInfo(label3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 34);
		}
		bindingExtension2.Source = label3;
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 14);
		}
		multiBinding.Bindings.Add(binding2);
		SetBinding(SemanticProperties.DescriptionProperty, multiBinding);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("green_shield.png"));
		grid.Children.Add(image);
		label.SetValue(Grid.ColumnProperty, 1);
		label.SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.None);
		staticResourceExtension.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { label, grid, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 13)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("SecurityNotification.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 13);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextColorProperty, new Color(19f / 85f, 0.5294118f, 4f / 85f, 1f));
		grid.Children.Add(label);
		SetValue(Border.ContentProperty, grid);
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
	[MemberNotNull("__label__")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(SecurityNotification));
		__label__ = this.FindByName<Label>("__label__");
	}
}
