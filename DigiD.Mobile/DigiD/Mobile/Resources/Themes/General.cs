using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Reflection;
using CommunityToolkit.Maui.Converters;
using DigiD.Common.Controls;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace DigiD.Mobile.Resources.Themes;

[XamlFilePath("Resources\\Themes\\General.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class General : ResourceDictionary
{
	public General()
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(General).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(General)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		double num = 20.0;
		VisualDiagnostics.RegisterSourceInfo(num, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 9, 6);
		Color color = new Color(0.2509804f, 0.2509804f, 0.2509804f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 6);
		Color color2 = new Color(0.7058824f, 0.7058824f, 0.7058824f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		Color color3 = new Color(81f / 85f, 81f / 85f, 81f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		Color color4 = new Color(0f, 0.6039216f, 2f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 6);
		Color color5 = new Color(0.23921569f, 0.6f, 0.17254902f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 6);
		Color color6 = new Color(0.88235295f, 0.4392157f, 0f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 6);
		Color color7 = new Color(0.99607843f, 38f / 51f, 42f / 85f, 0.3019608f);
		VisualDiagnostics.RegisterSourceInfo(color7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 6);
		Color color8 = new Color(0.88235295f, 0.4392157f, 0f, 0.3019608f);
		VisualDiagnostics.RegisterSourceInfo(color8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 6);
		Color color9 = new Color(0f, 57f / 85f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 6);
		Color color10 = new Color(0f, 0f, 0f, 0.7019608f);
		VisualDiagnostics.RegisterSourceInfo(color10, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 6);
		Color color11 = new Color(0f, 0f, 0f, 0.3019608f);
		VisualDiagnostics.RegisterSourceInfo(color11, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 6);
		Color color12 = new Color(0f, 0f, 0f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color12, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 6);
		Color color13 = new Color(81f / 85f, 81f / 85f, 81f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color13, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 28, 6);
		Color color14 = new Color(0.9843137f, 78f / 85f, 0.8509804f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color14, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 6);
		Color color15 = new Color(0f, 0f, 0f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color15, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 31, 6);
		Color color16 = new Color(0f, 0f, 0f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color16, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 33, 6);
		Color color17 = new Color(71f / 85f, 0.16862746f, 0.11764706f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color17, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 6);
		Color color18 = new Color(0.7058824f, 0.7058824f, 0.7058824f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color18, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 6);
		Color color19 = new Color(1f, 0.95686275f, 44f / 51f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color19, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 6);
		Color color20 = new Color(0.88235295f, 79f / 85f, 73f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color20, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 6);
		Color color21 = new Color(0.9843137f, 78f / 85f, 0.8509804f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color21, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 6);
		Color color22 = new Color(83f / 85f, 0.8745098f, 13f / 15f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color22, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 6);
		Color color23 = new Color(1f, 0.95686275f, 44f / 51f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color23, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 6);
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 44);
		Setter setter = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 10);
		DynamicResource dynamicResource2 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 47);
		Setter setter2 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 10);
		Style style = new Style(typeof(NavigationPage));
		VisualDiagnostics.RegisterSourceInfo(style, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 6);
		DynamicResource dynamicResource3 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 39);
		Setter setter3 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 10);
		DynamicResource dynamicResource4 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 37);
		Setter setter4 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 10);
		DynamicResource dynamicResource5 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 51);
		Setter setter5 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 10);
		DynamicResource dynamicResource6 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 38);
		Setter setter6 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 10);
		Style style2 = new Style(typeof(Entry));
		VisualDiagnostics.RegisterSourceInfo(style2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 6);
		DynamicResource dynamicResource7 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 39);
		Setter setter7 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 10);
		DynamicResource dynamicResource8 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 37);
		Setter setter8 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 10);
		DynamicResource dynamicResource9 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 51);
		Setter setter9 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 10);
		DynamicResource dynamicResource10 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource10, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 38);
		Setter setter10 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter10, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 10);
		Style style3 = new Style(typeof(Editor));
		VisualDiagnostics.RegisterSourceInfo(style3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 6);
		DynamicResource dynamicResource11 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource11, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 38);
		Setter setter11 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter11, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 10);
		DynamicResource dynamicResource12 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource12, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 39);
		Setter setter12 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter12, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 10);
		DynamicResource dynamicResource13 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource13, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 37);
		Setter setter13 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter13, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 10);
		DynamicResource dynamicResource14 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource14, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 51);
		Setter setter14 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter14, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 10);
		Style style4 = new Style(typeof(Span));
		VisualDiagnostics.RegisterSourceInfo(style4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 6);
		DynamicResource dynamicResource15 = new DynamicResource("FontLineHeight");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource15, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 39);
		Setter setter15 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter15, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 10);
		DynamicResource dynamicResource16 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource16, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 38);
		Setter setter16 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter16, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 10);
		DynamicResource dynamicResource17 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource17, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 39);
		Setter setter17 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter17, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 10);
		DynamicResource dynamicResource18 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource18, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 37);
		Setter setter18 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter18, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 10);
		DynamicResource dynamicResource19 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource19, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 51);
		Setter setter19 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter19, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 10);
		Style style5 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 6);
		DynamicResource dynamicResource20 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource20, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 38);
		Setter setter20 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter20, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 10);
		DynamicResource dynamicResource21 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource21, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 87, 39);
		Setter setter21 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter21, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 87, 10);
		DynamicResource dynamicResource22 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource22, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 88, 37);
		Setter setter22 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter22, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 88, 10);
		DynamicResource dynamicResource23 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource23, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 51);
		Setter setter23 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter23, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 10);
		Style style6 = new Style(typeof(DatePicker));
		VisualDiagnostics.RegisterSourceInfo(style6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 85, 6);
		DynamicResource dynamicResource24 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource24, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 39);
		Setter setter24 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter24, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 10);
		Style style7 = new Style(typeof(Span));
		VisualDiagnostics.RegisterSourceInfo(style7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 6);
		DynamicResource dynamicResource25 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource25, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 103, 39);
		Setter setter25 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter25, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 103, 10);
		Style style8 = new Style(typeof(Span));
		VisualDiagnostics.RegisterSourceInfo(style8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 99, 6);
		DynamicResource dynamicResource26 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource26, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 107, 39);
		Setter setter26 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter26, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 107, 10);
		DynamicResource dynamicResource27 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource27, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 37);
		Setter setter27 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter27, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 10);
		DynamicResource dynamicResource28 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource28, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 51);
		Setter setter28 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter28, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 10);
		DynamicResource dynamicResource29 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource29, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 38);
		Setter setter29 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter29, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 10);
		Style style9 = new Style(typeof(Button));
		VisualDiagnostics.RegisterSourceInfo(style9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 106, 6);
		DynamicResource dynamicResource30 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource30, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 120, 39);
		Setter setter30 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter30, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 120, 10);
		DynamicResource dynamicResource31 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource31, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 37);
		Setter setter31 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter31, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 10);
		DynamicResource dynamicResource32 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource32, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 51);
		Setter setter32 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter32, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 10);
		DynamicResource dynamicResource33 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource33, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 125, 38);
		Setter setter33 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter33, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 125, 10);
		Style style10 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style10, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 119, 6);
		DynamicResource dynamicResource34 = new DynamicResource("CaptionFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource34, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 37);
		Setter setter34 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter34, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 10);
		Style style11 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style11, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 129, 6);
		Color color24 = new Color(1f, 1f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color24, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 133, 6);
		Color color25 = new Color(4f / 15f, 23f / 85f, 0.30980393f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color25, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 134, 6);
		DynamicResource dynamicResource35 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource35, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 59);
		Setter setter35 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter35, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 30);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 142, 22);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 148, 22);
		DynamicResource dynamicResource36 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource36, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 155, 60);
		Setter setter36 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter36, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 155, 30);
		VisualState visualState3 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 153, 22);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 141, 18);
		VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 140, 14);
		Setter setter37 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter37, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 139, 10);
		Style style12 = new Style(typeof(ImageButton));
		VisualDiagnostics.RegisterSourceInfo(style12, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 136, 6);
		DynamicResource dynamicResource37 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource37, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 172, 59);
		Setter setter38 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter38, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 172, 30);
		VisualState visualState4 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 170, 22);
		VisualState visualState5 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 177, 22);
		DynamicResource dynamicResource38 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource38, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 185, 60);
		Setter setter39 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter39, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 185, 30);
		VisualState visualState6 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 183, 22);
		VisualStateGroup visualStateGroup2 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 169, 18);
		VisualStateGroupList visualStateGroupList2 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 168, 14);
		Setter setter40 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter40, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 167, 10);
		Style style13 = new Style(typeof(ImageButton));
		VisualDiagnostics.RegisterSourceInfo(style13, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 164, 6);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 59);
		AppThemeBindingExtension appThemeBindingExtension = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 59);
		Setter setter41 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter41, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 30);
		VisualState visualState7 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 198, 22);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 207, 59);
		AppThemeBindingExtension appThemeBindingExtension2 = new AppThemeBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(appThemeBindingExtension2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 207, 59);
		Setter setter42 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter42, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 207, 30);
		VisualState visualState8 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 204, 22);
		VisualStateGroup visualStateGroup3 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 197, 18);
		VisualStateGroupList visualStateGroupList3 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 196, 14);
		Setter setter43 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter43, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 195, 10);
		Style style14 = new Style(typeof(Switch));
		VisualDiagnostics.RegisterSourceInfo(style14, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 194, 6);
		DynamicResource dynamicResource39 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource39, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 216, 39);
		Setter setter44 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter44, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 216, 10);
		DynamicResource dynamicResource40 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource40, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 217, 38);
		Setter setter45 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter45, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 217, 10);
		Style style15 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style15, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 215, 6);
		DynamicResource dynamicResource41 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource41, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 223, 39);
		Setter setter46 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter46, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 223, 10);
		DynamicResource dynamicResource42 = new DynamicResource("DefaultHeaderFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource42, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 224, 37);
		Setter setter47 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter47, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 224, 10);
		DynamicResource dynamicResource43 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource43, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 225, 38);
		Setter setter48 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter48, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 225, 10);
		Style style16 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style16, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 221, 6);
		DynamicResource dynamicResource44 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource44, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 232, 39);
		Setter setter49 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter49, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 232, 10);
		Style style17 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style17, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 230, 6);
		DynamicResource dynamicResource45 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource45, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 242, 39);
		Setter setter50 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter50, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 242, 10);
		Style style18 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style18, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 240, 6);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 253, 44);
		Setter setter51 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter51, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 253, 10);
		Style style19 = new Style(typeof(StackLayout));
		VisualDiagnostics.RegisterSourceInfo(style19, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 251, 6);
		DynamicResource dynamicResource46 = new DynamicResource("LinkColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource46, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 260, 38);
		Setter setter52 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter52, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 260, 10);
		Style style20 = new Style(typeof(Label));
		VisualDiagnostics.RegisterSourceInfo(style20, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 259, 6);
		Color white = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 264, 6);
		DynamicResource dynamicResource47 = new DynamicResource("DefaultButtonFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource47, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 270, 37);
		Setter setter53 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter53, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 270, 10);
		DynamicResource dynamicResource48 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource48, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 39);
		Setter setter54 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter54, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 10);
		DynamicResource dynamicResource49 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource49, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 272, 51);
		Setter setter55 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter55, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 272, 10);
		Style style21 = new Style(typeof(BorderedButton));
		VisualDiagnostics.RegisterSourceInfo(style21, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 266, 6);
		DynamicResource dynamicResource50 = new DynamicResource("ButtonPrimaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource50, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 281, 40);
		Setter setter56 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter56, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 281, 10);
		DynamicResource dynamicResource51 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource51, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 289, 59);
		Setter setter57 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter57, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 289, 30);
		DynamicResource dynamicResource52 = new DynamicResource("DisabledButtonTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource52, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 290, 58);
		Setter setter58 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter58, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 290, 30);
		VisualState visualState9 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 287, 22);
		DynamicResource dynamicResource53 = new DynamicResource("ButtonPrimaryBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource53, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 296, 59);
		Setter setter59 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter59, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 296, 30);
		DynamicResource dynamicResource54 = new DynamicResource("ButtonPrimaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource54, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 297, 58);
		Setter setter60 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter60, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 297, 30);
		VisualState visualState10 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState10, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 294, 22);
		DynamicResource dynamicResource55 = new DynamicResource("ButtonPrimaryBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource55, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 303, 59);
		Setter setter61 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter61, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 303, 30);
		DynamicResource dynamicResource56 = new DynamicResource("ButtonPrimaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource56, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 304, 58);
		Setter setter62 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter62, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 304, 30);
		DynamicResource dynamicResource57 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource57, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 305, 60);
		Setter setter63 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter63, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 305, 30);
		VisualState visualState11 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState11, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 301, 22);
		VisualStateGroup visualStateGroup4 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 286, 18);
		VisualStateGroupList visualStateGroupList4 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 285, 14);
		Setter setter64 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter64, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 284, 10);
		Style style22 = new Style(typeof(BorderedButton));
		VisualDiagnostics.RegisterSourceInfo(style22, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 276, 6);
		DynamicResource dynamicResource58 = new DynamicResource("DefaultSecondaryButtonFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource58, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 319, 37);
		Setter setter65 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter65, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 319, 10);
		DynamicResource dynamicResource59 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource59, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 327, 60);
		Setter setter66 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter66, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 327, 30);
		DynamicResource dynamicResource60 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource60, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 328, 59);
		Setter setter67 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter67, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 328, 30);
		DynamicResource dynamicResource61 = new DynamicResource("DisabledButtonTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource61, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 329, 58);
		Setter setter68 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter68, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 329, 30);
		VisualState visualState12 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState12, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 325, 22);
		DynamicResource dynamicResource62 = new DynamicResource("ButtonSecondaryBorderColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource62, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 334, 60);
		Setter setter69 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter69, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 334, 30);
		DynamicResource dynamicResource63 = new DynamicResource("ButtonSecondaryBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource63, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 335, 59);
		Setter setter70 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter70, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 335, 30);
		DynamicResource dynamicResource64 = new DynamicResource("ButtonSecondaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource64, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 336, 58);
		Setter setter71 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter71, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 336, 30);
		VisualState visualState13 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState13, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 332, 22);
		DynamicResource dynamicResource65 = new DynamicResource("ButtonSecondaryBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource65, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 341, 59);
		Setter setter72 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter72, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 341, 30);
		DynamicResource dynamicResource66 = new DynamicResource("ButtonSecondaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource66, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 342, 58);
		Setter setter73 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter73, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 342, 30);
		DynamicResource dynamicResource67 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource67, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 343, 60);
		Setter setter74 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter74, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 343, 30);
		VisualState visualState14 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState14, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 339, 22);
		VisualStateGroup visualStateGroup5 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 324, 18);
		VisualStateGroupList visualStateGroupList5 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 323, 14);
		Setter setter75 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter75, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 322, 10);
		Style style23 = new Style(typeof(BorderedButton));
		VisualDiagnostics.RegisterSourceInfo(style23, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 314, 6);
		DynamicResource dynamicResource68 = new DynamicResource("Green2");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource68, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 356, 40);
		Setter setter76 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter76, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 356, 10);
		DynamicResource dynamicResource69 = new DynamicResource("Green2");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource69, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 357, 39);
		Setter setter77 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter77, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 357, 10);
		DynamicResource dynamicResource70 = new DynamicResource("PrimaryButtonTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource70, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 358, 38);
		Setter setter78 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter78, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 358, 10);
		DynamicResource dynamicResource71 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource71, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 366, 59);
		Setter setter79 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter79, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 366, 30);
		DynamicResource dynamicResource72 = new DynamicResource("DisabledButtonTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource72, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 367, 58);
		Setter setter80 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter80, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 367, 30);
		VisualState visualState15 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState15, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 364, 22);
		DynamicResource dynamicResource73 = new DynamicResource("Green2");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource73, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 373, 59);
		Setter setter81 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter81, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 373, 30);
		DynamicResource dynamicResource74 = new DynamicResource("ButtonPrimaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource74, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 374, 58);
		Setter setter82 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter82, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 374, 30);
		VisualState visualState16 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState16, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 371, 22);
		DynamicResource dynamicResource75 = new DynamicResource("Green2");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource75, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 380, 59);
		Setter setter83 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter83, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 380, 30);
		DynamicResource dynamicResource76 = new DynamicResource("ButtonPrimaryTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource76, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 381, 58);
		Setter setter84 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter84, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 381, 30);
		DynamicResource dynamicResource77 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource77, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 382, 60);
		Setter setter85 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter85, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 382, 30);
		VisualState visualState17 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState17, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 378, 22);
		VisualStateGroup visualStateGroup6 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 363, 18);
		VisualStateGroupList visualStateGroupList6 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 362, 14);
		Setter setter86 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter86, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 361, 10);
		Style style24 = new Style(typeof(BorderedButton));
		VisualDiagnostics.RegisterSourceInfo(style24, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 352, 6);
		DynamicResource dynamicResource78 = new DynamicResource("FontBold");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource78, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 395, 39);
		Setter setter87 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter87, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 395, 10);
		DynamicResource dynamicResource79 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource79, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 396, 38);
		Setter setter88 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter88, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 396, 10);
		DynamicResource dynamicResource80 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource80, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 397, 40);
		Setter setter89 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter89, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 397, 10);
		DynamicResource dynamicResource81 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource81, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 406, 60);
		Setter setter90 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter90, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 406, 30);
		DynamicResource dynamicResource82 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource82, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 407, 59);
		Setter setter91 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter91, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 407, 30);
		VisualState visualState18 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState18, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 403, 22);
		DynamicResource dynamicResource83 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource83, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 413, 60);
		Setter setter92 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter92, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 413, 30);
		DynamicResource dynamicResource84 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource84, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 414, 59);
		Setter setter93 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter93, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 414, 30);
		VisualState visualState19 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState19, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 410, 22);
		DynamicResource dynamicResource85 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource85, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 419, 60);
		Setter setter94 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter94, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 419, 30);
		DynamicResource dynamicResource86 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource86, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 420, 59);
		Setter setter95 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter95, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 420, 30);
		VisualState visualState20 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState20, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 417, 22);
		VisualStateGroup visualStateGroup7 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 402, 18);
		VisualStateGroupList visualStateGroupList7 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList7, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 401, 14);
		Setter setter96 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter96, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 400, 10);
		Style style25 = new Style(typeof(BorderedButton));
		VisualDiagnostics.RegisterSourceInfo(style25, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 391, 6);
		DynamicResource dynamicResource87 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource87, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 433, 39);
		Setter setter97 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter97, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 433, 10);
		DynamicResource dynamicResource88 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource88, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 434, 38);
		Setter setter98 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter98, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 434, 10);
		DynamicResource dynamicResource89 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource89, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 435, 40);
		Setter setter99 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter99, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 435, 10);
		DynamicResource dynamicResource90 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource90, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 442, 60);
		Setter setter100 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter100, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 442, 30);
		DynamicResource dynamicResource91 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource91, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 443, 59);
		Setter setter101 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter101, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 443, 30);
		VisualState visualState21 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState21, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 440, 22);
		DynamicResource dynamicResource92 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource92, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 448, 60);
		Setter setter102 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter102, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 448, 30);
		DynamicResource dynamicResource93 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource93, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 449, 59);
		Setter setter103 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter103, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 449, 30);
		VisualState visualState22 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState22, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 446, 22);
		DynamicResource dynamicResource94 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource94, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 454, 59);
		Setter setter104 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter104, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 454, 30);
		DynamicResource dynamicResource95 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource95, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 455, 60);
		Setter setter105 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter105, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 455, 30);
		DynamicResource dynamicResource96 = new DynamicResource("TabBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource96, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 456, 59);
		Setter setter106 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter106, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 456, 30);
		VisualState visualState23 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState23, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 452, 22);
		VisualStateGroup visualStateGroup8 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 439, 18);
		VisualStateGroupList visualStateGroupList8 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList8, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 438, 14);
		Setter setter107 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter107, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 437, 10);
		Style style26 = new Style(typeof(BorderedButton));
		VisualDiagnostics.RegisterSourceInfo(style26, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 429, 6);
		DynamicResource dynamicResource97 = new DynamicResource("FontRegular");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource97, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 467, 39);
		Setter setter108 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter108, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 467, 10);
		DynamicResource dynamicResource98 = new DynamicResource("DefaultFontSize");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource98, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 468, 37);
		Setter setter109 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter109, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 468, 10);
		DynamicResource dynamicResource99 = new DynamicResource("FontAutoScalingEnabled");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource99, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 469, 51);
		Setter setter110 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter110, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 469, 10);
		DynamicResource dynamicResource100 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource100, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 470, 38);
		Setter setter111 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter111, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 470, 10);
		DynamicResource dynamicResource101 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource101, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 473, 39);
		Setter setter112 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter112, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 473, 10);
		Style style27 = new Style(typeof(Picker));
		VisualDiagnostics.RegisterSourceInfo(style27, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 465, 6);
		VisualState visualState24 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState24, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 485, 22);
		DynamicResource dynamicResource102 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource102, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 492, 55);
		Setter setter113 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter113, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 492, 30);
		VisualState visualState25 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState25, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 490, 22);
		VisualStateGroup visualStateGroup9 = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 484, 18);
		VisualStateGroupList visualStateGroupList9 = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList9, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 483, 14);
		Setter setter114 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter114, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 482, 10);
		Style style28 = new Style(typeof(Border));
		VisualDiagnostics.RegisterSourceInfo(style28, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 478, 6);
		IsStringNotNullOrWhiteSpaceConverter isStringNotNullOrWhiteSpaceConverter = new IsStringNotNullOrWhiteSpaceConverter();
		VisualDiagnostics.RegisterSourceInfo(isStringNotNullOrWhiteSpaceConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 500, 6);
		InvertedBoolConverter invertedBoolConverter = new InvertedBoolConverter();
		VisualDiagnostics.RegisterSourceInfo(invertedBoolConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 501, 6);
		IsListNotNullOrEmptyConverter isListNotNullOrEmptyConverter = new IsListNotNullOrEmptyConverter();
		VisualDiagnostics.RegisterSourceInfo(isListNotNullOrEmptyConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 502, 6);
		IsListNullOrEmptyConverter isListNullOrEmptyConverter = new IsListNullOrEmptyConverter();
		VisualDiagnostics.RegisterSourceInfo(isListNullOrEmptyConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 503, 6);
		IsNotNullConverter isNotNullConverter = new IsNotNullConverter();
		VisualDiagnostics.RegisterSourceInfo(isNotNullConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 504, 6);
		IsNullConverter isNullConverter = new IsNullConverter();
		VisualDiagnostics.RegisterSourceInfo(isNullConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 505, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = new NameScope();
		INameScope nameScope2 = new NameScope();
		INameScope nameScope3 = new NameScope();
		INameScope nameScope4 = new NameScope();
		INameScope nameScope5 = new NameScope();
		INameScope nameScope6 = new NameScope();
		INameScope nameScope7 = new NameScope();
		INameScope nameScope8 = new NameScope();
		INameScope nameScope9 = new NameScope();
		INameScope nameScope10 = new NameScope();
		INameScope nameScope11 = new NameScope();
		INameScope nameScope12 = new NameScope();
		INameScope nameScope13 = new NameScope();
		INameScope nameScope14 = new NameScope();
		INameScope nameScope15 = new NameScope();
		INameScope nameScope16 = new NameScope();
		INameScope nameScope17 = new NameScope();
		INameScope nameScope18 = new NameScope();
		INameScope nameScope19 = new NameScope();
		INameScope nameScope20 = new NameScope();
		INameScope nameScope21 = new NameScope();
		INameScope nameScope22 = new NameScope();
		INameScope nameScope23 = new NameScope();
		INameScope nameScope24 = new NameScope();
		INameScope nameScope25 = new NameScope();
		INameScope nameScope26 = new NameScope();
		INameScope nameScope27 = new NameScope();
		INameScope nameScope28 = new NameScope();
		INameScope nameScope29 = new NameScope();
		INameScope nameScope30 = new NameScope();
		INameScope nameScope31 = new NameScope();
		INameScope nameScope32 = new NameScope();
		INameScope nameScope33 = new NameScope();
		INameScope nameScope34 = new NameScope();
		INameScope nameScope35 = new NameScope();
		INameScope nameScope36 = new NameScope();
		INameScope nameScope37 = new NameScope();
		INameScope nameScope38 = new NameScope();
		INameScope nameScope39 = new NameScope();
		INameScope nameScope40 = new NameScope();
		INameScope nameScope41 = new NameScope();
		INameScope nameScope42 = new NameScope();
		INameScope nameScope43 = new NameScope();
		INameScope nameScope44 = new NameScope();
		INameScope nameScope45 = new NameScope();
		nameScope45.RegisterName("ButtonState", visualStateGroup);
		nameScope45.RegisterName("Disabled", visualState);
		nameScope45.RegisterName("Normal", visualState2);
		nameScope45.RegisterName("Focused", visualState3);
		INameScope nameScope46 = new NameScope();
		INameScope nameScope47 = new NameScope();
		INameScope nameScope48 = new NameScope();
		INameScope nameScope49 = new NameScope();
		nameScope49.RegisterName("ButtonState", visualStateGroup2);
		nameScope49.RegisterName("Disabled", visualState4);
		nameScope49.RegisterName("Normal", visualState5);
		nameScope49.RegisterName("Focused", visualState6);
		INameScope nameScope50 = new NameScope();
		INameScope nameScope51 = new NameScope();
		nameScope51.RegisterName("CommonStates", visualStateGroup3);
		nameScope51.RegisterName("On", visualState7);
		nameScope51.RegisterName("Off", visualState8);
		INameScope nameScope52 = new NameScope();
		INameScope nameScope53 = new NameScope();
		INameScope nameScope54 = new NameScope();
		INameScope nameScope55 = new NameScope();
		INameScope nameScope56 = new NameScope();
		INameScope nameScope57 = new NameScope();
		INameScope nameScope58 = new NameScope();
		INameScope nameScope59 = new NameScope();
		INameScope nameScope60 = new NameScope();
		INameScope nameScope61 = new NameScope();
		INameScope nameScope62 = new NameScope();
		INameScope nameScope63 = new NameScope();
		INameScope nameScope64 = new NameScope();
		INameScope nameScope65 = new NameScope();
		INameScope nameScope66 = new NameScope();
		INameScope nameScope67 = new NameScope();
		INameScope nameScope68 = new NameScope();
		INameScope nameScope69 = new NameScope();
		INameScope nameScope70 = new NameScope();
		INameScope nameScope71 = new NameScope();
		INameScope nameScope72 = new NameScope();
		INameScope nameScope73 = new NameScope();
		INameScope nameScope74 = new NameScope();
		INameScope nameScope75 = new NameScope();
		INameScope nameScope76 = new NameScope();
		INameScope nameScope77 = new NameScope();
		INameScope nameScope78 = new NameScope();
		INameScope nameScope79 = new NameScope();
		INameScope nameScope80 = new NameScope();
		INameScope nameScope81 = new NameScope();
		INameScope nameScope82 = new NameScope();
		INameScope nameScope83 = new NameScope();
		INameScope nameScope84 = new NameScope();
		INameScope nameScope85 = new NameScope();
		INameScope nameScope86 = new NameScope();
		INameScope nameScope87 = new NameScope();
		INameScope nameScope88 = new NameScope();
		INameScope nameScope89 = new NameScope();
		INameScope nameScope90 = new NameScope();
		INameScope nameScope91 = new NameScope();
		INameScope nameScope92 = new NameScope();
		INameScope nameScope93 = new NameScope();
		INameScope nameScope94 = new NameScope();
		INameScope nameScope95 = new NameScope();
		nameScope95.RegisterName("ButtonState", visualStateGroup4);
		nameScope95.RegisterName("Disabled", visualState9);
		nameScope95.RegisterName("Normal", visualState10);
		nameScope95.RegisterName("Focused", visualState11);
		INameScope nameScope96 = new NameScope();
		INameScope nameScope97 = new NameScope();
		INameScope nameScope98 = new NameScope();
		INameScope nameScope99 = new NameScope();
		INameScope nameScope100 = new NameScope();
		INameScope nameScope101 = new NameScope();
		nameScope101.RegisterName("ButtonState", visualStateGroup5);
		nameScope101.RegisterName("Disabled", visualState12);
		nameScope101.RegisterName("Normal", visualState13);
		nameScope101.RegisterName("Focused", visualState14);
		INameScope nameScope102 = new NameScope();
		INameScope nameScope103 = new NameScope();
		INameScope nameScope104 = new NameScope();
		INameScope nameScope105 = new NameScope();
		INameScope nameScope106 = new NameScope();
		INameScope nameScope107 = new NameScope();
		INameScope nameScope108 = new NameScope();
		nameScope108.RegisterName("ButtonState", visualStateGroup6);
		nameScope108.RegisterName("Disabled", visualState15);
		nameScope108.RegisterName("Normal", visualState16);
		nameScope108.RegisterName("Focused", visualState17);
		INameScope nameScope109 = new NameScope();
		INameScope nameScope110 = new NameScope();
		INameScope nameScope111 = new NameScope();
		INameScope nameScope112 = new NameScope();
		INameScope nameScope113 = new NameScope();
		INameScope nameScope114 = new NameScope();
		INameScope nameScope115 = new NameScope();
		nameScope115.RegisterName("ButtonState", visualStateGroup7);
		nameScope115.RegisterName("Disabled", visualState18);
		nameScope115.RegisterName("Normal", visualState19);
		nameScope115.RegisterName("Focused", visualState20);
		INameScope nameScope116 = new NameScope();
		INameScope nameScope117 = new NameScope();
		INameScope nameScope118 = new NameScope();
		INameScope nameScope119 = new NameScope();
		INameScope nameScope120 = new NameScope();
		INameScope nameScope121 = new NameScope();
		nameScope121.RegisterName("ButtonState", visualStateGroup8);
		nameScope121.RegisterName("Disabled", visualState21);
		nameScope121.RegisterName("Normal", visualState22);
		nameScope121.RegisterName("Focused", visualState23);
		INameScope nameScope122 = new NameScope();
		INameScope nameScope123 = new NameScope();
		INameScope nameScope124 = new NameScope();
		INameScope nameScope125 = new NameScope();
		INameScope nameScope126 = new NameScope();
		INameScope nameScope127 = new NameScope();
		INameScope nameScope128 = new NameScope();
		INameScope nameScope129 = new NameScope();
		INameScope nameScope130 = new NameScope();
		INameScope nameScope131 = new NameScope();
		INameScope nameScope132 = new NameScope();
		INameScope nameScope133 = new NameScope();
		INameScope nameScope134 = new NameScope();
		INameScope nameScope135 = new NameScope();
		INameScope nameScope136 = new NameScope();
		this["DefaultRowSpacing"] = num;
		this["Gray6"] = color;
		this["Gray7"] = color2;
		this["Gray9"] = color3;
		this["Green1"] = color4;
		this["Green2"] = color5;
		this["PrimaryColor"] = color6;
		this["PrimaryColorFocus"] = color7;
		this["PrimaryColorTransparent"] = color8;
		this["DemoBarColor"] = color9;
		this["Black70Transparent"] = color10;
		this["Black30Transparent"] = color11;
		this["PinTileTextColor"] = color12;
		this["NumberPadButtonBackgroundColorLightFocus"] = color13;
		this["TooltipColor"] = color14;
		this["TooltipTextColor"] = color15;
		this["CustomEntryFieldEntryTextColor"] = color16;
		this["CustomEntryFieldFrameRequiredBorderColor"] = color17;
		this["CustomEntryFieldPlaceholderColor"] = color18;
		this["MessageBoxNewBackgroundColor"] = color19;
		this["ToastSuccessBackgroundColor"] = color20;
		this["ToastWarningBackgroundColor"] = color21;
		this["ToastErrorBackgroundColor"] = color22;
		this["ToastNeutralBackgroundColor"] = color23;
		style.ApplyToDerivedTypes = true;
		setter.Property = VisualElement.BackgroundColorProperty;
		setter.Value = dynamicResource;
		Setter setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundColorProperty;
		setter115.Value = dynamicResource;
		Setter setter116 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter116) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter116, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 10);
		}
		style.Setters.Add(setter116);
		setter2.Property = NavigationPage.BarBackgroundColorProperty;
		setter2.Value = dynamicResource2;
		setter115 = new Setter();
		setter115.Property = NavigationPage.BarBackgroundColorProperty;
		setter115.Value = dynamicResource2;
		Setter setter117 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter117) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter117, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 10);
		}
		style.Setters.Add(setter117);
		Add(style);
		setter3.Property = Entry.FontFamilyProperty;
		setter3.Value = dynamicResource3;
		setter115 = new Setter();
		setter115.Property = Entry.FontFamilyProperty;
		setter115.Value = dynamicResource3;
		Setter setter118 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter118) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter118, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 50, 10);
		}
		style2.Setters.Add(setter118);
		setter4.Property = Entry.FontSizeProperty;
		setter4.Value = dynamicResource4;
		setter115 = new Setter();
		setter115.Property = Entry.FontSizeProperty;
		setter115.Value = dynamicResource4;
		Setter setter119 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter119) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter119, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 10);
		}
		style2.Setters.Add(setter119);
		setter5.Property = Entry.FontAutoScalingEnabledProperty;
		setter5.Value = dynamicResource5;
		setter115 = new Setter();
		setter115.Property = Entry.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource5;
		Setter setter120 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter120) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter120, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 10);
		}
		style2.Setters.Add(setter120);
		setter6.Property = Entry.TextColorProperty;
		setter6.Value = dynamicResource6;
		setter115 = new Setter();
		setter115.Property = Entry.TextColorProperty;
		setter115.Value = dynamicResource6;
		Setter setter121 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter121) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter121, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 10);
		}
		style2.Setters.Add(setter121);
		Add(style2);
		style3.ApplyToDerivedTypes = true;
		setter7.Property = Editor.FontFamilyProperty;
		setter7.Value = dynamicResource7;
		setter115 = new Setter();
		setter115.Property = Editor.FontFamilyProperty;
		setter115.Value = dynamicResource7;
		Setter setter122 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter122) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter122, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 10);
		}
		style3.Setters.Add(setter122);
		setter8.Property = Editor.FontSizeProperty;
		setter8.Value = dynamicResource8;
		setter115 = new Setter();
		setter115.Property = Editor.FontSizeProperty;
		setter115.Value = dynamicResource8;
		Setter setter123 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter123) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter123, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 10);
		}
		style3.Setters.Add(setter123);
		setter9.Property = Editor.FontAutoScalingEnabledProperty;
		setter9.Value = dynamicResource9;
		setter115 = new Setter();
		setter115.Property = Editor.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource9;
		Setter setter124 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter124) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter124, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 10);
		}
		style3.Setters.Add(setter124);
		setter10.Property = Editor.TextColorProperty;
		setter10.Value = dynamicResource10;
		setter115 = new Setter();
		setter115.Property = Editor.TextColorProperty;
		setter115.Value = dynamicResource10;
		Setter setter125 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter125) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter125, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 10);
		}
		style3.Setters.Add(setter125);
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter126 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter126) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter126, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 10);
		}
		style3.Setters.Add(setter126);
		Add(style3);
		setter11.Property = Span.TextColorProperty;
		setter11.Value = dynamicResource11;
		setter115 = new Setter();
		setter115.Property = Span.TextColorProperty;
		setter115.Value = dynamicResource11;
		Setter setter127 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter127) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter127, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 10);
		}
		style4.Setters.Add(setter127);
		setter12.Property = Span.FontFamilyProperty;
		setter12.Value = dynamicResource12;
		setter115 = new Setter();
		setter115.Property = Span.FontFamilyProperty;
		setter115.Value = dynamicResource12;
		Setter setter128 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter128) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter128, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 10);
		}
		style4.Setters.Add(setter128);
		setter13.Property = Span.FontSizeProperty;
		setter13.Value = dynamicResource13;
		setter115 = new Setter();
		setter115.Property = Span.FontSizeProperty;
		setter115.Value = dynamicResource13;
		Setter setter129 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter129) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter129, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 10);
		}
		style4.Setters.Add(setter129);
		setter14.Property = Span.FontAutoScalingEnabledProperty;
		setter14.Value = dynamicResource14;
		setter115 = new Setter();
		setter115.Property = Span.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource14;
		Setter setter130 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter130) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter130, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 10);
		}
		style4.Setters.Add(setter130);
		Add(style4);
		style5.ApplyToDerivedTypes = true;
		setter15.Property = Label.LineHeightProperty;
		setter15.Value = dynamicResource15;
		setter115 = new Setter();
		setter115.Property = Label.LineHeightProperty;
		setter115.Value = dynamicResource15;
		Setter setter131 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter131) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter131, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 72, 10);
		}
		style5.Setters.Add(setter131);
		setter16.Property = Label.TextColorProperty;
		setter16.Value = dynamicResource16;
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = dynamicResource16;
		Setter setter132 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter132) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter132, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 10);
		}
		style5.Setters.Add(setter132);
		setter17.Property = Label.FontFamilyProperty;
		setter17.Value = dynamicResource17;
		setter115 = new Setter();
		setter115.Property = Label.FontFamilyProperty;
		setter115.Value = dynamicResource17;
		Setter setter133 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter133) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter133, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 10);
		}
		style5.Setters.Add(setter133);
		setter18.Property = Label.FontSizeProperty;
		setter18.Value = dynamicResource18;
		setter115 = new Setter();
		setter115.Property = Label.FontSizeProperty;
		setter115.Value = dynamicResource18;
		Setter setter134 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter134) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter134, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 10);
		}
		style5.Setters.Add(setter134);
		setter19.Property = Label.FontAutoScalingEnabledProperty;
		setter19.Value = dynamicResource19;
		setter115 = new Setter();
		setter115.Property = Label.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource19;
		Setter setter135 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter135) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter135, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 10);
		}
		style5.Setters.Add(setter135);
		setter115 = new Setter();
		setter115.Property = Label.PaddingProperty;
		setter115.Value = new Thickness(4.0, 2.0, 2.0, 4.0);
		Setter setter136 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter136) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter136, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 10);
		}
		style5.Setters.Add(setter136);
		Add(style5);
		style6.ApplyToDerivedTypes = true;
		setter20.Property = DatePicker.TextColorProperty;
		setter20.Value = dynamicResource20;
		setter115 = new Setter();
		setter115.Property = DatePicker.TextColorProperty;
		setter115.Value = dynamicResource20;
		Setter setter137 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter137) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter137, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 10);
		}
		style6.Setters.Add(setter137);
		setter21.Property = DatePicker.FontFamilyProperty;
		setter21.Value = dynamicResource21;
		setter115 = new Setter();
		setter115.Property = DatePicker.FontFamilyProperty;
		setter115.Value = dynamicResource21;
		Setter setter138 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter138) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter138, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 87, 10);
		}
		style6.Setters.Add(setter138);
		setter22.Property = DatePicker.FontSizeProperty;
		setter22.Value = dynamicResource22;
		setter115 = new Setter();
		setter115.Property = DatePicker.FontSizeProperty;
		setter115.Value = dynamicResource22;
		Setter setter139 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter139) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter139, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 88, 10);
		}
		style6.Setters.Add(setter139);
		setter23.Property = DatePicker.FontAutoScalingEnabledProperty;
		setter23.Value = dynamicResource23;
		setter115 = new Setter();
		setter115.Property = DatePicker.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource23;
		Setter setter140 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter140) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter140, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 10);
		}
		style6.Setters.Add(setter140);
		Add(style6);
		style7.ApplyToDerivedTypes = true;
		setter24.Property = Span.FontFamilyProperty;
		setter24.Value = dynamicResource24;
		setter115 = new Setter();
		setter115.Property = Span.FontFamilyProperty;
		setter115.Value = dynamicResource24;
		Setter setter141 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter141) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter141, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 10);
		}
		style7.Setters.Add(setter141);
		this["SpanRegular"] = style7;
		style8.ApplyToDerivedTypes = true;
		setter25.Property = Span.FontFamilyProperty;
		setter25.Value = dynamicResource25;
		setter115 = new Setter();
		setter115.Property = Span.FontFamilyProperty;
		setter115.Value = dynamicResource25;
		Setter setter142 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter142) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter142, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 103, 10);
		}
		style8.Setters.Add(setter142);
		this["SpanBold"] = style8;
		setter26.Property = Button.FontFamilyProperty;
		setter26.Value = dynamicResource26;
		setter115 = new Setter();
		setter115.Property = Button.FontFamilyProperty;
		setter115.Value = dynamicResource26;
		Setter setter143 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter143) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter143, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 107, 10);
		}
		style9.Setters.Add(setter143);
		setter27.Property = Button.FontSizeProperty;
		setter27.Value = dynamicResource27;
		setter115 = new Setter();
		setter115.Property = Button.FontSizeProperty;
		setter115.Value = dynamicResource27;
		Setter setter144 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter144) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter144, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 10);
		}
		style9.Setters.Add(setter144);
		setter28.Property = Button.FontAutoScalingEnabledProperty;
		setter28.Value = dynamicResource28;
		setter115 = new Setter();
		setter115.Property = Button.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource28;
		Setter setter145 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter145) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter145, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 10);
		}
		style9.Setters.Add(setter145);
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter146 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter146) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter146, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 110, 10);
		}
		style9.Setters.Add(setter146);
		setter29.Property = Button.TextColorProperty;
		setter29.Value = dynamicResource29;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource29;
		Setter setter147 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter147) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter147, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 10);
		}
		style9.Setters.Add(setter147);
		this["ButtonAsLabelStyle"] = style9;
		setter30.Property = Label.FontFamilyProperty;
		setter30.Value = dynamicResource30;
		setter115 = new Setter();
		setter115.Property = Label.FontFamilyProperty;
		setter115.Value = dynamicResource30;
		Setter setter148 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter148) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter148, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 120, 10);
		}
		style10.Setters.Add(setter148);
		setter31.Property = Label.FontSizeProperty;
		setter31.Value = dynamicResource31;
		setter115 = new Setter();
		setter115.Property = Label.FontSizeProperty;
		setter115.Value = dynamicResource31;
		Setter setter149 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter149) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter149, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 10);
		}
		style10.Setters.Add(setter149);
		setter32.Property = Label.FontAutoScalingEnabledProperty;
		setter32.Value = dynamicResource32;
		setter115 = new Setter();
		setter115.Property = Label.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource32;
		Setter setter150 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter150) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter150, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 10);
		}
		style10.Setters.Add(setter150);
		setter115 = new Setter();
		setter115.Property = Label.HorizontalTextAlignmentProperty;
		setter115.Value = TextAlignment.Start;
		Setter setter151 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter151) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter151, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 123, 10);
		}
		style10.Setters.Add(setter151);
		setter115 = new Setter();
		setter115.Property = Label.LineBreakModeProperty;
		setter115.Value = LineBreakMode.WordWrap;
		Setter setter152 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter152) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter152, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 124, 10);
		}
		style10.Setters.Add(setter152);
		setter33.Property = Label.TextColorProperty;
		setter33.Value = dynamicResource33;
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = dynamicResource33;
		Setter setter153 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter153) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter153, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 125, 10);
		}
		style10.Setters.Add(setter153);
		setter115 = new Setter();
		setter115.Property = Label.VerticalTextAlignmentProperty;
		setter115.Value = TextAlignment.Center;
		Setter setter154 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter154) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter154, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 126, 10);
		}
		style10.Setters.Add(setter154);
		this["ErrorLabelStyle"] = style10;
		setter34.Property = Label.FontSizeProperty;
		setter34.Value = dynamicResource34;
		setter115 = new Setter();
		setter115.Property = Label.FontSizeProperty;
		setter115.Value = dynamicResource34;
		Setter setter155 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter155) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter155, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 10);
		}
		style11.Setters.Add(setter155);
		this["CaptionLabelStyle"] = style11;
		this["ThumbColorOnColorLight"] = color24;
		this["ThumbColorOffColorLight"] = color25;
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter156 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter156) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter156, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 137, 10);
		}
		style12.Setters.Add(setter156);
		setter115 = new Setter();
		setter115.Property = ImageButton.CornerRadiusProperty;
		setter115.Value = 0;
		Setter setter157 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter157) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter157, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 138, 10);
		}
		style12.Setters.Add(setter157);
		setter37.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup.Name = "ButtonState";
		visualState.Name = "Disabled";
		setter35.Property = VisualElement.BackgroundProperty;
		setter35.Value = dynamicResource35;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource35;
		Setter setter158 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter158) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter158, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 144, 30);
		}
		IList<Setter> setters = visualState.Setters;
		setters.Add(setter158);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter159 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter159) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter159, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 145, 30);
		}
		setters.Add(setter159);
		visualStateGroup.States.Add(visualState);
		visualState2.Name = "Normal";
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter160 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter160) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter160, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 150, 30);
		}
		visualState2.Setters.Add(setter160);
		visualStateGroup.States.Add(visualState2);
		visualState3.Name = "Focused";
		setter36.Property = ImageButton.BorderColorProperty;
		setter36.Value = dynamicResource36;
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderColorProperty;
		setter115.Value = dynamicResource36;
		Setter setter161 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter161) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter161, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 155, 30);
		}
		IList<Setter> setters2 = visualState3.Setters;
		setters2.Add(setter161);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter162 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter162) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter162, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 156, 30);
		}
		setters2.Add(setter162);
		visualStateGroup.States.Add(visualState3);
		visualStateGroupList.Add(visualStateGroup);
		setter37.Value = visualStateGroupList;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList;
		Setter setter163 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter163) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter163, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 139, 10);
		}
		style12.Setters.Add(setter163);
		this["NumberPadButtonStyle"] = style12;
		style13.ApplyToDerivedTypes = false;
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter164 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter164) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter164, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 165, 10);
		}
		style13.Setters.Add(setter164);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter165 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter165) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter165, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 166, 10);
		}
		style13.Setters.Add(setter165);
		setter40.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup2.Name = "ButtonState";
		visualState4.Name = "Disabled";
		setter38.Property = VisualElement.BackgroundProperty;
		setter38.Value = dynamicResource37;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource37;
		Setter setter166 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter166) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter166, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 172, 30);
		}
		IList<Setter> setters3 = visualState4.Setters;
		setters3.Add(setter166);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter167 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter167) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter167, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 173, 30);
		}
		setters3.Add(setter167);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter168 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter168) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter168, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 174, 30);
		}
		setters3.Add(setter168);
		visualStateGroup2.States.Add(visualState4);
		visualState5.Name = "Normal";
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter169 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter169) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter169, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 179, 30);
		}
		IList<Setter> setters4 = visualState5.Setters;
		setters4.Add(setter169);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter170 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter170) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter170, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 180, 30);
		}
		setters4.Add(setter170);
		visualStateGroup2.States.Add(visualState5);
		visualState6.Name = "Focused";
		setter39.Property = ImageButton.BorderColorProperty;
		setter39.Value = dynamicResource38;
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderColorProperty;
		setter115.Value = dynamicResource38;
		Setter setter171 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter171) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter171, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 185, 30);
		}
		IList<Setter> setters5 = visualState6.Setters;
		setters5.Add(setter171);
		setter115 = new Setter();
		setter115.Property = ImageButton.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter172 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter172) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter172, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 186, 30);
		}
		setters5.Add(setter172);
		visualStateGroup2.States.Add(visualState6);
		visualStateGroupList2.Add(visualStateGroup2);
		setter40.Value = visualStateGroupList2;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList2;
		Setter setter173 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter173) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter173, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 167, 10);
		}
		style13.Setters.Add(setter173);
		Add(style13);
		setter43.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup3.Name = "CommonStates";
		visualState7.Name = "On";
		setter115 = new Setter();
		setter115.Property = Switch.OnColorProperty;
		setter115.Value = new Color(0.88235295f, 0.4392157f, 0f, 1f);
		Setter setter174 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter174) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter174, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 200, 30);
		}
		IList<Setter> setters6 = visualState7.Setters;
		setters6.Add(setter174);
		setter41.Property = Switch.ThumbColorProperty;
		appThemeBindingExtension.Dark = "White";
		staticResourceExtension.Key = "ThumbColorOnColorLight";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[8] { appThemeBindingExtension, setter41, visualState7, visualStateGroup3, visualStateGroupList3, setter43, style14, this }, typeof(AppThemeBindingExtension).GetProperty("Light"), new INameScope[1] { nameScope51 }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(201, 59)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 59);
		}
		appThemeBindingExtension.Light = obj;
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[7] { setter41, visualState7, visualStateGroup3, visualStateGroupList3, setter43, style14, this }, typeof(Setter).GetProperty("Value"), new INameScope[1] { nameScope51 }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(201, 59)));
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)appThemeBindingExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 59);
		}
		setter41.Value = bindingBase;
		setter115 = new Setter();
		setter115.Property = Switch.ThumbColorProperty;
		setter115.Value = bindingBase;
		Setter setter175 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter175) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter175, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 201, 30);
		}
		setters6.Add(setter175);
		visualStateGroup3.States.Add(visualState7);
		visualState8.Name = "Off";
		setter115 = new Setter();
		setter115.Property = Switch.OnColorProperty;
		setter115.Value = new Color(53f / 85f, 53f / 85f, 53f / 85f, 1f);
		Setter setter176 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter176) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter176, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 206, 30);
		}
		IList<Setter> setters7 = visualState8.Setters;
		setters7.Add(setter176);
		setter42.Property = Switch.ThumbColorProperty;
		appThemeBindingExtension2.Dark = "White";
		staticResourceExtension2.Key = "ThumbColorOffColorLight";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[8] { appThemeBindingExtension2, setter42, visualState8, visualStateGroup3, visualStateGroupList3, setter43, style14, this }, typeof(AppThemeBindingExtension).GetProperty("Light"), new INameScope[1] { nameScope51 }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(207, 59)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 207, 59);
		}
		appThemeBindingExtension2.Light = obj2;
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[7] { setter42, visualState8, visualStateGroup3, visualStateGroupList3, setter43, style14, this }, typeof(Setter).GetProperty("Value"), new INameScope[1] { nameScope51 }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(207, 59)));
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)appThemeBindingExtension2).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 207, 59);
		}
		setter42.Value = bindingBase2;
		setter115 = new Setter();
		setter115.Property = Switch.ThumbColorProperty;
		setter115.Value = bindingBase2;
		Setter setter177 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter177) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter177, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 207, 30);
		}
		setters7.Add(setter177);
		visualStateGroup3.States.Add(visualState8);
		visualStateGroupList3.Add(visualStateGroup3);
		setter43.Value = visualStateGroupList3;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList3;
		Setter setter178 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter178) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter178, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 195, 10);
		}
		style14.Setters.Add(setter178);
		Add(style14);
		setter44.Property = Label.FontFamilyProperty;
		setter44.Value = dynamicResource39;
		setter115 = new Setter();
		setter115.Property = Label.FontFamilyProperty;
		setter115.Value = dynamicResource39;
		Setter setter179 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter179) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter179, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 216, 10);
		}
		style15.Setters.Add(setter179);
		setter45.Property = Label.TextColorProperty;
		setter45.Value = dynamicResource40;
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = dynamicResource40;
		Setter setter180 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter180) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter180, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 217, 10);
		}
		style15.Setters.Add(setter180);
		setter115 = new Setter();
		setter115.Property = SemanticProperties.HeadingLevelProperty;
		setter115.Value = SemanticHeadingLevel.Level2;
		Setter setter181 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter181) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter181, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 218, 10);
		}
		style15.Setters.Add(setter181);
		this["LabelBold"] = style15;
		setter115 = new Setter();
		setter115.Property = Element.AutomationIdProperty;
		setter115.Value = "PageHeader";
		Setter setter182 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter182) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter182, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 222, 10);
		}
		style16.Setters.Add(setter182);
		setter46.Property = Label.FontFamilyProperty;
		setter46.Value = dynamicResource41;
		setter115 = new Setter();
		setter115.Property = Label.FontFamilyProperty;
		setter115.Value = dynamicResource41;
		Setter setter183 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter183) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter183, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 223, 10);
		}
		style16.Setters.Add(setter183);
		setter47.Property = Label.FontSizeProperty;
		setter47.Value = dynamicResource42;
		setter115 = new Setter();
		setter115.Property = Label.FontSizeProperty;
		setter115.Value = dynamicResource42;
		Setter setter184 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter184) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter184, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 224, 10);
		}
		style16.Setters.Add(setter184);
		setter48.Property = Label.TextColorProperty;
		setter48.Value = dynamicResource43;
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = dynamicResource43;
		Setter setter185 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter185) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter185, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 225, 10);
		}
		style16.Setters.Add(setter185);
		setter115 = new Setter();
		setter115.Property = Label.FontAttributesProperty;
		setter115.Value = FontAttributes.Bold;
		Setter setter186 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter186) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter186, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 226, 10);
		}
		style16.Setters.Add(setter186);
		setter115 = new Setter();
		setter115.Property = SemanticProperties.HeadingLevelProperty;
		setter115.Value = SemanticHeadingLevel.Level1;
		Setter setter187 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter187) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter187, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 227, 10);
		}
		style16.Setters.Add(setter187);
		this["LabelHeader"] = style16;
		setter115 = new Setter();
		setter115.Property = Element.AutomationIdProperty;
		setter115.Value = "DemoBarLabel";
		Setter setter188 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter188) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter188, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 231, 10);
		}
		style17.Setters.Add(setter188);
		setter49.Property = Label.FontFamilyProperty;
		setter49.Value = dynamicResource44;
		setter115 = new Setter();
		setter115.Property = Label.FontFamilyProperty;
		setter115.Value = dynamicResource44;
		Setter setter189 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter189) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter189, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 232, 10);
		}
		style17.Setters.Add(setter189);
		setter115 = new Setter();
		setter115.Property = Label.FontSizeProperty;
		setter115.Value = 16.0;
		Setter setter190 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter190) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter190, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 233, 10);
		}
		style17.Setters.Add(setter190);
		setter115 = new Setter();
		setter115.Property = Label.HorizontalTextAlignmentProperty;
		setter115.Value = TextAlignment.Center;
		Setter setter191 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter191) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter191, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 234, 10);
		}
		style17.Setters.Add(setter191);
		setter115 = new Setter();
		setter115.Property = Label.VerticalTextAlignmentProperty;
		setter115.Value = TextAlignment.Center;
		Setter setter192 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter192) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter192, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 235, 10);
		}
		style17.Setters.Add(setter192);
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = Colors.Black;
		Setter setter193 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter193) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter193, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 236, 10);
		}
		style17.Setters.Add(setter193);
		setter115 = new Setter();
		setter115.Property = View.HorizontalOptionsProperty;
		setter115.Value = LayoutOptions.Center;
		Setter setter194 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter194) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter194, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 237, 10);
		}
		style17.Setters.Add(setter194);
		this["DemoBarLabel"] = style17;
		setter115 = new Setter();
		setter115.Property = Element.AutomationIdProperty;
		setter115.Value = "DemoBarPageLabel";
		Setter setter195 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter195) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter195, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 241, 10);
		}
		style18.Setters.Add(setter195);
		setter50.Property = Label.FontFamilyProperty;
		setter50.Value = dynamicResource45;
		setter115 = new Setter();
		setter115.Property = Label.FontFamilyProperty;
		setter115.Value = dynamicResource45;
		Setter setter196 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter196) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter196, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 242, 10);
		}
		style18.Setters.Add(setter196);
		setter115 = new Setter();
		setter115.Property = Label.FontSizeProperty;
		setter115.Value = 16.0;
		Setter setter197 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter197) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter197, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 243, 10);
		}
		style18.Setters.Add(setter197);
		setter115 = new Setter();
		setter115.Property = Label.HorizontalTextAlignmentProperty;
		setter115.Value = TextAlignment.Center;
		Setter setter198 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter198) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter198, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 244, 10);
		}
		style18.Setters.Add(setter198);
		setter115 = new Setter();
		setter115.Property = Label.VerticalTextAlignmentProperty;
		setter115.Value = TextAlignment.Center;
		Setter setter199 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter199) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter199, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 245, 10);
		}
		style18.Setters.Add(setter199);
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = Colors.Red;
		Setter setter200 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter200) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter200, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 246, 10);
		}
		style18.Setters.Add(setter200);
		setter115 = new Setter();
		setter115.Property = View.HorizontalOptionsProperty;
		setter115.Value = LayoutOptions.End;
		Setter setter201 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter201) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter201, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 247, 10);
		}
		style18.Setters.Add(setter201);
		setter115 = new Setter();
		setter115.Property = View.VerticalOptionsProperty;
		setter115.Value = LayoutOptions.Start;
		Setter setter202 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter202) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter202, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 248, 10);
		}
		style18.Setters.Add(setter202);
		this["DemoBarPageLabel"] = style18;
		setter115 = new Setter();
		setter115.Property = Element.AutomationIdProperty;
		setter115.Value = "DemoBar";
		Setter setter203 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter203) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter203, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 252, 10);
		}
		style19.Setters.Add(setter203);
		setter51.Property = VisualElement.BackgroundColorProperty;
		staticResourceExtension3.Key = "DemoBarColor";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[3] { setter51, style19, this }, typeof(Setter).GetProperty("Value"), new INameScope[1] { nameScope77 }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(253, 44)));
		object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 253, 44);
		}
		setter51.Value = obj3;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundColorProperty;
		setter115.Value = obj3;
		Setter setter204 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter204) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter204, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 253, 10);
		}
		style19.Setters.Add(setter204);
		setter115 = new Setter();
		setter115.Property = StackLayout.OrientationProperty;
		setter115.Value = StackOrientation.Horizontal;
		Setter setter205 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter205) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter205, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 254, 10);
		}
		style19.Setters.Add(setter205);
		setter115 = new Setter();
		setter115.Property = View.HorizontalOptionsProperty;
		setter115.Value = LayoutOptions.Fill;
		Setter setter206 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter206) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter206, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 255, 10);
		}
		style19.Setters.Add(setter206);
		setter115 = new Setter();
		setter115.Property = Layout.PaddingProperty;
		setter115.Value = new Thickness(10.0, 0.0);
		Setter setter207 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter207) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter207, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 256, 10);
		}
		style19.Setters.Add(setter207);
		this["DemoBar"] = style19;
		setter52.Property = Label.TextColorProperty;
		setter52.Value = dynamicResource46;
		setter115 = new Setter();
		setter115.Property = Label.TextColorProperty;
		setter115.Value = dynamicResource46;
		Setter setter208 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter208) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter208, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 260, 10);
		}
		style20.Setters.Add(setter208);
		setter115 = new Setter();
		setter115.Property = Label.PaddingProperty;
		setter115.Value = new Thickness(4.0, 2.0, 2.0, 2.0);
		Setter setter209 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter209) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter209, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 261, 10);
		}
		style20.Setters.Add(setter209);
		this["LabelAsLinkStyle"] = style20;
		this["PrimaryButtonTextColor"] = white;
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 1.0;
		Setter setter210 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter210) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter210, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 267, 10);
		}
		style21.Setters.Add(setter210);
		setter115 = new Setter();
		setter115.Property = Button.CornerRadiusProperty;
		setter115.Value = 4;
		Setter setter211 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter211) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter211, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 268, 10);
		}
		style21.Setters.Add(setter211);
		setter115 = new Setter();
		setter115.Property = View.HorizontalOptionsProperty;
		setter115.Value = LayoutOptions.Fill;
		Setter setter212 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter212) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter212, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 269, 10);
		}
		style21.Setters.Add(setter212);
		setter53.Property = Button.FontSizeProperty;
		setter53.Value = dynamicResource47;
		setter115 = new Setter();
		setter115.Property = Button.FontSizeProperty;
		setter115.Value = dynamicResource47;
		Setter setter213 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter213) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter213, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 270, 10);
		}
		style21.Setters.Add(setter213);
		setter54.Property = Button.FontFamilyProperty;
		setter54.Value = dynamicResource48;
		setter115 = new Setter();
		setter115.Property = Button.FontFamilyProperty;
		setter115.Value = dynamicResource48;
		Setter setter214 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter214) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter214, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 271, 10);
		}
		style21.Setters.Add(setter214);
		setter55.Property = Button.FontAutoScalingEnabledProperty;
		setter55.Value = dynamicResource49;
		setter115 = new Setter();
		setter115.Property = Button.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource49;
		Setter setter215 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter215) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter215, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 272, 10);
		}
		style21.Setters.Add(setter215);
		setter115 = new Setter();
		setter115.Property = Button.LineBreakModeProperty;
		setter115.Value = LineBreakMode.WordWrap;
		Setter setter216 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter216) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter216, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 273, 10);
		}
		style21.Setters.Add(setter216);
		this["BorderedButton"] = style21;
		style22.BaseResourceKey = "BorderedButton";
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter217 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter217) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter217, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 280, 10);
		}
		style22.Setters.Add(setter217);
		setter56.Property = Button.BorderColorProperty;
		setter56.Value = dynamicResource50;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource50;
		Setter setter218 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter218) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter218, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 281, 10);
		}
		style22.Setters.Add(setter218);
		setter115 = new Setter();
		setter115.Property = VisualElement.MinimumHeightRequestProperty;
		setter115.Value = 48.0;
		Setter setter219 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter219) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter219, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 282, 10);
		}
		style22.Setters.Add(setter219);
		setter115 = new Setter();
		setter115.Property = Button.PaddingProperty;
		setter115.Value = new Thickness(6.0);
		Setter setter220 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter220) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter220, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 283, 10);
		}
		style22.Setters.Add(setter220);
		setter64.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup4.Name = "ButtonState";
		visualState9.Name = "Disabled";
		setter57.Property = VisualElement.BackgroundProperty;
		setter57.Value = dynamicResource51;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource51;
		Setter setter221 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter221) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter221, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 289, 30);
		}
		IList<Setter> setters8 = visualState9.Setters;
		setters8.Add(setter221);
		setter58.Property = Button.TextColorProperty;
		setter58.Value = dynamicResource52;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource52;
		Setter setter222 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter222) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter222, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 290, 30);
		}
		setters8.Add(setter222);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter223 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter223) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter223, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 291, 30);
		}
		setters8.Add(setter223);
		visualStateGroup4.States.Add(visualState9);
		visualState10.Name = "Normal";
		setter59.Property = VisualElement.BackgroundProperty;
		setter59.Value = dynamicResource53;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource53;
		Setter setter224 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter224) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter224, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 296, 30);
		}
		IList<Setter> setters9 = visualState10.Setters;
		setters9.Add(setter224);
		setter60.Property = Button.TextColorProperty;
		setter60.Value = dynamicResource54;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource54;
		Setter setter225 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter225) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter225, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 297, 30);
		}
		setters9.Add(setter225);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter226 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter226) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter226, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 298, 30);
		}
		setters9.Add(setter226);
		visualStateGroup4.States.Add(visualState10);
		visualState11.Name = "Focused";
		setter61.Property = VisualElement.BackgroundProperty;
		setter61.Value = dynamicResource55;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource55;
		Setter setter227 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter227) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter227, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 303, 30);
		}
		IList<Setter> setters10 = visualState11.Setters;
		setters10.Add(setter227);
		setter62.Property = Button.TextColorProperty;
		setter62.Value = dynamicResource56;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource56;
		Setter setter228 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter228) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter228, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 304, 30);
		}
		setters10.Add(setter228);
		setter63.Property = Button.BorderColorProperty;
		setter63.Value = dynamicResource57;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource57;
		Setter setter229 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter229) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter229, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 305, 30);
		}
		setters10.Add(setter229);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter230 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter230) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter230, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 306, 30);
		}
		setters10.Add(setter230);
		visualStateGroup4.States.Add(visualState11);
		visualStateGroupList4.Add(visualStateGroup4);
		setter64.Value = visualStateGroupList4;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList4;
		Setter setter231 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter231) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter231, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 284, 10);
		}
		style22.Setters.Add(setter231);
		this["ButtonPrimary"] = style22;
		style23.BaseResourceKey = "BorderedButton";
		setter115 = new Setter();
		setter115.Property = VisualElement.MinimumHeightRequestProperty;
		setter115.Value = 46.0;
		Setter setter232 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter232) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter232, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 318, 10);
		}
		style23.Setters.Add(setter232);
		setter65.Property = Button.FontSizeProperty;
		setter65.Value = dynamicResource58;
		setter115 = new Setter();
		setter115.Property = Button.FontSizeProperty;
		setter115.Value = dynamicResource58;
		Setter setter233 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter233) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter233, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 319, 10);
		}
		style23.Setters.Add(setter233);
		setter115 = new Setter();
		setter115.Property = Button.PaddingProperty;
		setter115.Value = new Thickness(2.0);
		Setter setter234 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter234) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter234, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 320, 10);
		}
		style23.Setters.Add(setter234);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 1.25;
		Setter setter235 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter235) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter235, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 321, 10);
		}
		style23.Setters.Add(setter235);
		setter75.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup5.Name = "ButtonState";
		visualState12.Name = "Disabled";
		setter66.Property = Button.BorderColorProperty;
		setter66.Value = dynamicResource59;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource59;
		Setter setter236 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter236) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter236, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 327, 30);
		}
		IList<Setter> setters11 = visualState12.Setters;
		setters11.Add(setter236);
		setter67.Property = VisualElement.BackgroundProperty;
		setter67.Value = dynamicResource60;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource60;
		Setter setter237 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter237) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter237, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 328, 30);
		}
		setters11.Add(setter237);
		setter68.Property = Button.TextColorProperty;
		setter68.Value = dynamicResource61;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource61;
		Setter setter238 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter238) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter238, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 329, 30);
		}
		setters11.Add(setter238);
		visualStateGroup5.States.Add(visualState12);
		visualState13.Name = "Normal";
		setter69.Property = Button.BorderColorProperty;
		setter69.Value = dynamicResource62;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource62;
		Setter setter239 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter239) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter239, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 334, 30);
		}
		IList<Setter> setters12 = visualState13.Setters;
		setters12.Add(setter239);
		setter70.Property = VisualElement.BackgroundProperty;
		setter70.Value = dynamicResource63;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource63;
		Setter setter240 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter240) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter240, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 335, 30);
		}
		setters12.Add(setter240);
		setter71.Property = Button.TextColorProperty;
		setter71.Value = dynamicResource64;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource64;
		Setter setter241 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter241) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter241, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 336, 30);
		}
		setters12.Add(setter241);
		visualStateGroup5.States.Add(visualState13);
		visualState14.Name = "Focused";
		setter72.Property = VisualElement.BackgroundProperty;
		setter72.Value = dynamicResource65;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource65;
		Setter setter242 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter242) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter242, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 341, 30);
		}
		IList<Setter> setters13 = visualState14.Setters;
		setters13.Add(setter242);
		setter73.Property = Button.TextColorProperty;
		setter73.Value = dynamicResource66;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource66;
		Setter setter243 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter243) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter243, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 342, 30);
		}
		setters13.Add(setter243);
		setter74.Property = Button.BorderColorProperty;
		setter74.Value = dynamicResource67;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource67;
		Setter setter244 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter244) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter244, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 343, 30);
		}
		setters13.Add(setter244);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 2.5;
		Setter setter245 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter245) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter245, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 344, 30);
		}
		setters13.Add(setter245);
		visualStateGroup5.States.Add(visualState14);
		visualStateGroupList5.Add(visualStateGroup5);
		setter75.Value = visualStateGroupList5;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList5;
		Setter setter246 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter246) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter246, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 322, 10);
		}
		style23.Setters.Add(setter246);
		this["ButtonSecondary"] = style23;
		style24.BaseResourceKey = "BorderedButton";
		setter76.Property = Button.BorderColorProperty;
		setter76.Value = dynamicResource68;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource68;
		Setter setter247 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter247) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter247, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 356, 10);
		}
		style24.Setters.Add(setter247);
		setter77.Property = VisualElement.BackgroundProperty;
		setter77.Value = dynamicResource69;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource69;
		Setter setter248 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter248) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter248, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 357, 10);
		}
		style24.Setters.Add(setter248);
		setter78.Property = Button.TextColorProperty;
		setter78.Value = dynamicResource70;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource70;
		Setter setter249 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter249) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter249, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 358, 10);
		}
		style24.Setters.Add(setter249);
		setter115 = new Setter();
		setter115.Property = VisualElement.MinimumHeightRequestProperty;
		setter115.Value = 48.0;
		Setter setter250 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter250) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter250, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 359, 10);
		}
		style24.Setters.Add(setter250);
		setter115 = new Setter();
		setter115.Property = Button.PaddingProperty;
		setter115.Value = new Thickness(6.0);
		Setter setter251 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter251) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter251, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 360, 10);
		}
		style24.Setters.Add(setter251);
		setter86.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup6.Name = "ButtonState";
		visualState15.Name = "Disabled";
		setter79.Property = VisualElement.BackgroundProperty;
		setter79.Value = dynamicResource71;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource71;
		Setter setter252 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter252) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter252, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 366, 30);
		}
		IList<Setter> setters14 = visualState15.Setters;
		setters14.Add(setter252);
		setter80.Property = Button.TextColorProperty;
		setter80.Value = dynamicResource72;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource72;
		Setter setter253 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter253) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter253, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 367, 30);
		}
		setters14.Add(setter253);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter254 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter254) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter254, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 368, 30);
		}
		setters14.Add(setter254);
		visualStateGroup6.States.Add(visualState15);
		visualState16.Name = "Normal";
		setter81.Property = VisualElement.BackgroundProperty;
		setter81.Value = dynamicResource73;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource73;
		Setter setter255 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter255) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter255, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 373, 30);
		}
		IList<Setter> setters15 = visualState16.Setters;
		setters15.Add(setter255);
		setter82.Property = Button.TextColorProperty;
		setter82.Value = dynamicResource74;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource74;
		Setter setter256 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter256) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter256, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 374, 30);
		}
		setters15.Add(setter256);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter257 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter257) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter257, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 375, 30);
		}
		setters15.Add(setter257);
		visualStateGroup6.States.Add(visualState16);
		visualState17.Name = "Focused";
		setter83.Property = VisualElement.BackgroundProperty;
		setter83.Value = dynamicResource75;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource75;
		Setter setter258 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter258) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter258, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 380, 30);
		}
		IList<Setter> setters16 = visualState17.Setters;
		setters16.Add(setter258);
		setter84.Property = Button.TextColorProperty;
		setter84.Value = dynamicResource76;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource76;
		Setter setter259 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter259) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter259, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 381, 30);
		}
		setters16.Add(setter259);
		setter85.Property = Button.BorderColorProperty;
		setter85.Value = dynamicResource77;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource77;
		Setter setter260 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter260) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter260, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 382, 30);
		}
		setters16.Add(setter260);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter261 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter261) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter261, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 383, 30);
		}
		setters16.Add(setter261);
		visualStateGroup6.States.Add(visualState17);
		visualStateGroupList6.Add(visualStateGroup6);
		setter86.Value = visualStateGroupList6;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList6;
		Setter setter262 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter262) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter262, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 361, 10);
		}
		style24.Setters.Add(setter262);
		this["ButtonGreen"] = style24;
		style25.BaseResourceKey = "BorderedButton";
		setter87.Property = Button.FontFamilyProperty;
		setter87.Value = dynamicResource78;
		setter115 = new Setter();
		setter115.Property = Button.FontFamilyProperty;
		setter115.Value = dynamicResource78;
		Setter setter263 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter263) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter263, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 395, 10);
		}
		style25.Setters.Add(setter263);
		setter88.Property = Button.TextColorProperty;
		setter88.Value = dynamicResource79;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource79;
		Setter setter264 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter264) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter264, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 396, 10);
		}
		style25.Setters.Add(setter264);
		setter89.Property = Button.BorderColorProperty;
		setter89.Value = dynamicResource80;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource80;
		Setter setter265 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter265) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter265, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 397, 10);
		}
		style25.Setters.Add(setter265);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter266 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter266) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter266, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 398, 10);
		}
		style25.Setters.Add(setter266);
		setter115 = new Setter();
		setter115.Property = VisualElement.TranslationYProperty;
		setter115.Value = 2.0;
		Setter setter267 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter267) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter267, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 399, 10);
		}
		style25.Setters.Add(setter267);
		setter96.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup7.Name = "ButtonState";
		visualState18.Name = "Disabled";
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter268 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter268) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter268, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 405, 30);
		}
		IList<Setter> setters17 = visualState18.Setters;
		setters17.Add(setter268);
		setter90.Property = Button.BorderColorProperty;
		setter90.Value = dynamicResource81;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource81;
		Setter setter269 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter269) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter269, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 406, 30);
		}
		setters17.Add(setter269);
		setter91.Property = VisualElement.BackgroundProperty;
		setter91.Value = dynamicResource82;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource82;
		Setter setter270 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter270) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter270, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 407, 30);
		}
		setters17.Add(setter270);
		visualStateGroup7.States.Add(visualState18);
		visualState19.Name = "Normal";
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 0.0;
		Setter setter271 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter271) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter271, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 412, 30);
		}
		IList<Setter> setters18 = visualState19.Setters;
		setters18.Add(setter271);
		setter92.Property = Button.BorderColorProperty;
		setter92.Value = dynamicResource83;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource83;
		Setter setter272 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter272) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter272, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 413, 30);
		}
		setters18.Add(setter272);
		setter93.Property = VisualElement.BackgroundProperty;
		setter93.Value = dynamicResource84;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource84;
		Setter setter273 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter273) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter273, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 414, 30);
		}
		setters18.Add(setter273);
		visualStateGroup7.States.Add(visualState19);
		visualState20.Name = "Focused";
		setter94.Property = Button.BorderColorProperty;
		setter94.Value = dynamicResource85;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource85;
		Setter setter274 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter274) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter274, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 419, 30);
		}
		IList<Setter> setters19 = visualState20.Setters;
		setters19.Add(setter274);
		setter95.Property = VisualElement.BackgroundProperty;
		setter95.Value = dynamicResource86;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource86;
		Setter setter275 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter275) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter275, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 420, 30);
		}
		setters19.Add(setter275);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter276 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter276) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter276, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 421, 30);
		}
		setters19.Add(setter276);
		visualStateGroup7.States.Add(visualState20);
		visualStateGroupList7.Add(visualStateGroup7);
		setter96.Value = visualStateGroupList7;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList7;
		Setter setter277 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter277) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter277, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 400, 10);
		}
		style25.Setters.Add(setter277);
		this["ButtonTabActive"] = style25;
		style26.BaseResourceKey = "BorderedButton";
		setter97.Property = Button.FontFamilyProperty;
		setter97.Value = dynamicResource87;
		setter115 = new Setter();
		setter115.Property = Button.FontFamilyProperty;
		setter115.Value = dynamicResource87;
		Setter setter278 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter278) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter278, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 433, 10);
		}
		style26.Setters.Add(setter278);
		setter98.Property = Button.TextColorProperty;
		setter98.Value = dynamicResource88;
		setter115 = new Setter();
		setter115.Property = Button.TextColorProperty;
		setter115.Value = dynamicResource88;
		Setter setter279 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter279) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter279, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 434, 10);
		}
		style26.Setters.Add(setter279);
		setter99.Property = Button.BorderColorProperty;
		setter99.Value = dynamicResource89;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource89;
		Setter setter280 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter280) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter280, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 435, 10);
		}
		style26.Setters.Add(setter280);
		setter115 = new Setter();
		setter115.Property = VisualElement.TranslationYProperty;
		setter115.Value = 2.0;
		Setter setter281 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter281) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter281, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 436, 10);
		}
		style26.Setters.Add(setter281);
		setter107.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup8.Name = "ButtonState";
		visualState21.Name = "Disabled";
		setter100.Property = Button.BorderColorProperty;
		setter100.Value = dynamicResource90;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource90;
		Setter setter282 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter282) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter282, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 442, 30);
		}
		IList<Setter> setters20 = visualState21.Setters;
		setters20.Add(setter282);
		setter101.Property = VisualElement.BackgroundProperty;
		setter101.Value = dynamicResource91;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource91;
		Setter setter283 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter283) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter283, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 443, 30);
		}
		setters20.Add(setter283);
		visualStateGroup8.States.Add(visualState21);
		visualState22.Name = "Normal";
		setter102.Property = Button.BorderColorProperty;
		setter102.Value = dynamicResource92;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource92;
		Setter setter284 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter284) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter284, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 448, 30);
		}
		IList<Setter> setters21 = visualState22.Setters;
		setters21.Add(setter284);
		setter103.Property = VisualElement.BackgroundProperty;
		setter103.Value = dynamicResource93;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource93;
		Setter setter285 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter285) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter285, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 449, 30);
		}
		setters21.Add(setter285);
		visualStateGroup8.States.Add(visualState22);
		visualState23.Name = "Focused";
		setter104.Property = VisualElement.BackgroundProperty;
		setter104.Value = dynamicResource94;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource94;
		Setter setter286 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter286) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter286, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 454, 30);
		}
		IList<Setter> setters22 = visualState23.Setters;
		setters22.Add(setter286);
		setter105.Property = Button.BorderColorProperty;
		setter105.Value = dynamicResource95;
		setter115 = new Setter();
		setter115.Property = Button.BorderColorProperty;
		setter115.Value = dynamicResource95;
		Setter setter287 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter287) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter287, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 455, 30);
		}
		setters22.Add(setter287);
		setter106.Property = VisualElement.BackgroundProperty;
		setter106.Value = dynamicResource96;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundProperty;
		setter115.Value = dynamicResource96;
		Setter setter288 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter288) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter288, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 456, 30);
		}
		setters22.Add(setter288);
		setter115 = new Setter();
		setter115.Property = Button.BorderWidthProperty;
		setter115.Value = 2.0;
		Setter setter289 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter289) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter289, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 457, 30);
		}
		setters22.Add(setter289);
		visualStateGroup8.States.Add(visualState23);
		visualStateGroupList8.Add(visualStateGroup8);
		setter107.Value = visualStateGroupList8;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList8;
		Setter setter290 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter290) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter290, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 437, 10);
		}
		style26.Setters.Add(setter290);
		this["ButtonTabInActive"] = style26;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter291 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter291) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter291, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 466, 10);
		}
		style27.Setters.Add(setter291);
		setter108.Property = Picker.FontFamilyProperty;
		setter108.Value = dynamicResource97;
		setter115 = new Setter();
		setter115.Property = Picker.FontFamilyProperty;
		setter115.Value = dynamicResource97;
		Setter setter292 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter292) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter292, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 467, 10);
		}
		style27.Setters.Add(setter292);
		setter109.Property = Picker.FontSizeProperty;
		setter109.Value = dynamicResource98;
		setter115 = new Setter();
		setter115.Property = Picker.FontSizeProperty;
		setter115.Value = dynamicResource98;
		Setter setter293 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter293) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter293, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 468, 10);
		}
		style27.Setters.Add(setter293);
		setter110.Property = Picker.FontAutoScalingEnabledProperty;
		setter110.Value = dynamicResource99;
		setter115 = new Setter();
		setter115.Property = Picker.FontAutoScalingEnabledProperty;
		setter115.Value = dynamicResource99;
		Setter setter294 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter294) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter294, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 469, 10);
		}
		style27.Setters.Add(setter294);
		setter111.Property = Picker.TextColorProperty;
		setter111.Value = dynamicResource100;
		setter115 = new Setter();
		setter115.Property = Picker.TextColorProperty;
		setter115.Value = dynamicResource100;
		Setter setter295 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter295) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter295, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 470, 10);
		}
		style27.Setters.Add(setter295);
		setter115 = new Setter();
		setter115.Property = Picker.HorizontalTextAlignmentProperty;
		setter115.Value = TextAlignment.Start;
		Setter setter296 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter296) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter296, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 471, 10);
		}
		style27.Setters.Add(setter296);
		setter115 = new Setter();
		setter115.Property = VisualElement.MinimumHeightRequestProperty;
		setter115.Value = 48.0;
		Setter setter297 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter297) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter297, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 472, 10);
		}
		style27.Setters.Add(setter297);
		setter112.Property = Picker.TitleColorProperty;
		setter112.Value = dynamicResource101;
		setter115 = new Setter();
		setter115.Property = Picker.TitleColorProperty;
		setter115.Value = dynamicResource101;
		Setter setter298 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter298) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter298, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 473, 10);
		}
		style27.Setters.Add(setter298);
		setter115 = new Setter();
		setter115.Property = View.VerticalOptionsProperty;
		setter115.Value = LayoutOptions.Center;
		Setter setter299 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter299) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter299, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 474, 10);
		}
		style27.Setters.Add(setter299);
		setter115 = new Setter();
		setter115.Property = Picker.VerticalTextAlignmentProperty;
		setter115.Value = TextAlignment.Center;
		Setter setter300 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter300) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter300, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 475, 10);
		}
		style27.Setters.Add(setter300);
		Add(style27);
		style28.ApplyToDerivedTypes = true;
		setter115 = new Setter();
		setter115.Property = VisualElement.BackgroundColorProperty;
		setter115.Value = Colors.Transparent;
		Setter setter301 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter301) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter301, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 479, 10);
		}
		style28.Setters.Add(setter301);
		setter115 = new Setter();
		setter115.Property = View.MarginProperty;
		setter115.Value = new Thickness(-2.0);
		Setter setter302 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter302) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter302, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 480, 10);
		}
		style28.Setters.Add(setter302);
		setter115 = new Setter();
		setter115.Property = Border.StrokeThicknessProperty;
		setter115.Value = 2.0;
		Setter setter303 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter303) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter303, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 481, 10);
		}
		style28.Setters.Add(setter303);
		setter114.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup9.Name = "CommonStates";
		visualState24.Name = "Normal";
		setter115 = new Setter();
		setter115.Property = Border.StrokeProperty;
		setter115.Value = new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush;
		Setter setter304 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter304) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter304, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 487, 30);
		}
		visualState24.Setters.Add(setter304);
		visualStateGroup9.States.Add(visualState24);
		visualState25.Name = "Focused";
		setter113.Property = Border.StrokeProperty;
		setter113.Value = dynamicResource102;
		setter115 = new Setter();
		setter115.Property = Border.StrokeProperty;
		setter115.Value = dynamicResource102;
		Setter setter305 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter305) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter305, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 492, 30);
		}
		visualState25.Setters.Add(setter305);
		visualStateGroup9.States.Add(visualState25);
		visualStateGroupList9.Add(visualStateGroup9);
		setter114.Value = visualStateGroupList9;
		setter115 = new Setter();
		setter115.Property = VisualStateManager.VisualStateGroupsProperty;
		setter115.Value = visualStateGroupList9;
		Setter setter306 = setter115;
		if (VisualDiagnostics.GetSourceInfo(setter306) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter306, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 482, 10);
		}
		style28.Setters.Add(setter306);
		Add(style28);
		ICommunityToolkitValueConverter communityToolkitValueConverter = ((IMarkupExtension<ICommunityToolkitValueConverter>)isStringNotNullOrWhiteSpaceConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 500, 6);
		}
		this["IsStringNotNullOrWhiteSpaceConverter"] = communityToolkitValueConverter;
		ICommunityToolkitValueConverter communityToolkitValueConverter2 = ((IMarkupExtension<ICommunityToolkitValueConverter>)invertedBoolConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter2, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 501, 6);
		}
		this["BooleanInvertConverter"] = communityToolkitValueConverter2;
		ICommunityToolkitValueConverter communityToolkitValueConverter3 = ((IMarkupExtension<ICommunityToolkitValueConverter>)isListNotNullOrEmptyConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter3, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 502, 6);
		}
		this["IsListNotNullOrEmptyConverter"] = communityToolkitValueConverter3;
		ICommunityToolkitValueConverter communityToolkitValueConverter4 = ((IMarkupExtension<ICommunityToolkitValueConverter>)isListNullOrEmptyConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter4, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 503, 6);
		}
		this["IsListNullOrEmptyConverter"] = communityToolkitValueConverter4;
		ICommunityToolkitValueConverter communityToolkitValueConverter5 = ((IMarkupExtension<ICommunityToolkitValueConverter>)isNotNullConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter5, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 504, 6);
		}
		this["IsNotNullConverter"] = communityToolkitValueConverter5;
		ICommunityToolkitValueConverter communityToolkitValueConverter6 = ((IMarkupExtension<ICommunityToolkitValueConverter>)isNullConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter6, new Uri("Resources\\Themes\\General.xaml;assembly=DigiD.Mobile", UriKind.Relative), 505, 6);
		}
		this["IsNullConverter"] = communityToolkitValueConverter6;
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
		this.LoadFromXaml(typeof(General));
	}
}
