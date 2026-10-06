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

[XamlFilePath("Pages\\DG054.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG054 : BasePage<DG054ViewModel>
{
	public DG054()
		: base((DG054ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG054).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG054)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string dG054_Titel = DigiDAppResources.DG054_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG054_Titel, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		string alg_No = CommonResources.Alg_No;
		VisualDiagnostics.RegisterSourceInfo(alg_No, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		string alg_Yes = CommonResources.Alg_Yes;
		VisualDiagnostics.RegisterSourceInfo(alg_Yes, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG054_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(label2);
		label3.SetValue(Grid.RowProperty, 2);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label3, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.None);
		bindingExtension2.Path = "EmailAddress";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		}
		label3.SetBinding(Label.TextProperty, bindingBase2);
		grid.Children.Add(label3);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(Element.AutomationIdProperty, "NoButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension3.Path = "ConfirmCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase3);
		borderedButton.SetValue(Button.CommandParameterProperty, "0");
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Button.TextProperty, alg_No);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "YesButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension4.Path = "ConfirmCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG054.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase4);
		borderedButton2.SetValue(Button.CommandParameterProperty, "1");
		borderedButton2.SetValue(Button.TextProperty, alg_Yes);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG054ViewModel, string> setter = delegate(DG054ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG054ViewModel, string>((DG054ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG054ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG054ViewModel, object>, string>((DG054ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG054ViewModel, string> setter = delegate(DG054ViewModel source, string? value)
			{
				source.EmailAddress = value;
			};
			return new TypedBinding<DG054ViewModel, string>((DG054ViewModel source) => (value: source.EmailAddress, success: true), setter, new Tuple<Func<DG054ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG054ViewModel, object>, string>((DG054ViewModel source) => source, "EmailAddress")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG054ViewModel, ICommand> setter = null;
			return new TypedBinding<DG054ViewModel, ICommand>((DG054ViewModel source) => ((ICommand value, bool success))(value: source.ConfirmCommand, success: true), setter, new Tuple<Func<DG054ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG054ViewModel, object>, string>((DG054ViewModel source) => source, "ConfirmCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG054ViewModel, ICommand> setter = null;
			return new TypedBinding<DG054ViewModel, ICommand>((DG054ViewModel source) => ((ICommand value, bool success))(value: source.ConfirmCommand, success: true), setter, new Tuple<Func<DG054ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG054ViewModel, object>, string>((DG054ViewModel source) => source, "ConfirmCommand")
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
		this.LoadFromXaml(typeof(DG054));
	}
}
