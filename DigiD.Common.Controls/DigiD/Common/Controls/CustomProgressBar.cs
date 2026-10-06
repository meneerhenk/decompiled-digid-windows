using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.ProgressBar;

namespace DigiD.Common.Controls;

[XamlFilePath("CustomProgressBar.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class CustomProgressBar : SfLinearProgressBar
{
	public CustomProgressBar()
	{
		InitializeComponent();
	}

	private void SfLinearProgressBar_ProgressCompleted(object? sender, ProgressValueEventArgs? e)
	{
		if (sender is SfLinearProgressBar sfLinearProgressBar)
		{
			sfLinearProgressBar.ProgressFill = (Color)Application.Current.Resources["Green1"];
		}
	}

	private void CustomProgressBar_OnProgressChanged(object? sender, ProgressValueEventArgs e)
	{
		if (e.Progress < 100.0 && sender is SfLinearProgressBar sfLinearProgressBar)
		{
			sfLinearProgressBar.ProgressFill = (Color)Application.Current.Resources["PrimaryColor"];
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomProgressBar).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomProgressBar)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomProgressBar.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 5);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("CustomProgressBar.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 5);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomProgressBar.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope((BindableObject)(object)this) ?? new NameScope();
		NameScope.SetNameScope((BindableObject)(object)this, nameScope);
		((BindableObject)(object)this).SetValue(View.MarginProperty, (object)new Thickness(0.0, 10.0, 0.0, 0.0));
		((BindableObject)(object)this).SetValue(ProgressBarBase.AnimationDurationProperty, (object)0.0);
		ProgressChanged += CustomProgressBar_OnProgressChanged;
		ProgressCompleted += SfLinearProgressBar_ProgressCompleted;
		staticResourceExtension.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, ProgressBarBase.ProgressFillProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(10, 5)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomProgressBar.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 5);
		}
		((BindableObject)(object)this).SetValue(ProgressBarBase.ProgressFillProperty, obj);
		((BindableObject)(object)this).SetValue(SfLinearProgressBar.ProgressHeightProperty, (object)10.0);
		staticResourceExtension2.Key = "PrimaryColorTransparent";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[1] { this }, ProgressBarBase.TrackFillProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(12, 5)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("CustomProgressBar.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 5);
		}
		((BindableObject)(object)this).SetValue(ProgressBarBase.TrackFillProperty, obj2);
		((BindableObject)(object)this).SetValue(SfLinearProgressBar.TrackHeightProperty, (object)10.0);
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
		this.LoadFromXaml(typeof(CustomProgressBar));
	}
}
