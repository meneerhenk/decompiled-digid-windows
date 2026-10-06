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
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG009.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG009 : BasePage<DG009ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label InfoLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BorderedButton RequestDigidButton;

	public DG009(DG009ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("InfoLabel")]
	[MemberNotNull("RequestDigidButton")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG009).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG009)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 20);
		string dG009_Titel = DigiDAppResources.DG009_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG009_Titel, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		string dG009_SubtitelNL = DigiDAppResources.DG009_SubtitelNL;
		VisualDiagnostics.RegisterSourceInfo(dG009_SubtitelNL, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 55);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		string dG009_KnopAanvragen = DigiDAppResources.DG009_KnopAanvragen;
		VisualDiagnostics.RegisterSourceInfo(dG009_KnopAanvragen, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		string dG009_SubtitelBTL = DigiDAppResources.DG009_SubtitelBTL;
		VisualDiagnostics.RegisterSourceInfo(dG009_SubtitelBTL, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		string dG009_InfoBuitenland = DigiDAppResources.DG009_InfoBuitenland;
		VisualDiagnostics.RegisterSourceInfo(dG009_InfoBuitenland, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 41);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		string dG009_LinkBTL = DigiDAppResources.DG009_LinkBTL;
		VisualDiagnostics.RegisterSourceInfo(dG009_LinkBTL, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		nameScope.RegisterName("InfoLabel", label3);
		Label label6 = label3;
		if (label6.StyleId == null)
		{
			string text = (label6.StyleId = "InfoLabel");
		}
		borderedButton.transientNamescope = nameScope;
		nameScope.RegisterName("RequestDigidButton", borderedButton);
		BorderedButton borderedButton3 = borderedButton;
		if (borderedButton3.StyleId == null)
		{
			string text = (borderedButton3.StyleId = "RequestDigidButton");
		}
		label4.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		InfoLabel = label3;
		RequestDigidButton = borderedButton;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(17, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG009_Titel);
		verticalStackLayout.Children.Add(label);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label2, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 20)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 20);
		}
		label2.SetValue(VisualElement.StyleProperty, obj2);
		label2.SetValue(Label.TextProperty, dG009_SubtitelNL);
		verticalStackLayout.Children.Add(label2);
		label3.SetValue(View.MarginProperty, new Thickness(0.0, -20.0, 0.0, -10.0));
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		}
		label3.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label3);
		borderedButton.SetValue(Element.AutomationIdProperty, "RequestDigidButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "RequestDigiDCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.TextProperty, dG009_KnopAanvragen);
		borderedButton.SetValue(VisualElement.ZIndexProperty, 10);
		verticalStackLayout.Children.Add(borderedButton);
		label4.SetValue(View.MarginProperty, new Thickness(0.0, 30.0, 0.0, 0.0));
		staticResourceExtension3.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { label4, verticalStackLayout, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(34, 17)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 17);
		}
		label4.SetValue(VisualElement.StyleProperty, obj3);
		label4.SetValue(Label.TextProperty, dG009_SubtitelBTL);
		verticalStackLayout.Children.Add(label4);
		label5.SetValue(View.MarginProperty, new Thickness(0.0, -20.0, 0.0, -10.0));
		label5.SetValue(Label.TextProperty, dG009_InfoBuitenland);
		verticalStackLayout.Children.Add(label5);
		borderedButton2.SetValue(Element.AutomationIdProperty, "RequestDigidAbroadButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension3.Path = "RequestDigiDAbroadCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG009.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase3);
		borderedButton2.SetValue(BorderedButton.IsExternProperty, true);
		borderedButton2.SetValue(Button.TextProperty, dG009_LinkBTL);
		borderedButton2.SetValue(VisualElement.ZIndexProperty, 15);
		verticalStackLayout.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG009ViewModel, string> setter = delegate(DG009ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG009ViewModel, string>((DG009ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG009ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG009ViewModel, object>, string>((DG009ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG009ViewModel, ICommand> setter = null;
			return new TypedBinding<DG009ViewModel, ICommand>((DG009ViewModel source) => ((ICommand value, bool success))(value: source.RequestDigiDCommand, success: true), setter, new Tuple<Func<DG009ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG009ViewModel, object>, string>((DG009ViewModel source) => source, "RequestDigiDCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG009ViewModel, ICommand> setter = null;
			return new TypedBinding<DG009ViewModel, ICommand>((DG009ViewModel source) => ((ICommand value, bool success))(value: source.RequestDigiDAbroadCommand, success: true), setter, new Tuple<Func<DG009ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG009ViewModel, object>, string>((DG009ViewModel source) => source, "RequestDigiDAbroadCommand")
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
	[MemberNotNull("InfoLabel")]
	[MemberNotNull("RequestDigidButton")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG009));
		InfoLabel = this.FindByName<Label>("InfoLabel");
		RequestDigidButton = this.FindByName<BorderedButton>("RequestDigidButton");
	}
}
