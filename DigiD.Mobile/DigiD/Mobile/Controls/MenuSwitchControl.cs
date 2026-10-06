using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
[XamlFilePath("Controls\\MenuSwitchControl.xaml")]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Controls_MenuSwitchControlWinRTTypeDetails))]
public class MenuSwitchControl : Grid
{
	public static readonly BindableProperty CheckedProperty = BindableProperty.Create("Checked", typeof(bool), typeof(MenuSwitchControl), false, BindingMode.TwoWay, null, CheckedPropertyChanged);

	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(MenuSwitchControl), null, BindingMode.OneWay, null, TextPropertyChanged);

	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(MenuSwitchControl));

	public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSource", typeof(ImageSource), typeof(MenuSwitchControl), null, BindingMode.OneWay, null, ImageSourcePropertyChanged);

	private bool _initialized;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid @this;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Image Image;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label Label;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border borderedFrame;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Switch ToggleSwitch;

	public bool Checked
	{
		get
		{
			return (bool)GetValue(CheckedProperty);
		}
		set
		{
			SetValue(CheckedProperty, value);
		}
	}

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

	public ImageSource ImageSource
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceProperty);
		}
		set
		{
			SetValue(ImageSourceProperty, value);
		}
	}

	private static void ImageSourcePropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		((MenuSwitchControl)bindable).Image.Source = (ImageSource)newvalue;
	}

	private static void CheckedPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		((MenuSwitchControl)bindable).ToggleSwitch.IsToggled = (bool)newvalue;
	}

	private static void TextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		((MenuSwitchControl)bindable).Label.Text = (string)newvalue;
	}

	public MenuSwitchControl()
	{
		InitializeComponent();
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		_initialized = true;
	}

	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if (VisualElement.HeightRequestProperty.PropertyName == propertyName)
		{
			SetRowHeight(base.HeightRequest);
		}
	}

	public void SetRowHeight(GridLength height)
	{
		if (base.RowDefinitions.Count > 0)
		{
			base.RowDefinitions[0].Height = height;
		}
	}

	private void ToggleSwitch_OnToggled(object? sender, ToggledEventArgs? e)
	{
		if (e != null)
		{
			Checked = e.Value;
			if (DeviceInfo.Platform == DevicePlatform.iOS)
			{
				AppSession.ServiceProvider.GetRequiredService<IA11YService>().Speak(Checked ? CommonResources.Alg_On : CommonResources.Alg_Off);
			}
			if (_initialized && Command != null && Command.CanExecute(e.Value))
			{
				Command.Execute(e.Value);
			}
		}
	}

	private void ToggleSwitch_Focused(object? sender, FocusEventArgs? e)
	{
		if (e != null && Application.Current != null)
		{
			Color color = (Color)Application.Current.Resources["FocusRectangleColor"];
			borderedFrame.Stroke = (e.IsFocused ? color : Colors.Transparent);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("this")]
	[MemberNotNull("Image")]
	[MemberNotNull("Label")]
	[MemberNotNull("borderedFrame")]
	[MemberNotNull("ToggleSwitch")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(MenuSwitchControl).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(MenuSwitchControl)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 7, 5);
		DynamicResource dynamicResource = new DynamicResource("MenuItemBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 9, 5);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 20, 6);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 13);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 13);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 50);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 22);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 22);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 18);
		Switch obj = new Switch();
		VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 10);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("this", this);
		if (StyleId == null)
		{
			string text = (StyleId = "this");
		}
		image.transientNamescope = nameScope;
		nameScope.RegisterName("Image", image);
		Image image2 = image;
		if (image2.StyleId == null)
		{
			string text = (image2.StyleId = "Image");
		}
		label.transientNamescope = nameScope;
		nameScope.RegisterName("Label", label);
		Label label2 = label;
		if (label2.StyleId == null)
		{
			string text = (label2.StyleId = "Label");
		}
		border.transientNamescope = nameScope;
		nameScope.RegisterName("borderedFrame", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "borderedFrame");
		}
		obj.transientNamescope = nameScope;
		nameScope.RegisterName("ToggleSwitch", obj);
		Switch obj2 = obj;
		if (obj2.StyleId == null)
		{
			string text = (obj2.StyleId = "ToggleSwitch");
		}
		this.@this = this;
		Image = image;
		Label = label;
		borderedFrame = border;
		ToggleSwitch = obj;
		onPlatformExtension.iOS = "10";
		onPlatformExtension.Android = "10,0";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, Microsoft.Maui.Controls.Layout.PaddingProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(7, 5)));
		object obj3 = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 7, 5);
		}
		SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, obj3);
		((IDynamicResourceHandler)this).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		SetValue(Grid.ColumnSpacingProperty, 10.0);
		SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star)));
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 34.0);
		image.SetValue(VisualElement.WidthRequestProperty, 34.0);
		Children.Add(image);
		label.SetValue(Grid.ColumnProperty, 1);
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label.SetValue(Label.LineBreakModeProperty, LineBreakMode.WordWrap);
		label.SetValue(Label.MaxLinesProperty, 3);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		Children.Add(label);
		border.SetValue(Grid.ColumnProperty, 2);
		border.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		obj.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		obj.Focused += ToggleSwitch_Focused;
		obj.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		referenceExtension.Name = "Label";
		Label label3 = label;
		if (VisualDiagnostics.GetSourceInfo(label3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 13);
		}
		bindingExtension.Source = label3;
		bindingExtension.Path = "Text";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 13);
		}
		obj.SetBinding(SemanticProperties.DescriptionProperty, binding);
		obj.Toggled += ToggleSwitch_OnToggled;
		obj.Unfocused += ToggleSwitch_Focused;
		obj.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		multiBinding.StringFormat = "{0}{1}";
		bindingExtension2.Path = "AutomationId";
		referenceExtension2.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 50);
		}
		bindingExtension2.Source = this;
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 22);
		}
		multiBinding.Bindings.Add(binding2);
		bindingExtension3.Source = "ToggleSwitch";
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("Controls\\MenuSwitchControl.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 22);
		}
		multiBinding.Bindings.Add(binding3);
		obj.SetBinding(Element.AutomationIdProperty, multiBinding);
		border.SetValue(Border.ContentProperty, obj);
		Children.Add(border);
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
	[MemberNotNull("this")]
	[MemberNotNull("Image")]
	[MemberNotNull("Label")]
	[MemberNotNull("borderedFrame")]
	[MemberNotNull("ToggleSwitch")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(MenuSwitchControl));
		this.@this = this.FindByName<Grid>("this");
		Image = this.FindByName<Image>("Image");
		Label = this.FindByName<Label>("Label");
		borderedFrame = this.FindByName<Border>("borderedFrame");
		ToggleSwitch = this.FindByName<Switch>("ToggleSwitch");
	}
}
