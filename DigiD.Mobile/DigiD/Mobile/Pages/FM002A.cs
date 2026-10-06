using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
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

[XamlFilePath("Pages\\FM002A.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM002A : BasePage<FM002ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid grid;

	public FM002A(FM002ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("grid")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM002A).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM002A)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate noScrollViewTemplate = TemplateSelector.NoScrollViewTemplate;
		VisualDiagnostics.RegisterSourceInfo(noScrollViewTemplate, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		string fM002A_Titel = CommonResources.FM002A_Titel;
		VisualDiagnostics.RegisterSourceInfo(fM002A_Titel, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		string fM002A_Body_iOS = CommonResources.FM002A_Body_iOS;
		VisualDiagnostics.RegisterSourceInfo(fM002A_Body_iOS, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		string fM002A_Body_Android = CommonResources.FM002A_Body_Android;
		VisualDiagnostics.RegisterSourceInfo(fM002A_Body_Android, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		string fM002A_Knop = CommonResources.FM002A_Knop1;
		VisualDiagnostics.RegisterSourceInfo(fM002A_Knop, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		string fM002A_Knop2 = CommonResources.FM002A_Knop2;
		VisualDiagnostics.RegisterSourceInfo(fM002A_Knop2, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		nameScope.RegisterName("grid", grid);
		Grid grid2 = grid;
		if (grid2.StyleId == null)
		{
			string text = (grid2.StyleId = "grid");
		}
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		this.grid = grid;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, noScrollViewTemplate);
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 10.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM002A_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		onPlatformExtension.iOS = fM002A_Body_iOS;
		onPlatformExtension.Android = fM002A_Body_Android;
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label2, grid, contentView, this }, Label.TextProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(26, 17)));
		object obj2 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 17);
		}
		label2.SetValue(Label.TextProperty, obj2);
		label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(label2);
		image.SetValue(Grid.RowProperty, 2);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_afbeelding_version_warning.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid.Children.Add(image);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "CloseButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension.Path = "CloseButtonClickCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(Button.TextProperty, fM002A_Knop);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "OpenUpdateUrlButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension2.Path = "OpenUpdateUrlCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\FM002A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton2.SetValue(Button.TextProperty, fM002A_Knop2);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<FM002ViewModel, IAsyncRelayCommand> setter = null;
			return new TypedBinding<FM002ViewModel, IAsyncRelayCommand>((FM002ViewModel source) => (value: source.CloseButtonClickCommand, success: true), setter, new Tuple<Func<FM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM002ViewModel, object>, string>((FM002ViewModel source) => source, "CloseButtonClickCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<FM002ViewModel, ICommand> setter = null;
			return new TypedBinding<FM002ViewModel, ICommand>((FM002ViewModel source) => ((ICommand value, bool success))(value: source.OpenUpdateUrlCommand, success: true), setter, new Tuple<Func<FM002ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM002ViewModel, object>, string>((FM002ViewModel source) => source, "OpenUpdateUrlCommand")
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
	[MemberNotNull("grid")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(FM002A));
		grid = this.FindByName<Grid>("grid");
	}
}
