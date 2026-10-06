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

[XamlFilePath("Pages\\FM105.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM105 : BasePage<FM105ViewModel>
{
	public FM105(FM105ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM105).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM105)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		string fM105_Title = CommonResources.FM105_Title;
		VisualDiagnostics.RegisterSourceInfo(fM105_Title, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		string fM105_Message = CommonResources.FM105_Message;
		VisualDiagnostics.RegisterSourceInfo(fM105_Message, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 33);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		string continueText = FM105ViewModel.ContinueText;
		VisualDiagnostics.RegisterSourceInfo(continueText, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 33);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		bool buttonVisible = FM105ViewModel.ButtonVisible;
		VisualDiagnostics.RegisterSourceInfo(buttonVisible, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 17);
		string fM105_Button = CommonResources.FM105_Button;
		VisualDiagnostics.RegisterSourceInfo(fM105_Button, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM105_Title);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, fM105_Message);
		grid.Children.Add(label2);
		label3.SetValue(Grid.RowProperty, 2);
		label3.SetValue(Label.TextProperty, continueText);
		grid.Children.Add(label3);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(Element.AutomationIdProperty, "ConfirmButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension.Path = "NextCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\FM105.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase);
		borderedButton.SetValue(VisualElement.IsVisibleProperty, buttonVisible);
		borderedButton.SetValue(Button.TextProperty, fM105_Button);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<FM105ViewModel, ICommand> setter = null;
			return new TypedBinding<FM105ViewModel, ICommand>((FM105ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<FM105ViewModel, object>, string>[1]
			{
				new Tuple<Func<FM105ViewModel, object>, string>((FM105ViewModel source) => source, "NextCommand")
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
		this.LoadFromXaml(typeof(FM105));
	}
}
