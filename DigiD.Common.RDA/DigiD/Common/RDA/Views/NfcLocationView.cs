using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using DigiD.Common.Controls;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;
using Syncfusion.Maui.Core;
using Syncfusion.Maui.ProgressBar;

namespace DigiD.Common.RDA.Views;

[XamlFilePath("Views\\NfcLocationView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class NfcLocationView : ContentView
{
	public static readonly BindableProperty ReScanProperty = BindableProperty.Create("ReScan", typeof(bool), typeof(NfcLocationView), false, BindingMode.OneWay, null, ReScanPropertyChanged);

	public static readonly BindableProperty WaitForRemovalProperty = BindableProperty.Create("WaitForRemovalProperty", typeof(bool), typeof(NfcLocationView), false, BindingMode.OneWay, null, WaitForRemovalPropertyChanged);

	public static readonly BindableProperty ProgressProperty = BindableProperty.Create("Progress", typeof(int), typeof(NfcLocationView), 0, BindingMode.OneWay, null, ProgressPropertyChanged);

	public static readonly BindableProperty DocumentTypeProperty = BindableProperty.Create("DocumentType", typeof(DocumentType), typeof(NfcLocationView), DocumentType.Generic, BindingMode.OneWay, null, DocumentTypePropertyChanged);

	public static readonly BindableProperty NfcPositionProperty = BindableProperty.Create("NfcPosition", typeof(NfcPosition), typeof(NfcLocationView), null, BindingMode.OneWay, null, NfcPositionPropertyChanged);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout ContainerProgress;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private SfBusyIndicator ProgressIndicator;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label ProgressLabel;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Image IconChecked;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private SfLinearProgressBar ProgressBar;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TextContainer2Title;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TextContainer2Text;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout TextContainer1;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TextContainer1Title;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label LabelKnownPosition;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Span LabelLocation1;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label LabelUnknownPosition;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private VerticalStackLayout TextContainer2;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TextContainer3Title;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TextContainer3Text;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Span LabelLocation2;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private CustomAnimationView AnimationView;

	public bool ReScan
	{
		get
		{
			return (bool)GetValue(ReScanProperty);
		}
		set
		{
			SetValue(ReScanProperty, value);
		}
	}

	public bool WaitForRemoval
	{
		get
		{
			return (bool)GetValue(WaitForRemovalProperty);
		}
		set
		{
			SetValue(WaitForRemovalProperty, value);
		}
	}

	public int Progress
	{
		get
		{
			return (int)GetValue(ProgressProperty);
		}
		set
		{
			SetValue(ProgressProperty, value);
		}
	}

	public DocumentType DocumentType
	{
		get
		{
			return (DocumentType)GetValue(DocumentTypeProperty);
		}
		set
		{
			SetValue(DocumentTypeProperty, value);
		}
	}

	public NfcPosition NfcPosition
	{
		get
		{
			return (NfcPosition)GetValue(NfcPositionProperty);
		}
		set
		{
			SetValue(NfcPositionProperty, value);
		}
	}

	private static IA11YService A11YService => ((IApp)Application.Current).A11YService;

	private static void DocumentTypePropertyChanged(BindableObject bindable, object? oldvalue, object? newvalue)
	{
		if (bindable is NfcLocationView nfcLocationView)
		{
			nfcLocationView.TextContainer1Title.Text = string.Format(CommonResources.DG080_Title, nfcLocationView.DocumentType.Translate().ToLower());
			if (nfcLocationView.NfcPosition != NfcPosition.Unknown || DeviceInfo.Platform == DevicePlatform.Android)
			{
				nfcLocationView.SetAnimation();
			}
		}
	}

	private static void NfcPositionPropertyChanged(BindableObject bindable, object? oldvalue, object? newvalue)
	{
		if (bindable is NfcLocationView nfcLocationView)
		{
			nfcLocationView.SetPosition();
		}
	}

	private static void ReScanPropertyChanged(BindableObject bindable, object? oldvalue, object? newvalue)
	{
		if (bindable is NfcLocationView nfcLocationView)
		{
			nfcLocationView.TextContainer1Title.Text = string.Format(CommonResources.DG080_Title_Again, nfcLocationView.DocumentType.Translate().ToLower());
		}
	}

	private static void WaitForRemovalPropertyChanged(BindableObject bindable, object? oldvalue, object? newvalue)
	{
		if (bindable is NfcLocationView nfcLocationView)
		{
			ArgumentNullException.ThrowIfNull(Application.Current, "Application.Current");
			nfcLocationView.TextContainer2Title.Text = string.Format(CommonResources.DG080_WaitForRemoval_Title, nfcLocationView.DocumentType.Translate().ToLowerInvariant());
			nfcLocationView.TextContainer2Text.Text = CommonResources.DG080_WaitForRemoval_Message;
			nfcLocationView.ProgressBar.ProgressFill = (Color)Application.Current.Resources["Green2"];
			nfcLocationView.ProgressIndicator.IsVisible = false;
			nfcLocationView.ProgressLabel.IsVisible = false;
			nfcLocationView.IconChecked.IsVisible = true;
		}
	}

	private static void ProgressPropertyChanged(BindableObject bindable, object? oldvalue, object? newvalue)
	{
		if (!(bindable is NfcLocationView nfcLocationView) || !(newvalue is int num) || !(oldvalue is int num2))
		{
			return;
		}
		nfcLocationView.TextContainer1.IsVisible = false;
		nfcLocationView.ProgressBar.IsVisible = num > 0;
		nfcLocationView.ProgressBar.Progress = num;
		nfcLocationView.ProgressLabel.Text = $"{num}%";
		if (num == 0)
		{
			nfcLocationView.TextContainer2.IsVisible = true;
			nfcLocationView.ContainerProgress.IsVisible = false;
			nfcLocationView.AnimationView.IsVisible = true;
			nfcLocationView.AnimationView.Progress = default(TimeSpan);
			if (num2 > 0)
			{
				A11YService.Speak(nfcLocationView.TextContainer3Title.Text);
				SemanticProperties.SetDescription(nfcLocationView.TextContainer3Text, nfcLocationView.TextContainer3Text.Text);
			}
			else
			{
				A11YService.Speak(CommonResources.Alg_Scanning);
			}
		}
		else if (num2 == 0)
		{
			nfcLocationView.ContainerProgress.IsVisible = true;
			nfcLocationView.TextContainer2.IsVisible = false;
			nfcLocationView.AnimationView.IsVisible = false;
			A11YService.Speak(nfcLocationView.TextContainer2Title.Text + ", " + nfcLocationView.TextContainer2Text.Text);
		}
	}

	public NfcLocationView()
	{
		InitializeComponent();
		AnimationView.WidthRequest = DisplayHelper.Width - 40.0;
		AnimationView.HeightRequest = DisplayHelper.Width - 40.0;
		AnimationView.AnimationSource = $"dga_animatie_nfcscan_locatie_{NfcPosition}_generic.json".ToLowerInvariant();
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			ContainerProgress.Margin = new Thickness(0.0, 50.0, 0.0, 0.0);
		}
		TextContainer1Title.Text = string.Format(CommonResources.DG080_Title, DocumentType.Translate().ToLower());
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		if (base.BindingContext != null)
		{
			SetPosition();
		}
	}

	private void SetPosition()
	{
		LabelKnownPosition.IsVisible = NfcPosition != NfcPosition.Unknown;
		LabelUnknownPosition.IsVisible = NfcPosition == NfcPosition.Unknown;
		switch (NfcPosition)
		{
		case NfcPosition.Top:
			LabelLocation1.Text = CommonResources.DG082_Text_Part4_Top;
			LabelLocation2.Text = LabelLocation1.Text;
			break;
		case NfcPosition.Middle:
			LabelLocation1.Text = CommonResources.DG082_Text_Part4_Middle;
			LabelLocation2.Text = LabelLocation1.Text;
			break;
		case NfcPosition.Bottom:
			LabelLocation1.Text = CommonResources.DG082_Text_Part4_Bottom;
			LabelLocation2.Text = LabelLocation1.Text;
			break;
		}
		if (base.BindingContext != null)
		{
			A11YService.Speak(TextContainer1Title.Text, 1);
			if (LabelKnownPosition.IsVisible)
			{
				string text = LabelKnownPosition.FormattedText.ToString();
				A11YService.Speak(text);
				SemanticProperties.SetDescription(LabelKnownPosition, text);
			}
			else
			{
				string text2 = LabelUnknownPosition.FormattedText.ToString();
				A11YService.Speak(text2);
				SemanticProperties.SetDescription(LabelUnknownPosition, text2);
			}
		}
		SetAnimation();
	}

	private void SetAnimation()
	{
		AnimationView.AnimationSource = $"dga_animatie_nfcscan_locatie_{NfcPosition}_{DocumentType.ToString().ToLower()}.json".ToLowerInvariant();
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("ContainerProgress")]
	[MemberNotNull("ProgressIndicator")]
	[MemberNotNull("ProgressLabel")]
	[MemberNotNull("IconChecked")]
	[MemberNotNull("ProgressBar")]
	[MemberNotNull("TextContainer2Title")]
	[MemberNotNull("TextContainer2Text")]
	[MemberNotNull("TextContainer1")]
	[MemberNotNull("TextContainer1Title")]
	[MemberNotNull("LabelKnownPosition")]
	[MemberNotNull("LabelLocation1")]
	[MemberNotNull("LabelUnknownPosition")]
	[MemberNotNull("TextContainer2")]
	[MemberNotNull("TextContainer3Title")]
	[MemberNotNull("TextContainer3Text")]
	[MemberNotNull("LabelLocation2")]
	[MemberNotNull("AnimationView")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(NfcLocationView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(NfcLocationView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 18, 13);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 32, 21);
		SfBusyIndicator sfBusyIndicator = new SfBusyIndicator();
		VisualDiagnostics.RegisterSourceInfo(sfBusyIndicator, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 25, 18);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 43, 21);
		StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 44, 21);
		LabelLiveTextBehavior labelLiveTextBehavior = new LabelLiveTextBehavior();
		VisualDiagnostics.RegisterSourceInfo(labelLiveTextBehavior, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 47, 26);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 38, 18);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 51, 22);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 21, 14);
		StaticResourceExtension staticResourceExtension4 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 64, 17);
		SfLinearProgressBar sfLinearProgressBar = new SfLinearProgressBar();
		VisualDiagnostics.RegisterSourceInfo(sfLinearProgressBar, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 59, 14);
		StaticResourceExtension staticResourceExtension5 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 74, 21);
		TranslateBindingExtension translateBindingExtension = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 75, 21);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 72, 18);
		TranslateBindingExtension translateBindingExtension2 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 77, 52);
		Label label3 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 77, 18);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 71, 14);
		VerticalStackLayout verticalStackLayout2 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 13, 10);
		StaticResourceExtension staticResourceExtension6 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension6, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 86, 49);
		Label label4 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 86, 14);
		TranslateBindingExtension translateBindingExtension3 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 90, 31);
		Span span = new Span();
		VisualDiagnostics.RegisterSourceInfo(span, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 90, 26);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 91, 31);
		StaticResourceExtension staticResourceExtension7 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension7, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 91, 77);
		Span span2 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 91, 26);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 92, 31);
		Span span3 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 92, 26);
		StaticResourceExtension staticResourceExtension8 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension8, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 93, 55);
		Span span4 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 93, 26);
		FormattedString formattedString = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 89, 22);
		Label label5 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 87, 14);
		TranslateBindingExtension translateBindingExtension4 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 100, 31);
		Span span5 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 100, 26);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 101, 31);
		StaticResourceExtension staticResourceExtension9 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension9, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 101, 77);
		Span span6 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span6, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 101, 26);
		TranslateExtension translateExtension4 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 102, 31);
		Span span7 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span7, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 102, 26);
		TranslateExtension translateExtension5 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 103, 31);
		StaticResourceExtension staticResourceExtension10 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension10, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 103, 72);
		Span span8 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span8, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 103, 26);
		FormattedString formattedString2 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 99, 22);
		Label label6 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label6, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 97, 14);
		VerticalStackLayout verticalStackLayout3 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 81, 10);
		StaticResourceExtension staticResourceExtension11 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension11, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 116, 17);
		TranslateExtension translateExtension6 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension6, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 117, 17);
		Label label7 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label7, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 114, 14);
		TranslateBindingExtension translateBindingExtension5 = new TranslateBindingExtension();
		VisualDiagnostics.RegisterSourceInfo(translateBindingExtension5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 121, 31);
		Span span9 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span9, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 121, 26);
		StaticResourceExtension staticResourceExtension12 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension12, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 122, 31);
		TranslateExtension translateExtension7 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension7, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 122, 65);
		Span span10 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span10, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 122, 26);
		TranslateExtension translateExtension8 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension8, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 123, 31);
		Span span11 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span11, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 123, 26);
		StaticResourceExtension staticResourceExtension13 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension13, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 124, 55);
		Span span12 = new Span();
		VisualDiagnostics.RegisterSourceInfo(span12, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 124, 26);
		FormattedString formattedString3 = new FormattedString();
		VisualDiagnostics.RegisterSourceInfo(formattedString3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 120, 22);
		Label label8 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label8, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 118, 14);
		VerticalStackLayout verticalStackLayout4 = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 109, 10);
		CustomAnimationView customAnimationView = new CustomAnimationView();
		VisualDiagnostics.RegisterSourceInfo(customAnimationView, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 130, 10);
		Grid grid2 = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 12, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		grid2.transientNamescope = nameScope;
		verticalStackLayout2.transientNamescope = nameScope;
		nameScope.RegisterName("ContainerProgress", verticalStackLayout2);
		VerticalStackLayout verticalStackLayout5 = verticalStackLayout2;
		if (verticalStackLayout5.StyleId == null)
		{
			string text = (verticalStackLayout5.StyleId = "ContainerProgress");
		}
		grid.transientNamescope = nameScope;
		sfBusyIndicator.transientNamescope = nameScope;
		nameScope.RegisterName("ProgressIndicator", sfBusyIndicator);
		SfBusyIndicator sfBusyIndicator2 = sfBusyIndicator;
		if (sfBusyIndicator2.StyleId == null)
		{
			string text = (sfBusyIndicator2.StyleId = "ProgressIndicator");
		}
		label.transientNamescope = nameScope;
		nameScope.RegisterName("ProgressLabel", label);
		Label label9 = label;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "ProgressLabel");
		}
		image.transientNamescope = nameScope;
		nameScope.RegisterName("IconChecked", image);
		Image image2 = image;
		if (image2.StyleId == null)
		{
			string text = (image2.StyleId = "IconChecked");
		}
		sfLinearProgressBar.transientNamescope = nameScope;
		nameScope.RegisterName("ProgressBar", sfLinearProgressBar);
		SfLinearProgressBar sfLinearProgressBar2 = sfLinearProgressBar;
		if (sfLinearProgressBar2.StyleId == null)
		{
			string text = (sfLinearProgressBar2.StyleId = "ProgressBar");
		}
		verticalStackLayout.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer2Title", label2);
		label9 = label2;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "TextContainer2Title");
		}
		label3.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer2Text", label3);
		label9 = label3;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "TextContainer2Text");
		}
		verticalStackLayout3.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer1", verticalStackLayout3);
		verticalStackLayout5 = verticalStackLayout3;
		if (verticalStackLayout5.StyleId == null)
		{
			string text = (verticalStackLayout5.StyleId = "TextContainer1");
		}
		label4.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer1Title", label4);
		label9 = label4;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "TextContainer1Title");
		}
		label5.transientNamescope = nameScope;
		nameScope.RegisterName("LabelKnownPosition", label5);
		label9 = label5;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "LabelKnownPosition");
		}
		formattedString.transientNamescope = nameScope;
		span.transientNamescope = nameScope;
		span2.transientNamescope = nameScope;
		span3.transientNamescope = nameScope;
		span4.transientNamescope = nameScope;
		nameScope.RegisterName("LabelLocation1", span4);
		Span span13 = span4;
		if (span13.StyleId == null)
		{
			string text = (span13.StyleId = "LabelLocation1");
		}
		label6.transientNamescope = nameScope;
		nameScope.RegisterName("LabelUnknownPosition", label6);
		label9 = label6;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "LabelUnknownPosition");
		}
		formattedString2.transientNamescope = nameScope;
		span5.transientNamescope = nameScope;
		span6.transientNamescope = nameScope;
		span7.transientNamescope = nameScope;
		span8.transientNamescope = nameScope;
		verticalStackLayout4.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer2", verticalStackLayout4);
		verticalStackLayout5 = verticalStackLayout4;
		if (verticalStackLayout5.StyleId == null)
		{
			string text = (verticalStackLayout5.StyleId = "TextContainer2");
		}
		label7.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer3Title", label7);
		label9 = label7;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "TextContainer3Title");
		}
		label8.transientNamescope = nameScope;
		nameScope.RegisterName("TextContainer3Text", label8);
		label9 = label8;
		if (label9.StyleId == null)
		{
			string text = (label9.StyleId = "TextContainer3Text");
		}
		formattedString3.transientNamescope = nameScope;
		span9.transientNamescope = nameScope;
		span10.transientNamescope = nameScope;
		span11.transientNamescope = nameScope;
		span12.transientNamescope = nameScope;
		nameScope.RegisterName("LabelLocation2", span12);
		span13 = span12;
		if (span13.StyleId == null)
		{
			string text = (span13.StyleId = "LabelLocation2");
		}
		customAnimationView.transientNamescope = nameScope;
		nameScope.RegisterName("AnimationView", customAnimationView);
		CustomAnimationView customAnimationView2 = customAnimationView;
		if (customAnimationView2.StyleId == null)
		{
			string text = (customAnimationView2.StyleId = "AnimationView");
		}
		ContainerProgress = verticalStackLayout2;
		ProgressIndicator = sfBusyIndicator;
		ProgressLabel = label;
		IconChecked = image;
		ProgressBar = sfLinearProgressBar;
		TextContainer2Title = label2;
		TextContainer2Text = label3;
		TextContainer1 = verticalStackLayout3;
		TextContainer1Title = label4;
		LabelKnownPosition = label5;
		LabelLocation1 = span4;
		LabelUnknownPosition = label6;
		TextContainer2 = verticalStackLayout4;
		TextContainer3Title = label7;
		TextContainer3Text = label8;
		LabelLocation2 = span12;
		AnimationView = customAnimationView;
		grid2.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Star)));
		grid2.SetValue(Grid.RowSpacingProperty, 20.0);
		verticalStackLayout2.SetValue(Grid.RowSpanProperty, 2);
		verticalStackLayout2.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		verticalStackLayout2.SetValue(StackBase.SpacingProperty, 20.0);
		onPlatformExtension.Android = "Center";
		onPlatformExtension.iOS = "Start";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[3] { verticalStackLayout2, grid2, this }, View.VerticalOptionsProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(18, 13)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 18, 13);
		}
		verticalStackLayout2.SetValue(View.VerticalOptionsProperty, obj);
		verticalStackLayout2.SetValue(VisualElement.ZIndexProperty, 10);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
		grid.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		sfBusyIndicator.SetValue(SfBusyIndicator.AnimationTypeProperty, AnimationType.CircularMaterial);
		sfBusyIndicator.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		sfBusyIndicator.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		sfBusyIndicator.SetValue(VisualElement.HeightRequestProperty, 40.0);
		sfBusyIndicator.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		staticResourceExtension.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { sfBusyIndicator, grid, verticalStackLayout2, grid2, this }, SfBusyIndicator.IndicatorColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 21)));
		object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 32, 21);
		}
		sfBusyIndicator.SetValue(SfBusyIndicator.IndicatorColorProperty, obj2);
		sfBusyIndicator.SetValue(SfBusyIndicator.IsRunningProperty, true);
		sfBusyIndicator.SetValue(SfBusyIndicator.SizeFactorProperty, 0.2);
		sfBusyIndicator.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		sfBusyIndicator.SetValue(VisualElement.WidthRequestProperty, 40.0);
		grid.Children.Add(sfBusyIndicator);
		label.SetValue(Grid.ColumnProperty, 1);
		label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		label.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);
		staticResourceExtension2.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { label, grid, verticalStackLayout2, grid2, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(43, 21)));
		object obj3 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 43, 21);
		}
		label.SetValue(VisualElement.StyleProperty, obj3);
		staticResourceExtension3.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[5] { label, grid, verticalStackLayout2, grid2, this }, Label.TextColorProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(44, 21)));
		object obj4 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 44, 21);
		}
		label.SetValue(Label.TextColorProperty, obj4);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		((IList<Behavior>)label.GetValue(VisualElement.BehaviorsProperty)).Add(labelLiveTextBehavior);
		grid.Children.Add(label);
		image.SetValue(VisualElement.HeightRequestProperty, 24.0);
		image.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		image.SetValue(Image.SourceProperty, ImageSource.FromFile("digid_icon_vink.png"));
		image.SetValue(VisualElement.WidthRequestProperty, 24.0);
		grid.Children.Add(image);
		verticalStackLayout2.Children.Add(grid);
		sfLinearProgressBar.SetValue(View.MarginProperty, new Thickness(0.0, -10.0, 0.0, 0.0));
		sfLinearProgressBar.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		sfLinearProgressBar.SetValue(SfLinearProgressBar.ProgressCornerRadiusProperty, new CornerRadius(4.0));
		staticResourceExtension4.Key = "PrimaryColor";
		XamlServiceProvider xamlServiceProvider5 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service5 = new SimpleValueTargetProvider(new object[4] { sfLinearProgressBar, verticalStackLayout2, grid2, this }, ProgressBarBase.ProgressFillProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider5.Add(typeof(IReferenceProvider), service5);
		xamlServiceProvider5.Add(typeof(IProvideValueTarget), service5);
		xamlServiceProvider5.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(64, 17)));
		object obj5 = ((IMarkupExtension)staticResourceExtension4).ProvideValue((IServiceProvider)xamlServiceProvider5);
		if (VisualDiagnostics.GetSourceInfo(obj5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 64, 17);
		}
		sfLinearProgressBar.SetValue(ProgressBarBase.ProgressFillProperty, obj5);
		sfLinearProgressBar.SetValue(SfLinearProgressBar.ProgressHeightProperty, 8.0);
		sfLinearProgressBar.SetValue(SfLinearProgressBar.TrackCornerRadiusProperty, new CornerRadius(4.0));
		sfLinearProgressBar.SetValue(ProgressBarBase.TrackFillProperty, new BrushTypeConverter().ConvertFromInvariantString("#D9D9D9") as Brush);
		sfLinearProgressBar.SetValue(SfLinearProgressBar.TrackHeightProperty, 8.0);
		sfLinearProgressBar.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		verticalStackLayout2.Children.Add(sfLinearProgressBar);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 20.0);
		staticResourceExtension5.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider6 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service6 = new SimpleValueTargetProvider(new object[5] { label2, verticalStackLayout, verticalStackLayout2, grid2, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider6.Add(typeof(IReferenceProvider), service6);
		xamlServiceProvider6.Add(typeof(IProvideValueTarget), service6);
		xamlServiceProvider6.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(74, 21)));
		object obj6 = ((IMarkupExtension)staticResourceExtension5).ProvideValue((IServiceProvider)xamlServiceProvider6);
		if (VisualDiagnostics.GetSourceInfo(obj6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj6, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 74, 21);
		}
		label2.SetValue(VisualElement.StyleProperty, obj6);
		translateBindingExtension.TranslateFormat = "DG081_Title";
		translateBindingExtension.Path = "CurrentDocumentType";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateBindingExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 75, 21);
		}
		label2.SetBinding(Label.TextProperty, bindingBase);
		verticalStackLayout.Children.Add(label2);
		translateBindingExtension2.TranslateFormat = "DG081_Text";
		translateBindingExtension2.Path = "CurrentDocumentType";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateBindingExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 77, 52);
		}
		label3.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label3);
		verticalStackLayout2.Children.Add(verticalStackLayout);
		grid2.Children.Add(verticalStackLayout2);
		verticalStackLayout3.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("True"));
		verticalStackLayout3.SetValue(StackBase.SpacingProperty, 20.0);
		verticalStackLayout3.SetValue(VisualElement.ZIndexProperty, 10);
		staticResourceExtension6.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider7 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service7 = new SimpleValueTargetProvider(new object[4] { label4, verticalStackLayout3, grid2, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider7.Add(typeof(IReferenceProvider), service7);
		xamlServiceProvider7.Add(typeof(IProvideValueTarget), service7);
		xamlServiceProvider7.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(86, 49)));
		object obj7 = ((IMarkupExtension)staticResourceExtension6).ProvideValue((IServiceProvider)xamlServiceProvider7);
		if (VisualDiagnostics.GetSourceInfo(obj7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj7, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 86, 49);
		}
		label4.SetValue(VisualElement.StyleProperty, obj7);
		verticalStackLayout3.Children.Add(label4);
		translateBindingExtension3.TranslateFormat = "DG080_Text_Part1";
		translateBindingExtension3.Path = "CurrentDocumentType";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateBindingExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 90, 31);
		}
		span.SetBinding(Span.TextProperty, bindingBase3);
		formattedString.Spans.Add(span);
		translateExtension.Text = "DG080_Text_Part2";
		BindingBase bindingBase4 = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 91, 31);
		}
		span2.SetBinding(Span.TextProperty, bindingBase4);
		staticResourceExtension7.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider8 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service8 = new SimpleValueTargetProvider(new object[6] { span2, formattedString, label5, verticalStackLayout3, grid2, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider8.Add(typeof(IReferenceProvider), service8);
		xamlServiceProvider8.Add(typeof(IProvideValueTarget), service8);
		xamlServiceProvider8.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(91, 77)));
		object obj8 = ((IMarkupExtension)staticResourceExtension7).ProvideValue((IServiceProvider)xamlServiceProvider8);
		if (VisualDiagnostics.GetSourceInfo(obj8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj8, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 91, 77);
		}
		span2.SetValue(Span.StyleProperty, obj8);
		formattedString.Spans.Add(span2);
		translateExtension2.Text = "DG080_Text_Part3";
		BindingBase bindingBase5 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 92, 31);
		}
		span3.SetBinding(Span.TextProperty, bindingBase5);
		formattedString.Spans.Add(span3);
		staticResourceExtension8.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider9 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service9 = new SimpleValueTargetProvider(new object[6] { span4, formattedString, label5, verticalStackLayout3, grid2, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider9.Add(typeof(IReferenceProvider), service9);
		xamlServiceProvider9.Add(typeof(IProvideValueTarget), service9);
		xamlServiceProvider9.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(93, 55)));
		object obj9 = ((IMarkupExtension)staticResourceExtension8).ProvideValue((IServiceProvider)xamlServiceProvider9);
		if (VisualDiagnostics.GetSourceInfo(obj9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj9, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 93, 55);
		}
		span4.SetValue(Span.StyleProperty, obj9);
		formattedString.Spans.Add(span4);
		label5.SetValue(Label.FormattedTextProperty, formattedString);
		verticalStackLayout3.Children.Add(label5);
		translateBindingExtension4.TranslateFormat = "DG080_Text_Part1";
		translateBindingExtension4.Path = "CurrentDocumentType";
		BindingBase bindingBase6 = ((IMarkupExtension<BindingBase>)translateBindingExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 100, 31);
		}
		span5.SetBinding(Span.TextProperty, bindingBase6);
		formattedString2.Spans.Add(span5);
		translateExtension3.Text = "DG080_Text_Part2";
		BindingBase bindingBase7 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 101, 31);
		}
		span6.SetBinding(Span.TextProperty, bindingBase7);
		staticResourceExtension9.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider10 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service10 = new SimpleValueTargetProvider(new object[6] { span6, formattedString2, label6, verticalStackLayout3, grid2, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider10.Add(typeof(IReferenceProvider), service10);
		xamlServiceProvider10.Add(typeof(IProvideValueTarget), service10);
		xamlServiceProvider10.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(101, 77)));
		object obj10 = ((IMarkupExtension)staticResourceExtension9).ProvideValue((IServiceProvider)xamlServiceProvider10);
		if (VisualDiagnostics.GetSourceInfo(obj10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj10, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 101, 77);
		}
		span6.SetValue(Span.StyleProperty, obj10);
		formattedString2.Spans.Add(span6);
		translateExtension4.Text = "DG080_Text_Part4";
		BindingBase bindingBase8 = ((IMarkupExtension<BindingBase>)translateExtension4).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 102, 31);
		}
		span7.SetBinding(Span.TextProperty, bindingBase8);
		formattedString2.Spans.Add(span7);
		translateExtension5.Text = "DG080_Text_Part5";
		BindingBase bindingBase9 = ((IMarkupExtension<BindingBase>)translateExtension5).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 103, 31);
		}
		span8.SetBinding(Span.TextProperty, bindingBase9);
		staticResourceExtension10.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider11 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service11 = new SimpleValueTargetProvider(new object[6] { span8, formattedString2, label6, verticalStackLayout3, grid2, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider11.Add(typeof(IReferenceProvider), service11);
		xamlServiceProvider11.Add(typeof(IProvideValueTarget), service11);
		xamlServiceProvider11.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(103, 72)));
		object obj11 = ((IMarkupExtension)staticResourceExtension10).ProvideValue((IServiceProvider)xamlServiceProvider11);
		if (VisualDiagnostics.GetSourceInfo(obj11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj11, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 103, 72);
		}
		span8.SetValue(Span.StyleProperty, obj11);
		formattedString2.Spans.Add(span8);
		label6.SetValue(Label.FormattedTextProperty, formattedString2);
		verticalStackLayout3.Children.Add(label6);
		grid2.Children.Add(verticalStackLayout3);
		verticalStackLayout4.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("false"));
		verticalStackLayout4.SetValue(StackBase.SpacingProperty, 20.0);
		verticalStackLayout4.SetValue(VisualElement.ZIndexProperty, 10);
		staticResourceExtension11.Key = "LabelHeader";
		XamlServiceProvider xamlServiceProvider12 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service12 = new SimpleValueTargetProvider(new object[4] { label7, verticalStackLayout4, grid2, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider12.Add(typeof(IReferenceProvider), service12);
		xamlServiceProvider12.Add(typeof(IProvideValueTarget), service12);
		xamlServiceProvider12.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(116, 17)));
		object obj12 = ((IMarkupExtension)staticResourceExtension11).ProvideValue((IServiceProvider)xamlServiceProvider12);
		if (VisualDiagnostics.GetSourceInfo(obj12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj12, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 116, 17);
		}
		label7.SetValue(VisualElement.StyleProperty, obj12);
		translateExtension6.Text = "DG082_Title";
		BindingBase bindingBase10 = ((IMarkupExtension<BindingBase>)translateExtension6).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 117, 17);
		}
		label7.SetBinding(Label.TextProperty, bindingBase10);
		verticalStackLayout4.Children.Add(label7);
		translateBindingExtension5.TranslateFormat = "DG082_Text_Part1";
		translateBindingExtension5.Path = "CurrentDocumentType";
		BindingBase bindingBase11 = ((IMarkupExtension<BindingBase>)translateBindingExtension5).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 121, 31);
		}
		span9.SetBinding(Span.TextProperty, bindingBase11);
		formattedString3.Spans.Add(span9);
		staticResourceExtension12.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider13 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service13 = new SimpleValueTargetProvider(new object[6] { span10, formattedString3, label8, verticalStackLayout4, grid2, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider13.Add(typeof(IReferenceProvider), service13);
		xamlServiceProvider13.Add(typeof(IProvideValueTarget), service13);
		xamlServiceProvider13.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(122, 31)));
		object obj13 = ((IMarkupExtension)staticResourceExtension12).ProvideValue((IServiceProvider)xamlServiceProvider13);
		if (VisualDiagnostics.GetSourceInfo(obj13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj13, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 122, 31);
		}
		span10.SetValue(Span.StyleProperty, obj13);
		translateExtension7.Text = "DG082_Text_Part2";
		BindingBase bindingBase12 = ((IMarkupExtension<BindingBase>)translateExtension7).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 122, 65);
		}
		span10.SetBinding(Span.TextProperty, bindingBase12);
		formattedString3.Spans.Add(span10);
		translateExtension8.Text = "DG082_Text_Part5";
		BindingBase bindingBase13 = ((IMarkupExtension<BindingBase>)translateExtension8).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 123, 31);
		}
		span11.SetBinding(Span.TextProperty, bindingBase13);
		formattedString3.Spans.Add(span11);
		staticResourceExtension13.Key = "SpanBold";
		XamlServiceProvider xamlServiceProvider14 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service14 = new SimpleValueTargetProvider(new object[6] { span12, formattedString3, label8, verticalStackLayout4, grid2, this }, Span.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider14.Add(typeof(IReferenceProvider), service14);
		xamlServiceProvider14.Add(typeof(IProvideValueTarget), service14);
		xamlServiceProvider14.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(124, 55)));
		object obj14 = ((IMarkupExtension)staticResourceExtension13).ProvideValue((IServiceProvider)xamlServiceProvider14);
		if (VisualDiagnostics.GetSourceInfo(obj14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj14, new Uri("Views\\NfcLocationView.xaml;assembly=DigiD.Common.RDA", UriKind.Relative), 124, 55);
		}
		span12.SetValue(Span.StyleProperty, obj14);
		formattedString3.Spans.Add(span12);
		label8.SetValue(Label.FormattedTextProperty, formattedString3);
		verticalStackLayout4.Children.Add(label8);
		grid2.Children.Add(verticalStackLayout4);
		customAnimationView.SetValue(Grid.RowProperty, 1);
		customAnimationView.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		customAnimationView.SetValue(VisualElement.ZIndexProperty, 15);
		grid2.Children.Add(customAnimationView);
		SetValue(ContentView.ContentProperty, grid2);
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
	[MemberNotNull("ContainerProgress")]
	[MemberNotNull("ProgressIndicator")]
	[MemberNotNull("ProgressLabel")]
	[MemberNotNull("IconChecked")]
	[MemberNotNull("ProgressBar")]
	[MemberNotNull("TextContainer2Title")]
	[MemberNotNull("TextContainer2Text")]
	[MemberNotNull("TextContainer1")]
	[MemberNotNull("TextContainer1Title")]
	[MemberNotNull("LabelKnownPosition")]
	[MemberNotNull("LabelLocation1")]
	[MemberNotNull("LabelUnknownPosition")]
	[MemberNotNull("TextContainer2")]
	[MemberNotNull("TextContainer3Title")]
	[MemberNotNull("TextContainer3Text")]
	[MemberNotNull("LabelLocation2")]
	[MemberNotNull("AnimationView")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(NfcLocationView));
		ContainerProgress = this.FindByName<VerticalStackLayout>("ContainerProgress");
		ProgressIndicator = this.FindByName<SfBusyIndicator>("ProgressIndicator");
		ProgressLabel = this.FindByName<Label>("ProgressLabel");
		IconChecked = this.FindByName<Image>("IconChecked");
		ProgressBar = this.FindByName<SfLinearProgressBar>("ProgressBar");
		TextContainer2Title = this.FindByName<Label>("TextContainer2Title");
		TextContainer2Text = this.FindByName<Label>("TextContainer2Text");
		TextContainer1 = this.FindByName<VerticalStackLayout>("TextContainer1");
		TextContainer1Title = this.FindByName<Label>("TextContainer1Title");
		LabelKnownPosition = this.FindByName<Label>("LabelKnownPosition");
		LabelLocation1 = this.FindByName<Span>("LabelLocation1");
		LabelUnknownPosition = this.FindByName<Label>("LabelUnknownPosition");
		TextContainer2 = this.FindByName<VerticalStackLayout>("TextContainer2");
		TextContainer3Title = this.FindByName<Label>("TextContainer3Title");
		TextContainer3Text = this.FindByName<Label>("TextContainer3Text");
		LabelLocation2 = this.FindByName<Span>("LabelLocation2");
		AnimationView = this.FindByName<CustomAnimationView>("AnimationView");
	}
}
