using System;
using System.CodeDom.Compiler;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
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

[XamlFilePath("Pages\\FM002C.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM002C : BasePage<FM002ViewModel>
{
	public FM002C(FM002ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(FM002C).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(FM002C)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate noScrollViewTemplate = TemplateSelector.NoScrollViewTemplate;
		VisualDiagnostics.RegisterSourceInfo(noScrollViewTemplate, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		string fM002C_Titel = CommonResources.FM002C_Titel;
		VisualDiagnostics.RegisterSourceInfo(fM002C_Titel, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		string fM002C_Body = CommonResources.FM002C_Body;
		VisualDiagnostics.RegisterSourceInfo(fM002C_Body, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 14);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, noScrollViewTemplate);
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid.SetValue(Grid.RowSpacingProperty, 10.0);
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
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\FM002C.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, fM002C_Titel);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Label.TextProperty, fM002C_Body);
		label2.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(label2);
		image.SetValue(Grid.RowProperty, 2);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_afbeelding_version_blocked.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		grid.Children.Add(image);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
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
		this.LoadFromXaml(typeof(FM002C));
	}
}
