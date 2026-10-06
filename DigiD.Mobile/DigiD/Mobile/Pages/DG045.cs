using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Mobile.ViewModels;
using DigiD.Mobile.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG045.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG045 : BasePage<DG045ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CollectionView ListViewMessages;

	public DG045()
		: base((DG045ViewModel?)null)
	{
		InitializeComponent();
	}

	private void ListViewMessages_HandlerChanged(object? sender, EventArgs? e)
	{
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("ListViewMessages")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG045).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG045)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 18);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		string dG045_Titel = DigiDAppResources.DG045_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG045_Titel, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 14);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 18);
		string dG045_Melding = DigiDAppResources.DG045_Melding;
		VisualDiagnostics.RegisterSourceInfo(dG045_Melding, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 40);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 18);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		string dG045_NoMessages = DigiDAppResources.DG045_NoMessages;
		VisualDiagnostics.RegisterSourceInfo(dG045_NoMessages, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 48, 17);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 14);
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 22);
		CollectionView collectionView = new CollectionView();
		VisualDiagnostics.RegisterSourceInfo(collectionView, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 14);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 17);
		string dG045_Knop = DigiDAppResources.DG045_Knop;
		VisualDiagnostics.RegisterSourceInfo(dG045_Knop, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 80, 17);
		BorderedButton borderedButton = new BorderedButton();
		VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 14);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		grid2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		grid.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		label3.transientNamescope = nameScope;
		collectionView.transientNamescope = nameScope;
		nameScope.RegisterName("ListViewMessages", collectionView);
		CollectionView collectionView2 = collectionView;
		if (collectionView2.StyleId == null)
		{
			string text = (collectionView2.StyleId = "ListViewMessages");
		}
		borderedButton.transientNamescope = nameScope;
		ListViewMessages = collectionView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		grid2.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		grid2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		label.SetValue(Grid.RowProperty, 0);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(23, 17)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG045_Titel);
		grid2.Children.Add(label);
		grid.SetValue(Grid.RowProperty, 1);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		bindingExtension.Path = "OpenSettingsCommandVisible";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 17);
		}
		grid.SetBinding(VisualElement.IsVisibleProperty, bindingBase);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto)));
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 5.0, 0.0));
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 20.0);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("icon_foutmelding_kritiek.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		image.SetValue(VisualElement.WidthRequestProperty, 20.0);
		grid.Children.Add(image);
		label2.SetValue(Grid.ColumnProperty, 1);
		label2.SetValue(Label.TextProperty, dG045_Melding);
		grid.Children.Add(label2);
		grid2.Children.Add(grid);
		label3.SetValue(Grid.RowProperty, 2);
		label3.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
		staticResourceExtension2.Key = "BooleanInvertConverter";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { bindingExtension2, label3, grid2, contentView, this }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(46, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		}
		bindingExtension2.Converter = (IValueConverter)obj2;
		bindingExtension2.Path = "HasMessages";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 17);
		}
		label3.SetBinding(VisualElement.IsVisibleProperty, bindingBase2);
		staticResourceExtension3.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { label3, grid2, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(47, 17)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 17);
		}
		label3.SetValue(VisualElement.StyleProperty, obj3);
		label3.SetValue(Label.TextProperty, dG045_NoMessages);
		label3.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid2.Children.Add(label3);
		collectionView.SetValue(Grid.RowProperty, 2);
		((IDynamicResourceHandler)collectionView).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		collectionView.HandlerChanged += ListViewMessages_HandlerChanged;
		bindingExtension3.Path = "HasMessages";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 17);
		}
		collectionView.SetBinding(VisualElement.IsVisibleProperty, bindingBase3);
		collectionView.SetValue(StructuredItemsView.ItemSizingStrategyProperty, ItemSizingStrategy.MeasureAllItems);
		bindingExtension4.Path = "Messages";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 17);
		}
		collectionView.SetBinding(ItemsView.ItemsSourceProperty, bindingBase4);
		collectionView.SetValue(SelectableItemsView.SelectionModeProperty, SelectionMode.None);
		collectionView.SetValue(SemanticProperties.DescriptionProperty, "");
		collectionView.SetValue(ItemsView.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Default);
		dataTemplate.LoadTemplate = delegate
		{
			CustomMessageView customMessageView = new CustomMessageView();
			VisualDiagnostics.RegisterSourceInfo(customMessageView, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 26);
			INameScope value = new NameScope();
			NameScope.SetNameScope(customMessageView, value);
			return customMessageView;
		};
		collectionView.SetValue(ItemsView.ItemTemplateProperty, dataTemplate);
		grid2.Children.Add(collectionView);
		borderedButton.SetValue(Grid.RowProperty, 3);
		borderedButton.SetValue(Element.AutomationIdProperty, "OpenSettingsButton");
		borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
		bindingExtension5.Path = "OpenSettingsCommand";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 17);
		}
		borderedButton.SetBinding(Button.CommandProperty, bindingBase5);
		bindingExtension6.Path = "OpenSettingsCommandVisible";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Pages\\DG045.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 17);
		}
		borderedButton.SetBinding(VisualElement.IsVisibleProperty, bindingBase6);
		borderedButton.SetValue(Button.TextProperty, dG045_Knop);
		grid2.Children.Add(borderedButton);
		contentView.SetValue(ContentView.ContentProperty, grid2);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG045ViewModel, bool> setter = delegate(DG045ViewModel source, bool value)
			{
				source.OpenSettingsCommandVisible = value;
			};
			return new TypedBinding<DG045ViewModel, bool>((DG045ViewModel source) => (value: source.OpenSettingsCommandVisible, success: true), setter, new Tuple<Func<DG045ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG045ViewModel, object>, string>((DG045ViewModel source) => source, "OpenSettingsCommandVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG045ViewModel, bool> setter = null;
			return new TypedBinding<DG045ViewModel, bool>((DG045ViewModel source) => (value: source.HasMessages, success: true), setter, new Tuple<Func<DG045ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG045ViewModel, object>, string>((DG045ViewModel source) => source, "HasMessages")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DG045ViewModel, bool> setter = null;
			return new TypedBinding<DG045ViewModel, bool>((DG045ViewModel source) => (value: source.HasMessages, success: true), setter, new Tuple<Func<DG045ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG045ViewModel, object>, string>((DG045ViewModel source) => source, "HasMessages")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DG045ViewModel, List<MessageModel>> setter = delegate(DG045ViewModel source, List<MessageModel>? value)
			{
				source.Messages = value;
			};
			return new TypedBinding<DG045ViewModel, List<MessageModel>>((DG045ViewModel source) => (value: source.Messages, success: true), setter, new Tuple<Func<DG045ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG045ViewModel, object>, string>((DG045ViewModel source) => source, "Messages")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DG045ViewModel, ICommand> setter = null;
			return new TypedBinding<DG045ViewModel, ICommand>((DG045ViewModel source) => ((ICommand value, bool success))(value: source.OpenSettingsCommand, success: true), setter, new Tuple<Func<DG045ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG045ViewModel, object>, string>((DG045ViewModel source) => source, "OpenSettingsCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DG045ViewModel, bool> setter = delegate(DG045ViewModel source, bool value)
			{
				source.OpenSettingsCommandVisible = value;
			};
			return new TypedBinding<DG045ViewModel, bool>((DG045ViewModel source) => (value: source.OpenSettingsCommandVisible, success: true), setter, new Tuple<Func<DG045ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG045ViewModel, object>, string>((DG045ViewModel source) => source, "OpenSettingsCommandVisible")
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
	[MemberNotNull("ListViewMessages")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG045));
		ListViewMessages = this.FindByName<CollectionView>("ListViewMessages");
	}
}
