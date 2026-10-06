using System;
using System.CodeDom.Compiler;
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
using Microsoft.Maui.Converters;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG033.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG033 : BasePage<DG033ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label dummyLabel;

	public DG033()
		: base((DG033ViewModel?)null)
	{
		InitializeComponent();
	}

	private void Entry_Focused(object? sender, FocusEventArgs e)
	{
		if (((IApp)Application.Current).A11YService.IsInVoiceOverMode)
		{
			dummyLabel.HeightRequest = (e.IsFocused ? 100 : 0);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("dummyLabel")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG033).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG033)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string dG033_Titel = DigiDAppResources.DG033_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG033_Titel, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string dG033_Intro = DigiDAppResources.DG033_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG033_Intro, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		string fM044_Melding = CommonResources.FM044_Melding;
		VisualDiagnostics.RegisterSourceInfo(fM044_Melding, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		string dG033_EmailVeld = DigiDAppResources.DG033_EmailVeld;
		VisualDiagnostics.RegisterSourceInfo(dG033_EmailVeld, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 17);
		CustomEntryField customEntryField = new CustomEntryField();
		VisualDiagnostics.RegisterSourceInfo(customEntryField, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 17);
		string dG033_Helplink = DigiDAppResources.DG033_Helplink;
		VisualDiagnostics.RegisterSourceInfo(dG033_Helplink, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		customEntryField.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		nameScope.RegisterName("dummyLabel", label3);
		Label label4 = label3;
		if (label4.StyleId == null)
		{
			string text = (label4.StyleId = "dummyLabel");
		}
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		dummyLabel = label3;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG033_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG033_Intro);
		grid.Children.Add(label2);
		customEntryField.SetValue(Grid.RowProperty, 2);
		customEntryField.SetValue(Element.AutomationIdProperty, "EmailEntry");
		customEntryField.SetValue(CustomEntryField.ErrorTextProperty, fM044_Melding);
		customEntryField.Focused += Entry_Focused;
		bindingExtension.Path = "IsValid";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		}
		customEntryField.SetBinding(CustomEntryField.IsValidProperty, bindingBase);
		customEntryField.SetValue(CustomEntryField.KeyboardProperty, new KeyboardTypeConverter().ConvertFromInvariantString("Email") as Keyboard);
		customEntryField.SetValue(CustomEntryField.ReturnTypeProperty, ReturnType.Go);
		bindingExtension2.Path = "RegisterCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		onIdiomExtension.Desktop = bindingBase2;
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { customEntryField, grid, contentView, this }, CustomEntryField.ReturnCommandProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 17)));
		object obj2 = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		}
		customEntryField.SetValue(CustomEntryField.ReturnCommandProperty, obj2);
		customEntryField.ShowValidIcon = true;
		bindingExtension3.Path = "EmailAddress";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 17);
		}
		customEntryField.SetBinding(CustomEntryField.TextProperty, bindingBase3);
		customEntryField.SetValue(CustomEntryField.TitleTextProperty, dG033_EmailVeld);
		customEntryField.Unfocused += Entry_Focused;
		grid.Children.Add(customEntryField);
		label3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label3.SetValue(VisualElement.HeightRequestProperty, 0.0);
		label3.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		grid.Children.Add(label3);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "SkipButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension4.Path = "SkipCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase4);
		borderedButton.SetValue(Button.TextProperty, dG033_Helplink);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension5.Path = "RegisterCommand";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase5);
		bindingExtension6.Path = "IsValid";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG033.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 17);
		}
		borderedButton2.SetBinding(VisualElement.IsEnabledProperty, bindingBase6);
		borderedButton2.SetValue(Button.TextProperty, alg_Next);
		borderedButton2.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG033ViewModel, bool> setter = null;
			return new TypedBinding<DG033ViewModel, bool>((DG033ViewModel source) => (value: source.IsValid, success: true), setter, new Tuple<Func<DG033ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG033ViewModel, object>, string>((DG033ViewModel source) => source, "IsValid")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG033ViewModel, ICommand> setter = null;
			return new TypedBinding<DG033ViewModel, ICommand>((DG033ViewModel source) => ((ICommand value, bool success))(value: source.RegisterCommand, success: true), setter, new Tuple<Func<DG033ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG033ViewModel, object>, string>((DG033ViewModel source) => source, "RegisterCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG033ViewModel, string> setter = delegate(DG033ViewModel source, string? value)
			{
				source.EmailAddress = value;
			};
			return new TypedBinding<DG033ViewModel, string>((DG033ViewModel source) => (value: source.EmailAddress, success: true), setter, new Tuple<Func<DG033ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG033ViewModel, object>, string>((DG033ViewModel source) => source, "EmailAddress")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG033ViewModel, ICommand> setter = null;
			return new TypedBinding<DG033ViewModel, ICommand>((DG033ViewModel source) => ((ICommand value, bool success))(value: source.SkipCommand, success: true), setter, new Tuple<Func<DG033ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG033ViewModel, object>, string>((DG033ViewModel source) => source, "SkipCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG033ViewModel, ICommand> setter = null;
			return new TypedBinding<DG033ViewModel, ICommand>((DG033ViewModel source) => ((ICommand value, bool success))(value: source.RegisterCommand, success: true), setter, new Tuple<Func<DG033ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG033ViewModel, object>, string>((DG033ViewModel source) => source, "RegisterCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG033ViewModel, bool> setter = null;
			return new TypedBinding<DG033ViewModel, bool>((DG033ViewModel source) => (value: source.IsValid, success: true), setter, new Tuple<Func<DG033ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG033ViewModel, object>, string>((DG033ViewModel source) => source, "IsValid")
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
	[MemberNotNull("dummyLabel")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG033));
		dummyLabel = this.FindByName<Label>("dummyLabel");
	}
}
