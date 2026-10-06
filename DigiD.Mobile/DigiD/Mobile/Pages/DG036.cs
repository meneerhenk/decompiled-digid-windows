using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
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

[XamlFilePath("Pages\\DG036.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG036 : BasePage<DG036ViewModel>
{
	public DG036(DG036ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG036).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG036)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 20);
		string dG036_Titel = DigiDAppResources.DG036_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG036_Titel, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 24);
		string dG010_Titel = DigiDAppResources.DG010_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG010_Titel, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 59);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 18);
		string selectedBsn = DG010ViewModel.SelectedBsn;
		VisualDiagnostics.RegisterSourceInfo(selectedBsn, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 24);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 18);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		string dG036_LinkButtonText = DigiDAppResources.DG036_LinkButtonText1;
		VisualDiagnostics.RegisterSourceInfo(dG036_LinkButtonText, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 21);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 24);
		string dG036_Geboortedatum = DigiDAppResources.DG036_Geboortedatum;
		VisualDiagnostics.RegisterSourceInfo(dG036_Geboortedatum, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 59);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 18);
		string dateOfBirth = DG036ViewModel.DateOfBirth;
		VisualDiagnostics.RegisterSourceInfo(dateOfBirth, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 24);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 18);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 21);
		string dG036_LinkButtonText2 = DigiDAppResources.DG036_LinkButtonText1;
		VisualDiagnostics.RegisterSourceInfo(dG036_LinkButtonText2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 21);
		LinkLabel linkLabel2 = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 18);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 24);
		string dG036_Adres = DigiDAppResources.DG036_Adres;
		VisualDiagnostics.RegisterSourceInfo(dG036_Adres, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 59);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 18);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 21);
		string dG012_PostcodeVeld = DigiDAppResources.DG012_PostcodeVeld;
		VisualDiagnostics.RegisterSourceInfo(dG012_PostcodeVeld, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 21);
		AppThemeBindingExtension appThemeBindingExtension = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 21);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 18);
		string selectedPostalCode = DG012ViewModel.SelectedPostalCode;
		VisualDiagnostics.RegisterSourceInfo(selectedPostalCode, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 42);
		Label label8 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label8, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 18);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 21);
		string dG012_Huisnummer = DigiDAppResources.DG012_Huisnummer;
		VisualDiagnostics.RegisterSourceInfo(dG012_Huisnummer, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 21);
		AppThemeBindingExtension appThemeBindingExtension2 = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 21);
		Label label9 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label9, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 18);
		string selectedHouseNumber = DG012ViewModel.SelectedHouseNumber;
		VisualDiagnostics.RegisterSourceInfo(selectedHouseNumber, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 42);
		Label label10 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label10, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 18);
		bool isSuffixVisible = DG036ViewModel.IsSuffixVisible;
		VisualDiagnostics.RegisterSourceInfo(isSuffixVisible, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 38);
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension7, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 25);
		string dG036_Toevoeging = DigiDAppResources.DG036_Toevoeging;
		VisualDiagnostics.RegisterSourceInfo(dG036_Toevoeging, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 25);
		AppThemeBindingExtension appThemeBindingExtension3 = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 25);
		Label label11 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label11, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 22);
		string selectedHouseNumberSuffix = DG012ViewModel.SelectedHouseNumberSuffix;
		VisualDiagnostics.RegisterSourceInfo(selectedHouseNumberSuffix, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 46);
		Label label12 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label12, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 22);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 21);
		string dG036_LinkButtonText3 = DigiDAppResources.DG036_LinkButtonText2;
		VisualDiagnostics.RegisterSourceInfo(dG036_LinkButtonText3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 21);
		LinkLabel linkLabel3 = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 18);
		VerticalStackLayout verticalStackLayout4 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout4, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 14);
		VerticalStackLayout verticalStackLayout5 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout5, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout5.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		linkLabel2.transientNamescope = nameScope;
		verticalStackLayout4.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		label8.transientNamescope = nameScope;
		label9.transientNamescope = nameScope;
		label10.transientNamescope = nameScope;
		verticalStackLayout3.transientNamescope = nameScope;
		label11.transientNamescope = nameScope;
		label12.transientNamescope = nameScope;
		linkLabel3.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout5.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout5.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout5.SetValue(StackBase.SpacingProperty, 40.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG036_Titel);
		verticalStackLayout5.Children.Add(label);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(0.0, -20.0, 0.0, 0.0));
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label2, verticalStackLayout, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 24)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 24);
		}
		label2.SetValue(VisualElement.StyleProperty, obj2);
		label2.SetValue(Label.TextProperty, dG010_Titel);
		verticalStackLayout.Children.Add(label2);
		label3.SetValue(Label.TextProperty, selectedBsn);
		verticalStackLayout.Children.Add(label3);
		linkLabel.SetValue(Element.AutomationIdProperty, "BackToDG010Link");
		bindingExtension.Path = "BackToPageCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase);
		linkLabel.SetValue(LinkLabel.CommandArgumentsProperty, "DG010");
		linkLabel.SetValue(LinkLabel.TextProperty, dG036_LinkButtonText);
		verticalStackLayout.Children.Add(linkLabel);
		verticalStackLayout5.Children.Add(verticalStackLayout);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension3.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { label4, verticalStackLayout2, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 24)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 24);
		}
		label4.SetValue(VisualElement.StyleProperty, obj3);
		label4.SetValue(Label.TextProperty, dG036_Geboortedatum);
		verticalStackLayout2.Children.Add(label4);
		label5.SetValue(Label.TextProperty, dateOfBirth);
		verticalStackLayout2.Children.Add(label5);
		linkLabel2.SetValue(Element.AutomationIdProperty, "BackToDG011Link");
		bindingExtension2.Path = "BackToPageCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 21);
		}
		linkLabel2.SetBinding(LinkLabel.CommandProperty, bindingBase2);
		linkLabel2.SetValue(LinkLabel.CommandArgumentsProperty, "DG011");
		linkLabel2.SetValue(LinkLabel.TextProperty, dG036_LinkButtonText2);
		verticalStackLayout2.Children.Add(linkLabel2);
		verticalStackLayout5.Children.Add(verticalStackLayout2);
		verticalStackLayout4.SetValue(StackBase.SpacingProperty, 5.0);
		staticResourceExtension4.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[5] { label6, verticalStackLayout4, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(40, 24)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 24);
		}
		label6.SetValue(VisualElement.StyleProperty, obj4);
		label6.SetValue(Label.TextProperty, dG036_Adres);
		verticalStackLayout4.Children.Add(label6);
		staticResourceExtension5.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[5] { label7, verticalStackLayout4, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 21)));
		object obj5 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 21);
		}
		label7.SetValue(VisualElement.StyleProperty, obj5);
		label7.SetValue(Label.TextProperty, dG012_PostcodeVeld);
		appThemeBindingExtension.Dark = "#C4C4C4";
		appThemeBindingExtension.Light = "#696969";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[5] { label7, verticalStackLayout4, verticalStackLayout5, contentView, this }, Label.TextColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(45, 21)));
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)appThemeBindingExtension).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 21);
		}
		label7.SetBinding(Label.TextColorProperty, bindingBase3);
		verticalStackLayout4.Children.Add(label7);
		label8.SetValue(View.MarginProperty, new Thickness(0.0, -3.0, 0.0, 0.0));
		label8.SetValue(Label.TextProperty, selectedPostalCode);
		verticalStackLayout4.Children.Add(label8);
		label9.SetValue(View.MarginProperty, new Thickness(0.0, 15.0, 0.0, 0.0));
		staticResourceExtension6.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[5] { label9, verticalStackLayout4, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(51, 21)));
		object obj6 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 21);
		}
		label9.SetValue(VisualElement.StyleProperty, obj6);
		label9.SetValue(Label.TextProperty, dG012_Huisnummer);
		appThemeBindingExtension2.Dark = "#C4C4C4";
		appThemeBindingExtension2.Light = "#696969";
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[5] { label9, verticalStackLayout4, verticalStackLayout5, contentView, this }, Label.TextColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(53, 21)));
		BindingBase bindingBase4 = ((IMarkupExtension<BindingBase>)appThemeBindingExtension2).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 21);
		}
		label9.SetBinding(Label.TextColorProperty, bindingBase4);
		verticalStackLayout4.Children.Add(label9);
		label10.SetValue(View.MarginProperty, new Thickness(0.0, -3.0, 0.0, 0.0));
		label10.SetValue(Label.TextProperty, selectedHouseNumber);
		verticalStackLayout4.Children.Add(label10);
		verticalStackLayout3.SetValue(VisualElement.IsVisibleProperty, isSuffixVisible);
		label11.SetValue(View.MarginProperty, new Thickness(0.0, 15.0, 0.0, 0.0));
		staticResourceExtension7.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service9 = new SimpleValueTargetProvider(new object[6] { label11, verticalStackLayout3, verticalStackLayout4, verticalStackLayout5, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
		xamlServiceProvider9.Add(typeof(IProvideValueTarget), service9);
		xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(60, 25)));
		object obj7 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider9);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 25);
		}
		label11.SetValue(VisualElement.StyleProperty, obj7);
		label11.SetValue(Label.TextProperty, dG036_Toevoeging);
		appThemeBindingExtension3.Dark = "#C4C4C4";
		appThemeBindingExtension3.Light = "#696969";
		XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service10 = new SimpleValueTargetProvider(new object[6] { label11, verticalStackLayout3, verticalStackLayout4, verticalStackLayout5, contentView, this }, Label.TextColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
		xamlServiceProvider10.Add(typeof(IProvideValueTarget), service10);
		xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(62, 25)));
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)appThemeBindingExtension3).ProvideValue((IServiceProvider)xamlServiceProvider10);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 25);
		}
		label11.SetBinding(Label.TextColorProperty, bindingBase5);
		verticalStackLayout3.Children.Add(label11);
		label12.SetValue(View.MarginProperty, new Thickness(0.0, -3.0, 0.0, 0.0));
		label12.SetValue(Label.TextProperty, selectedHouseNumberSuffix);
		verticalStackLayout3.Children.Add(label12);
		verticalStackLayout4.Children.Add(verticalStackLayout3);
		linkLabel3.SetValue(Element.AutomationIdProperty, "BackToDG012Link");
		bindingExtension3.Path = "BackToPageCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG036.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 21);
		}
		linkLabel3.SetBinding(LinkLabel.CommandProperty, bindingBase6);
		linkLabel3.SetValue(LinkLabel.CommandArgumentsProperty, "DG012");
		linkLabel3.SetValue(LinkLabel.TextProperty, dG036_LinkButtonText3);
		verticalStackLayout4.Children.Add(linkLabel3);
		verticalStackLayout5.Children.Add(verticalStackLayout4);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout5);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG036ViewModel, ICommand> setter = null;
			return new TypedBinding<DG036ViewModel, ICommand>((DG036ViewModel source) => ((ICommand value, bool success))(value: source.BackToPageCommand, success: true), setter, new Tuple<Func<DG036ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG036ViewModel, object>, string>((DG036ViewModel source) => source, "BackToPageCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG036ViewModel, ICommand> setter = null;
			return new TypedBinding<DG036ViewModel, ICommand>((DG036ViewModel source) => ((ICommand value, bool success))(value: source.BackToPageCommand, success: true), setter, new Tuple<Func<DG036ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG036ViewModel, object>, string>((DG036ViewModel source) => source, "BackToPageCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG036ViewModel, ICommand> setter = null;
			return new TypedBinding<DG036ViewModel, ICommand>((DG036ViewModel source) => ((ICommand value, bool success))(value: source.BackToPageCommand, success: true), setter, new Tuple<Func<DG036ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG036ViewModel, object>, string>((DG036ViewModel source) => source, "BackToPageCommand")
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
		this.LoadFromXaml(typeof(DG036));
	}
}
