using System;
using System.CodeDom.Compiler;
using System.Reflection;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Controls.Settings;

[XamlFilePath("Settings\\SupportView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class SupportView : BaseSettingsView
{
	private readonly IGeneralPreferences _generalPreferences;

	private readonly INfcLocationService _nfcLocationService;

	private readonly IDeviceService _deviceService;

	public static string AppVersionNumber => AppInfo.VersionString + " (" + AppInfo.BuildString + ")";

	public string AppCode => _generalPreferences.InstanceId.Substring(0, 6).ToUpperInvariant() ?? "";

	public static string PlatformVersion => $"{DeviceInfo.Platform} {DeviceInfo.VersionString}";

	public static string Model => DeviceInfo.Model;

	public string NfcPosition => _nfcLocationService.Position.Translate();

	public string DeviceName => _deviceService.DeviceName.ReplaceEmoticons();

	public SupportView()
	{
		base.BindingContext = this;
		ArgumentNullException.ThrowIfNull((IApp)Application.Current, "(IApp)Application.Current!");
		_generalPreferences = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IGeneralPreferences>();
		_nfcLocationService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<INfcLocationService>();
		_deviceService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IDeviceService>();
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(SupportView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(SupportView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 13);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 13);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 10);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 16);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 10);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 27);
		string supportView_Version = CommonResources.SupportView_Version;
		VisualDiagnostics.RegisterSourceInfo(supportView_Version, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 61);
		Span span = new Span();
		VisualDiagnostics.RegisterSourceInfo(span, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 22);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 27);
		Span span2 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 22);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 27);
		string appVersionNumber = AppVersionNumber;
		VisualDiagnostics.RegisterSourceInfo(appVersionNumber, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 64);
		Span span3 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 22);
		FormattedString formattedString = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 18);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 10);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 27);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 61);
		Span span4 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 22);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 27);
		Span span5 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 22);
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension7, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 27);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 64);
		Span span6 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 22);
		FormattedString formattedString2 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 18);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 10);
		StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension8, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 27);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 61);
		Span span7 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span7, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 22);
		StaticResourceExtension staticResourceExtension9 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension9, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 27);
		Span span8 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span8, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 22);
		StaticResourceExtension staticResourceExtension10 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension10, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 47, 27);
		string platformVersion = PlatformVersion;
		VisualDiagnostics.RegisterSourceInfo(platformVersion, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 47, 64);
		Span span9 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span9, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 47, 22);
		FormattedString formattedString3 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 18);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 10);
		StaticResourceExtension staticResourceExtension11 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension11, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 27);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 61);
		Span span10 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span10, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 22);
		StaticResourceExtension staticResourceExtension12 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension12, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 27);
		Span span11 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span11, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 22);
		StaticResourceExtension staticResourceExtension13 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension13, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 27);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 64);
		Span span12 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span12, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 22);
		FormattedString formattedString4 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 54, 18);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 52, 10);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 16);
		StaticResourceExtension staticResourceExtension14 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension14, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 27);
		TranslateExtension translateExtension5 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 61);
		Span span13 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span13, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 22);
		StaticResourceExtension staticResourceExtension15 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension15, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 27);
		Span span14 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span14, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 22);
		StaticResourceExtension staticResourceExtension16 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension16, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 27);
		string model = Model;
		VisualDiagnostics.RegisterSourceInfo(model, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 64);
		Span span15 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span15, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 22);
		FormattedString formattedString5 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 18);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 10);
		OnIdiomExtension onIdiomExtension2 = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 16);
		StaticResourceExtension staticResourceExtension17 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension17, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 27);
		TranslateExtension translateExtension6 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 61);
		Span span16 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span16, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 22);
		StaticResourceExtension staticResourceExtension18 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension18, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 27);
		Span span17 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span17, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 22);
		StaticResourceExtension staticResourceExtension19 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension19, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 27);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 64);
		Span span18 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span18, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 22);
		FormattedString formattedString6 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 74, 18);
		Label label8 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label8, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 10);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 3, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		formattedString.transientNamescope = nameScope;
		span.transientNamescope = nameScope;
		span2.transientNamescope = nameScope;
		span3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		formattedString2.transientNamescope = nameScope;
		span4.transientNamescope = nameScope;
		span5.transientNamescope = nameScope;
		span6.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		formattedString3.transientNamescope = nameScope;
		span7.transientNamescope = nameScope;
		span8.transientNamescope = nameScope;
		span9.transientNamescope = nameScope;
		label6.transientNamescope = nameScope;
		formattedString4.transientNamescope = nameScope;
		span10.transientNamescope = nameScope;
		span11.transientNamescope = nameScope;
		span12.transientNamescope = nameScope;
		label7.transientNamescope = nameScope;
		formattedString5.transientNamescope = nameScope;
		span13.transientNamescope = nameScope;
		span14.transientNamescope = nameScope;
		span15.transientNamescope = nameScope;
		label8.transientNamescope = nameScope;
		formattedString6.transientNamescope = nameScope;
		span16.transientNamescope = nameScope;
		span17.transientNamescope = nameScope;
		span18.transientNamescope = nameScope;
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { label, verticalStackLayout, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 13)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 13);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "SupportView_Title";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 13);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label);
		bindingExtension.Path = "Intro";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 16);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label2);
		staticResourceExtension2.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { span, formattedString, label3, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 27)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 27);
		}
		span.SetValue(Span.StyleProperty, obj2);
		span.SetValue(Span.TextProperty, supportView_Version);
		formattedString.Spans.Add(span);
		staticResourceExtension3.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { span2, formattedString, label3, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 27)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 27);
		}
		span2.SetValue(Span.StyleProperty, obj3);
		span2.SetValue(Span.TextProperty, " ");
		formattedString.Spans.Add(span2);
		staticResourceExtension4.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[5] { span3, formattedString, label3, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(27, 27)));
		object obj4 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 27);
		}
		span3.SetValue(Span.StyleProperty, obj4);
		span3.SetValue(Span.TextProperty, appVersionNumber);
		formattedString.Spans.Add(span3);
		label3.SetValue(Label.FormattedTextProperty, formattedString);
		verticalStackLayout.Children.Add(label3);
		staticResourceExtension5.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[5] { span4, formattedString2, label4, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(35, 27)));
		object obj5 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 27);
		}
		span4.SetValue(Span.StyleProperty, obj5);
		translateExtension2.Text = "SupportView_AppCode";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 61);
		}
		span4.SetBinding(Span.TextProperty, bindingBase3);
		formattedString2.Spans.Add(span4);
		staticResourceExtension6.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[5] { span5, formattedString2, label4, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(36, 27)));
		object obj6 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 27);
		}
		span5.SetValue(Span.StyleProperty, obj6);
		span5.SetValue(Span.TextProperty, " ");
		formattedString2.Spans.Add(span5);
		staticResourceExtension7.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[5] { span6, formattedString2, label4, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 27)));
		object obj7 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 27);
		}
		span6.SetValue(Span.StyleProperty, obj7);
		bindingExtension2.Path = "AppCode";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 64);
		}
		span6.SetBinding(Span.TextProperty, bindingBase4);
		formattedString2.Spans.Add(span6);
		label4.SetValue(Label.FormattedTextProperty, formattedString2);
		verticalStackLayout.Children.Add(label4);
		staticResourceExtension8.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[5] { span7, formattedString3, label5, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(45, 27)));
		object obj8 = ((IMarkupExtension)staticResourceExtension8).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(obj8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 27);
		}
		span7.SetValue(Span.StyleProperty, obj8);
		translateExtension3.Text = "SupportView_OS";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 61);
		}
		span7.SetBinding(Span.TextProperty, bindingBase5);
		formattedString3.Spans.Add(span7);
		staticResourceExtension9.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service9 = new SimpleValueTargetProvider(new object[5] { span8, formattedString3, label5, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
		xamlServiceProvider9.Add(typeof(IProvideValueTarget), service9);
		xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 27)));
		object obj9 = ((IMarkupExtension)staticResourceExtension9).ProvideValue((IServiceProvider)xamlServiceProvider9);
		if (VisualDiagnostics.GetSourceInfo(obj9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj9, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 27);
		}
		span8.SetValue(Span.StyleProperty, obj9);
		span8.SetValue(Span.TextProperty, " ");
		formattedString3.Spans.Add(span8);
		staticResourceExtension10.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service10 = new SimpleValueTargetProvider(new object[5] { span9, formattedString3, label5, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
		xamlServiceProvider10.Add(typeof(IProvideValueTarget), service10);
		xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 27)));
		object obj10 = ((IMarkupExtension)staticResourceExtension10).ProvideValue((IServiceProvider)xamlServiceProvider10);
		if (VisualDiagnostics.GetSourceInfo(obj10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj10, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 47, 27);
		}
		span9.SetValue(Span.StyleProperty, obj10);
		span9.SetValue(Span.TextProperty, platformVersion);
		formattedString3.Spans.Add(span9);
		label5.SetValue(Label.FormattedTextProperty, formattedString3);
		verticalStackLayout.Children.Add(label5);
		staticResourceExtension11.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider11 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service11 = new SimpleValueTargetProvider(new object[5] { span10, formattedString4, label6, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider11.Add(typeof(IReferenceProvider), service11);
		xamlServiceProvider11.Add(typeof(IProvideValueTarget), service11);
		xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(55, 27)));
		object obj11 = ((IMarkupExtension)staticResourceExtension11).ProvideValue((IServiceProvider)xamlServiceProvider11);
		if (VisualDiagnostics.GetSourceInfo(obj11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj11, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 27);
		}
		span10.SetValue(Span.StyleProperty, obj11);
		translateExtension4.Text = "SupportView_Name";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 61);
		}
		span10.SetBinding(Span.TextProperty, bindingBase6);
		formattedString4.Spans.Add(span10);
		staticResourceExtension12.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider12 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service12 = new SimpleValueTargetProvider(new object[5] { span11, formattedString4, label6, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider12.Add(typeof(IReferenceProvider), service12);
		xamlServiceProvider12.Add(typeof(IProvideValueTarget), service12);
		xamlServiceProvider12.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(56, 27)));
		object obj12 = ((IMarkupExtension)staticResourceExtension12).ProvideValue((IServiceProvider)xamlServiceProvider12);
		if (VisualDiagnostics.GetSourceInfo(obj12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj12, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 27);
		}
		span11.SetValue(Span.StyleProperty, obj12);
		span11.SetValue(Span.TextProperty, " ");
		formattedString4.Spans.Add(span11);
		staticResourceExtension13.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider13 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service13 = new SimpleValueTargetProvider(new object[5] { span12, formattedString4, label6, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider13.Add(typeof(IReferenceProvider), service13);
		xamlServiceProvider13.Add(typeof(IProvideValueTarget), service13);
		xamlServiceProvider13.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(57, 27)));
		object obj13 = ((IMarkupExtension)staticResourceExtension13).ProvideValue((IServiceProvider)xamlServiceProvider13);
		if (VisualDiagnostics.GetSourceInfo(obj13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj13, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 27);
		}
		span12.SetValue(Span.StyleProperty, obj13);
		bindingExtension3.Path = "DeviceName";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 64);
		}
		span12.SetBinding(Span.TextProperty, bindingBase7);
		formattedString4.Spans.Add(span12);
		label6.SetValue(Label.FormattedTextProperty, formattedString4);
		verticalStackLayout.Children.Add(label6);
		onIdiomExtension.Desktop = "false";
		onIdiomExtension.Default = "true";
		XamlServiceProvider xamlServiceProvider14 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service14 = new SimpleValueTargetProvider(new object[3] { label7, verticalStackLayout, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider14.Add(typeof(IReferenceProvider), service14);
		xamlServiceProvider14.Add(typeof(IProvideValueTarget), service14);
		xamlServiceProvider14.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(62, 16)));
		object obj14 = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider14);
		if (VisualDiagnostics.GetSourceInfo(obj14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj14, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 16);
		}
		label7.SetValue(VisualElement.IsVisibleProperty, obj14);
		staticResourceExtension14.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider15 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service15 = new SimpleValueTargetProvider(new object[5] { span13, formattedString5, label7, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider15.Add(typeof(IReferenceProvider), service15);
		xamlServiceProvider15.Add(typeof(IProvideValueTarget), service15);
		xamlServiceProvider15.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(65, 27)));
		object obj15 = ((IMarkupExtension)staticResourceExtension14).ProvideValue((IServiceProvider)xamlServiceProvider15);
		if (VisualDiagnostics.GetSourceInfo(obj15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj15, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 27);
		}
		span13.SetValue(Span.StyleProperty, obj15);
		translateExtension5.Text = "SupportView_Model";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension5).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 61);
		}
		span13.SetBinding(Span.TextProperty, bindingBase8);
		formattedString5.Spans.Add(span13);
		staticResourceExtension15.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider16 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service16 = new SimpleValueTargetProvider(new object[5] { span14, formattedString5, label7, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider16.Add(typeof(IReferenceProvider), service16);
		xamlServiceProvider16.Add(typeof(IProvideValueTarget), service16);
		xamlServiceProvider16.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(66, 27)));
		object obj16 = ((IMarkupExtension)staticResourceExtension15).ProvideValue((IServiceProvider)xamlServiceProvider16);
		if (VisualDiagnostics.GetSourceInfo(obj16) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj16, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 27);
		}
		span14.SetValue(Span.StyleProperty, obj16);
		span14.SetValue(Span.TextProperty, " ");
		formattedString5.Spans.Add(span14);
		staticResourceExtension16.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider17 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service17 = new SimpleValueTargetProvider(new object[5] { span15, formattedString5, label7, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider17.Add(typeof(IReferenceProvider), service17);
		xamlServiceProvider17.Add(typeof(IProvideValueTarget), service17);
		xamlServiceProvider17.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(67, 27)));
		object obj17 = ((IMarkupExtension)staticResourceExtension16).ProvideValue((IServiceProvider)xamlServiceProvider17);
		if (VisualDiagnostics.GetSourceInfo(obj17) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj17, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 27);
		}
		span15.SetValue(Span.StyleProperty, obj17);
		span15.SetValue(Span.TextProperty, model);
		formattedString5.Spans.Add(span15);
		label7.SetValue(Label.FormattedTextProperty, formattedString5);
		verticalStackLayout.Children.Add(label7);
		onIdiomExtension2.Desktop = "false";
		onIdiomExtension2.Default = "true";
		XamlServiceProvider xamlServiceProvider18 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service18 = new SimpleValueTargetProvider(new object[3] { label8, verticalStackLayout, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider18.Add(typeof(IReferenceProvider), service18);
		xamlServiceProvider18.Add(typeof(IProvideValueTarget), service18);
		xamlServiceProvider18.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(72, 16)));
		object obj18 = ((IMarkupExtension)onIdiomExtension2).ProvideValue((IServiceProvider)xamlServiceProvider18);
		if (VisualDiagnostics.GetSourceInfo(obj18) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj18, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 16);
		}
		label8.SetValue(VisualElement.IsVisibleProperty, obj18);
		staticResourceExtension17.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider19 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service19 = new SimpleValueTargetProvider(new object[5] { span16, formattedString6, label8, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider19.Add(typeof(IReferenceProvider), service19);
		xamlServiceProvider19.Add(typeof(IProvideValueTarget), service19);
		xamlServiceProvider19.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(75, 27)));
		object obj19 = ((IMarkupExtension)staticResourceExtension17).ProvideValue((IServiceProvider)xamlServiceProvider19);
		if (VisualDiagnostics.GetSourceInfo(obj19) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj19, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 27);
		}
		span16.SetValue(Span.StyleProperty, obj19);
		translateExtension6.Text = "SupportView_NFCLocation";
		BindingBase bindingBase9 = ((IMarkupExtension<BindingBase>)translateExtension6).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 61);
		}
		span16.SetBinding(Span.TextProperty, bindingBase9);
		formattedString6.Spans.Add(span16);
		staticResourceExtension18.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider20 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service20 = new SimpleValueTargetProvider(new object[5] { span17, formattedString6, label8, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider20.Add(typeof(IReferenceProvider), service20);
		xamlServiceProvider20.Add(typeof(IProvideValueTarget), service20);
		xamlServiceProvider20.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(76, 27)));
		object obj20 = ((IMarkupExtension)staticResourceExtension18).ProvideValue((IServiceProvider)xamlServiceProvider20);
		if (VisualDiagnostics.GetSourceInfo(obj20) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj20, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 27);
		}
		span17.SetValue(Span.StyleProperty, obj20);
		span17.SetValue(Span.TextProperty, " ");
		formattedString6.Spans.Add(span17);
		staticResourceExtension19.Key = "SpanRegular";
		XamlServiceProvider xamlServiceProvider21 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service21 = new SimpleValueTargetProvider(new object[5] { span18, formattedString6, label8, verticalStackLayout, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider21.Add(typeof(IReferenceProvider), service21);
		xamlServiceProvider21.Add(typeof(IProvideValueTarget), service21);
		xamlServiceProvider21.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(77, 27)));
		object obj21 = ((IMarkupExtension)staticResourceExtension19).ProvideValue((IServiceProvider)xamlServiceProvider21);
		if (VisualDiagnostics.GetSourceInfo(obj21) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj21, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 27);
		}
		span18.SetValue(Span.StyleProperty, obj21);
		bindingExtension4.Path = "NfcPosition";
		BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Settings\\SupportView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 64);
		}
		span18.SetBinding(Span.TextProperty, bindingBase10);
		formattedString6.Spans.Add(span18);
		label8.SetValue(Label.FormattedTextProperty, formattedString6);
		verticalStackLayout.Children.Add(label8);
		SetValue(ContentView.ContentProperty, verticalStackLayout);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<SupportView, string> setter = delegate(SupportView source, string value)
			{
				source.Intro = value;
			};
			return new TypedBinding<SupportView, string>((SupportView source) => (value: source.Intro, success: true), setter, new Tuple<Func<SupportView, object>, string>[1]
			{
				new Tuple<Func<SupportView, object>, string>((SupportView source) => source, "Intro")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<SupportView, string> setter = null;
			return new TypedBinding<SupportView, string>((SupportView source) => (value: source.AppCode, success: true), setter, new Tuple<Func<SupportView, object>, string>[1]
			{
				new Tuple<Func<SupportView, object>, string>((SupportView source) => source, "AppCode")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<SupportView, string> setter = null;
			return new TypedBinding<SupportView, string>((SupportView source) => (value: source.DeviceName, success: true), setter, new Tuple<Func<SupportView, object>, string>[1]
			{
				new Tuple<Func<SupportView, object>, string>((SupportView source) => source, "DeviceName")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<SupportView, string> setter = null;
			return new TypedBinding<SupportView, string>((SupportView source) => (value: source.NfcPosition, success: true), setter, new Tuple<Func<SupportView, object>, string>[1]
			{
				new Tuple<Func<SupportView, object>, string>((SupportView source) => source, "NfcPosition")
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
		this.LoadFromXaml(typeof(SupportView));
	}
}
