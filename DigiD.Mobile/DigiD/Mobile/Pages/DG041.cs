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

[XamlFilePath("Pages\\DG041.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG041 : BasePage<DG041ViewModel>
{
	public DG041()
		: base((DG041ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG041).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG041)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string dG041_Titel = DigiDAppResources.DG041_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG041_Titel, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		string dG041_Uitleg = DigiDAppResources.DG041_Uitleg;
		VisualDiagnostics.RegisterSourceInfo(dG041_Uitleg, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 33);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		string dG041_Knop = DigiDAppResources.DG041_Knop1;
		VisualDiagnostics.RegisterSourceInfo(dG041_Knop, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		string dG041_Knop2 = DigiDAppResources.DG041_Knop2;
		VisualDiagnostics.RegisterSourceInfo(dG041_Knop2, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG041_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(label2);
		label3.SetValue(Grid.RowProperty, 2);
		label3.SetValue(Label.TextProperty, dG041_Uitleg);
		grid.Children.Add(label3);
		image.SetValue(Grid.RowProperty, 3);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_idcheck_idbewijzen.png"));
		grid.Children.Add(image);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "SkipScanButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "SkipScanCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.TextProperty, dG041_Knop);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 5);
		borderedButton2.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension3.Path = "NextCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG041.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase3);
		borderedButton2.SetValue(Button.TextProperty, dG041_Knop2);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG041ViewModel, string> setter = delegate(DG041ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG041ViewModel, string>((DG041ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG041ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG041ViewModel, object>, string>((DG041ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG041ViewModel, ICommand> setter = null;
			return new TypedBinding<DG041ViewModel, ICommand>((DG041ViewModel source) => ((ICommand value, bool success))(value: source.SkipScanCommand, success: true), setter, new Tuple<Func<DG041ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG041ViewModel, object>, string>((DG041ViewModel source) => source, "SkipScanCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG041ViewModel, ICommand> setter = null;
			return new TypedBinding<DG041ViewModel, ICommand>((DG041ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG041ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG041ViewModel, object>, string>((DG041ViewModel source) => source, "NextCommand")
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
		this.LoadFromXaml(typeof(DG041));
	}
}
