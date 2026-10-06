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

[XamlFilePath("Pages\\DG043.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG043 : BasePage<DG043ViewModel>
{
	public DG043(DG043ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG043).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG043)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 33);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		string dG043_Knop = DigiDAppResources.DG043_Knop;
		VisualDiagnostics.RegisterSourceInfo(dG043_Knop, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.Path = "Title.Localized";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		bindingExtension2.Path = "Intro.Localized";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		grid.Children.Add(label2);
		label3.SetValue(Grid.RowProperty, 2);
		bindingExtension3.Path = "Explanation.Localized";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 33);
		}
		label3.SetBinding(Label.TextProperty, bindingBase3);
		grid.Children.Add(label3);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(Element.AutomationIdProperty, "MoreInfoButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension4.Path = "MoreInfoCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase4);
		bindingExtension5.Path = "MoreInfoVisible";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG043.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		borderedButton.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		borderedButton.SetValue(Button.TextProperty, dG043_Knop);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG043ViewModel, string> setter = null;
			return new TypedBinding<DG043ViewModel, string>((DG043ViewModel source) => (value: source.Title.Localized, success: true), setter, new Tuple<Func<DG043ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source, "Title"),
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source.Title, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG043ViewModel, string> setter = null;
			return new TypedBinding<DG043ViewModel, string>((DG043ViewModel source) => (value: source.Intro.Localized, success: true), setter, new Tuple<Func<DG043ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source, "Intro"),
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source.Intro, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG043ViewModel, string> setter = null;
			return new TypedBinding<DG043ViewModel, string>((DG043ViewModel source) => (value: source.Explanation.Localized, success: true), setter, new Tuple<Func<DG043ViewModel, object>, string>[2]
			{
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source, "Explanation"),
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source.Explanation, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG043ViewModel, ICommand> setter = null;
			return new TypedBinding<DG043ViewModel, ICommand>((DG043ViewModel source) => ((ICommand value, bool success))(value: source.MoreInfoCommand, success: true), setter, new Tuple<Func<DG043ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source, "MoreInfoCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG043ViewModel, bool> setter = delegate(DG043ViewModel source, bool value)
			{
				source.MoreInfoVisible = value;
			};
			return new TypedBinding<DG043ViewModel, bool>((DG043ViewModel source) => (value: source.MoreInfoVisible, success: true), setter, new Tuple<Func<DG043ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG043ViewModel, object>, string>((DG043ViewModel source) => source, "MoreInfoVisible")
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
		this.LoadFromXaml(typeof(DG043));
	}
}
