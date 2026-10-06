using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Models;
using DigiD.Common.Controls.Settings;
using DigiD.Mobile.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Pages;

[XamlFilePath("Pages\\DG062.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG062 : BasePage<DG062ViewModel>
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private MenuItemView Faq;

	public DG062(DG062ViewModel viewModel)
		: base(viewModel)
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Faq")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DG062).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DG062)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ControlTemplate currentTemplate = TemplateSelector.CurrentTemplate;
		VisualDiagnostics.RegisterSourceInfo(currentTemplate, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 18);
		ContactView contactView = new ContactView();
		VisualDiagnostics.RegisterSourceInfo(contactView, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 14);
		PageMenuItem<DG060> fAQMenuItem = DG062ViewModel.FAQMenuItem;
		VisualDiagnostics.RegisterSourceInfo(fAQMenuItem, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 17);
		MenuItemView menuItemView = new MenuItemView();
		VisualDiagnostics.RegisterSourceInfo(menuItemView, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 10);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Pages\\DG062.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		contentView.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		contactView.transientNamescope = nameScope;
		menuItemView.transientNamescope = nameScope;
		nameScope.RegisterName("Faq", menuItemView);
		MenuItemView menuItemView2 = menuItemView;
		if (menuItemView2.StyleId == null)
		{
			string text = (menuItemView2.StyleId = "Faq");
		}
		Faq = menuItemView;
		contentView.SetValue(TemplatedView.ControlTemplateProperty, currentTemplate);
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(20.0, 0.0, 20.0, 20.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		contactView.SetValue(BaseSettingsView.IntroProperty, "DG062_Intro");
		verticalStackLayout.Children.Add(contactView);
		menuItemView.SetValue(View.MarginProperty, new Thickness(-20.0, 10.0));
		menuItemView.SetValue(Element.AutomationIdProperty, "MenuItemFaq");
		menuItemView.SetValue(BindableObject.BindingContextProperty, fAQMenuItem);
		verticalStackLayout.Children.Add(menuItemView);
		contentView.SetValue(ContentView.ContentProperty, verticalStackLayout);
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
	[MemberNotNull("Faq")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(DG062));
		Faq = this.FindByName<MenuItemView>("Faq");
	}
}
