using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Enums;
using DigiD.Common.RDA.ViewModels;
using DigiD.Common.RDA.Views;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Common.RDA.Pages;

[XamlFilePath("Pages\\DG080.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class DG080 : BasePage<DG080ViewModel>
{
	public DG080()
		: base((DG080ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG080).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG080)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 14, 18);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 19, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 20, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 21, 17);
		NfcLocationView nfcLocationView = new NfcLocationView();
		VisualDiagnostics.RegisterSourceInfo(nfcLocationView, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 27, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 28, 17);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 29, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 23, 14);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 36, 17);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 37, 17);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 39, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 31, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 15, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 14, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		nfcLocationView.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		bindingExtension.Path = "DocumentType";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 19, 17);
		}
		nfcLocationView.SetBinding(NfcLocationView.DocumentTypeProperty, bindingBase);
		bindingExtension2.Path = "NfcPosition";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 20, 17);
		}
		nfcLocationView.SetBinding(NfcLocationView.NfcPositionProperty, bindingBase2);
		bindingExtension3.Path = "ProgressPercentage";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 21, 17);
		}
		nfcLocationView.SetBinding(NfcLocationView.ProgressProperty, bindingBase3);
		grid.Children.Add(nfcLocationView);
		borderedButton.SetValue(Grid.RowProperty, 1);
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		borderedButton.SetValue(Element.AutomationIdProperty, "btnCancel");
		bindingExtension4.Path = "CancelScanCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 27, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase4);
		bindingExtension5.Path = "CancelButtonVisible";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 28, 17);
		}
		borderedButton.SetBinding(VisualElement.IsVisibleProperty, bindingBase5);
		translateExtension.Text = "DG080_Button_Escape";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 29, 17);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase6);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 2);
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		borderedButton2.SetValue(Element.AutomationIdProperty, "btnStartScan");
		borderedButton2.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 0.0, 0.0));
		bindingExtension6.Path = "StartScanCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 36, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase7);
		onPlatformExtension.iOS = "true";
		onPlatformExtension.Android = "false";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { borderedButton2, grid, contentView, this }, VisualElement.IsVisibleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 17)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 37, 17);
		}
		borderedButton2.SetValue(VisualElement.IsVisibleProperty, obj);
		translateExtension2.Text = "DG080_Button_Retry";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG080.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 39, 17);
		}
		borderedButton2.SetBinding(Button.TextProperty, bindingBase8);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG080ViewModel, DocumentType> setter = delegate(DG080ViewModel source, DocumentType value)
			{
				source.DocumentType = value;
			};
			return new TypedBinding<DG080ViewModel, DocumentType>((DG080ViewModel source) => (value: source.DocumentType, success: true), setter, new Tuple<Func<DG080ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG080ViewModel, object>, string>((DG080ViewModel source) => source, "DocumentType")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG080ViewModel, NfcPosition> setter = delegate(DG080ViewModel source, NfcPosition value)
			{
				source.NfcPosition = value;
			};
			return new TypedBinding<DG080ViewModel, NfcPosition>((DG080ViewModel source) => (value: source.NfcPosition, success: true), setter, new Tuple<Func<DG080ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG080ViewModel, object>, string>((DG080ViewModel source) => source, "NfcPosition")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG080ViewModel, int> setter = null;
			return new TypedBinding<DG080ViewModel, int>((DG080ViewModel source) => (value: source.ProgressPercentage, success: true), setter, new Tuple<Func<DG080ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG080ViewModel, object>, string>((DG080ViewModel source) => source, "ProgressPercentage")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG080ViewModel, IAsyncRelayCommand> setter = null;
			return new TypedBinding<DG080ViewModel, IAsyncRelayCommand>((DG080ViewModel source) => (value: source.CancelScanCommand, success: true), setter, new Tuple<Func<DG080ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG080ViewModel, object>, string>((DG080ViewModel source) => source, "CancelScanCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG080ViewModel, bool> setter = null;
			return new TypedBinding<DG080ViewModel, bool>((DG080ViewModel source) => (value: source.CancelButtonVisible, success: true), setter, new Tuple<Func<DG080ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG080ViewModel, object>, string>((DG080ViewModel source) => source, "CancelButtonVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG080ViewModel, ICommand> setter = null;
			return new TypedBinding<DG080ViewModel, ICommand>((DG080ViewModel source) => ((ICommand value, bool success))(value: source.StartScanCommand, success: true), setter, new Tuple<Func<DG080ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG080ViewModel, object>, string>((DG080ViewModel source) => source, "StartScanCommand")
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
		this.LoadFromXaml(typeof(DG080));
	}
}
