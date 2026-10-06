using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.Controls;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG035B.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG035B : BasePage<DG035ViewModel>
{
	public DG035B()
		: base((DG035ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG035B).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG035B)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		string dG035_Titel = DigiDAppResources.DG035_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG035_Titel, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG035_InfoBerichten = DigiDAppResources.DG035_InfoBerichten;
		VisualDiagnostics.RegisterSourceInfo(dG035_InfoBerichten, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		DynamicResource dynamicResource = new DynamicResource("digidIconMenuBerichtenRectangle");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		string dG035_KeuzeBerichten = DigiDAppResources.DG035_KeuzeBerichten;
		VisualDiagnostics.RegisterSourceInfo(dG035_KeuzeBerichten, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		MenuSwitchControl menuSwitchControl = new MenuSwitchControl();
		VisualDiagnostics.RegisterSourceInfo(menuSwitchControl, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		menuSwitchControl.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG035_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		label2.SetValue(Label.TextProperty, dG035_InfoBerichten);
		grid.Children.Add(label2);
		menuSwitchControl.SetValue(Grid.RowProperty, 2);
		menuSwitchControl.SetValue(Element.AutomationIdProperty, "Messages");
		bindingExtension.Path = "NotificationsEnabled";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		menuSwitchControl.SetBinding(MenuSwitchControl.CheckedProperty, bindingBase);
		((IDynamicResourceHandler)menuSwitchControl).SetDynamicResource(MenuSwitchControl.ImageSourceProperty, dynamicResource.Key);
		menuSwitchControl.SetValue(MenuSwitchControl.TextProperty, dG035_KeuzeBerichten);
		grid.Children.Add(menuSwitchControl);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension2.Path = "NextCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG035B.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG035ViewModel, bool> setter = delegate(DG035ViewModel source, bool value)
			{
				source.NotificationsEnabled = value;
			};
			return new TypedBinding<DG035ViewModel, bool>((DG035ViewModel source) => (value: source.NotificationsEnabled, success: true), setter, new Tuple<Func<DG035ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG035ViewModel, object>, string>((DG035ViewModel source) => source, "NotificationsEnabled")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG035ViewModel, ICommand> setter = null;
			return new TypedBinding<DG035ViewModel, ICommand>((DG035ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG035ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG035ViewModel, object>, string>((DG035ViewModel source) => source, "NextCommand")
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
		this.LoadFromXaml(typeof(DG035B));
	}
}
