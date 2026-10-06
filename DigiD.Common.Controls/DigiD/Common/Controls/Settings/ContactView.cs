using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Common.Controls.Settings;

[XamlFilePath("Settings\\ContactView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class ContactView : BaseSettingsView
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private MenuItemContactView TeletolkView;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openContactFormCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openPhoneCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openTeletolkCommand;

	protected bool CanExecute { get; set; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenContactFormCommand => openContactFormCommand ?? (openContactFormCommand = new AsyncRelayCommand(OpenContactFormAsync, () => CanExecute));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenPhoneCommand => openPhoneCommand ?? (openPhoneCommand = new AsyncRelayCommand(OpenPhoneAsync, () => CanExecute));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenTeletolkCommand => openTeletolkCommand ?? (openTeletolkCommand = new AsyncRelayCommand(OpenTeletolkAsync));

	public ContactView()
	{
		base.BindingContext = this;
		CanExecute = true;
		InitializeComponent();
		TeletolkView.IsVisible = ((IApp)Application.Current).GeneralPreferences.Language.Equals("nl", StringComparison.CurrentCultureIgnoreCase);
	}

	[RelayCommand(CanExecute = "CanExecute")]
	private async Task OpenContactFormAsync()
	{
		if (CanExecute)
		{
			CanExecute = false;
			await Browser.OpenAsync(CommonResources.ContactView_ContactFormUrl);
			await Task.Delay(1000);
			CanExecute = true;
		}
	}

	[RelayCommand(CanExecute = "CanExecute")]
	private async Task OpenPhoneAsync()
	{
		if (CanExecute)
		{
			CanExecute = false;
			await Launcher.OpenAsync("nScZvCdZH0skLz1d13mZog==".DeObfuscate("6UJ1hgxqLnMcHg9u4Uysl8eph8lXFG4L/RoM8Ry1knA="));
			await Task.Delay(1000);
			CanExecute = true;
		}
	}

	[RelayCommand]
	private static async Task OpenTeletolkAsync()
	{
		Uri url = new Uri("https://mijn.tolkopafstand.nl/b04bc3d6e21d7f7e8e13bea5187cd3ae");
		await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("TeletolkView")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(ContactView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(ContactView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 16);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 53);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 10);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 16);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 10);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 13);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 13);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 13);
		MenuItemContactView menuItemContactView = new MenuItemContactView();
		VisualDiagnostics.RegisterSourceInfo(menuItemContactView, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 10);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 13);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 13);
		TranslateExtension translateExtension5 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension5, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 13);
		TranslateExtension translateExtension6 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension6, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 13);
		MenuItemContactView menuItemContactView2 = new MenuItemContactView();
		VisualDiagnostics.RegisterSourceInfo(menuItemContactView2, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 10);
		TranslateExtension translateExtension7 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension7, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 13);
		TranslateExtension translateExtension8 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension8, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 13);
		MenuItemContactView menuItemContactView3 = new MenuItemContactView();
		VisualDiagnostics.RegisterSourceInfo(menuItemContactView3, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 10);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 3, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		menuItemContactView.transientNamescope = nameScope;
		menuItemContactView2.transientNamescope = nameScope;
		menuItemContactView3.transientNamescope = nameScope;
		nameScope.RegisterName("TeletolkView", menuItemContactView3);
		MenuItemContactView menuItemContactView4 = menuItemContactView3;
		if (menuItemContactView4.StyleId == null)
		{
			string text = (menuItemContactView4.StyleId = "TeletolkView");
		}
		TeletolkView = menuItemContactView3;
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { label, verticalStackLayout, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(13, 16)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 16);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension.Text = "ContactView_Titel";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 53);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label);
		bindingExtension.Path = "Intro";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 16);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label2);
		translateExtension2.Text = "ContactView_Formulier_Titel";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 13);
		}
		menuItemContactView.SetBinding(MenuItemContactView.TitleProperty, bindingBase3);
		menuItemContactView.SetValue(Element.AutomationIdProperty, "ContactForm");
		menuItemContactView.SetValue(MenuItemContactView.ImageProperty, ImageSource.FromFile("digid_icon_contact_form.png"));
		bindingExtension2.Path = "OpenContactFormCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 13);
		}
		menuItemContactView.SetBinding(MenuItemContactView.ItemCommandProperty, bindingBase4);
		translateExtension3.Text = "ContactView_Formulier_Body";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 13);
		}
		menuItemContactView.SetBinding(MenuItemContactView.TextProperty, bindingBase5);
		verticalStackLayout.Children.Add(menuItemContactView);
		translateExtension4.Text = "ContactView_Telefoon_Titel";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 13);
		}
		menuItemContactView2.SetBinding(MenuItemContactView.TitleProperty, bindingBase6);
		menuItemContactView2.SetValue(Element.AutomationIdProperty, "ContactPhone");
		menuItemContactView2.SetValue(MenuItemContactView.ImageProperty, ImageSource.FromFile("digid_icon_contact_telefoon.png"));
		bindingExtension3.Path = "OpenPhoneCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 13);
		}
		menuItemContactView2.SetBinding(MenuItemContactView.ItemCommandProperty, bindingBase7);
		translateExtension5.Text = "ContactView_Telefoon_Nummer";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension5).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 13);
		}
		menuItemContactView2.SetBinding(MenuItemContactView.LinkProperty, bindingBase8);
		translateExtension6.Text = "ContactView_Telefoon_Body";
		BindingBase bindingBase9 = ((IMarkupExtension<BindingBase>)translateExtension6).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 13);
		}
		menuItemContactView2.SetBinding(MenuItemContactView.TextProperty, bindingBase9);
		verticalStackLayout.Children.Add(menuItemContactView2);
		translateExtension7.Text = "DG062_ContactTeletolk_Titel";
		BindingBase bindingBase10 = ((IMarkupExtension<BindingBase>)translateExtension7).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		}
		menuItemContactView3.SetBinding(MenuItemContactView.TitleProperty, bindingBase10);
		menuItemContactView3.SetValue(Element.AutomationIdProperty, "ContactTeletolk");
		menuItemContactView3.SetValue(MenuItemContactView.ImageProperty, ImageSource.FromFile("digid_icon_contact_teletolk.png"));
		bindingExtension4.Path = "OpenTeletolkCommand";
		BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 13);
		}
		menuItemContactView3.SetBinding(MenuItemContactView.ItemCommandProperty, bindingBase11);
		translateExtension8.Text = "DG062_ContactTeletolk_Info";
		BindingBase bindingBase12 = ((IMarkupExtension<BindingBase>)translateExtension8).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Settings\\ContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 13);
		}
		menuItemContactView3.SetBinding(MenuItemContactView.TextProperty, bindingBase12);
		verticalStackLayout.Children.Add(menuItemContactView3);
		SetValue(ContentView.ContentProperty, verticalStackLayout);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<ContactView, string> setter = delegate(ContactView source, string value)
			{
				source.Intro = value;
			};
			return new TypedBinding<ContactView, string>((ContactView source) => (value: source.Intro, success: true), setter, new Tuple<Func<ContactView, object>, string>[1]
			{
				new Tuple<Func<ContactView, object>, string>((ContactView source) => source, "Intro")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<ContactView, ICommand> setter = null;
			return new TypedBinding<ContactView, ICommand>((ContactView source) => ((ICommand value, bool success))(value: source.OpenContactFormCommand, success: true), setter, new Tuple<Func<ContactView, object>, string>[1]
			{
				new Tuple<Func<ContactView, object>, string>((ContactView source) => source, "OpenContactFormCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<ContactView, ICommand> setter = null;
			return new TypedBinding<ContactView, ICommand>((ContactView source) => ((ICommand value, bool success))(value: source.OpenPhoneCommand, success: true), setter, new Tuple<Func<ContactView, object>, string>[1]
			{
				new Tuple<Func<ContactView, object>, string>((ContactView source) => source, "OpenPhoneCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<ContactView, ICommand> setter = null;
			return new TypedBinding<ContactView, ICommand>((ContactView source) => ((ICommand value, bool success))(value: source.OpenTeletolkCommand, success: true), setter, new Tuple<Func<ContactView, object>, string>[1]
			{
				new Tuple<Func<ContactView, object>, string>((ContactView source) => source, "OpenTeletolkCommand")
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
	[MemberNotNull("TeletolkView")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(ContactView));
		TeletolkView = this.FindByName<MenuItemContactView>("TeletolkView");
	}
}
