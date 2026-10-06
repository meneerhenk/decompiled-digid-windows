using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Controls;

[XamlFilePath("CustomCheckBox.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class CustomCheckBox : Grid
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(CustomCheckBox), null, BindingMode.OneWay, null, TextPropertyChanged);

	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(CustomCheckBox), null, BindingMode.TwoWay, null, CommandPropertyChanged);

	public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(CustomCheckBox), false, BindingMode.TwoWay);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid HideSwitch;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BoolToObjectConverter OnOffConverter;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BoolToObjectConverter ImageConverter;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private A11YBehavior CheckBoxBehavior;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border Border;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Image Image;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label Label;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? tapCommand;

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

	public bool IsChecked
	{
		get
		{
			return (bool)GetValue(IsCheckedProperty);
		}
		set
		{
			SetValue(IsCheckedProperty, value);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand TapCommand => tapCommand ?? (tapCommand = new RelayCommand(Tap));

	private static void CommandPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		if (bindable is CustomCheckBox customCheckBox)
		{
			customCheckBox.CheckBoxBehavior.Command = newvalue as ICommand;
		}
	}

	private static void TextPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		if (bindable is CustomCheckBox customCheckBox)
		{
			customCheckBox.Label.Text = (newvalue as string) ?? string.Empty;
			customCheckBox.CheckBoxBehavior.Description = (newvalue as string) ?? string.Empty;
		}
	}

	public CustomCheckBox()
	{
		InitializeComponent();
	}

	[RelayCommand]
	private void Tap()
	{
		IsChecked = !IsChecked;
		ICommand? command = Command;
		if (command != null && command.CanExecute(null))
		{
			Command.Execute(null);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("HideSwitch")]
	[MemberNotNull("OnOffConverter")]
	[MemberNotNull("ImageConverter")]
	[MemberNotNull("CheckBoxBehavior")]
	[MemberNotNull("Border")]
	[MemberNotNull("Image")]
	[MemberNotNull("Label")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomCheckBox).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomCheckBox)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		string alg_On = CommonResources.Alg_On;
		VisualDiagnostics.RegisterSourceInfo(alg_On, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 17);
		string alg_Off = CommonResources.Alg_Off;
		VisualDiagnostics.RegisterSourceInfo(alg_Off, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 17);
		BoolToObjectConverter boolToObjectConverter = new BoolToObjectConverter();
		VisualDiagnostics.RegisterSourceInfo(boolToObjectConverter, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 14);
		BoolToObjectConverter boolToObjectConverter2 = new BoolToObjectConverter();
		VisualDiagnostics.RegisterSourceInfo(boolToObjectConverter2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 14);
		ResourceDictionary resourceDictionary = new ResourceDictionary();
		VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 10);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 13);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 13);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 13);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 13);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 10);
		DynamicResource dynamicResource = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 74);
		Setter setter = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 22);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 14);
		DynamicResource dynamicResource2 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 70, 74);
		Setter setter2 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 70, 22);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 14);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 10);
		DynamicResource dynamicResource3 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 9);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 6);
		ReferenceExtension referenceExtension4 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension4, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 9);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 9);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 9);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 6);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 9);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 9);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("HideSwitch", this);
		if (StyleId == null)
		{
			string text = (StyleId = "HideSwitch");
		}
		nameScope.RegisterName("OnOffConverter", boolToObjectConverter);
		nameScope.RegisterName("ImageConverter", boolToObjectConverter2);
		nameScope.RegisterName("CheckBoxBehavior", a11YBehavior);
		INameScope nameScope2 = new NameScope();
		border.transientNamescope = nameScope;
		nameScope.RegisterName("Border", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "Border");
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
		HideSwitch = this;
		OnOffConverter = boolToObjectConverter;
		ImageConverter = boolToObjectConverter2;
		CheckBoxBehavior = a11YBehavior;
		Border = border;
		Image = image;
		Label = label;
		Resources = resourceDictionary;
		boolToObjectConverter.TrueObject = alg_On;
		boolToObjectConverter.FalseObject = alg_Off;
		ICommunityToolkitValueConverter communityToolkitValueConverter = ((IMarkupExtension<ICommunityToolkitValueConverter>)boolToObjectConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 14);
		}
		resourceDictionary["OnOffConverter"] = communityToolkitValueConverter;
		boolToObjectConverter2.TrueObject = "digid_icon_have_read.png";
		boolToObjectConverter2.FalseObject = "digid_icon_have_not_read.png";
		ICommunityToolkitValueConverter communityToolkitValueConverter2 = ((IMarkupExtension<ICommunityToolkitValueConverter>)boolToObjectConverter2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 20, 14);
		}
		resourceDictionary["ImageConverter"] = communityToolkitValueConverter2;
		SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star)));
		SetValue(Grid.ColumnSpacingProperty, 4.0);
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		Resources = resourceDictionary;
		referenceExtension.Name = "HideSwitch";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 13);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "TapCommand";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 13);
		}
		a11YBehavior.SetBinding(A11YBehavior.CommandProperty, binding);
		referenceExtension2.Name = "Label";
		Label label3 = label;
		if (VisualDiagnostics.GetSourceInfo(label3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 13);
		}
		bindingExtension2.Source = label3;
		bindingExtension2.Path = "Text";
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 13);
		}
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, binding2);
		a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
		referenceExtension3.Name = "HideSwitch";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		}
		bindingExtension3.Source = this;
		bindingExtension3.Path = "IsChecked";
		staticResourceExtension.Key = "OnOffConverter";
		ICommunityToolkitValueConverter communityToolkitValueConverter3 = communityToolkitValueConverter;
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		}
		bindingExtension3.Converter = communityToolkitValueConverter3;
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 13);
		}
		a11YBehavior.SetBinding(A11YBehavior.StateDescriptionProperty, binding3);
		((IList<Behavior>)GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
		visualStateGroup.Name = "CommonStates";
		visualState.Name = "Normal";
		Setter setter3 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeThicknessProperty,
			Value = 0.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 22);
		}
		IList<Setter> setters = visualState.Setters;
		setters.Add(setter3);
		setter.TargetName = "Border";
		setter.Property = Border.StrokeProperty;
		setter.Value = dynamicResource;
		Setter setter4 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeProperty,
			Value = dynamicResource
		};
		if (VisualDiagnostics.GetSourceInfo(setter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 22);
		}
		setters.Add(setter4);
		visualStateGroup.States.Add(visualState);
		visualState2.Name = "Focused";
		Setter setter5 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeThicknessProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 22);
		}
		IList<Setter> setters2 = visualState2.Setters;
		setters2.Add(setter5);
		setter2.TargetName = "Border";
		setter2.Property = Border.StrokeProperty;
		setter2.Value = dynamicResource2;
		Setter setter6 = new Setter
		{
			TargetName = "Border",
			Property = Border.StrokeProperty,
			Value = dynamicResource2
		};
		if (VisualDiagnostics.GetSourceInfo(setter6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 70, 22);
		}
		setters2.Add(setter6);
		visualStateGroup.States.Add(visualState2);
		((IList<VisualStateGroup>)GetValue(VisualStateManager.VisualStateGroupsProperty)).Add(visualStateGroup);
		border.SetValue(Grid.ColumnSpanProperty, 2);
		border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		border.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		((IDynamicResourceHandler)border).SetDynamicResource(Border.StrokeProperty, dynamicResource3.Key);
		Children.Add(border);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(VisualElement.HeightRequestProperty, 24.0);
		referenceExtension4.Name = "HideSwitch";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 9);
		}
		bindingExtension4.Source = this;
		bindingExtension4.Path = "IsChecked";
		staticResourceExtension2.Key = "ImageConverter";
		ICommunityToolkitValueConverter communityToolkitValueConverter4 = communityToolkitValueConverter2;
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter4, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 9);
		}
		bindingExtension4.Converter = communityToolkitValueConverter4;
		Binding binding4 = new Binding(bindingExtension4.Path, bindingExtension4.Mode, bindingExtension4.Converter, bindingExtension4.ConverterParameter, bindingExtension4.StringFormat, bindingExtension4.Source)
		{
			UpdateSourceEventName = bindingExtension4.UpdateSourceEventName,
			FallbackValue = bindingExtension4.FallbackValue,
			TargetNullValue = bindingExtension4.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding4, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 9);
		}
		image.SetBinding(Image.SourceProperty, binding4);
		image.SetValue(VisualElement.WidthRequestProperty, 24.0);
		Children.Add(image);
		label.SetValue(Grid.ColumnProperty, 1);
		onPlatformExtension.Android = "false";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { label, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(55, 9)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 55, 9);
		}
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		staticResourceExtension3.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[2] { label, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(56, 9)));
		object obj2 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("CustomCheckBox.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 9);
		}
		label.SetValue(VisualElement.StyleProperty, obj2);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		Children.Add(label);
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
	[MemberNotNull("HideSwitch")]
	[MemberNotNull("OnOffConverter")]
	[MemberNotNull("ImageConverter")]
	[MemberNotNull("CheckBoxBehavior")]
	[MemberNotNull("Border")]
	[MemberNotNull("Image")]
	[MemberNotNull("Label")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomCheckBox));
		HideSwitch = this.FindByName<Grid>("HideSwitch");
		OnOffConverter = this.FindByName<BoolToObjectConverter>("OnOffConverter");
		ImageConverter = this.FindByName<BoolToObjectConverter>("ImageConverter");
		CheckBoxBehavior = this.FindByName<A11YBehavior>("CheckBoxBehavior");
		Border = this.FindByName<Border>("Border");
		Image = this.FindByName<Image>("Image");
		Label = this.FindByName<Label>("Label");
	}
}
