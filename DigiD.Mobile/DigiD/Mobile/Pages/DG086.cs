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

[XamlFilePath("Pages\\DG086.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG086 : BasePage<DG086ViewModel>
{
	public DG086()
		: base((DG086ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG086).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG086)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		string dG086_LinkText = DigiDAppResources.DG086_LinkText;
		VisualDiagnostics.RegisterSourceInfo(dG086_LinkText, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 46);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 107);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 14);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		string dG086_Button1_Text = DigiDAppResources.DG086_Button1_Text;
		VisualDiagnostics.RegisterSourceInfo(dG086_Button1_Text, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		bool flag = true;
		VisualDiagnostics.RegisterSourceInfo(flag, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 22);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		string dG086_Button2_Text = DigiDAppResources.DG086_Button2_Text;
		VisualDiagnostics.RegisterSourceInfo(dG086_Button2_Text, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 17);
		bool flag2 = false;
		VisualDiagnostics.RegisterSourceInfo(flag2, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 22);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		linkLabel.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.Path = "HeaderText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		bindingExtension2.Path = "MessageText";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 33);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		grid.Children.Add(label2);
		linkLabel.SetValue(Grid.RowProperty, 2);
		linkLabel.SetValue(LinkLabel.TextProperty, dG086_LinkText);
		bindingExtension3.Path = "OpenLinkCommand";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 107);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase3);
		grid.Children.Add(linkLabel);
		image.SetValue(Grid.RowProperty, 3);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_activeringscode_brief.png"));
		grid.Children.Add(image);
		borderedButton.SetValue(Grid.RowProperty, 4);
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension4.Path = "NextCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase4);
		borderedButton.SetValue(Button.TextProperty, dG086_Button1_Text);
		borderedButton.SetValue(Button.CommandParameterProperty, flag);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 5);
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension5.Path = "NextCommand";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG086.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase5);
		borderedButton2.SetValue(Button.TextProperty, dG086_Button2_Text);
		borderedButton2.SetValue(Button.CommandParameterProperty, flag2);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG086ViewModel, string> setter = delegate(DG086ViewModel source, string? value)
			{
				source.HeaderText = value;
			};
			return new TypedBinding<DG086ViewModel, string>((DG086ViewModel source) => (value: source.HeaderText, success: true), setter, new Tuple<Func<DG086ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG086ViewModel, object>, string>((DG086ViewModel source) => source, "HeaderText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG086ViewModel, string> setter = delegate(DG086ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG086ViewModel, string>((DG086ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG086ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG086ViewModel, object>, string>((DG086ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG086ViewModel, ICommand> setter = null;
			return new TypedBinding<DG086ViewModel, ICommand>((DG086ViewModel source) => ((ICommand value, bool success))(value: source.OpenLinkCommand, success: true), setter, new Tuple<Func<DG086ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG086ViewModel, object>, string>((DG086ViewModel source) => source, "OpenLinkCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG086ViewModel, ICommand> setter = null;
			return new TypedBinding<DG086ViewModel, ICommand>((DG086ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG086ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG086ViewModel, object>, string>((DG086ViewModel source) => source, "NextCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG086ViewModel, ICommand> setter = null;
			return new TypedBinding<DG086ViewModel, ICommand>((DG086ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG086ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG086ViewModel, object>, string>((DG086ViewModel source) => source, "NextCommand")
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
		this.LoadFromXaml(typeof(DG086));
	}
}
