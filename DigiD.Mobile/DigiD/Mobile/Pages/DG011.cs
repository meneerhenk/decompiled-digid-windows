using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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

[XamlFilePath("Pages\\DG011.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG011 : BasePage<DG011ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryField dayEntry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomPicker monthEntry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryField yearEntry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BorderedButton nextButton;

	public DG011(DG011ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("dayEntry")]
	[MemberNotNull("monthEntry")]
	[MemberNotNull("yearEntry")]
	[MemberNotNull("nextButton")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG011).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG011)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string dG011_Titel = DigiDAppResources.DG011_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG011_Titel, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG011_Intro = DigiDAppResources.DG011_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG011_Intro, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		string dG011_Veld = DigiDAppResources.DG011_Veld1;
		VisualDiagnostics.RegisterSourceInfo(dG011_Veld, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		CustomEntryField customEntryField = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 17);
		string dG011_Veld2 = DigiDAppResources.DG011_Veld2;
		VisualDiagnostics.RegisterSourceInfo(dG011_Veld2, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		CustomPicker customPicker = new CustomPicker();
		VisualDiagnostics.RegisterSourceInfo(customPicker, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		string dG011_Veld3 = DigiDAppResources.DG011_Veld3;
		VisualDiagnostics.RegisterSourceInfo(dG011_Veld3, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 17);
		CustomEntryField customEntryField2 = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField2, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 14);
		string fM021_Melding = CommonResources.FM021_Melding;
		VisualDiagnostics.RegisterSourceInfo(fM021_Melding, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		CustomErrorLabel customErrorLabel = new CustomErrorLabel();
		VisualDiagnostics.RegisterSourceInfo(customErrorLabel, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 14);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 17);
		string dG011_Helplink = DigiDAppResources.DG011_Helplink;
		VisualDiagnostics.RegisterSourceInfo(dG011_Helplink, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 70, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 14);
		BindingExtension bindingExtension10 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 77, 17);
		BindingExtension bindingExtension11 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		customEntryField.transientNamescope = nameScope;
		nameScope.RegisterName("dayEntry", customEntryField);
		CustomEntryField customEntryField3 = customEntryField;
		if (customEntryField3.StyleId == null)
		{
			string text = (customEntryField3.StyleId = "dayEntry");
		}
		customPicker.transientNamescope = nameScope;
		nameScope.RegisterName("monthEntry", customPicker);
		CustomPicker customPicker2 = customPicker;
		if (customPicker2.StyleId == null)
		{
			string text = (customPicker2.StyleId = "monthEntry");
		}
		customEntryField2.transientNamescope = nameScope;
		nameScope.RegisterName("yearEntry", customEntryField2);
		customEntryField3 = customEntryField2;
		if (customEntryField3.StyleId == null)
		{
			string text = (customEntryField3.StyleId = "yearEntry");
		}
		customErrorLabel.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		nameScope.RegisterName("nextButton", borderedButton);
		BorderedButton borderedButton2 = borderedButton;
		if (borderedButton2.StyleId == null)
		{
			string text = (borderedButton2.StyleId = "nextButton");
		}
		dayEntry = customEntryField;
		monthEntry = customPicker;
		yearEntry = customEntryField2;
		nextButton = borderedButton;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG011_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG011_Intro);
		grid.Children.Add(label2);
		customEntryField.SetValue(Grid.RowProperty, 2);
		customEntryField.SetValue(Element.AutomationIdProperty, "DayEntry");
		customEntryField.IsRequired = true;
		bindingExtension.Path = "IsValidDay";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		customEntryField.SetBinding(CustomEntryField.IsValidProperty, bindingBase);
		customEntryField.SetValue(CustomEntryField.KeyboardProperty, new KeyboardTypeConverter().ConvertFromInvariantString("Numeric") as Keyboard);
		customEntryField.MaxLength = 2;
		customEntryField.MinLength = 2;
		customEntryField.SetValue(CustomEntryField.ReturnTypeProperty, ReturnType.Next);
		customEntryField.ShowValidIcon = true;
		bindingExtension2.Path = "Day";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		customEntryField.SetBinding(CustomEntryField.TextProperty, bindingBase2);
		customEntryField.SetValue(CustomEntryField.TitleTextProperty, dG011_Veld);
		grid.Children.Add(customEntryField);
		customPicker.SetValue(Grid.RowProperty, 3);
		customPicker.SetValue(Element.AutomationIdProperty, "MonthPicker");
		customPicker.IsRequired = true;
		bindingExtension3.Path = "IsValidMonth";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		}
		customPicker.SetBinding(CustomPicker.IsValidProperty, bindingBase3);
		bindingExtension4.Path = "Months";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		customPicker.SetBinding(CustomPicker.OptionsProperty, bindingBase4);
		customPicker.ShowValidIcon = true;
		bindingExtension5.Path = "Month";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 17);
		}
		customPicker.SetBinding(CustomPicker.TextProperty, bindingBase5);
		customPicker.SetValue(CustomPicker.TitleTextProperty, dG011_Veld2);
		grid.Children.Add(customPicker);
		customEntryField2.SetValue(Grid.RowProperty, 4);
		customEntryField2.SetValue(CustomEntryField.AutoDismissKeyboardProperty, true);
		customEntryField2.SetValue(Element.AutomationIdProperty, "YearEntry");
		customEntryField2.IsRequired = true;
		bindingExtension6.Path = "IsValidYear";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		}
		customEntryField2.SetBinding(CustomEntryField.IsValidProperty, bindingBase6);
		customEntryField2.SetValue(CustomEntryField.KeyboardProperty, new KeyboardTypeConverter().ConvertFromInvariantString("Numeric") as Keyboard);
		customEntryField2.MaxLength = 4;
		customEntryField2.MinLength = 4;
		customEntryField2.SetValue(CustomEntryField.ReturnTypeProperty, ReturnType.Next);
		customEntryField2.ShowValidIcon = true;
		bindingExtension7.Path = "Year";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		}
		customEntryField2.SetBinding(CustomEntryField.TextProperty, bindingBase7);
		customEntryField2.SetValue(CustomEntryField.TitleTextProperty, dG011_Veld3);
		grid.Children.Add(customEntryField2);
		customErrorLabel.SetValue(Grid.RowProperty, 5);
		customErrorLabel.SetValue(CustomErrorLabel.ErrorTextProperty, fM021_Melding);
		bindingExtension8.Path = "ShowError";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		}
		customErrorLabel.SetBinding(VisualElement.IsVisibleProperty, bindingBase8);
		grid.Children.Add(customErrorLabel);
		linkLabel.SetValue(Grid.RowProperty, 6);
		linkLabel.SetValue(Element.AutomationIdProperty, "UnknownDateOfBirthLink");
		bindingExtension9.Path = "UnknownDateOfBirthCommand";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase9);
		linkLabel.SetValue(LinkLabel.TextProperty, dG011_Helplink);
		grid.Children.Add(linkLabel);
		borderedButton.SetValue(Grid.RowProperty, 7);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension10.Path = "NextCommand";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 77, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase10);
		bindingExtension11.Path = "IsValidDateOfBirth";
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension11(bindingExtension11);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Pages\\DG011.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase11);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG011ViewModel, bool> setter = delegate(DG011ViewModel source, bool value)
			{
				source.IsValidDay = value;
			};
			return new TypedBinding<DG011ViewModel, bool>((DG011ViewModel source) => (value: source.IsValidDay, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "IsValidDay")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<DG011ViewModel, ICommand> setter = null;
			return new TypedBinding<DG011ViewModel, ICommand>((DG011ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
		{
			Action<DG011ViewModel, bool> setter = delegate(DG011ViewModel source, bool value)
			{
				source.IsValidDateOfBirth = value;
			};
			return new TypedBinding<DG011ViewModel, bool>((DG011ViewModel source) => (value: source.IsValidDateOfBirth, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "IsValidDateOfBirth")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG011ViewModel, string> setter = delegate(DG011ViewModel source, string value)
			{
				source.Day = value;
			};
			return new TypedBinding<DG011ViewModel, string>((DG011ViewModel source) => (value: source.Day, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "Day")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG011ViewModel, bool> setter = delegate(DG011ViewModel source, bool value)
			{
				source.IsValidMonth = value;
			};
			return new TypedBinding<DG011ViewModel, bool>((DG011ViewModel source) => (value: source.IsValidMonth, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "IsValidMonth")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG011ViewModel, IList<string>> setter = null;
			return new TypedBinding<DG011ViewModel, IList<string>>((DG011ViewModel source) => (value: source.Months, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "Months")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG011ViewModel, string> setter = delegate(DG011ViewModel source, string value)
			{
				source.Month = value;
			};
			return new TypedBinding<DG011ViewModel, string>((DG011ViewModel source) => (value: source.Month, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "Month")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG011ViewModel, bool> setter = delegate(DG011ViewModel source, bool value)
			{
				source.IsValidYear = value;
			};
			return new TypedBinding<DG011ViewModel, bool>((DG011ViewModel source) => (value: source.IsValidYear, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "IsValidYear")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG011ViewModel, string> setter = delegate(DG011ViewModel source, string value)
			{
				source.Year = value;
			};
			return new TypedBinding<DG011ViewModel, string>((DG011ViewModel source) => (value: source.Year, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "Year")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG011ViewModel, bool> setter = delegate(DG011ViewModel source, bool value)
			{
				source.ShowError = value;
			};
			return new TypedBinding<DG011ViewModel, bool>((DG011ViewModel source) => (value: source.ShowError, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "ShowError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DG011ViewModel, ICommand> setter = null;
			return new TypedBinding<DG011ViewModel, ICommand>((DG011ViewModel source) => ((ICommand value, bool success))(value: source.UnknownDateOfBirthCommand, success: true), setter, new Tuple<Func<DG011ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG011ViewModel, object>, string>((DG011ViewModel source) => source, "UnknownDateOfBirthCommand")
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
	[MemberNotNull("dayEntry")]
	[MemberNotNull("monthEntry")]
	[MemberNotNull("yearEntry")]
	[MemberNotNull("nextButton")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG011));
		dayEntry = this.FindByName<CustomEntryField>("dayEntry");
		monthEntry = this.FindByName<CustomPicker>("monthEntry");
		yearEntry = this.FindByName<CustomEntryField>("yearEntry");
		nextButton = this.FindByName<BorderedButton>("nextButton");
	}
}
