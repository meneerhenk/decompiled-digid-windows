using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\FM065.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM065 : BasePage<FM065ViewModel>
{
	public FM065(FM065ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM065).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM065)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string fM065_Titel = CommonResources.FM065_Titel;
		VisualDiagnostics.RegisterSourceInfo(fM065_Titel, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string fM065_Body = CommonResources.FM065_Body;
		VisualDiagnostics.RegisterSourceInfo(fM065_Body, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		string fM065_Knop = CommonResources.FM065_Knop;
		VisualDiagnostics.RegisterSourceInfo(fM065_Knop, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 10.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM065_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, fM065_Body);
		grid.Children.Add(label2);
		borderedButton.SetValue(Grid.RowProperty, 2);
		borderedButton.SetValue(Element.AutomationIdProperty, "OpenSettingsButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension.Path = "OpenSettingsCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\FM065.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(Button.TextProperty, fM065_Knop);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<FM065ViewModel, ICommand> setter = null;
			return new TypedBinding<FM065ViewModel, ICommand>((FM065ViewModel source) => ((ICommand value, bool success))(value: source.OpenSettingsCommand, success: true), setter, new Tuple<Func<FM065ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM065ViewModel, object>, string>((FM065ViewModel source) => source, "OpenSettingsCommand")
			});
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(FM065));
	}
}
