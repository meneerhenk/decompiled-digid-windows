using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Controls;

[XamlFilePath("MenuItemSelectView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class MenuItemSelectView : ContentView
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(MenuItemSelectView), string.Empty, BindingMode.OneWay, null, OnTextPropertyChanged);

	public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create("IsSelected", typeof(bool), typeof(MenuItemSelectView), false, BindingMode.OneWay, null, OnIsSelectedChanged);

	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(MenuItemSelectView));

	public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(MenuItemSelectView));

	private readonly A11YBehavior a11YBehavior;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ContentView This;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border Border;

	public string Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public ICommand? Command
	{
		get
		{
			return (ICommand)GetValue(CommandProperty);
		}
		set
		{
			SetValue(CommandProperty, value);
		}
	}

	public object? CommandParameter
	{
		get
		{
			return GetValue(CommandParameterProperty);
		}
		set
		{
			SetValue(CommandParameterProperty, value);
		}
	}

	public string? AutomationTestId { get; set; }

	private static void OnTextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		((MenuItemSelectView)bindable).a11YBehavior.Description = newvalue as string;
	}

	private static void OnIsSelectedChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		((MenuItemSelectView)bindable).OnLanguageChanged(bindable, null);
	}

	public MenuItemSelectView()
	{
		InitializeComponent();
		a11YBehavior = new A11YBehavior
		{
			Role = A11YRole.Button
		};
		base.Behaviors.Add(a11YBehavior);
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, new Binding("Text", BindingMode.Default, null, null, null, this));
		a11YBehavior.SetBinding(A11YBehavior.CommandProperty, new Binding("Command", BindingMode.Default, null, null, null, this));
		a11YBehavior.SetBinding(A11YBehavior.CommandParameterProperty, new Binding("CommandParameter", BindingMode.Default, null, null, null, this));
		if (!WeakReferenceMessenger.Default.IsRegistered<LanguageChangedMessage>(this))
		{
			WeakReferenceMessenger.Default.Register<LanguageChangedMessage>(this, OnLanguageChanged);
		}
	}

	private void OnLanguageChanged(object recipient, LanguageChangedMessage? message)
	{
		if (recipient is MenuItemSelectView menuItemSelectView)
		{
			bool flag = string.IsNullOrWhiteSpace(menuItemSelectView.a11YBehavior.StateDescription);
			string text = AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>()["Alg_Selected"];
			menuItemSelectView.a11YBehavior.StateDescription = (menuItemSelectView.IsSelected ? text : null);
			if (!flag)
			{
				AppSession.ServiceProvider.GetRequiredService<IA11YService>().Speak(text);
			}
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("This")]
	[MemberNotNull("Border")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(MenuItemSelectView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(MenuItemSelectView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		DynamicResource dynamicResource = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 74);
		Setter setter = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 22);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 14);
		DynamicResource dynamicResource2 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 74);
		Setter setter2 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 22);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 14);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 10);
		DynamicResource dynamicResource3 = new DynamicResource("MenuItemBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 9);
		DynamicResource dynamicResource4 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource4, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 23, 13);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 10);
		DynamicResource dynamicResource5 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource5, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 13);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		DynamicResource dynamicResource6 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource6, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 13);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 38, 21);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 38, 21);
		DynamicResource dynamicResource7 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource7, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 51);
		Setter setter3 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 22);
		DataTrigger dataTrigger = new DataTrigger(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(dataTrigger, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 18);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 10);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 49, 13);
		ReferenceExtension referenceExtension4 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension4, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 13);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 13);
		DynamicResource dynamicResource8 = new DynamicResource("iconInstellingenTaalVink");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource8, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 52, 13);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 46, 10);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("This", this);
		if (StyleId == null)
		{
			string text = (StyleId = "This");
		}
		INameScope nameScope2 = new NameScope();
		grid.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		nameScope.RegisterName("Border", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "Border");
		}
		label.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		This = this;
		Border = border;
		onPlatformExtension.iOS = "True";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(9, 5)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		}
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		visualStateGroup.Name = "CommonStates";
		visualState.Name = "Normal";
		Setter setter4 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeThicknessProperty,
			Value = 0.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 22);
		}
		IList<Setter> setters = visualState.Setters;
		setters.Add(setter4);
		setter.TargetName = "Border";
		setter.Property = Border.StrokeProperty;
		setter.Value = dynamicResource;
		Setter setter5 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeProperty,
			Value = dynamicResource
		};
		if (VisualDiagnostics.GetSourceInfo(setter5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 22);
		}
		setters.Add(setter5);
		visualStateGroup.States.Add(visualState);
		visualState2.Name = "Focused";
		Setter setter6 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeThicknessProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 68, 22);
		}
		IList<Setter> setters2 = visualState2.Setters;
		setters2.Add(setter6);
		setter2.TargetName = "Border";
		setter2.Property = Border.StrokeProperty;
		setter2.Value = dynamicResource2;
		Setter setter7 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeProperty,
			Value = dynamicResource2
		};
		if (VisualDiagnostics.GetSourceInfo(setter7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter7, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 22);
		}
		setters2.Add(setter7);
		visualStateGroup.States.Add(visualState2);
		((IList<VisualStateGroup>)GetValue(VisualStateManager.VisualStateGroupsProperty)).Add(visualStateGroup);
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(10.0, 0.0, 0.0, 0.0));
		((IDynamicResourceHandler)grid).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource3.Key);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(new GridLength(48.0, GridUnitType.Absolute))));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star)));
		border.SetValue(Grid.ColumnSpanProperty, 2);
		border.SetValue(View.MarginProperty, new Thickness(2.0));
		border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		border.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		((IDynamicResourceHandler)border).SetDynamicResource(Border.StrokeProperty, dynamicResource4.Key);
		grid.Children.Add(border);
		label.SetValue(Grid.ColumnProperty, 0);
		label.SetValue(View.MarginProperty, new Thickness(10.0, 10.0, 0.0, 10.0));
		label.SetValue(Label.PaddingProperty, new Thickness(0.0, 4.0, 0.0, 4.0));
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		((IDynamicResourceHandler)label).SetDynamicResource(Label.FontFamilyProperty, dynamicResource5.Key);
		label.SetValue(Label.LineBreakModeProperty, LineBreakMode.WordWrap);
		label.SetValue(Label.MaxLinesProperty, 3);
		referenceExtension.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "Text";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		}
		label.SetBinding(Label.TextProperty, binding);
		((IDynamicResourceHandler)label).SetDynamicResource(Label.TextColorProperty, dynamicResource6.Key);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		referenceExtension2.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 38, 21);
		}
		bindingExtension2.Source = this;
		bindingExtension2.Path = "IsSelected";
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 38, 21);
		}
		dataTrigger.Binding = binding2;
		dataTrigger.Value = "True";
		setter3.Property = Label.FontFamilyProperty;
		setter3.Value = dynamicResource7;
		Setter setter8 = new Setter
		{
			Property = Label.FontFamilyProperty,
			Value = dynamicResource7
		};
		if (VisualDiagnostics.GetSourceInfo(setter8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter8, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 22);
		}
		dataTrigger.Setters.Add(setter8);
		((IList<TriggerBase>)label.GetValue(VisualElement.TriggersProperty)).Add(dataTrigger);
		grid.Children.Add(label);
		image.SetValue(Grid.ColumnProperty, 1);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		referenceExtension3.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 49, 13);
		}
		image.SetValue(BindableObject.BindingContextProperty, this);
		image.SetValue(VisualElement.HeightRequestProperty, 20.0);
		referenceExtension4.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 13);
		}
		bindingExtension3.Source = this;
		bindingExtension3.Path = "IsSelected";
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("MenuItemSelectView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 13);
		}
		image.SetBinding(VisualElement.IsVisibleProperty, binding3);
		((IDynamicResourceHandler)image).SetDynamicResource(Image.SourceProperty, dynamicResource8.Key);
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		image.SetValue(VisualElement.WidthRequestProperty, 20.0);
		grid.Children.Add(image);
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
	[MemberNotNull("This")]
	[MemberNotNull("Border")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(MenuItemSelectView));
		This = this.FindByName<ContentView>("This");
		Border = this.FindByName<Border>("Border");
	}
}
