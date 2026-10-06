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
using Microsoft.Maui.Converters;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG010.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG010 : BasePage<DG010ViewModel>
{
	public DG010(DG010ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG010).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG010)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		string dG010_Titel = DigiDAppResources.DG010_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG010_Titel, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		string dG010_Intro = DigiDAppResources.DG010_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG010_Intro, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		string fM020_Melding = CommonResources.FM020_Melding;
		VisualDiagnostics.RegisterSourceInfo(fM020_Melding, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		string dG010_Helptekst = DigiDAppResources.DG010_Helptekst;
		VisualDiagnostics.RegisterSourceInfo(dG010_Helptekst, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		string dG010_BSNveld = DigiDAppResources.DG010_BSNveld;
		VisualDiagnostics.RegisterSourceInfo(dG010_BSNveld, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		CustomEntryField customEntryField = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		customEntryField.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG010_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG010_Intro);
		grid.Children.Add(label2);
		customEntryField.SetValue(Grid.RowProperty, 2);
		customEntryField.SetValue(CustomEntryField.AutoDismissKeyboardProperty, true);
		customEntryField.SetValue(Element.AutomationIdProperty, "BsnEntry");
		customEntryField.SetValue(CustomEntryField.ErrorTextProperty, fM020_Melding);
		customEntryField.SetValue(CustomEntryField.HelpTextProperty, dG010_Helptekst);
		customEntryField.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		customEntryField.IsRequired = true;
		bindingExtension.Path = "IsValidBsn";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		}
		customEntryField.SetBinding(CustomEntryField.IsValidProperty, bindingBase);
		customEntryField.SetValue(CustomEntryField.KeyboardProperty, new KeyboardTypeConverter().ConvertFromInvariantString("Numeric") as Keyboard);
		customEntryField.MaxLength = 9;
		customEntryField.MinLength = 9;
		onIdiomExtension.Default = "Done";
		onIdiomExtension.Desktop = "Go";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { customEntryField, grid, contentView, this }, CustomEntryField.ReturnTypeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(34, 17)));
		object obj2 = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		}
		customEntryField.SetValue(CustomEntryField.ReturnTypeProperty, obj2);
		bindingExtension2.Path = "NextCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		onIdiomExtension2.Desktop = bindingBase2;
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { customEntryField, grid, contentView, this }, CustomEntryField.ReturnCommandProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 17)));
		object obj3 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		customEntryField.SetValue(CustomEntryField.ReturnCommandProperty, obj3);
		customEntryField.SetValue(CustomEntryField.ShowCounterProperty, true);
		bindingExtension3.Path = "ShowError";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		customEntryField.SetBinding(CustomEntryField.ShowErrorLabelProperty, bindingBase3);
		customEntryField.ShowValidIcon = true;
		bindingExtension4.Path = "Bsn";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		customEntryField.SetBinding(CustomEntryField.TextProperty, bindingBase4);
		customEntryField.SetValue(CustomEntryField.TitleTextProperty, dG010_BSNveld);
		grid.Children.Add(customEntryField);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension5.Path = "NextCommand";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase5);
		bindingExtension6.Path = "IsValidBsn";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG010.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase6);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG010ViewModel, bool> setter = delegate(DG010ViewModel source, bool value)
			{
				source.IsValidBsn = value;
			};
			return new TypedBinding<DG010ViewModel, bool>((DG010ViewModel source) => (value: source.IsValidBsn, success: true), setter, new Tuple<Func<DG010ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG010ViewModel, object>, string>((DG010ViewModel source) => source, "IsValidBsn")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG010ViewModel, ICommand> setter = null;
			return new TypedBinding<DG010ViewModel, ICommand>((DG010ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG010ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG010ViewModel, object>, string>((DG010ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG010ViewModel, bool> setter = delegate(DG010ViewModel source, bool value)
			{
				source.ShowError = value;
			};
			return new TypedBinding<DG010ViewModel, bool>((DG010ViewModel source) => (value: source.ShowError, success: true), setter, new Tuple<Func<DG010ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG010ViewModel, object>, string>((DG010ViewModel source) => source, "ShowError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG010ViewModel, string> setter = delegate(DG010ViewModel source, string value)
			{
				source.Bsn = value;
			};
			return new TypedBinding<DG010ViewModel, string>((DG010ViewModel source) => (value: source.Bsn, success: true), setter, new Tuple<Func<DG010ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG010ViewModel, object>, string>((DG010ViewModel source) => source, "Bsn")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG010ViewModel, ICommand> setter = null;
			return new TypedBinding<DG010ViewModel, ICommand>((DG010ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG010ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG010ViewModel, object>, string>((DG010ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG010ViewModel, bool> setter = delegate(DG010ViewModel source, bool value)
			{
				source.IsValidBsn = value;
			};
			return new TypedBinding<DG010ViewModel, bool>((DG010ViewModel source) => (value: source.IsValidBsn, success: true), setter, new Tuple<Func<DG010ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG010ViewModel, object>, string>((DG010ViewModel source) => source, "IsValidBsn")
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
		this.LoadFromXaml(typeof(DG010));
	}
}
