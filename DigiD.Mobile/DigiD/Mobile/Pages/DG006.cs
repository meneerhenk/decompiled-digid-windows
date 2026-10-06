using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
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

[XamlFilePath("Pages\\DG006.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG006 : BasePage<DG006ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private PinTilesCodeEntryView Entry;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BorderedButton NextButton;

	public DG006(DG006ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
		if (!((IApp)Application.Current).A11YService.IsInVoiceOverMode)
		{
			Entry.Focus();
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Entry")]
	[MemberNotNull("NextButton")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG006).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG006)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string dG006_Titel = DigiDAppResources.DG006_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG006_Titel, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG006_Intro = DigiDAppResources.DG006_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG006_Intro, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		PinTilesCodeEntryView pinTilesCodeEntryView = new PinTilesCodeEntryView();
		VisualDiagnostics.RegisterSourceInfo(pinTilesCodeEntryView, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		string dG006_Helplink = DigiDAppResources.DG006_Helplink;
		VisualDiagnostics.RegisterSourceInfo(dG006_Helplink, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		pinTilesCodeEntryView.transientNamescope = nameScope;
		nameScope.RegisterName("Entry", pinTilesCodeEntryView);
		PinTilesCodeEntryView pinTilesCodeEntryView2 = pinTilesCodeEntryView;
		if (pinTilesCodeEntryView2.StyleId == null)
		{
			string text = (pinTilesCodeEntryView2.StyleId = "Entry");
		}
		linkLabel.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		nameScope.RegisterName("NextButton", borderedButton);
		BorderedButton borderedButton2 = borderedButton;
		if (borderedButton2.StyleId == null)
		{
			string text = (borderedButton2.StyleId = "NextButton");
		}
		Entry = pinTilesCodeEntryView;
		NextButton = borderedButton;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG006_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG006_Intro);
		grid.Children.Add(label2);
		pinTilesCodeEntryView.SetValue(Grid.RowProperty, 2);
		pinTilesCodeEntryView.SetValue(View.MarginProperty, new Thickness(0.0, 20.0));
		pinTilesCodeEntryView.SetValue(Element.AutomationIdProperty, "VerificationCodeEntry");
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.CodeTypeProperty, CodeType.KoppelCode);
		pinTilesCodeEntryView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		pinTilesCodeEntryView.SetBinding(SemanticProperties.DescriptionProperty, bindingBase);
		bindingExtension2.Path = "Code";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		pinTilesCodeEntryView.SetBinding(PinTilesCodeEntryView.TextProperty, bindingBase2);
		grid.Children.Add(pinTilesCodeEntryView);
		linkLabel.SetValue(Grid.RowProperty, 3);
		linkLabel.SetValue(Element.AutomationIdProperty, "VerificationCodeNotFoundLink");
		bindingExtension3.Path = "OpenHelpCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase3);
		linkLabel.SetValue(LinkLabel.TextProperty, dG006_Helplink);
		grid.Children.Add(linkLabel);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension4.Path = "StartSessionCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase4);
		bindingExtension5.Path = "IsValid";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG006.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase5);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG006ViewModel, string> setter = delegate(DG006ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG006ViewModel, string>((DG006ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG006ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG006ViewModel, object>, string>((DG006ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG006ViewModel, string> setter = delegate(DG006ViewModel source, string? value)
			{
				source.Code = value;
			};
			return new TypedBinding<DG006ViewModel, string>((DG006ViewModel source) => (value: source.Code, success: true), setter, new Tuple<Func<DG006ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG006ViewModel, object>, string>((DG006ViewModel source) => source, "Code")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG006ViewModel, ICommand> setter = null;
			return new TypedBinding<DG006ViewModel, ICommand>((DG006ViewModel source) => ((ICommand value, bool success))(value: source.OpenHelpCommand, success: true), setter, new Tuple<Func<DG006ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG006ViewModel, object>, string>((DG006ViewModel source) => source, "OpenHelpCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG006ViewModel, ICommand> setter = null;
			return new TypedBinding<DG006ViewModel, ICommand>((DG006ViewModel source) => ((ICommand value, bool success))(value: source.StartSessionCommand, success: true), setter, new Tuple<Func<DG006ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG006ViewModel, object>, string>((DG006ViewModel source) => source, "StartSessionCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG006ViewModel, bool> setter = null;
			return new TypedBinding<DG006ViewModel, bool>((DG006ViewModel source) => (value: source.IsValid, success: true), setter, new Tuple<Func<DG006ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG006ViewModel, object>, string>((DG006ViewModel source) => source, "IsValid")
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
	[MemberNotNull("Entry")]
	[MemberNotNull("NextButton")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG006));
		Entry = this.FindByName<PinTilesCodeEntryView>("Entry");
		NextButton = this.FindByName<BorderedButton>("NextButton");
	}
}
