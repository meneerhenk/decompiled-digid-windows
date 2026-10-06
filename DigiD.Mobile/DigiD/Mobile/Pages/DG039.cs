using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
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

[XamlFilePath("Pages\\DG039.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG039 : BasePage<DG039ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid Grid;

	public DG039(DG039ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Grid")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG039).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG039)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 20);
		string dG039_Titel = DigiDAppResources.DG039_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG039_Titel, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		string dG039_Intro = DigiDAppResources.DG039_Intro;
		VisualDiagnostics.RegisterSourceInfo(dG039_Intro, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		VerificationCodeLabel verificationCodeLabel = new VerificationCodeLabel();
		VisualDiagnostics.RegisterSourceInfo(verificationCodeLabel, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		string dG039_Uitleg = DigiDAppResources.DG039_Uitleg;
		VisualDiagnostics.RegisterSourceInfo(dG039_Uitleg, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 33);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		string dG039_KnopUitleg = DigiDAppResources.DG039_KnopUitleg;
		VisualDiagnostics.RegisterSourceInfo(dG039_KnopUitleg, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		string alg_Next = CommonResources.Alg_Next;
		VisualDiagnostics.RegisterSourceInfo(alg_Next, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		nameScope.RegisterName("Grid", grid);
		Grid grid2 = grid;
		if (grid2.StyleId == null)
		{
			string text = (grid2.StyleId = "Grid");
		}
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verificationCodeLabel.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		Grid = grid;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(20, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG039_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, dG039_Intro);
		grid.Children.Add(label2);
		verificationCodeLabel.SetValue(Grid.RowProperty, 2);
		bindingExtension.Path = "Code";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		}
		verificationCodeLabel.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(verificationCodeLabel);
		label3.SetValue(Grid.RowProperty, 3);
		label3.SetValue(Label.TextProperty, dG039_Uitleg);
		grid.Children.Add(label3);
		linkLabel.SetValue(Grid.RowProperty, 4);
		linkLabel.SetValue(Element.AutomationIdProperty, "MoreInfoButton");
		bindingExtension2.Path = "OpenMoreInfoCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase2);
		linkLabel.SetValue(LinkLabel.TextProperty, dG039_KnopUitleg);
		grid.Children.Add(linkLabel);
		borderedButton.SetValue(Grid.RowProperty, 5);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 0.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "NextButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension3.Path = "OpenQrCodeScannerCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase3);
		bindingExtension4.Path = "IsCodeValid";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG039.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		borderedButton.SetBinding(VisualElement.IsEnabledProperty, bindingBase4);
		borderedButton.SetValue(Button.TextProperty, alg_Next);
		borderedButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG039ViewModel, string> setter = delegate(DG039ViewModel source, string? value)
			{
				source.Code = value;
			};
			return new TypedBinding<DG039ViewModel, string>((DG039ViewModel source) => (value: source.Code, success: true), setter, new Tuple<Func<DG039ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG039ViewModel, object>, string>((DG039ViewModel source) => source, "Code")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG039ViewModel, ICommand> setter = null;
			return new TypedBinding<DG039ViewModel, ICommand>((DG039ViewModel source) => ((ICommand value, bool success))(value: source.OpenMoreInfoCommand, success: true), setter, new Tuple<Func<DG039ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG039ViewModel, object>, string>((DG039ViewModel source) => source, "OpenMoreInfoCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG039ViewModel, ICommand> setter = null;
			return new TypedBinding<DG039ViewModel, ICommand>((DG039ViewModel source) => ((ICommand value, bool success))(value: source.OpenQrCodeScannerCommand, success: true), setter, new Tuple<Func<DG039ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG039ViewModel, object>, string>((DG039ViewModel source) => source, "OpenQrCodeScannerCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG039ViewModel, bool> setter = null;
			return new TypedBinding<DG039ViewModel, bool>((DG039ViewModel source) => (value: source.IsCodeValid, success: true), setter, new Tuple<Func<DG039ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG039ViewModel, object>, string>((DG039ViewModel source) => source, "IsCodeValid")
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
	[MemberNotNull("Grid")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG039));
		Grid = this.FindByName<Grid>("Grid");
	}
}
