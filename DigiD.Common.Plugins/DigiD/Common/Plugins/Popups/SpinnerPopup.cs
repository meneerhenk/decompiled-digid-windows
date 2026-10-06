using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.Interfaces;
using DigiD.Common.Plugins.ViewModels;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Plugins.Popups;

[XamlFilePath("Popups\\SpinnerPopup.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class SpinnerPopup : ContentView
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ActivityIndicator activityIndicator;

	public SpinnerPopup(SpinnerPopupViewModel spinnerPopupViewModel)
	{
		InitializeComponent();
		base.BindingContext = spinnerPopupViewModel;
	}

	protected override void OnParentSet()
	{
		base.OnParentSet();
		AutomationProperties.SetIsInAccessibleTree(base.Parent, false);
	}

	private void ActivityIndicator_OnFocused(object? sender, FocusEventArgs e)
	{
		if (sender is ActivityIndicator bindable)
		{
			string description = SemanticProperties.GetDescription(bindable);
			AppSession.ServiceProvider.GetRequiredService<IA11YService>().Speak(description);
		}
	}

	private void ActivityIndicator_OnHandlerChanged(object? sender, EventArgs e)
	{
		if (sender != activityIndicator || activityIndicator.Handler != null)
		{
			if (DeviceInfo.Platform == DevicePlatform.Android)
			{
				AppSession.ServiceProvider.GetRequiredService<IA11YService>().NotifyForNewPage(activityIndicator);
			}
			activityIndicator.SetSemanticFocus();
		}
	}

	private void SpinnerPopup_OnLoaded(object? sender, EventArgs e)
	{
		activityIndicator.SetSemanticFocus();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("activityIndicator")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(SpinnerPopup).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(SpinnerPopup)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Popups\\SpinnerPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 21, 13);
		ActivityIndicator activityIndicator = new ActivityIndicator();
		VisualDiagnostics.RegisterSourceInfo(activityIndicator, new Uri("Popups\\SpinnerPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 14, 10);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Popups\\SpinnerPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 13, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Popups\\SpinnerPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 3, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		grid.transientNamescope = nameScope;
		activityIndicator.transientNamescope = nameScope;
		nameScope.RegisterName("activityIndicator", activityIndicator);
		ActivityIndicator activityIndicator2 = activityIndicator;
		if (activityIndicator2.StyleId == null)
		{
			string text = (activityIndicator2.StyleId = "activityIndicator");
		}
		this.activityIndicator = activityIndicator;
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		SetValue(VisualElement.HeightRequestProperty, 30.0);
		Loaded += SpinnerPopup_OnLoaded;
		SetValue(TemplatedView.PaddingProperty, new Thickness(0.0));
		SetValue(VisualElement.WidthRequestProperty, 30.0);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		activityIndicator.SetValue(ActivityIndicator.ColorProperty, Colors.White);
		activityIndicator.Focused += ActivityIndicator_OnFocused;
		activityIndicator.HandlerChanged += ActivityIndicator_OnHandlerChanged;
		activityIndicator.SetValue(ActivityIndicator.IsRunningProperty, true);
		activityIndicator.SetValue(View.MarginProperty, new Thickness(0.0));
		translateExtension.Text = "Alg_Spinner";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Popups\\SpinnerPopup.xaml;assembly=DigiD.Common.Plugins", UriKind.Relative), 21, 13);
		}
		activityIndicator.SetBinding(SemanticProperties.DescriptionProperty, bindingBase);
		grid.Children.Add(activityIndicator);
		SetValue(ContentView.ContentProperty, grid);
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
	[MemberNotNull("activityIndicator")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(SpinnerPopup));
		activityIndicator = this.FindByName<ActivityIndicator>("activityIndicator");
	}
}
