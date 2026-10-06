using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Helpers;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Barcode;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("IconQrCode.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class IconQrCode : Grid
{
	public static readonly BindableProperty QrCodeProperty = BindableProperty.Create("QrCode", typeof(string), typeof(IconQrCode));

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid @this;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private SfBarcodeGenerator QrCodeImage;

	public string? QrCode
	{
		get
		{
			return (string)GetValue(QrCodeProperty);
		}
		set
		{
			SetValue(QrCodeProperty, value);
		}
	}

	public IconQrCode()
	{
		InitializeComponent();
		DeviceDisplay.MainDisplayInfoChanged -= SetDimensions;
		DeviceDisplay.MainDisplayInfoChanged += SetDimensions;
		QrCodeImage.WidthRequest = (QrCodeImage.MaximumWidthRequest = 400.0);
		QrCodeImage.HeightRequest = (QrCodeImage.MaximumHeightRequest = 400.0);
	}

	private void SetDimensions(object? sender, DisplayInfoChangedEventArgs e)
	{
		SfBarcodeGenerator qrCodeImage = QrCodeImage;
		double widthRequest = (QrCodeImage.MaximumWidthRequest = ((e.DisplayInfo.Orientation == DisplayOrientation.Landscape) ? (DisplayHelper.Height * 0.6) : (DisplayHelper.MaxContentWidth - 40.0)));
		qrCodeImage.WidthRequest = widthRequest;
		SfBarcodeGenerator qrCodeImage2 = QrCodeImage;
		widthRequest = (QrCodeImage.MaximumHeightRequest = QrCodeImage.WidthRequest);
		qrCodeImage2.HeightRequest = widthRequest;
		InvalidateMeasure();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("this")]
	[MemberNotNull("QrCodeImage")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(IconQrCode).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(IconQrCode)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 37);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 14);
		QRCode qRCode = new QRCode();
		VisualDiagnostics.RegisterSourceInfo(qRCode, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 14);
		SfBarcodeGenerator sfBarcodeGenerator = new SfBarcodeGenerator();
		VisualDiagnostics.RegisterSourceInfo(sfBarcodeGenerator, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 10, 6);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 10);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("this", this);
		if (StyleId == null)
		{
			string text = (StyleId = "this");
		}
		sfBarcodeGenerator.transientNamescope = nameScope;
		nameScope.RegisterName("QrCodeImage", sfBarcodeGenerator);
		SfBarcodeGenerator sfBarcodeGenerator2 = sfBarcodeGenerator;
		if (sfBarcodeGenerator2.StyleId == null)
		{
			string text = (sfBarcodeGenerator2.StyleId = "QrCodeImage");
		}
		border.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		this.@this = this;
		QrCodeImage = sfBarcodeGenerator;
		sfBarcodeGenerator.SetValue(VisualElement.BackgroundColorProperty, Colors.White);
		sfBarcodeGenerator.SetValue(VisualElement.MaximumHeightRequestProperty, 200.0);
		sfBarcodeGenerator.SetValue(VisualElement.MaximumWidthRequestProperty, 200.0);
		sfBarcodeGenerator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		referenceExtension.Name = "this";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "QrCode";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		}
		sfBarcodeGenerator.SetBinding(SfBarcodeGenerator.ValueProperty, binding);
		translateExtension.Text = "AccessibilityQRCodeDescription";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("IconQrCode.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 37);
		}
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, bindingBase);
		a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Image);
		((IList<Behavior>)sfBarcodeGenerator.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
		qRCode.SetValue(QRCode.ErrorCorrectionLevelProperty, ErrorCorrectionLevel.High);
		sfBarcodeGenerator.SetValue(SfBarcodeGenerator.SymbologyProperty, qRCode);
		Children.Add(sfBarcodeGenerator);
		border.SetValue(Border.PaddingProperty, new Thickness(0.0));
		border.SetValue(VisualElement.BackgroundColorProperty, Colors.White);
		border.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		border.SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 10") as IShape);
		border.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 60.0);
		image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("afbeelding_digid_officiele_app.png"));
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		image.SetValue(VisualElement.WidthRequestProperty, 60.0);
		border.SetValue(Border.ContentProperty, image);
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
	[MemberNotNull("QrCodeImage")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(IconQrCode));
		this.@this = this.FindByName<Grid>("this");
		QrCodeImage = this.FindByName<SfBarcodeGenerator>("QrCodeImage");
	}
}
