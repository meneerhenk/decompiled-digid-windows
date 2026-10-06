using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
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

[XamlFilePath("Pages\\DG012.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG012 : BasePage<DG012ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryField postcodeEntry;

	public DG012(DG012ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("postcodeEntry")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG012).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG012)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string dG012_Titel = DigiDAppResources.DG012_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG012_Titel, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG012_Intro = DigiDAppResources.DG012_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG012_Intro, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		string dG012_PostcodeHelp = DigiDAppResources.DG012_PostcodeHelp;
		VisualDiagnostics.RegisterSourceInfo(dG012_PostcodeHelp, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		string dG012_PostcodeVeld = DigiDAppResources.DG012_PostcodeVeld;
		VisualDiagnostics.RegisterSourceInfo(dG012_PostcodeVeld, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		CustomEntryField customEntryField = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		string dG012_Huisnummer = DigiDAppResources.DG012_Huisnummer;
		VisualDiagnostics.RegisterSourceInfo(dG012_Huisnummer, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		CustomEntryField customEntryField2 = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField2, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 17);
		string dG012_Toevoeging = DigiDAppResources.DG012_Toevoeging;
		VisualDiagnostics.RegisterSourceInfo(dG012_Toevoeging, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 17);
		CustomEntryField customEntryField3 = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField3, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		customEntryField.transientNamescope = nameScope;
		nameScope.RegisterName("postcodeEntry", customEntryField);
		CustomEntryField customEntryField4 = customEntryField;
		if (customEntryField4.StyleId == null)
		{
			string text = (customEntryField4.StyleId = "postcodeEntry");
		}
		customEntryField2.transientNamescope = nameScope;
		customEntryField3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		postcodeEntry = customEntryField;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG012_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG012_Intro);
		grid.Children.Add(label2);
		customEntryField.SetValue(Grid.RowProperty, 2);
		customEntryField.SetValue(Element.AutomationIdProperty, "ZipcodeEntry");
		customEntryField.SetValue(CustomEntryField.HelpTextProperty, dG012_PostcodeHelp);
		customEntryField.IsRequired = true;
		bindingExtension.Path = "IsValidPostcode";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		}
		customEntryField.SetBinding(CustomEntryField.IsValidProperty, bindingBase);
		customEntryField.MaxLength = 6;
		customEntryField.MinLength = 6;
		customEntryField.SetValue(CustomEntryField.ReturnTypeProperty, ReturnType.Next);
		customEntryField.ShowValidIcon = true;
		bindingExtension2.Path = "Postalcode";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		customEntryField.SetBinding(CustomEntryField.TextProperty, bindingBase2);
		customEntryField.SetValue(CustomEntryField.TitleTextProperty, dG012_PostcodeVeld);
		grid.Children.Add(customEntryField);
		customEntryField2.SetValue(Grid.RowProperty, 3);
		customEntryField2.SetValue(CustomEntryField.AutoDismissKeyboardProperty, true);
		customEntryField2.SetValue(Element.AutomationIdProperty, "HouseNumberEntry");
		customEntryField2.IsRequired = true;
		bindingExtension3.Path = "IsValidHouseNumber";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		customEntryField2.SetBinding(CustomEntryField.IsValidProperty, bindingBase3);
		customEntryField2.SetValue(CustomEntryField.KeyboardProperty, new KeyboardTypeConverter().ConvertFromInvariantString("Numeric") as Keyboard);
		customEntryField2.MaxLength = 5;
		customEntryField2.MinLength = 1;
		customEntryField2.SetValue(CustomEntryField.ReturnTypeProperty, ReturnType.Next);
		customEntryField2.ShowValidIcon = true;
		bindingExtension4.Path = "HouseNumber";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		customEntryField2.SetBinding(CustomEntryField.TextProperty, bindingBase4);
		customEntryField2.SetValue(CustomEntryField.TitleTextProperty, dG012_Huisnummer);
		grid.Children.Add(customEntryField2);
		customEntryField3.SetValue(Grid.RowProperty, 4);
		customEntryField3.SetValue(Element.AutomationIdProperty, "HouseNumberSuffixEntry");
		customEntryField3.IsRequired = false;
		customEntryField3.MaxLength = 5;
		customEntryField3.SetValue(CustomEntryField.ReturnTypeProperty, ReturnType.Done);
		bindingExtension5.Path = "HouseNumberSuffix";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 17);
		}
		customEntryField3.SetBinding(CustomEntryField.TextProperty, bindingBase5);
		customEntryField3.SetValue(CustomEntryField.TitleTextProperty, dG012_Toevoeging);
		grid.Children.Add(customEntryField3);
		borderedButton.SetValue(Grid.RowProperty, 5);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension6.Path = "NextCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase6);
		bindingExtension7.Path = "IsValidAddress";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG012.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase7);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG012ViewModel, bool> setter = delegate(DG012ViewModel source, bool value)
			{
				source.IsValidPostcode = value;
			};
			return new TypedBinding<DG012ViewModel, bool>((DG012ViewModel source) => (value: source.IsValidPostcode, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "IsValidPostcode")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG012ViewModel, string> setter = delegate(DG012ViewModel source, string? value)
			{
				source.Postalcode = value;
			};
			return new TypedBinding<DG012ViewModel, string>((DG012ViewModel source) => (value: source.Postalcode, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "Postalcode")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG012ViewModel, bool> setter = delegate(DG012ViewModel source, bool value)
			{
				source.IsValidHouseNumber = value;
			};
			return new TypedBinding<DG012ViewModel, bool>((DG012ViewModel source) => (value: source.IsValidHouseNumber, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "IsValidHouseNumber")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG012ViewModel, string> setter = delegate(DG012ViewModel source, string? value)
			{
				source.HouseNumber = value;
			};
			return new TypedBinding<DG012ViewModel, string>((DG012ViewModel source) => (value: source.HouseNumber, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "HouseNumber")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG012ViewModel, string> setter = delegate(DG012ViewModel source, string? value)
			{
				source.HouseNumberSuffix = value;
			};
			return new TypedBinding<DG012ViewModel, string>((DG012ViewModel source) => (value: source.HouseNumberSuffix, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "HouseNumberSuffix")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG012ViewModel, ICommand> setter = null;
			return new TypedBinding<DG012ViewModel, ICommand>((DG012ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG012ViewModel, bool> setter = null;
			return new TypedBinding<DG012ViewModel, bool>((DG012ViewModel source) => (value: source.IsValidAddress, success: true), setter, new Tuple<Func<DG012ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG012ViewModel, object>, string>((DG012ViewModel source) => source, "IsValidAddress")
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
	[MemberNotNull("postcodeEntry")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG012));
		postcodeEntry = this.FindByName<CustomEntryField>("postcodeEntry");
	}
}
