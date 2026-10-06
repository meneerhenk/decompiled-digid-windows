using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Resources;
using DigiD.Mobile.Controls;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG029.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG029 : BasePage<DG029ViewModel>
{
	public DG029(DG029ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG029).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG029)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 17);
		string dG029_Titel = DigiDAppResources.DG029_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG029_Titel, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 34);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		string dG029_Subtitel = DigiDAppResources.DG029_Subtitel;
		VisualDiagnostics.RegisterSourceInfo(dG029_Subtitel, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 21);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 18);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 45);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		DynamicResource dynamicResource = new DynamicResource("digidIconMenuBerichtenRectangle");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 21);
		string dG029_KeuzeHerinnering = DigiDAppResources.DG029_KeuzeHerinnering;
		VisualDiagnostics.RegisterSourceInfo(dG029_KeuzeHerinnering, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 21);
		MenuSwitchControl menuSwitchControl = new MenuSwitchControl();
		VisualDiagnostics.RegisterSourceInfo(menuSwitchControl, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		string dG029_InfoSluiten = DigiDAppResources.DG029_InfoSluiten;
		VisualDiagnostics.RegisterSourceInfo(dG029_InfoSluiten, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 34);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		Button button = new Button();
		VisualDiagnostics.RegisterSourceInfo(button, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		menuSwitchControl.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		button.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		label.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG029_Titel);
		verticalStackLayout2.Children.Add(label);
		label2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		bindingExtension.Path = "IntroText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 34);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout2.Children.Add(label2);
		onPlatformExtension.MacCatalyst = "false";
		onPlatformExtension.WinUI = "false";
		onPlatformExtension.Default = "true";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { verticalStackLayout, verticalStackLayout2, contentView, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 34)));
		object obj2 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 34);
		}
		verticalStackLayout.SetValue(VisualElement.IsVisibleProperty, obj2);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		label3.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { label3, verticalStackLayout, verticalStackLayout2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 21)));
		object obj3 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 21);
		}
		label3.SetValue(VisualElement.StyleProperty, obj3);
		label3.SetValue(Label.TextProperty, dG029_Subtitel);
		verticalStackLayout.Children.Add(label3);
		label4.SetValue(View.MarginProperty, new Thickness(20.0, -10.0, 20.0, 0.0));
		bindingExtension2.Path = "ReminderText";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 45);
		}
		label4.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label4);
		menuSwitchControl.SetValue(Element.AutomationIdProperty, "Notification");
		bindingExtension3.Path = "ReceiveReminder";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 21);
		}
		menuSwitchControl.SetBinding(MenuSwitchControl.CheckedProperty, bindingBase3);
		((IDynamicResourceHandler)menuSwitchControl).SetDynamicResource(MenuSwitchControl.ImageSourceProperty, dynamicResource.Key);
		menuSwitchControl.SetValue(MenuSwitchControl.TextProperty, dG029_KeuzeHerinnering);
		verticalStackLayout.Children.Add(menuSwitchControl);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		label5.SetValue(View.MarginProperty, new Thickness(20.0, 0.0));
		label5.SetValue(Label.TextProperty, dG029_InfoSluiten);
		verticalStackLayout2.Children.Add(label5);
		button.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		button.SetValue(Element.AutomationIdProperty, "NextButton");
		bindingExtension4.Path = "NextCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		button.SetBinding(Button.CommandProperty, bindingBase4);
		bindingExtension5.Path = "ButtonVisible";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG029.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		}
		button.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		button.SetValue(Button.TextProperty, alg_Next);
		verticalStackLayout2.Children.Add(button);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG029ViewModel, string> setter = delegate(DG029ViewModel source, string value)
			{
				source.IntroText = value;
			};
			return new TypedBinding<DG029ViewModel, string>((DG029ViewModel source) => (value: source.IntroText, success: true), setter, new Tuple<Func<DG029ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG029ViewModel, object>, string>((DG029ViewModel source) => source, "IntroText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG029ViewModel, string> setter = delegate(DG029ViewModel source, string value)
			{
				source.ReminderText = value;
			};
			return new TypedBinding<DG029ViewModel, string>((DG029ViewModel source) => (value: source.ReminderText, success: true), setter, new Tuple<Func<DG029ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG029ViewModel, object>, string>((DG029ViewModel source) => source, "ReminderText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG029ViewModel, bool> setter = delegate(DG029ViewModel source, bool value)
			{
				source.ReceiveReminder = value;
			};
			return new TypedBinding<DG029ViewModel, bool>((DG029ViewModel source) => (value: source.ReceiveReminder, success: true), setter, new Tuple<Func<DG029ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG029ViewModel, object>, string>((DG029ViewModel source) => source, "ReceiveReminder")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG029ViewModel, ICommand> setter = null;
			return new TypedBinding<DG029ViewModel, ICommand>((DG029ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG029ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG029ViewModel, object>, string>((DG029ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG029ViewModel, bool> setter = delegate(DG029ViewModel source, bool value)
			{
				source.ButtonVisible = value;
			};
			return new TypedBinding<DG029ViewModel, bool>((DG029ViewModel source) => (value: source.ButtonVisible, success: true), setter, new Tuple<Func<DG029ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG029ViewModel, object>, string>((DG029ViewModel source) => source, "ButtonVisible")
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
		this.LoadFromXaml(typeof(DG029));
	}
}
