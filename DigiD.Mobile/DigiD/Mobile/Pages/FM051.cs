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

[XamlFilePath("Pages\\FM051.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM051 : BasePage<FM051ViewModel>
{
	public FM051(FM051ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM051).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM051)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 17);
		string fM051_Titel = CommonResources.FM051_Titel;
		VisualDiagnostics.RegisterSourceInfo(fM051_Titel, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		string fM051_Subtitle = CommonResources.FM051_Subtitle;
		VisualDiagnostics.RegisterSourceInfo(fM051_Subtitle, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		string fM051_Text = CommonResources.FM051_Text2;
		VisualDiagnostics.RegisterSourceInfo(fM051_Text, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 20);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		string fM051_Button = CommonResources.FM051_Button;
		VisualDiagnostics.RegisterSourceInfo(fM051_Button, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 20.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM051_Titel);
		verticalStackLayout.Children.Add(label);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label2);
		label3.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -20.0));
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label3, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(Label.TextProperty, fM051_Subtitle);
		verticalStackLayout.Children.Add(label3);
		label4.SetValue(Label.TextProperty, fM051_Text);
		verticalStackLayout.Children.Add(label4);
		borderedButton.SetValue(Element.AutomationIdProperty, "RequestNewLetterButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "RequestNewLetterCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\FM051.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.TextProperty, fM051_Button);
		verticalStackLayout.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<FM051ViewModel, string> setter = delegate(FM051ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<FM051ViewModel, string>((FM051ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<FM051ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM051ViewModel, object>, string>((FM051ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<FM051ViewModel, ICommand> setter = null;
			return new TypedBinding<FM051ViewModel, ICommand>((FM051ViewModel source) => ((ICommand value, bool success))(value: source.RequestNewLetterCommand, success: true), setter, new Tuple<Func<FM051ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM051ViewModel, object>, string>((FM051ViewModel source) => source, "RequestNewLetterCommand")
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
		this.LoadFromXaml(typeof(FM051));
	}
}
