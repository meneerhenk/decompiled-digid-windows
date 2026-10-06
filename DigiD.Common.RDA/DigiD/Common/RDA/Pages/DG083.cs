using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.RDA.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using SkiaSharp.Extended.UI.Controls;
using WinRT;
using WinRT.DigiD_Common_RDAVtableClasses;

namespace DigiD.Common.RDA.Pages;

[XamlFilePath("Pages\\DG083.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_RDA_ViewModels_DG078ViewModelWinRTTypeDetails))]
public class DG083 : BasePage<DG083ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomAnimationView CompleteAnimationView;

	public DG083()
		: base((DG083ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("CompleteAnimationView")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG083).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG083)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 14, 18);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 26, 58);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 26, 22);
		CustomAnimationView customAnimationView = new CustomAnimationView();
		VisualDiagnostics.RegisterSourceInfo(customAnimationView, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 20, 14);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 33, 17);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 34, 17);
		LabelLiveTextBehavior labelLiveTextBehavior = new LabelLiveTextBehavior();
		VisualDiagnostics.RegisterSourceInfo(labelLiveTextBehavior, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 36, 22);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 30, 14);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 43, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 40, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 49, 17);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 50, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 45, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 15, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 14, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		customAnimationView.transientNamescope = nameScope;
		nameScope.RegisterName("CompleteAnimationView", customAnimationView);
		CustomAnimationView customAnimationView2 = customAnimationView;
		if (customAnimationView2.StyleId == null)
		{
			string text = (customAnimationView2.StyleId = "CompleteAnimationView");
		}
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		CompleteAnimationView = customAnimationView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		customAnimationView.SetValue(CustomAnimationView.AnimationSourceProperty, "dga_animatie_nfcscan_cirkel_success.json");
		customAnimationView.SetValue(SKLottieView.RepeatCountProperty, 0);
		customAnimationView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Image);
		translateExtension.Text = "DG083_Complete_Text";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 26, 58);
		}
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, bindingBase);
		((IList<Behavior>)customAnimationView.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
		grid.Children.Add(customAnimationView);
		label.SetValue(Grid.RowProperty, 1);
		label.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -10.0));
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 33, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		translateExtension2.Text = "DG083_CompleteHeader";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 34, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase2);
		((IList<Behavior>)label.GetValue(VisualElement.BehaviorsProperty)).Add(labelLiveTextBehavior);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 2);
		label2.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 10.0));
		translateExtension3.Text = "DG083_Complete_Text";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 43, 17);
		}
		label2.SetBinding(Label.TextProperty, bindingBase3);
		grid.Children.Add(label2);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		borderedButton.SetValue(Element.AutomationIdProperty, "btnNext");
		bindingExtension.Path = "NextCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 49, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase4);
		translateExtension4.Text = "DG083_Complete_Button";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG083.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 50, 17);
		}
		borderedButton.SetBinding(Button.TextProperty, bindingBase5);
		grid.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG083ViewModel, ICommand> setter = null;
			return new TypedBinding<DG083ViewModel, ICommand>((DG083ViewModel source) => ((ICommand value, bool success))(value: source.NextCommand, success: true), setter, new Tuple<Func<DG083ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG083ViewModel, object>, string>((DG083ViewModel source) => source, "NextCommand")
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
	[MemberNotNull("CompleteAnimationView")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG083));
		CompleteAnimationView = this.FindByName<CustomAnimationView>("CompleteAnimationView");
	}
}
