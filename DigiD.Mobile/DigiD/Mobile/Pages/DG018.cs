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

[XamlFilePath("Pages\\DG018.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG018 : BasePage<DG018ViewModel>
{
	public DG018(DG018ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG018).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG018)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate noScrollViewTemplate = TemplateSelector.NoScrollViewTemplate;
		VisualDiagnostics.RegisterSourceInfo(noScrollViewTemplate, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		string dG018_Titel = DigiDAppResources.DG018_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG018_Titel, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG018_Intro = DigiDAppResources.DG018_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG018_Intro, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 24);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 18);
		ScrollView scrollView = new ScrollView();
		VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		bool noDocumentsButtonVisible = DG018ViewModel.NoDocumentsButtonVisible;
		VisualDiagnostics.RegisterSourceInfo(noDocumentsButtonVisible, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		scrollView.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, noScrollViewTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG018_Titel);
		label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid.Children.Add(label);
		scrollView.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG018_Intro);
		scrollView.Content = label2;
		grid.Children.Add(scrollView);
		borderedButton.SetValue(Grid.RowProperty, 2);
		borderedButton.SetValue(Element.AutomationIdProperty, "NoDocumentButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension.Path = "NoDocumentCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG018.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(VisualElement.IsVisibleProperty, noDocumentsButtonVisible);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG018ViewModel, ICommand> setter = null;
			return new TypedBinding<DG018ViewModel, ICommand>((DG018ViewModel source) => ((ICommand value, bool success))(value: source.NoDocumentCommand, success: true), setter, new Tuple<Func<DG018ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG018ViewModel, object>, string>((DG018ViewModel source) => source, "NoDocumentCommand")
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
		this.LoadFromXaml(typeof(DG018));
	}
}
