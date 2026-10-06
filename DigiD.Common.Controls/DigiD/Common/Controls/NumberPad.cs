using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Helpers;
using DigiD.Common.Models.Messages;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("NumberPad.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class NumberPad : Grid
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout EmptyButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private NumberPadButton BiometricsButton;

	public NumberPad()
	{
		InitializeComponent();
		if (DisplayHelper.IsTablet)
		{
			SetTabletSize();
		}
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, delegate
		{
			SetTintColor();
		});
		SetTintColor();
	}

	private void SetTintColor()
	{
		ArgumentNullException.ThrowIfNull(Application.Current, "Application.Current");
		EmptyButton.SetDynamicResource(VisualElement.BackgroundColorProperty, "NumberPadButtonBackgroundColor");
		BiometricsButton.SetDynamicResource(VisualElement.BackgroundColorProperty, "NumberPadButtonBackgroundColor");
	}

	private void SetTabletSize()
	{
		bool flag = DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape;
		base.WidthRequest = DisplayHelper.Width * 0.4;
		base.HeightRequest = DisplayHelper.Height * (flag ? 0.4 : 0.30000000000000004);
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("EmptyButton")]
	[MemberNotNull("BiometricsButton")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(NumberPad).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(NumberPad)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		DynamicResource dynamicResource = new DynamicResource("NumberPadBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 5);
		OnIdiomExtension onIdiomExtension = new OnIdiomExtension();
		VisualDiagnostics.RegisterSourceInfo(onIdiomExtension, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 5);
		NumberPadButton numberPadButton = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 6);
		NumberPadButton numberPadButton2 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton2, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 6);
		NumberPadButton numberPadButton3 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton3, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 6);
		NumberPadButton numberPadButton4 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton4, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 6);
		NumberPadButton numberPadButton5 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton5, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 6);
		NumberPadButton numberPadButton6 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton6, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 50, 6);
		NumberPadButton numberPadButton7 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton7, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 6);
		NumberPadButton numberPadButton8 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton8, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 6);
		NumberPadButton numberPadButton9 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton9, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 71, 6);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 78, 6);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 88, 9);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 89, 9);
		bool flag = false;
		VisualDiagnostics.RegisterSourceInfo(flag, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 92, 14);
		NumberPadButton numberPadButton10 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton10, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 83, 6);
		NumberPadButton numberPadButton11 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton11, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 97, 6);
		NumberPadButton numberPadButton12 = new NumberPadButton();
		VisualDiagnostics.RegisterSourceInfo(numberPadButton12, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 103, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		numberPadButton.transientNamescope = nameScope;
		numberPadButton2.transientNamescope = nameScope;
		numberPadButton3.transientNamescope = nameScope;
		numberPadButton4.transientNamescope = nameScope;
		numberPadButton5.transientNamescope = nameScope;
		numberPadButton6.transientNamescope = nameScope;
		numberPadButton7.transientNamescope = nameScope;
		numberPadButton8.transientNamescope = nameScope;
		numberPadButton9.transientNamescope = nameScope;
		verticalStackLayout.transientNamescope = nameScope;
		nameScope.RegisterName("EmptyButton", verticalStackLayout);
		VerticalStackLayout verticalStackLayout2 = verticalStackLayout;
		if (verticalStackLayout2.StyleId == null)
		{
			string text = (verticalStackLayout2.StyleId = "EmptyButton");
		}
		numberPadButton10.transientNamescope = nameScope;
		nameScope.RegisterName("BiometricsButton", numberPadButton10);
		NumberPadButton numberPadButton13 = numberPadButton10;
		if (numberPadButton13.StyleId == null)
		{
			string text = (numberPadButton13.StyleId = "BiometricsButton");
		}
		numberPadButton11.transientNamescope = nameScope;
		numberPadButton12.transientNamescope = nameScope;
		EmptyButton = verticalStackLayout;
		BiometricsButton = numberPadButton10;
		SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(1.0));
		((IDynamicResourceHandler)this).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Star)));
		SetValue(Grid.ColumnSpacingProperty, 1.0);
		onIdiomExtension.Phone = "Fill";
		onIdiomExtension.Default = "Center";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, View.HorizontalOptionsProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(11, 5)));
		object obj = ((IMarkupExtension)onIdiomExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 5);
		}
		SetValue(View.HorizontalOptionsProperty, obj);
		SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Star)));
		SetValue(Grid.RowSpacingProperty, 1.0);
		numberPadButton.SetValue(Grid.RowProperty, 0);
		numberPadButton.SetValue(Grid.ColumnProperty, 0);
		numberPadButton.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton.Number = 1;
		Children.Add(numberPadButton);
		numberPadButton2.SetValue(Grid.RowProperty, 0);
		numberPadButton2.SetValue(Grid.ColumnProperty, 1);
		numberPadButton2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton2.Number = 2;
		numberPadButton2.SetValue(SemanticProperties.DescriptionProperty, "2  A B C");
		Children.Add(numberPadButton2);
		numberPadButton3.SetValue(Grid.RowProperty, 0);
		numberPadButton3.SetValue(Grid.ColumnProperty, 2);
		numberPadButton3.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton3.Number = 3;
		numberPadButton3.SetValue(SemanticProperties.DescriptionProperty, "3 D E F");
		Children.Add(numberPadButton3);
		numberPadButton4.SetValue(Grid.RowProperty, 1);
		numberPadButton4.SetValue(Grid.ColumnProperty, 0);
		numberPadButton4.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton4.Number = 4;
		numberPadButton4.SetValue(SemanticProperties.DescriptionProperty, "4 G H I");
		Children.Add(numberPadButton4);
		numberPadButton5.SetValue(Grid.RowProperty, 1);
		numberPadButton5.SetValue(Grid.ColumnProperty, 1);
		numberPadButton5.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton5.Number = 5;
		numberPadButton5.SetValue(SemanticProperties.DescriptionProperty, "5 J K L");
		Children.Add(numberPadButton5);
		numberPadButton6.SetValue(Grid.RowProperty, 1);
		numberPadButton6.SetValue(Grid.ColumnProperty, 2);
		numberPadButton6.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton6.Number = 6;
		numberPadButton6.SetValue(SemanticProperties.DescriptionProperty, "6 M N O");
		Children.Add(numberPadButton6);
		numberPadButton7.SetValue(Grid.RowProperty, 2);
		numberPadButton7.SetValue(Grid.ColumnProperty, 0);
		numberPadButton7.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton7.Number = 7;
		numberPadButton7.SetValue(SemanticProperties.DescriptionProperty, "7 P Q R S");
		Children.Add(numberPadButton7);
		numberPadButton8.SetValue(Grid.RowProperty, 2);
		numberPadButton8.SetValue(Grid.ColumnProperty, 1);
		numberPadButton8.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton8.Number = 8;
		numberPadButton8.SetValue(SemanticProperties.DescriptionProperty, "8 T U V");
		Children.Add(numberPadButton8);
		numberPadButton9.SetValue(Grid.RowProperty, 2);
		numberPadButton9.SetValue(Grid.ColumnProperty, 2);
		numberPadButton9.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton9.Number = 9;
		numberPadButton9.SetValue(SemanticProperties.DescriptionProperty, "9 W X Y Z");
		Children.Add(numberPadButton9);
		verticalStackLayout.SetValue(Grid.RowProperty, 3);
		verticalStackLayout.SetValue(Grid.ColumnProperty, 0);
		Children.Add(verticalStackLayout);
		numberPadButton10.SetValue(Grid.RowProperty, 3);
		numberPadButton10.SetValue(Grid.ColumnProperty, 0);
		numberPadButton10.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		bindingExtension.Path = "StartBiometricsAuthenticationCommand";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 88, 9);
		}
		numberPadButton10.SetBinding(ImageButton.CommandProperty, binding);
		bindingExtension2.Path = "IsBiometricsEnrolled";
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("NumberPad.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 89, 9);
		}
		numberPadButton10.SetBinding(VisualElement.IsVisibleProperty, binding2);
		numberPadButton10.Number = 10;
		numberPadButton10.SetValue(ImageButton.CommandParameterProperty, flag);
		Children.Add(numberPadButton10);
		numberPadButton11.SetValue(Grid.RowProperty, 3);
		numberPadButton11.SetValue(Grid.ColumnProperty, 1);
		numberPadButton11.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton11.Number = 0;
		Children.Add(numberPadButton11);
		numberPadButton12.SetValue(Grid.RowProperty, 3);
		numberPadButton12.SetValue(Grid.ColumnProperty, 2);
		numberPadButton12.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		numberPadButton12.Number = 11;
		Children.Add(numberPadButton12);
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
	[MemberNotNull("EmptyButton")]
	[MemberNotNull("BiometricsButton")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(NumberPad));
		EmptyButton = this.FindByName<VerticalStackLayout>("EmptyButton");
		BiometricsButton = this.FindByName<NumberPadButton>("BiometricsButton");
	}
}
