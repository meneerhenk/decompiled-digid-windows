using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.Triggers;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG031.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG031 : BasePage<DG031ViewModel>
{
	public DG031(DG031ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG031).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG031)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 24);
		string dG031_Titel = DigiDAppResources.DG031_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG031_Titel, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 61);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 18);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 24);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 18);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 21);
		string dG031_KnopBriefOntvangen = DigiDAppResources.DG031_KnopBriefOntvangen;
		VisualDiagnostics.RegisterSourceInfo(dG031_KnopBriefOntvangen, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 21);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 18);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 24);
		string dG031_Subtitel = DigiDAppResources.DG031_Subtitel;
		VisualDiagnostics.RegisterSourceInfo(dG031_Subtitel, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 59);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 18);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 43);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 18);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 21);
		string dG031_Helplink = DigiDAppResources.DG031_Helplink;
		VisualDiagnostics.RegisterSourceInfo(dG031_Helplink, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 21);
		BorderedButton borderedButton2 = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 14);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 17);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 43);
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 22);
		CollapseTrigger collapseTrigger = new CollapseTrigger();
		VisualDiagnostics.RegisterSourceInfo(collapseTrigger, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 30);
		CollapseTrigger collapseTrigger2 = new CollapseTrigger();
		VisualDiagnostics.RegisterSourceInfo(collapseTrigger2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 30);
		Trigger trigger = new Trigger(typeof(Grid));
		VisualDiagnostics.RegisterSourceInfo(trigger, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 22);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 18);
		BindingExtension bindingExtension8 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 21);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		borderedButton.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		label4.transientNamescope = nameScope;
		borderedButton2.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		tapGestureRecognizer.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label5.transientNamescope = nameScope;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		verticalStackLayout.SetValue(Grid.RowSpanProperty, 2);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { label, verticalStackLayout, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(19, 24)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 24);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG031_Titel);
		verticalStackLayout.Children.Add(label);
		bindingExtension.Path = "IntroText";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 24);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label2);
		borderedButton.SetValue(Element.AutomationIdProperty, "EnterLetterCodeButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension2.Path = "EnterLetterCodeCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 21);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase2);
		borderedButton.SetValue(Button.TextProperty, dG031_KnopBriefOntvangen);
		verticalStackLayout.Children.Add(borderedButton);
		staticResourceExtension2.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label3, verticalStackLayout, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(29, 24)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 24);
		}
		label3.SetValue(VisualElement.StyleProperty, obj2);
		label3.SetValue(Label.TextProperty, dG031_Subtitel);
		verticalStackLayout.Children.Add(label3);
		label4.SetValue(View.MarginProperty, new Thickness(0.0, -10.0, 0.0, 0.0));
		bindingExtension3.Path = "NewLetterText";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 43);
		}
		label4.SetBinding(Label.TextProperty, bindingBase3);
		verticalStackLayout.Children.Add(label4);
		borderedButton2.SetValue(Element.AutomationIdProperty, "RequestNewLetterButton");
		borderedButton2.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Secondary);
		bindingExtension4.Path = "RequestNewLetterCommand";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 21);
		}
		borderedButton2.SetBinding(Button.CommandProperty, bindingBase4);
		borderedButton2.SetValue(Button.TextProperty, dG031_Helplink);
		verticalStackLayout.Children.Add(borderedButton2);
		grid2.Children.Add(verticalStackLayout);
		grid.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(16.0));
		grid.SetValue(AutomationProperties.ExcludedWithChildrenProperty, false);
		grid.SetValue(VisualElement.BackgroundColorProperty, new Color(1f, 0.95686275f, 44f / 51f, 1f));
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		staticResourceExtension3.Key = "IsStringNotNullOrWhiteSpaceConverter";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { bindingExtension5, grid, grid2, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 17)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		bindingExtension5.Converter = (IValueConverter)obj3;
		bindingExtension5.Path = "MessageText";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		grid.SetBinding(VisualElement.IsEnabledProperty, bindingBase5);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto)));
		bindingExtension6.Path = "MessageText";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 17);
		}
		grid.SetBinding(SemanticProperties.DescriptionProperty, bindingBase6);
		bindingExtension7.Path = "HideToastCommand";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 43);
		}
		tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, bindingBase7);
		grid.GestureRecognizers.Add(tapGestureRecognizer);
		trigger.Property = VisualElement.IsEnabledProperty;
		trigger.Value = "True";
		collapseTrigger.IsVisible = true;
		trigger.EnterActions.Add(collapseTrigger);
		collapseTrigger2.IsVisible = false;
		trigger.ExitActions.Add(collapseTrigger2);
		((IList<TriggerBase>)grid.GetValue(VisualElement.TriggersProperty)).Add(trigger);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_icon_melding_attentie.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(image);
		label5.SetValue(Grid.ColumnProperty, 1);
		bindingExtension8.Path = "MessageText";
		BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Pages\\DG031.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 21);
		}
		label5.SetBinding(Label.TextProperty, bindingBase8);
		label5.SetValue(Label.TextColorProperty, Colors.Black);
		label5.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(label5);
		grid2.Children.Add(grid);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG031ViewModel, string> setter = delegate(DG031ViewModel source, string value)
			{
				source.IntroText = value;
			};
			return new TypedBinding<DG031ViewModel, string>((DG031ViewModel source) => (value: source.IntroText, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "IntroText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG031ViewModel, ICommand> setter = null;
			return new TypedBinding<DG031ViewModel, ICommand>((DG031ViewModel source) => ((ICommand value, bool success))(value: source.EnterLetterCodeCommand, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "EnterLetterCodeCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG031ViewModel, string> setter = delegate(DG031ViewModel source, string value)
			{
				source.NewLetterText = value;
			};
			return new TypedBinding<DG031ViewModel, string>((DG031ViewModel source) => (value: source.NewLetterText, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "NewLetterText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG031ViewModel, ICommand> setter = null;
			return new TypedBinding<DG031ViewModel, ICommand>((DG031ViewModel source) => ((ICommand value, bool success))(value: source.RequestNewLetterCommand, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "RequestNewLetterCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG031ViewModel, string> setter = delegate(DG031ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG031ViewModel, string>((DG031ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "MessageText")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG031ViewModel, string> setter = delegate(DG031ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG031ViewModel, string>((DG031ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "MessageText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DG031ViewModel, ICommand> setter = null;
			return new TypedBinding<DG031ViewModel, ICommand>((DG031ViewModel source) => ((ICommand value, bool success))(value: source.HideToastCommand, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "HideToastCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<DG031ViewModel, string> setter = delegate(DG031ViewModel source, string? value)
			{
				source.MessageText = value;
			};
			return new TypedBinding<DG031ViewModel, string>((DG031ViewModel source) => (value: source.MessageText, success: true), setter, new Tuple<Func<DG031ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG031ViewModel, object>, string>((DG031ViewModel source) => source, "MessageText")
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
		this.LoadFromXaml(typeof(DG031));
	}
}
