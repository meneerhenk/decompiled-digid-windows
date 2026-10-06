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

[XamlFilePath("Pages\\DG005.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG005 : BasePage<DG005ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private PinTilesCodeEntryView Entry;

	public DG005(DG005ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		if (base.BindingContext != null)
		{
			base.BindingContext.ChangeFocus += delegate
			{
				Entry.Focus();
			};
		}
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
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG005).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG005)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string dG005_Titel = DigiDAppResources.DG005_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG005_Titel, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG005_Intro = DigiDAppResources.DG005_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG005_Intro, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		string initialChar = DG005ViewModel.InitialChar;
		VisualDiagnostics.RegisterSourceInfo(initialChar, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		PinTilesCodeEntryView pinTilesCodeEntryView = new PinTilesCodeEntryView();
		VisualDiagnostics.RegisterSourceInfo(pinTilesCodeEntryView, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		CustomErrorLabel customErrorLabel = new CustomErrorLabel();
		VisualDiagnostics.RegisterSourceInfo(customErrorLabel, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
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
		customErrorLabel.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		Entry = pinTilesCodeEntryView;
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG005_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG005_Intro);
		grid.Children.Add(label2);
		pinTilesCodeEntryView.SetValue(Grid.RowProperty, 2);
		pinTilesCodeEntryView.SetValue(Element.AutomationIdProperty, "ActivationCodeEntry");
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.CodeTypeProperty, CodeType.Letter);
		pinTilesCodeEntryView.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		pinTilesCodeEntryView.SetValue(PinTilesCodeEntryView.InitialCharProperty, initialChar);
		bindingExtension.Path = "MessageText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		pinTilesCodeEntryView.SetBinding(SemanticProperties.DescriptionProperty, bindingBase);
		bindingExtension2.Path = "Code";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		pinTilesCodeEntryView.SetBinding(PinTilesCodeEntryView.TextProperty, bindingBase2);
		grid.Children.Add(pinTilesCodeEntryView);
		customErrorLabel.SetValue(Grid.RowProperty, 3);
		bindingExtension3.Path = "ErrorMessage";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 17);
		}
		customErrorLabel.SetBinding(CustomErrorLabel.ErrorTextProperty, bindingBase3);
		bindingExtension4.Path = "IsError";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 17);
		}
		customErrorLabel.SetBinding(VisualElement.IsVisibleProperty, bindingBase4);
		grid.Children.Add(customErrorLabel);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension5.Path = "ValidateCodeCommand";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase5);
		bindingExtension6.Path = "IsValidLength";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG005.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase6);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG005ViewModel, string> setter = delegate(DG005ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG005ViewModel, string>((DG005ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG005ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG005ViewModel, object>, string>((DG005ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG005ViewModel, string> setter = delegate(DG005ViewModel source, string? value)
			{
				source.Code = value;
			};
			return new TypedBinding<DG005ViewModel, string>((DG005ViewModel source) => (value: source.Code, success: true), setter, new Tuple<Func<DG005ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG005ViewModel, object>, string>((DG005ViewModel source) => source, "Code")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG005ViewModel, string> setter = delegate(DG005ViewModel source, string? value)
			{
				source.ErrorMessage = value;
			};
			return new TypedBinding<DG005ViewModel, string>((DG005ViewModel source) => (value: source.ErrorMessage, success: true), setter, new Tuple<Func<DG005ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG005ViewModel, object>, string>((DG005ViewModel source) => source, "ErrorMessage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG005ViewModel, bool> setter = delegate(DG005ViewModel source, bool value)
			{
				source.IsError = value;
			};
			return new TypedBinding<DG005ViewModel, bool>((DG005ViewModel source) => (value: source.IsError, success: true), setter, new Tuple<Func<DG005ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG005ViewModel, object>, string>((DG005ViewModel source) => source, "IsError")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG005ViewModel, ICommand> setter = null;
			return new TypedBinding<DG005ViewModel, ICommand>((DG005ViewModel source) => ((ICommand value, bool success))(value: source.ValidateCodeCommand, success: true), setter, new Tuple<Func<DG005ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG005ViewModel, object>, string>((DG005ViewModel source) => source, "ValidateCodeCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG005ViewModel, bool> setter = null;
			return new TypedBinding<DG005ViewModel, bool>((DG005ViewModel source) => (value: source.IsValidLength, success: true), setter, new Tuple<Func<DG005ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG005ViewModel, object>, string>((DG005ViewModel source) => source, "IsValidLength")
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG005));
		Entry = this.FindByName<PinTilesCodeEntryView>("Entry");
	}
}
