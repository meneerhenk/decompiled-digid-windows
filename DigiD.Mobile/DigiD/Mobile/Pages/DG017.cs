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

[XamlFilePath("Pages\\DG017.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG017 : BasePage<DG017ViewModel>
{
	public DG017()
		: base((DG017ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG017).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG017)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		string dG017_Titel = DigiDAppResources.DG017_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG017_Titel, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		string dG017_Text = DigiDAppResources.DG017_Text;
		VisualDiagnostics.RegisterSourceInfo(dG017_Text, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		string alg_AlternateTextExplainIDBewijs = CommonResources.Alg_AlternateTextExplainIDBewijs;
		VisualDiagnostics.RegisterSourceInfo(alg_AlternateTextExplainIDBewijs, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		bool isSkipButtonVisible = DG017ViewModel.IsSkipButtonVisible;
		VisualDiagnostics.RegisterSourceInfo(isSkipButtonVisible, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		string dG017_Button = DigiDAppResources.DG017_Button1;
		VisualDiagnostics.RegisterSourceInfo(dG017_Button, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		string dG017_Button2 = DigiDAppResources.DG017_Button2;
		VisualDiagnostics.RegisterSourceInfo(dG017_Button2, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 0.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG017_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 0.0));
		label2.SetValue(Label.TextProperty, dG017_Text);
		grid.Children.Add(label2);
		image.SetValue(Grid.RowProperty, 2);
		image.SetValue(SemanticProperties.DescriptionProperty, alg_AlternateTextExplainIDBewijs);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_idcheck_idbewijzen.png"));
		grid.Children.Add(image);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 15.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "ScanLaterButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension.Path = "CancelScanCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(VisualElement.IsVisibleProperty, isSkipButtonVisible);
		borderedButton.SetValue(Button.TextProperty, dG017_Button);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "ScanButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension2.Path = "StartScanCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG017.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton2.SetValue(Button.TextProperty, dG017_Button2);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG017ViewModel, ICommand> setter = null;
			return new TypedBinding<DG017ViewModel, ICommand>((DG017ViewModel source) => ((ICommand value, bool success))(value: source.CancelScanCommand, success: true), setter, new Tuple<Func<DG017ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG017ViewModel, object>, string>((DG017ViewModel source) => source, "CancelScanCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG017ViewModel, ICommand> setter = null;
			return new TypedBinding<DG017ViewModel, ICommand>((DG017ViewModel source) => ((ICommand value, bool success))(value: source.StartScanCommand, success: true), setter, new Tuple<Func<DG017ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG017ViewModel, object>, string>((DG017ViewModel source) => source, "StartScanCommand")
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
		this.LoadFromXaml(typeof(DG017));
	}
}
