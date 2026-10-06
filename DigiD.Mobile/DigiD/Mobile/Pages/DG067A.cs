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
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ProgressBar;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG067A.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG067A : BasePage<DG067AViewModel>
{
	public DG067A(DG067AViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG067A).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG067A)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 57);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 14);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 21);
		string dG067_Melding = DigiDAppResources.DG067_Melding;
		VisualDiagnostics.RegisterSourceInfo(dG067_Melding, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 21);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 18);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 21);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 21);
		string alg_SecondsToConfirmUpdate = CommonResources.Alg_SecondsToConfirmUpdate;
		VisualDiagnostics.RegisterSourceInfo(alg_SecondsToConfirmUpdate, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 29);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 29);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 29);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 26);
		SfCircularProgressBar sfCircularProgressBar = new SfCircularProgressBar();
		VisualDiagnostics.RegisterSourceInfo(sfCircularProgressBar, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 14);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		string alg_Cancel = CommonResources.Alg_Cancel;
		VisualDiagnostics.RegisterSourceInfo(alg_Cancel, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 14);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 70, 17);
		BindingExtension bindingExtension9 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 17);
		string dG067_Knop = DigiDAppResources.DG067_Knop;
		VisualDiagnostics.RegisterSourceInfo(dG067_Knop, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 17);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		sfCircularProgressBar.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
		grid.SetValue(Grid.RowSpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.Path = "HeaderText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 57);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		grid.Children.Add(label);
		label2.SetValue(Grid.RowProperty, 1);
		bindingExtension2.Path = "MessageText";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		}
		label2.SetBinding(Label.TextProperty, bindingBase2);
		label2.SetValue(Label.TextTypeProperty, TextType.Html);
		grid.Children.Add(label2);
		verticalStackLayout.SetValue(Grid.RowProperty, 2);
		bindingExtension3.Path = "IsTimerVisible";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 17);
		}
		verticalStackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase3);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		verticalStackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		label3.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label3, verticalStackLayout, grid, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(33, 21)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 21);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(Label.TextProperty, dG067_Melding);
		label3.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		verticalStackLayout.Children.Add(label3);
		sfCircularProgressBar.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		sfCircularProgressBar.SetValue(VisualElement.HeightRequestProperty, 64.0);
		sfCircularProgressBar.SetValue(ProgressBarBase.MaximumProperty, 30.0);
		sfCircularProgressBar.SetValue(ProgressBarBase.MinimumProperty, 0.0);
		bindingExtension4.Path = "SecondsUsed";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 21);
		}
		sfCircularProgressBar.SetBinding(ProgressBarBase.ProgressProperty, bindingBase4);
		sfCircularProgressBar.SetValue(ProgressBarBase.ProgressFillProperty, new BrushTypeConverter().ConvertFromInvariantString("#FCD2AD") as Brush);
		sfCircularProgressBar.SetValue(SfCircularProgressBar.ProgressRadiusFactorProperty, 0.65);
		staticResourceExtension3.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { sfCircularProgressBar, verticalStackLayout, grid, contentView, this }, ProgressBarBase.TrackFillProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(45, 21)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 21);
		}
		sfCircularProgressBar.SetValue(ProgressBarBase.TrackFillProperty, obj3);
		sfCircularProgressBar.SetValue(SfCircularProgressBar.TrackRadiusFactorProperty, 0.65);
		sfCircularProgressBar.SetValue(VisualElement.WidthRequestProperty, 64.0);
		label4.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		bindingExtension5.StringFormat = alg_SecondsToConfirmUpdate;
		bindingExtension5.Path = "SecondsLeft";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 29);
		}
		label4.SetBinding(SemanticProperties.DescriptionProperty, bindingBase5);
		bindingExtension6.Path = "SecondsLeft";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 29);
		}
		label4.SetBinding(Label.TextProperty, bindingBase6);
		sfCircularProgressBar.SetValue(SfCircularProgressBar.ContentProperty, label4);
		verticalStackLayout.Children.Add(sfCircularProgressBar);
		grid.Children.Add(verticalStackLayout);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, -5.0));
		borderedButton.SetValue(Element.AutomationIdProperty, "CancelButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension7.Path = "AbortCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase7);
		borderedButton.SetValue(Button.TextProperty, alg_Cancel);
		grid.Children.Add(borderedButton);
		borderedButton2.SetValue(Grid.RowProperty, 4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "ConfirmButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension8.Path = "ConfirmCommand";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 70, 17);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase8);
		bindingExtension9.Path = "LoginButtonEnabled";
		BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Pages\\DG067A.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 17);
		}
		borderedButton2.SetBinding(VisualElement.IsEnabledProperty, bindingBase9);
		borderedButton2.SetValue(Button.TextProperty, dG067_Knop);
		grid.Children.Add(borderedButton2);
		contentView.SetValue(ContentView.ContentProperty, grid);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG067AViewModel, string> setter = delegate(DG067AViewModel source, string? value)
			{
				source.HeaderText = value;
			};
			return new TypedBinding<DG067AViewModel, string>((DG067AViewModel source) => (value: source.HeaderText, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "HeaderText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG067AViewModel, string> setter = delegate(DG067AViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG067AViewModel, string>((DG067AViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG067AViewModel, bool> setter = delegate(DG067AViewModel source, bool value)
			{
				source.IsTimerVisible = value;
			};
			return new TypedBinding<DG067AViewModel, bool>((DG067AViewModel source) => (value: source.IsTimerVisible, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "IsTimerVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG067AViewModel, int> setter = delegate(DG067AViewModel source, int value)
			{
				source.SecondsUsed = value;
			};
			return new TypedBinding<DG067AViewModel, int>((DG067AViewModel source) => (value: source.SecondsUsed, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "SecondsUsed")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG067AViewModel, int> setter = delegate(DG067AViewModel source, int value)
			{
				source.SecondsLeft = value;
			};
			return new TypedBinding<DG067AViewModel, int>((DG067AViewModel source) => (value: source.SecondsLeft, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "SecondsLeft")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG067AViewModel, int> setter = delegate(DG067AViewModel source, int value)
			{
				source.SecondsLeft = value;
			};
			return new TypedBinding<DG067AViewModel, int>((DG067AViewModel source) => (value: source.SecondsLeft, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "SecondsLeft")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG067AViewModel, ICommand> setter = null;
			return new TypedBinding<DG067AViewModel, ICommand>((DG067AViewModel source) => ((ICommand value, bool success))(value: source.AbortCommand, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "AbortCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG067AViewModel, ICommand> setter = null;
			return new TypedBinding<DG067AViewModel, ICommand>((DG067AViewModel source) => ((ICommand value, bool success))(value: source.ConfirmCommand, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "ConfirmCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<DG067AViewModel, bool> setter = null;
			return new TypedBinding<DG067AViewModel, bool>((DG067AViewModel source) => (value: source.LoginButtonEnabled, success: true), setter, new Tuple<Func<DG067AViewModel, object>, string>[1]
			{
				new Tuple<Func<DG067AViewModel, object>, string>((DG067AViewModel source) => source, "LoginButtonEnabled")
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
		this.LoadFromXaml(typeof(DG067A));
	}
}
