using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
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

[XamlFilePath("Pages\\DG003.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG003 : BasePage<DG003ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomEntryField usernameEntry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomErrorLabel errorLabel;

	public DG003(DG003ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		if (!((IApp)Application.Current).A11YService.IsInVoiceOverMode)
		{
			usernameEntry.Focus();
		}
	}

	private void ErrorLabel_PropertyChanged(object? sender, PropertyChangedEventArgs? e)
	{
		if (sender == errorLabel && errorLabel.IsVisible)
		{
			usernameEntry.Focus();
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("usernameEntry")]
	[MemberNotNull("errorLabel")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG003).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG003)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string dG003_Titel = DigiDAppResources.DG003_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG003_Titel, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		string dG003_Gebruikersnaam = DigiDAppResources.DG003_Gebruikersnaam;
		VisualDiagnostics.RegisterSourceInfo(dG003_Gebruikersnaam, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		CustomEntryField customEntryField = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		OnIdiomExtension onIdiomExtension3 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension3, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		string dG003_Wachtwoord = DigiDAppResources.DG003_Wachtwoord;
		VisualDiagnostics.RegisterSourceInfo(dG003_Wachtwoord, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		CustomEntryField customEntryField2 = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		CustomErrorLabel customErrorLabel = new CustomErrorLabel();
		VisualDiagnostics.RegisterSourceInfo(customErrorLabel, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 17);
		string dG003_Login = DigiDAppResources.DG003_Login;
		VisualDiagnostics.RegisterSourceInfo(dG003_Login, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 14);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 17);
		string dG003_Helplink = DigiDAppResources.DG003_Helplink;
		VisualDiagnostics.RegisterSourceInfo(dG003_Helplink, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 44);
		BoxView boxView = new BoxView();
		VisualDiagnostics.RegisterSourceInfo(boxView, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 18);
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 21);
		string dG003_Or = DigiDAppResources.DG003_Or;
		VisualDiagnostics.RegisterSourceInfo(dG003_Or, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 21);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 14);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 17);
		string dG003_AndereApp = DigiDAppResources.DG003_AndereApp;
		VisualDiagnostics.RegisterSourceInfo(dG003_AndereApp, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 70, 14);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 17);
		string dG003_RequestDigiD = DigiDAppResources.DG003_RequestDigiD;
		VisualDiagnostics.RegisterSourceInfo(dG003_RequestDigiD, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 17);
		BorderedButton borderedButton3 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton3, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		customEntryField.transientNamescope = nameScope;
		nameScope.RegisterName("usernameEntry", customEntryField);
		CustomEntryField customEntryField3 = customEntryField;
		if (customEntryField3.StyleId == null)
		{
			string text = (customEntryField3.StyleId = "usernameEntry");
		}
		customEntryField2.transientNamescope = nameScope;
		customErrorLabel.transientNamescope = nameScope;
		nameScope.RegisterName("errorLabel", customErrorLabel);
		CustomErrorLabel customErrorLabel2 = customErrorLabel;
		if (customErrorLabel2.StyleId == null)
		{
			string text = (customErrorLabel2.StyleId = "errorLabel");
		}
		borderedButton.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		boxView.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		borderedButton3.transientNamescope = nameScope;
		usernameEntry = customEntryField;
		errorLabel = customErrorLabel;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG003_Titel);
		grid2.Children.Add(label);
		customEntryField.SetValue(Grid.RowProperty, 1);
		customEntryField.SetValue(Element.AutomationIdProperty, "UsernameEntry");
		customEntryField.IsRequired = true;
		onIdiomExtension.Default = "Default";
		onIdiomExtension.Desktop = "Next";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { customEntryField, grid2, contentView, this }, CustomEntryField.ReturnTypeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 17)));
		object obj2 = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		}
		customEntryField.SetValue(CustomEntryField.ReturnTypeProperty, obj2);
		bindingExtension.Path = "UserName";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 17);
		}
		customEntryField.SetBinding(CustomEntryField.TextProperty, bindingBase);
		customEntryField.SetValue(CustomEntryField.TitleTextProperty, dG003_Gebruikersnaam);
		grid2.Children.Add(customEntryField);
		customEntryField2.SetValue(Grid.RowProperty, 2);
		customEntryField2.SetValue(Element.AutomationIdProperty, "PasswordEntry");
		customEntryField2.IsPassword = true;
		customEntryField2.IsRequired = true;
		bindingExtension2.Path = "Password";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		customEntryField2.SetBinding(CustomEntryField.TextProperty, bindingBase2);
		onIdiomExtension2.Default = "Done";
		onIdiomExtension2.Desktop = "Go";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { customEntryField2, grid2, contentView, this }, CustomEntryField.ReturnTypeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 17)));
		object obj3 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		}
		customEntryField2.SetValue(CustomEntryField.ReturnTypeProperty, obj3);
		bindingExtension3.Path = "LoginCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		onIdiomExtension3.Desktop = bindingBase3;
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[4] { customEntryField2, grid2, contentView, this }, CustomEntryField.ReturnCommandProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 17)));
		object obj4 = ((IMarkupExtension)onIdiomExtension3).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		customEntryField2.SetValue(CustomEntryField.ReturnCommandProperty, obj4);
		customEntryField2.SetValue(CustomEntryField.TitleTextProperty, dG003_Wachtwoord);
		grid2.Children.Add(customEntryField2);
		customErrorLabel.SetValue(Grid.RowProperty, 3);
		bindingExtension4.Path = "ErrorMessage";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 17);
		}
		customErrorLabel.SetBinding(CustomErrorLabel.ErrorTextProperty, bindingBase4);
		bindingExtension5.Path = "IsError";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		}
		customErrorLabel.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		customErrorLabel.PropertyChanged += ErrorLabel_PropertyChanged;
		grid2.Children.Add(customErrorLabel);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension6.Path = "LoginCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase6);
		borderedButton.SetValue(Button.TextProperty, dG003_Login);
		grid2.Children.Add(borderedButton);
		linkLabel.SetValue(Grid.RowProperty, 5);
		linkLabel.SetValue(Element.AutomationIdProperty, "ForgotUsernameLink");
		bindingExtension7.Path = "ForgotUserNameCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase7);
		linkLabel.SetValue(LinkLabel.TextProperty, dG003_Helplink);
		grid2.Children.Add(linkLabel);
		grid.SetValue(Grid.RowProperty, 6);
		boxView.SetValue(VisualElement.HeightRequestProperty, 1.0);
		staticResourceExtension2.Key = "Gray2";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[5] { boxView, grid, grid2, contentView, this }, BoxView.ColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(61, 44)));
		object obj5 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 44);
		}
		boxView.SetValue(BoxView.ColorProperty, obj5);
		grid.Children.Add(boxView);
		label2.SetValue(Label.PaddingProperty, new Thickness(10.0, 0.0));
		((IDynamicResourceHandler)label2).SetDynamicResource(VisualElement.BackgroundProperty, dynamicResource.Key);
		label2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		label2.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		label2.SetValue(Label.TextProperty, dG003_Or);
		grid.Children.Add(label2);
		grid2.Children.Add(grid);
		borderedButton2.SetValue(Grid.RowProperty, 7);
		borderedButton2.SetValue(Element.AutomationIdProperty, "LoginWithAppButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension8.Path = "OtherMethodsCommand";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase8);
		borderedButton2.SetValue(Button.ContentLayoutProperty, new Button.ButtonContentTypeConverter().ConvertFromInvariantString("Right, 10") as Button.ButtonContentLayout);
		borderedButton2.SetValue(Button.TextProperty, dG003_AndereApp);
		grid2.Children.Add(borderedButton2);
		borderedButton3.SetValue(Grid.RowProperty, 8);
		borderedButton3.SetValue(Element.AutomationIdProperty, "RequestAccountButton");
		borderedButton3.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension9.Path = "NoDigiDCommand";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG003.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 17);
		}
		borderedButton3.SetBinding(Button.CommandProperty, bindingBase9);
		borderedButton3.SetValue(BorderedButton.IsExternProperty, true);
		borderedButton3.SetValue(Button.TextProperty, dG003_RequestDigiD);
		grid2.Children.Add(borderedButton3);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG003ViewModel, string> setter = delegate(DG003ViewModel source, string? value)
			{
				source.UserName = value;
			};
			return new TypedBinding<DG003ViewModel, string>((DG003ViewModel source) => (value: source.UserName, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "UserName")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG003ViewModel, string> setter = delegate(DG003ViewModel source, string? value)
			{
				source.Password = value;
			};
			return new TypedBinding<DG003ViewModel, string>((DG003ViewModel source) => (value: source.Password, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "Password")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG003ViewModel, ICommand> setter = null;
			return new TypedBinding<DG003ViewModel, ICommand>((DG003ViewModel source) => ((ICommand value, bool success))(value: source.LoginCommand, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "LoginCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG003ViewModel, string> setter = delegate(DG003ViewModel source, string? value)
			{
				source.ErrorMessage = value;
			};
			return new TypedBinding<DG003ViewModel, string>((DG003ViewModel source) => (value: source.ErrorMessage, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "ErrorMessage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG003ViewModel, bool> setter = delegate(DG003ViewModel source, bool value)
			{
				source.IsError = value;
			};
			return new TypedBinding<DG003ViewModel, bool>((DG003ViewModel source) => (value: source.IsError, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "IsError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG003ViewModel, ICommand> setter = null;
			return new TypedBinding<DG003ViewModel, ICommand>((DG003ViewModel source) => ((ICommand value, bool success))(value: source.LoginCommand, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "LoginCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG003ViewModel, ICommand> setter = null;
			return new TypedBinding<DG003ViewModel, ICommand>((DG003ViewModel source) => ((ICommand value, bool success))(value: source.ForgotUserNameCommand, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "ForgotUserNameCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG003ViewModel, ICommand> setter = null;
			return new TypedBinding<DG003ViewModel, ICommand>((DG003ViewModel source) => ((ICommand value, bool success))(value: source.OtherMethodsCommand, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "OtherMethodsCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DG003ViewModel, ICommand> setter = null;
			return new TypedBinding<DG003ViewModel, ICommand>((DG003ViewModel source) => ((ICommand value, bool success))(value: source.NoDigiDCommand, success: true), setter, new Tuple<Func<DG003ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG003ViewModel, object>, string>((DG003ViewModel source) => source, "NoDigiDCommand")
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
	[MemberNotNull("usernameEntry")]
	[MemberNotNull("errorLabel")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG003));
		usernameEntry = this.FindByName<CustomEntryField>("usernameEntry");
		errorLabel = this.FindByName<CustomErrorLabel>("errorLabel");
	}
}
