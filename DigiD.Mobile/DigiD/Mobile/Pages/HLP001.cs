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

[XamlFilePath("Pages\\HLP001.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP001 : BasePage<HLP001ViewModel>
{
	public HLP001(HLP001ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HLP001).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HLP001)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string hLP01_Titel = DigiDAppResources.HLP01_Titel;
		VisualDiagnostics.RegisterSourceInfo(hLP01_Titel, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 24);
		string hLP01_SubtitelWachtwoord = DigiDAppResources.HLP01_SubtitelWachtwoord;
		VisualDiagnostics.RegisterSourceInfo(hLP01_SubtitelWachtwoord, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 59);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 18);
		string hLP01_InfoWachtwoord = DigiDAppResources.HLP01_InfoWachtwoord;
		VisualDiagnostics.RegisterSourceInfo(hLP01_InfoWachtwoord, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 24);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		string hLP01_LinkWebsite = DigiDAppResources.HLP01_LinkWebsite;
		VisualDiagnostics.RegisterSourceInfo(hLP01_LinkWebsite, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		BoxView boxView = new BoxView();
		VisualDiagnostics.RegisterSourceInfo(boxView, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 24);
		string hLP01_SubtitelGebruikersnaam = DigiDAppResources.HLP01_SubtitelGebruikersnaam;
		VisualDiagnostics.RegisterSourceInfo(hLP01_SubtitelGebruikersnaam, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 59);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 18);
		string hLP01_InfoGebruikersnaam = DigiDAppResources.HLP01_InfoGebruikersnaam;
		VisualDiagnostics.RegisterSourceInfo(hLP01_InfoGebruikersnaam, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 24);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 18);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		string hLP01_RequestUserName = DigiDAppResources.HLP01_RequestUserName;
		VisualDiagnostics.RegisterSourceInfo(hLP01_RequestUserName, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 14);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		BoxView boxView2 = new BoxView();
		VisualDiagnostics.RegisterSourceInfo(boxView2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 14);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 24);
		string hLP01_Gebruikersnaam_ww = DigiDAppResources.HLP01_Gebruikersnaam_ww;
		VisualDiagnostics.RegisterSourceInfo(hLP01_Gebruikersnaam_ww, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 59);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 18);
		string hLP01_InfoGebruikersnaam_ww = DigiDAppResources.HLP01_InfoGebruikersnaam_ww;
		VisualDiagnostics.RegisterSourceInfo(hLP01_InfoGebruikersnaam_ww, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 24);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 37);
		string hLP01_LinkGebruikersnaam_ww = DigiDAppResources.HLP01_LinkGebruikersnaam_ww;
		VisualDiagnostics.RegisterSourceInfo(hLP01_LinkGebruikersnaam_ww, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 72);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 18);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 14);
		VerticalStackLayout verticalStackLayout4 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout4, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout4.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		boxView.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		boxView2.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout4.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout4.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout4.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout4, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, hLP01_Titel);
		verticalStackLayout4.Children.Add(label);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label2, verticalStackLayout, verticalStackLayout4, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 24)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 24);
		}
		label2.SetValue(VisualElement.StyleProperty, obj2);
		label2.SetValue(Label.TextProperty, hLP01_SubtitelWachtwoord);
		verticalStackLayout.Children.Add(label2);
		label3.SetValue(Label.TextProperty, hLP01_InfoWachtwoord);
		verticalStackLayout.Children.Add(label3);
		verticalStackLayout4.Children.Add(verticalStackLayout);
		borderedButton.SetValue(Element.AutomationIdProperty, "RecoverPasswordButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension.Path = "RecoverPasswordCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(BorderedButton.IsExternProperty, true);
		borderedButton.SetValue(Button.TextProperty, hLP01_LinkWebsite);
		verticalStackLayout4.Children.Add(borderedButton);
		boxView.SetValue(View.MarginProperty, new Thickness(0.0, 12.0));
		boxView.SetValue(VisualElement.HeightRequestProperty, 1.0);
		staticResourceExtension3.Key = "Gray2";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { boxView, verticalStackLayout4, contentView, this }, BoxView.ColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 17)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		boxView.SetValue(BoxView.ColorProperty, obj3);
		verticalStackLayout4.Children.Add(boxView);
		staticResourceExtension4.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[5] { label4, verticalStackLayout2, verticalStackLayout4, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(38, 24)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 24);
		}
		label4.SetValue(VisualElement.StyleProperty, obj4);
		label4.SetValue(Label.TextProperty, hLP01_SubtitelGebruikersnaam);
		verticalStackLayout2.Children.Add(label4);
		label5.SetValue(Label.TextProperty, hLP01_InfoGebruikersnaam);
		verticalStackLayout2.Children.Add(label5);
		verticalStackLayout4.Children.Add(verticalStackLayout2);
		borderedButton2.SetValue(Element.AutomationIdProperty, "RequestDigiDButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "RecoverUserNameCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton2.SetValue(BorderedButton.IsExternProperty, true);
		borderedButton2.SetValue(Button.TextProperty, hLP01_RequestUserName);
		verticalStackLayout4.Children.Add(borderedButton2);
		boxView2.SetValue(View.MarginProperty, new Thickness(0.0, 12.0));
		boxView2.SetValue(VisualElement.HeightRequestProperty, 1.0);
		staticResourceExtension5.Key = "Gray2";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[4] { boxView2, verticalStackLayout4, contentView, this }, BoxView.ColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(52, 17)));
		object obj5 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 17);
		}
		boxView2.SetValue(BoxView.ColorProperty, obj5);
		verticalStackLayout4.Children.Add(boxView2);
		staticResourceExtension6.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[5] { label6, verticalStackLayout3, verticalStackLayout4, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(55, 24)));
		object obj6 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 24);
		}
		label6.SetValue(VisualElement.StyleProperty, obj6);
		label6.SetValue(Label.TextProperty, hLP01_Gebruikersnaam_ww);
		verticalStackLayout3.Children.Add(label6);
		label7.SetValue(Label.TextProperty, hLP01_InfoGebruikersnaam_ww);
		verticalStackLayout3.Children.Add(label7);
		bindingExtension3.Path = "NoDigiDCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\HLP001.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 37);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase3);
		linkLabel.SetValue(LinkLabel.TextProperty, hLP01_LinkGebruikersnaam_ww);
		verticalStackLayout3.Children.Add(linkLabel);
		verticalStackLayout4.Children.Add(verticalStackLayout3);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout4);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<HLP001ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP001ViewModel, ICommand>((HLP001ViewModel source) => ((ICommand value, bool success))(value: source.RecoverPasswordCommand, success: true), setter, new Tuple<Func<HLP001ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP001ViewModel, object>, string>((HLP001ViewModel source) => source, "RecoverPasswordCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<HLP001ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP001ViewModel, ICommand>((HLP001ViewModel source) => ((ICommand value, bool success))(value: source.RecoverUserNameCommand, success: true), setter, new Tuple<Func<HLP001ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP001ViewModel, object>, string>((HLP001ViewModel source) => source, "RecoverUserNameCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<HLP001ViewModel, ICommand> setter = null;
			return new TypedBinding<HLP001ViewModel, ICommand>((HLP001ViewModel source) => ((ICommand value, bool success))(value: source.NoDigiDCommand, success: true), setter, new Tuple<Func<HLP001ViewModel, object>, string>[1]
			{
				new Tuple<Func<HLP001ViewModel, object>, string>((HLP001ViewModel source) => source, "NoDigiDCommand")
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
		this.LoadFromXaml(typeof(HLP001));
	}
}
