using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Models;
using DigiD.Common.Resources;
using DigiD.Mobile.Controls;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG053.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG053 : BasePage<DG053ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private DataTemplate dataTemplate;

	public DG053()
		: base((DG053ViewModel?)null)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("dataTemplate")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG053).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG053)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate noScrollViewTemplate = TemplateSelector.NoScrollViewTemplate;
		VisualDiagnostics.RegisterSourceInfo(noScrollViewTemplate, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 18);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 13);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 13);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 25);
		string dG053_Titel = DigiDAppResources.DG053_Titel;
		VisualDiagnostics.RegisterSourceInfo(dG053_Titel, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 25);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 22);
		string dG053_Info = DigiDAppResources.DG053_Info;
		VisualDiagnostics.RegisterSourceInfo(dG053_Info, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 25);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 22);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 18);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 18);
		CollectionView collectionView = new CollectionView();
		VisualDiagnostics.RegisterSourceInfo(collectionView, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		collectionView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		nameScope.RegisterName("dataTemplate", dataTemplate);
		this.dataTemplate = dataTemplate;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, noScrollViewTemplate);
		bindingExtension.Path = "Items";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 16, 13);
		}
		collectionView.SetBinding(ItemsView.ItemsSourceProperty, bindingBase);
		collectionView.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		collectionView.SetValue(ItemsView.RemainingItemsThresholdProperty, 5);
		bindingExtension2.Path = "LoadDataCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 13);
		}
		collectionView.SetBinding(ItemsView.RemainingItemsThresholdReachedCommandProperty, bindingBase2);
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		label.SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.Level1);
		staticResourceExtension.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { label, verticalStackLayout, collectionView, contentView, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(25, 25)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 25);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		label.SetValue(Label.TextProperty, dG053_Titel);
		verticalStackLayout.Children.Add(label);
		label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		label2.SetValue(View.MarginProperty, new Thickness(0.0, 20.0, 20.0, 20.0));
		label2.SetValue(Label.TextProperty, dG053_Info);
		verticalStackLayout.Children.Add(label2);
		collectionView.SetValue(StructuredItemsView.HeaderProperty, verticalStackLayout);
		dataTemplate.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		dataTemplate.LoadTemplate = delegate
		{
			UsageHistoryListItem usageHistoryListItem = new UsageHistoryListItem();
			VisualDiagnostics.RegisterSourceInfo(usageHistoryListItem, new Uri("Pages\\DG053.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 22);
			INameScope value = new NameScope();
			NameScope.SetNameScope(usageHistoryListItem, value);
			usageHistoryListItem.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			return usageHistoryListItem;
		};
		collectionView.SetValue(ItemsView.ItemTemplateProperty, dataTemplate);
		contentView.SetValue(ContentView.ContentProperty, collectionView);
		SetValue(ContentPage.ContentProperty, contentView);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DG053ViewModel, ObservableCollection<UsageHistoryModel>> setter = delegate(DG053ViewModel source, ObservableCollection<UsageHistoryModel> value)
			{
				source.Items = value;
			};
			return new TypedBinding<DG053ViewModel, ObservableCollection<UsageHistoryModel>>((DG053ViewModel source) => (value: source.Items, success: true), setter, new Tuple<Func<DG053ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG053ViewModel, object>, string>((DG053ViewModel source) => source, "Items")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DG053ViewModel, ICommand> setter = null;
			return new TypedBinding<DG053ViewModel, ICommand>((DG053ViewModel source) => ((ICommand value, bool success))(value: source.LoadDataCommand, success: true), setter, new Tuple<Func<DG053ViewModel, object>, string>[1]
			{
				new Tuple<Func<DG053ViewModel, object>, string>((DG053ViewModel source) => source, "LoadDataCommand")
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
	[MemberNotNull("dataTemplate")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG053));
		dataTemplate = this.FindByName<DataTemplate>("dataTemplate");
	}
}
