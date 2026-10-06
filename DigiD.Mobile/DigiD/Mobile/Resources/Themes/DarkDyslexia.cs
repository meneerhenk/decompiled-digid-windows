using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;

namespace DigiD.Mobile.Resources.Themes;

[XamlFilePath("Resources\\Themes\\DarkDyslexia.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class DarkDyslexia : ResourceDictionary
{
	public DarkDyslexia()
	{
		InitializeComponent();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(DarkDyslexia).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(DarkDyslexia)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		Color color = new Color(0.3254902f, 0.3254902f, 0.34509805f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 7, 6);
		Color color2 = new Color(0.38431373f, 33f / 85f, 0.40392157f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color2, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 8, 6);
		Color color3 = new Color(22f / 85f, 22f / 85f, 0.29411766f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color3, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 9, 6);
		Color color4 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color4, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 11, 6);
		Color color5 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color5, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 12, 6);
		Color white = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 13, 6);
		Color white2 = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white2, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 14, 6);
		Color white3 = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white3, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 17, 6);
		Color color6 = new Color(0.56078434f, 0.7921569f, 77f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color6, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 6);
		Color color7 = new Color(13f / 51f, 13f / 51f, 14f / 51f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color7, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 21, 6);
		Color color8 = new Color(0.7058824f, 0.7058824f, 0.7019608f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color8, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 23, 6);
		Color color9 = new Color(0.34901962f, 0.34901962f, 0.34901962f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color9, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 24, 6);
		Color color10 = new Color(1f, 1f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color10, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 26, 6);
		Color color11 = new Color(22f / 85f, 22f / 85f, 0.29411766f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color11, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 27, 6);
		Color color12 = new Color(28f / 85f, 1f / 3f, 0.35686275f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color12, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 29, 6);
		Color color13 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color13, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 30, 6);
		FileImageSource fileImageSource = "digid_icon_activate_other_app_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 6);
		Color color14 = new Color(1f, 1f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color14, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 34, 6);
		Color color15 = new Color(1f, 1f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color15, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 35, 6);
		Color color16 = new Color(1f, 1f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color16, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 36, 6);
		Color color17 = new Color(1f, 1f, 1f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color17, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 37, 6);
		Color color18 = new Color(0.88235295f, 0.4392157f, 0f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color18, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 38, 6);
		Color transparent = Colors.Transparent;
		VisualDiagnostics.RegisterSourceInfo(transparent, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 39, 6);
		Color color19 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color19, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 6);
		Color color20 = new Color(81f / 85f, 81f / 85f, 81f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color20, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 41, 6);
		Color color21 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color21, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 6);
		Color color22 = new Color(81f / 85f, 81f / 85f, 81f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color22, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 44, 6);
		Color color23 = new Color(0.20784314f, 18f / 85f, 0.23921569f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color23, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 46, 6);
		Color color24 = new Color(81f / 85f, 81f / 85f, 81f / 85f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color24, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 47, 6);
		Color color25 = new Color(0.20784314f, 18f / 85f, 0.23921569f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color25, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 6);
		Color color26 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color26, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 51, 6);
		Color white4 = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white4, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 53, 6);
		Color color27 = new Color(0.88235295f, 0.4392157f, 0f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color27, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 54, 6);
		Color white5 = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white5, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 56, 6);
		Color color28 = new Color(14f / 85f, 0.16862746f, 0.19215687f, 1f);
		VisualDiagnostics.RegisterSourceInfo(color28, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 6);
		Color white6 = Colors.White;
		VisualDiagnostics.RegisterSourceInfo(white6, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 58, 6);
		FileImageSource fileImageSource2 = "digid_icon_overlay_afnemer_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource2, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 60, 6);
		FileImageSource fileImageSource3 = "icon_sluiten_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource3, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 61, 6);
		FileImageSource fileImageSource4 = "icon_terug_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource4, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 6);
		FileImageSource fileImageSource5 = "digid_icon_menu_nieuwe_bericht_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource5, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 63, 6);
		FileImageSource fileImageSource6 = "digid_icon_menu_smallsize_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource6, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 64, 6);
		FileImageSource fileImageSource7 = "digid_icon_radiobutton_app_off_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource7, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 6);
		FileImageSource fileImageSource8 = "digid_icon_radiobutton_app_on.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource8, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 66, 6);
		FileImageSource fileImageSource9 = "digid_icon_landing_inloggen_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource9, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 69, 6);
		FileImageSource fileImageSource10 = "digid_icon_landing_koppelcode_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource10, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 70, 6);
		FileImageSource fileImageSource11 = "pincode0_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource11, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 73, 6);
		FileImageSource fileImageSource12 = "pincode1_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource12, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 74, 6);
		FileImageSource fileImageSource13 = "pincode2_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource13, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 75, 6);
		FileImageSource fileImageSource14 = "pincode3_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource14, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 6);
		FileImageSource fileImageSource15 = "pincode4_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource15, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 77, 6);
		FileImageSource fileImageSource16 = "pincode5_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource16, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 78, 6);
		FileImageSource fileImageSource17 = "pincode6_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource17, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 79, 6);
		FileImageSource fileImageSource18 = "pincode7_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource18, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 80, 6);
		FileImageSource fileImageSource19 = "pincode8_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource19, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 81, 6);
		FileImageSource fileImageSource20 = "pincode9_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource20, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 6);
		FileImageSource fileImageSource21 = "pincode_backspace_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource21, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 83, 6);
		FileImageSource fileImageSource22 = "pincode_fingerprint_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource22, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 84, 6);
		FileImageSource fileImageSource23 = "pincode_touchid_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource23, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 85, 6);
		FileImageSource fileImageSource24 = "pincode_faceid_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource24, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 86, 6);
		FileImageSource fileImageSource25 = "pincode_on_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource25, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 89, 6);
		FileImageSource fileImageSource26 = "pincode_active_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource26, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 90, 6);
		FileImageSource fileImageSource27 = "pincode_off_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource27, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 91, 6);
		FileImageSource fileImageSource28 = "pincode_locked_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource28, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 92, 6);
		FileImageSource fileImageSource29 = "digid_icon_document_check_alert_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource29, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 95, 6);
		FileImageSource fileImageSource30 = "digid_icon_document_check_ok_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource30, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 96, 6);
		FileImageSource fileImageSource31 = "digid_icon_menu_berichten_nieuwe_bericht_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource31, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 97, 6);
		FileImageSource fileImageSource32 = "digid_icon_menu_berichten_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource32, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 98, 6);
		FileImageSource fileImageSource33 = "digid_icon_menu_berichten_rectangle_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource33, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 99, 6);
		FileImageSource fileImageSource34 = "digid_icon_menu_mijn_digid_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource34, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 100, 6);
		FileImageSource fileImageSource35 = "icon_menu_instellingen_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource35, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 101, 6);
		FileImageSource fileImageSource36 = "icon_menu_faq_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource36, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 102, 6);
		FileImageSource fileImageSource37 = "digid_icon_menu_uitloggen_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource37, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 103, 6);
		FileImageSource fileImageSource38 = "icon_taal_selectie_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource38, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 105, 6);
		FileImageSource fileImageSource39 = "icon_instellingen_switch_theme_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource39, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 106, 6);
		FileImageSource fileImageSource40 = "digid_icon_menu_tekstgrootte_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource40, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 107, 6);
		FileImageSource fileImageSource41 = "digid_icon_menu_dyslexie_font_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource41, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 108, 6);
		FileImageSource fileImageSource42 = "icon_menu_verzamelen_statistieken_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource42, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 109, 6);
		FileImageSource fileImageSource43 = "digid_icon_menu_app_deactiveren_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource43, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 110, 6);
		FileImageSource fileImageSource44 = "digid_icon_menu_touchid_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource44, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 111, 6);
		FileImageSource fileImageSource45 = "digid_icon_menu_faceid_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource45, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 112, 6);
		FileImageSource fileImageSource46 = "digid_icon_menu_fingerprint_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource46, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 113, 6);
		FileImageSource fileImageSource47 = "digid_icon_menu_screenshot_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource47, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 114, 6);
		FileImageSource fileImageSource48 = "digid_icon_menu_email_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource48, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 116, 6);
		FileImageSource fileImageSource49 = "digid_icon_menu_app_gebruiksgeschiedenis_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource49, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 117, 6);
		FileImageSource fileImageSource50 = "digid_icon_pincode_veranderen_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource50, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 118, 6);
		FileImageSource fileImageSource51 = "digid_icon_menu_2fa_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource51, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 119, 6);
		FileImageSource fileImageSource52 = "digid_icon_menu_contact_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource52, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 121, 6);
		FileImageSource fileImageSource53 = "icon_menu_info_over_de_app_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource53, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 122, 6);
		FileImageSource fileImageSource54 = "digid_icon_menu_ondersteuning_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource54, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 123, 6);
		FileImageSource fileImageSource55 = "digid_icon_menu_rate_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource55, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 124, 6);
		FileImageSource fileImageSource56 = "digid_icon_menu_toegankelijkheid_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource56, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 125, 6);
		FileImageSource fileImageSource57 = "digid_icon_opensource_libraries_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource57, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 126, 6);
		FileImageSource fileImageSource58 = "icon_menu_externe_link_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource58, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 128, 6);
		FileImageSource fileImageSource59 = "icon_button_externe_link_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource59, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 129, 6);
		FileImageSource fileImageSource60 = "icon_sluiten_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource60, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 130, 6);
		FileImageSource fileImageSource61 = "icon_instellingen_taal_vink_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource61, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 131, 6);
		FileImageSource fileImageSource62 = "digid_icon_menu_chevron_interne_link_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource62, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 132, 6);
		FileImageSource fileImageSource63 = "digid_icon_notificatie_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource63, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 134, 6);
		FileImageSource fileImageSource64 = "digid_icon_close_bottomsheet_dark.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource64, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 136, 6);
		FileImageSource fileImageSource65 = "digid_icon_wachtwoord.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource65, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 138, 6);
		FileImageSource fileImageSource66 = "digid_icon_wachtwoord_on.png";
		VisualDiagnostics.RegisterSourceInfo(fileImageSource66, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 139, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Resources\\Themes\\DarkDyslexia.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		fileImageSource66.transientNamescope = (fileImageSource65.transientNamescope = (fileImageSource64.transientNamescope = (fileImageSource63.transientNamescope = (fileImageSource62.transientNamescope = (fileImageSource61.transientNamescope = (fileImageSource60.transientNamescope = (fileImageSource59.transientNamescope = (fileImageSource58.transientNamescope = (fileImageSource57.transientNamescope = (fileImageSource56.transientNamescope = (fileImageSource55.transientNamescope = (fileImageSource54.transientNamescope = (fileImageSource53.transientNamescope = (fileImageSource52.transientNamescope = (fileImageSource51.transientNamescope = (fileImageSource50.transientNamescope = (fileImageSource49.transientNamescope = (fileImageSource48.transientNamescope = (fileImageSource47.transientNamescope = (fileImageSource46.transientNamescope = (fileImageSource45.transientNamescope = (fileImageSource44.transientNamescope = (fileImageSource43.transientNamescope = (fileImageSource42.transientNamescope = (fileImageSource41.transientNamescope = (fileImageSource40.transientNamescope = (fileImageSource39.transientNamescope = (fileImageSource38.transientNamescope = (fileImageSource37.transientNamescope = (fileImageSource36.transientNamescope = (fileImageSource35.transientNamescope = (fileImageSource34.transientNamescope = (fileImageSource33.transientNamescope = (fileImageSource32.transientNamescope = (fileImageSource31.transientNamescope = (fileImageSource30.transientNamescope = (fileImageSource29.transientNamescope = (fileImageSource28.transientNamescope = (fileImageSource27.transientNamescope = (fileImageSource26.transientNamescope = (fileImageSource25.transientNamescope = (fileImageSource24.transientNamescope = (fileImageSource23.transientNamescope = (fileImageSource22.transientNamescope = (fileImageSource21.transientNamescope = (fileImageSource20.transientNamescope = (fileImageSource19.transientNamescope = (fileImageSource18.transientNamescope = (fileImageSource17.transientNamescope = (fileImageSource16.transientNamescope = (fileImageSource15.transientNamescope = (fileImageSource14.transientNamescope = (fileImageSource13.transientNamescope = (fileImageSource12.transientNamescope = (fileImageSource11.transientNamescope = (fileImageSource10.transientNamescope = (fileImageSource9.transientNamescope = (fileImageSource8.transientNamescope = (fileImageSource7.transientNamescope = (fileImageSource6.transientNamescope = (fileImageSource5.transientNamescope = (fileImageSource4.transientNamescope = (fileImageSource3.transientNamescope = (fileImageSource2.transientNamescope = (fileImageSource.transientNamescope = new NameScope())))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
		this["Gray1"] = color;
		this["Gray2"] = color2;
		this["Gray3"] = color3;
		this["BackgroundColor"] = color4;
		this["AppPageBackground"] = color5;
		this["FontColor"] = white;
		this["FontTextColor"] = white2;
		this["FocusRectangleColor"] = white3;
		this["LinkColor"] = color6;
		this["ActiveStepBackgroundColor"] = color7;
		this["DisabledButtonBackgroundColor"] = color8;
		this["DisabledButtonTextColor"] = color9;
		this["BarTextColor"] = color10;
		this["TabBackgroundColor"] = color11;
		this["NumberPadButtonBackgroundColor"] = color12;
		this["NumberPadBackgroundColor"] = color13;
		this["ActivateWithOtherApp"] = fileImageSource;
		this["CustomEntryFieldInactiveBackgroundColor"] = color14;
		this["CustomEntryFieldActiveBackgroundColor"] = color15;
		this["CustomEntryFieldTextEnteredBackgroundColor"] = color16;
		this["CustomEntryFieldEntryTextColor"] = color17;
		this["CustomEntryFieldFrameBorderColor"] = color18;
		this["CustomEntryFieldFrameBorderColorNoFocus"] = transparent;
		this["CustomEntryFieldHelpLabelBackgroundColor"] = color19;
		this["CustomEntryFieldHeaderTextColor"] = color20;
		this["CustomEntryFieldCounterTextColor"] = color21;
		this["CustomPickerHeaderTextColor"] = color22;
		this["MenuItemBackgroundColor"] = color23;
		this["MenuItemBackgroundColorFocus"] = color24;
		this["MessageBoxBackgroundColor"] = color25;
		this["CustomIconListItemViewBackgroundColor"] = color26;
		this["ButtonPrimaryTextColor"] = white4;
		this["ButtonPrimaryBackgroundColor"] = color27;
		this["ButtonSecondaryTextColor"] = white5;
		this["ButtonSecondaryBackgroundColor"] = color28;
		this["ButtonSecondaryBorderColor"] = white6;
		this["AfnemerOverlay"] = fileImageSource2;
		this["ImageButtonSluiten"] = fileImageSource3;
		this["ImageButtonBack"] = fileImageSource4;
		this["MenuIconNieuwBericht"] = fileImageSource5;
		this["MenuIconSmall"] = fileImageSource6;
		this["RadioButtonAppOff"] = fileImageSource7;
		this["RadioButtonAppOn"] = fileImageSource8;
		this["digidIconLandingInloggen"] = fileImageSource9;
		this["digidIconLandingKoppelcode"] = fileImageSource10;
		this["pincode0"] = fileImageSource11;
		this["pincode1"] = fileImageSource12;
		this["pincode2"] = fileImageSource13;
		this["pincode3"] = fileImageSource14;
		this["pincode4"] = fileImageSource15;
		this["pincode5"] = fileImageSource16;
		this["pincode6"] = fileImageSource17;
		this["pincode7"] = fileImageSource18;
		this["pincode8"] = fileImageSource19;
		this["pincode9"] = fileImageSource20;
		this["pincodeBackspace"] = fileImageSource21;
		this["pincodeFingerPrint"] = fileImageSource22;
		this["pincodeTouchID"] = fileImageSource23;
		this["pincodeFaceID"] = fileImageSource24;
		this["pincode_on"] = fileImageSource25;
		this["pincode_active"] = fileImageSource26;
		this["pincode_inactive"] = fileImageSource27;
		this["pincode_locked"] = fileImageSource28;
		this["digidIconDocumentCheckAlert"] = fileImageSource29;
		this["digidIconDocumentCheckOk"] = fileImageSource30;
		this["digidIconMenuBerichtenNieuweBericht"] = fileImageSource31;
		this["digidIconMenuBerichten"] = fileImageSource32;
		this["digidIconMenuBerichtenRectangle"] = fileImageSource33;
		this["digidIconMenuMijnDigid"] = fileImageSource34;
		this["iconMenuInstellingen"] = fileImageSource35;
		this["iconMenuFaq"] = fileImageSource36;
		this["digidIconMenuUitloggen"] = fileImageSource37;
		this["iconTaalSelectie"] = fileImageSource38;
		this["iconInstellingenSwitchTheme"] = fileImageSource39;
		this["digidIconMenuTekstgrootte"] = fileImageSource40;
		this["digidIconMenuDyslexieFont"] = fileImageSource41;
		this["iconMenuVerzamelenStatistieken"] = fileImageSource42;
		this["digidIconMenuAppDeactiveren"] = fileImageSource43;
		this["digidIconMenuTouchId"] = fileImageSource44;
		this["digidIconMenuFaceId"] = fileImageSource45;
		this["digidIconMenuFingerprint"] = fileImageSource46;
		this["iconScreenshots"] = fileImageSource47;
		this["digidIconMenuEmail"] = fileImageSource48;
		this["digidIconMenuAppGebruiksgeschiedenis"] = fileImageSource49;
		this["digidIconPincodeVeranderen"] = fileImageSource50;
		this["digidIconMenu2fa"] = fileImageSource51;
		this["digidIconMenuContact"] = fileImageSource52;
		this["iconMenuInfoOverDeApp"] = fileImageSource53;
		this["digidIconMenuOndersteuning"] = fileImageSource54;
		this["digidIconMenuRate"] = fileImageSource55;
		this["digidIconMenuToegankelijkheid"] = fileImageSource56;
		this["digidIconOpensourceLibraries"] = fileImageSource57;
		this["iconMenuExternalLink"] = fileImageSource58;
		this["iconButtonExternalLink"] = fileImageSource59;
		this["iconSluiten"] = fileImageSource60;
		this["iconInstellingenTaalVink"] = fileImageSource61;
		this["digidIconMenuChevronInterneLink"] = fileImageSource62;
		this["digidIconNotificatie"] = fileImageSource63;
		this["BottomSheetCloseIcon"] = fileImageSource64;
		this["PasswordToggleOffIcon"] = fileImageSource65;
		this["PasswordToggleOnIcon"] = fileImageSource66;
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
		this.LoadFromXaml(typeof(DarkDyslexia));
	}
}
