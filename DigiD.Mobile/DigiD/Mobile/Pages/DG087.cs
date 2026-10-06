using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG087.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG087 : BasePage<DG087ViewModel>
{
	public DG087()
		: base((DG087ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG087).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG087)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		TranslateBindingExtension translateBindingExtension = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		TranslateBindingExtension translateBindingExtension2 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 18);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 21);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 21);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 18);
		TranslateBindingExtension translateBindingExtension3 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension3, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 21);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 17);
		string dG087_CheckBox_Text = DigiDAppResources.DG087_CheckBox_Text;
		VisualDiagnostics.RegisterSourceInfo(dG087_CheckBox_Text, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 17);
		CustomCheckBox customCheckBox = new CustomCheckBox();
		VisualDiagnostics.RegisterSourceInfo(customCheckBox, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 55, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		string alg_Continue = CommonResources.Alg_Continue;
		VisualDiagnostics.RegisterSourceInfo(alg_Continue, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		customCheckBox.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateBindingExtension.TranslateFormat = "DG087_Title";
		translateBindingExtension.Path = "CurrentDocumentType";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateBindingExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		grid2.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		translateBindingExtension2.TranslateFormat = "DG087_Message";
		translateBindingExtension2.Path = "CurrentDocumentType";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateBindingExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 33);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		grid2.Children.Add(label2);
		grid.SetValue(Grid.RowProperty, 2);
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(16.0));
		grid.SetValue(VisualElement.BackgroundColorProperty, new Color(83f / 85f, 0.8745098f, 13f / 15f, 1f));
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(16.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 10.0);
		image.SetValue(Grid.RowProperty, 0);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_foutmelding_kritiek.png"));
		grid.Children.Add(image);
		label3.SetValue(Grid.RowProperty, 0);
		label3.SetValue(Grid.ColumnProperty, 1);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label3, grid, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(42, 21)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 21);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		translateExtension.Text = "DG087_Warning_Title";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 21);
		}
		label3.SetBinding(Label.TextProperty, bindingBase3);
		label3.SetValue(Label.TextColorProperty, Colors.Black);
		grid.Children.Add(label3);
		label4.SetValue(Grid.RowProperty, 1);
		label4.SetValue(Grid.ColumnProperty, 1);
		translateBindingExtension3.TranslateFormat = "DG087_Warning_Message";
		translateBindingExtension3.Path = "CurrentDocumentType";
		BindingBase bindingBase4 = ((IMarkupExtension<BindingBase>)translateBindingExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 21);
		}
		label4.SetBinding(Label.TextProperty, bindingBase4);
		label4.SetValue(Label.TextColorProperty, Colors.Black);
		grid.Children.Add(label4);
		grid2.Children.Add(grid);
		image2.SetValue(Grid.RowProperty, 3);
		image2.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_pin_drivinglicence"));
		grid2.Children.Add(image2);
		customCheckBox.SetValue(Grid.RowProperty, 4);
		bindingExtension.Path = "IsChecked";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 17);
		}
		customCheckBox.SetBinding(CustomCheckBox.IsCheckedProperty, bindingBase5);
		customCheckBox.SetValue(CustomCheckBox.TextProperty, dG087_CheckBox_Text);
		grid2.Children.Add(customCheckBox);
		borderedButton.SetValue(Grid.RowProperty, 5);
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension2.Path = "NextCommand";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG087.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase6);
		borderedButton.SetValue(Button.TextProperty, alg_Continue);
		grid2.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG087ViewModel, bool> setter = delegate(DG087ViewModel source, bool value)
			{
				source.IsChecked = value;
			};
			return new TypedBinding<DG087ViewModel, bool>((DG087ViewModel source) => (value: source.IsChecked, success: true), setter, new Tuple<Func<DG087ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG087ViewModel, object>, string>((DG087ViewModel source) => source, "IsChecked")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG087ViewModel, ICommand> setter = null;
			return new TypedBinding<DG087ViewModel, ICommand>((DG087ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG087ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG087ViewModel, object>, string>((DG087ViewModel source) => source, "NextCommand")
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
		this.LoadFromXaml(typeof(DG087));
	}
}
