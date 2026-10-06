using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.Models.ResponseModels;
using DigiD.Mobile.Converters;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Views;

[XamlFilePath("Views\\CustomMessageView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class CustomMessageView : ContentView
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border Border;

	public CustomMessageView()
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("Border")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomMessageView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomMessageView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		MessageBoxBackgroundColorConverter messageBoxBackgroundColorConverter = new MessageBoxBackgroundColorConverter();
		VisualDiagnostics.RegisterSourceInfo(messageBoxBackgroundColorConverter, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 10, 10);
		MessageBoxTextColorConverter messageBoxTextColorConverter = new MessageBoxTextColorConverter();
		VisualDiagnostics.RegisterSourceInfo(messageBoxTextColorConverter, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 10);
		NewLineConverter newLineConverter = new NewLineConverter();
		VisualDiagnostics.RegisterSourceInfo(newLineConverter, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 10);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 14);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 10);
		AppThemeBindingExtension appThemeBindingExtension = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 13);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 10);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 55);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 14);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 47);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 47);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 24);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 24);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 91);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 91);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 10);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		INameScope nameScope2 = new NameScope();
		grid.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		nameScope.RegisterName("Border", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "Border");
		}
		verticalStackLayout2.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		Border = border;
		ResourceDictionary resources = Resources;
		resources["MessageBoxBackgroundColorConverter"] = messageBoxBackgroundColorConverter;
		resources["MessageBoxTextColorConverter"] = messageBoxTextColorConverter;
		resources["NewLineConverter"] = newLineConverter;
		visualStateGroup.Name = "CommonStates";
		visualState.Name = "Normal";
		Setter setter = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeThicknessProperty,
			Value = 0.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 22);
		}
		visualState.Setters.Add(setter);
		visualStateGroup.States.Add(visualState);
		visualState2.Name = "Focused";
		Setter setter2 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeThicknessProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 22);
		}
		visualState2.Setters.Add(setter2);
		visualStateGroup.States.Add(visualState2);
		((IList<VisualStateGroup>)GetValue(VisualStateManager.VisualStateGroupsProperty)).Add(visualStateGroup);
		border.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		appThemeBindingExtension.Dark = "White";
		appThemeBindingExtension.Light = "Black";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { border, grid, this }, Border.StrokeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 13)));
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)appThemeBindingExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 13);
		}
		border.SetBinding(Border.StrokeProperty, bindingBase);
		grid.Children.Add(border);
		verticalStackLayout2.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 20.0));
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 4.0);
		staticResourceExtension.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label, verticalStackLayout2, grid, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(22, 20)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 20);
		}
		label.SetValue(VisualElement.StyleProperty, obj);
		bindingExtension.StringFormat = "{0:ddd dd-MM-yyyy, HH:mm:ss}";
		bindingExtension.Path = "DateTime";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 55);
		}
		label.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout2.Children.Add(label);
		verticalStackLayout.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(10.0));
		staticResourceExtension2.Key = "MessageBoxBackgroundColorConverter";
		MessageBoxBackgroundColorConverter messageBoxBackgroundColorConverter2 = messageBoxBackgroundColorConverter;
		if (VisualDiagnostics.GetSourceInfo(messageBoxBackgroundColorConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(messageBoxBackgroundColorConverter2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 47);
		}
		bindingExtension2.Converter = messageBoxBackgroundColorConverter2;
		bindingExtension2.Path = "IsNew";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 47);
		}
		verticalStackLayout.SetBinding(VisualElement.BackgroundColorProperty, bindingBase3);
		staticResourceExtension3.Key = "NewLineConverter";
		NewLineConverter newLineConverter2 = newLineConverter;
		if (VisualDiagnostics.GetSourceInfo(newLineConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(newLineConverter2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 24);
		}
		bindingExtension3.Converter = newLineConverter2;
		bindingExtension3.Path = "Text";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 24);
		}
		label2.SetBinding(Label.TextProperty, bindingBase4);
		staticResourceExtension4.Key = "MessageBoxTextColorConverter";
		MessageBoxTextColorConverter messageBoxTextColorConverter2 = messageBoxTextColorConverter;
		if (VisualDiagnostics.GetSourceInfo(messageBoxTextColorConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(messageBoxTextColorConverter2, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 91);
		}
		bindingExtension4.Converter = messageBoxTextColorConverter2;
		bindingExtension4.Path = "IsNew";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Views\\CustomMessageView.xaml;assembly=DigiD.Mobile", UriKind.Relative), 25, 91);
		}
		label2.SetBinding(Label.TextColorProperty, bindingBase5);
		verticalStackLayout.Children.Add(label2);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		grid.Children.Add(verticalStackLayout2);
		SetValue(ContentView.ContentProperty, grid);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<MessageModel, DateTime> setter3 = null;
			return new TypedBinding<MessageModel, DateTime>((MessageModel source) => (value: source.DateTime, success: true), setter3, new Tuple<Func<MessageModel, object>, string>[1]
			{
				new Tuple<Func<MessageModel, object>, string>((MessageModel source) => source, "DateTime")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<MessageModel, bool> setter3 = null;
			return new TypedBinding<MessageModel, bool>((MessageModel source) => (value: source.IsNew, success: true), setter3, new Tuple<Func<MessageModel, object>, string>[1]
			{
				new Tuple<Func<MessageModel, object>, string>((MessageModel source) => source, "IsNew")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<MessageModel, string> setter3 = delegate(MessageModel source, string value)
			{
				source.Text = value;
			};
			return new TypedBinding<MessageModel, string>((MessageModel source) => (value: source.Text, success: true), setter3, new Tuple<Func<MessageModel, object>, string>[1]
			{
				new Tuple<Func<MessageModel, object>, string>((MessageModel source) => source, "Text")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<MessageModel, bool> setter3 = null;
			return new TypedBinding<MessageModel, bool>((MessageModel source) => (value: source.IsNew, success: true), setter3, new Tuple<Func<MessageModel, object>, string>[1]
			{
				new Tuple<Func<MessageModel, object>, string>((MessageModel source) => source, "IsNew")
			})
			{
				Converter = extension.Converter
			};
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
	[MemberNotNull("Border")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomMessageView));
		Border = this.FindByName<Border>("Border");
	}
}
