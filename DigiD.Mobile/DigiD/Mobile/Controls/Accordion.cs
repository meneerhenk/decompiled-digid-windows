using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Resources;
using DigiD.Mobile.Models;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace DigiD.Mobile.Controls;

[XamlFilePath("Controls\\Accordion.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class Accordion : ContentView
{
	public static readonly BindableProperty HeaderBackgroundColorProperty = BindableProperty.Create("HeaderBackgroundColor", typeof(Color), typeof(Accordion), null, BindingMode.OneWay, null, HeaderBackgroundColorPropertyChanged);

	public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(Accordion), null, BindingMode.OneWay, null, TitlePropertyChanged);

	public static readonly BindableProperty IsOpenProperty = BindableProperty.Create("IsOpen", typeof(bool), typeof(Accordion), false, BindingMode.OneWay, null, IsOpenChanged);

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ContentView AccordionItem;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BoolToObjectConverter OpenCloseConverter;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private A11YBehavior TitleViewBehavior;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private HorizontalStackLayout TitleView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private AccordionButton _titleButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Image ChevronImage;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ContentView ContentView;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? titleTappedCommand;

	public View AccordionContentView
	{
		get
		{
			return ContentView.Content;
		}
		set
		{
			ContentView.Content = value;
		}
	}

	public string Title
	{
		get
		{
			return (string)GetValue(TitleProperty);
		}
		set
		{
			SetValue(TitleProperty, value);
		}
	}

	public bool IsOpen
	{
		get
		{
			return (bool)GetValue(IsOpenProperty);
		}
		set
		{
			SetValue(IsOpenProperty, value);
		}
	}

	public Color HeaderBackgroundColor
	{
		get
		{
			return (Color)GetValue(HeaderBackgroundColorProperty);
		}
		set
		{
			SetValue(HeaderBackgroundColorProperty, value);
		}
	}

	public uint AnimationDuration { get; set; }

	public static double MaxButtonWidth => DisplayHelper.MaxContentWidth - 38.0;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand TitleTappedCommand => titleTappedCommand ?? (titleTappedCommand = new RelayCommand(TitleTapped));

	private static void HeaderBackgroundColorPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		if (bindable is Accordion accordion)
		{
			accordion.TitleView.BackgroundColor = (Color)newvalue;
		}
	}

	private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is Accordion accordion)
		{
			accordion.TitleViewBehavior.Description = accordion.Title;
			accordion.TitleViewBehavior.StateDescription = (accordion.IsOpen ? CommonResources.Alg_FaqAnswerShown : CommonResources.Alg_FaqAnswerHidden);
			accordion._titleButton.Text = (string)newValue;
		}
	}

	[RelayCommand]
	public void TitleTapped()
	{
		TitleTapped(this, EventArgs.Empty);
	}

	private static async void IsOpenChanged(BindableObject? bindable, object? oldValue, object? newValue)
	{
		if (bindable != null && newValue != null)
		{
			Accordion control = (Accordion)bindable;
			control.TitleViewBehavior.CanExecute = false;
			if (!control.IsOpen)
			{
				VisualStateManager.GoToState(control, "Open");
				control.TitleViewBehavior.StateDescription = CommonResources.Alg_FaqAnswerHidden;
				await control.Close();
			}
			else
			{
				VisualStateManager.GoToState(control, "Closed");
				control.TitleViewBehavior.StateDescription = CommonResources.Alg_FaqAnswerShown;
				await control.Open();
			}
			control.TitleViewBehavior.CanExecute = true;
		}
	}

	public Accordion()
	{
		AnimationDuration = 250u;
		IsOpen = false;
		InitializeComponent();
		Task.Run((Func<Task?>)Close);
	}

	private void TitleTapped(object? sender, EventArgs? e)
	{
		IsOpen = !IsOpen;
	}

	private async Task Close()
	{
		InlineArray2<Task<bool>> buffer = default(InlineArray2<Task<bool>>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<Task<bool>>, Task<bool>>(ref buffer, 0) = ChevronImage.RotateToAsync(90.0, AnimationDuration);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<Task<bool>>, Task<bool>>(ref buffer, 1) = ContentView.FadeToAsync(0.0, 50u);
		await Task.WhenAll(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray2<Task<bool>>, Task<bool>>(in buffer, 2));
		ContentView.IsVisible = false;
	}

	private async Task Open()
	{
		ContentView.IsVisible = true;
		InlineArray2<Task<bool>> buffer = default(InlineArray2<Task<bool>>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<Task<bool>>, Task<bool>>(ref buffer, 0) = ChevronImage.RotateToAsync(-90.0, AnimationDuration);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray2<Task<bool>>, Task<bool>>(ref buffer, 1) = ContentView.FadeToAsync(30.0, 50u, Easing.SinIn);
		await Task.WhenAll(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray2<Task<bool>>, Task<bool>>(in buffer, 2));
	}

	private void BorderFocusChanged(object? sender, FocusEventArgs e)
	{
		if (sender is Border border)
		{
			if (e.IsFocused)
			{
				border.Stroke = (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black);
			}
			else
			{
				border.Stroke = Colors.Transparent;
			}
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("AccordionItem")]
	[MemberNotNull("OpenCloseConverter")]
	[MemberNotNull("TitleViewBehavior")]
	[MemberNotNull("TitleView")]
	[MemberNotNull("_titleButton")]
	[MemberNotNull("ChevronImage")]
	[MemberNotNull("ContentView")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(Accordion).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(Accordion)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		string alg_FaqAnswerHidden = CommonResources.Alg_FaqAnswerHidden;
		VisualDiagnostics.RegisterSourceInfo(alg_FaqAnswerHidden, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 18, 13);
		string alg_FaqAnswerShown = CommonResources.Alg_FaqAnswerShown;
		VisualDiagnostics.RegisterSourceInfo(alg_FaqAnswerShown, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 19, 13);
		BoolToObjectConverter boolToObjectConverter = new BoolToObjectConverter();
		VisualDiagnostics.RegisterSourceInfo(boolToObjectConverter, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 10);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 25);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 25);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 25);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 25);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 40, 22);
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 49, 22);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 25);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 25);
		StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 25);
		double maxButtonWidth = MaxButtonWidth;
		VisualDiagnostics.RegisterSourceInfo(maxButtonWidth, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 67, 25);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 25);
		AccordionButton accordionButton = new AccordionButton();
		VisualDiagnostics.RegisterSourceInfo(accordionButton, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 57, 22);
		DynamicResource dynamicResource = new DynamicResource("digidIconMenuChevronInterneLink");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 76, 25);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 71, 22);
		HorizontalStackLayout horizontalStackLayout = new HorizontalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(horizontalStackLayout, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 52, 18);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 32, 14);
		ContentView contentView = new ContentView();
		VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 82, 14);
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 22, 10);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("AccordionItem", this);
		if (StyleId == null)
		{
			string text = (StyleId = "AccordionItem");
		}
		nameScope.RegisterName("OpenCloseConverter", boolToObjectConverter);
		verticalStackLayout.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		nameScope.RegisterName("TitleViewBehavior", a11YBehavior);
		tapGestureRecognizer.transientNamescope = nameScope;
		horizontalStackLayout.transientNamescope = nameScope;
		nameScope.RegisterName("TitleView", horizontalStackLayout);
		HorizontalStackLayout horizontalStackLayout2 = horizontalStackLayout;
		if (horizontalStackLayout2.StyleId == null)
		{
			string text = (horizontalStackLayout2.StyleId = "TitleView");
		}
		accordionButton.transientNamescope = nameScope;
		nameScope.RegisterName("_titleButton", accordionButton);
		AccordionButton accordionButton2 = accordionButton;
		if (accordionButton2.StyleId == null)
		{
			string text = (accordionButton2.StyleId = "_titleButton");
		}
		image.transientNamescope = nameScope;
		nameScope.RegisterName("ChevronImage", image);
		Image image2 = image;
		if (image2.StyleId == null)
		{
			string text = (image2.StyleId = "ChevronImage");
		}
		contentView.transientNamescope = nameScope;
		nameScope.RegisterName("ContentView", contentView);
		ContentView contentView2 = contentView;
		if (contentView2.StyleId == null)
		{
			string text = (contentView2.StyleId = "ContentView");
		}
		AccordionItem = this;
		OpenCloseConverter = boolToObjectConverter;
		TitleViewBehavior = a11YBehavior;
		TitleView = horizontalStackLayout;
		_titleButton = accordionButton;
		ChevronImage = image;
		ContentView = contentView;
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		boolToObjectConverter.FalseObject = alg_FaqAnswerHidden;
		boolToObjectConverter.TrueObject = alg_FaqAnswerShown;
		ICommunityToolkitValueConverter communityToolkitValueConverter = ((IMarkupExtension<ICommunityToolkitValueConverter>)boolToObjectConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 15, 10);
		}
		Resources["OpenCloseConverter"] = communityToolkitValueConverter;
		verticalStackLayout.SetValue(View.MarginProperty, new Thickness(0.0, 0.0, 0.0, 2.0));
		verticalStackLayout.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		verticalStackLayout.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 0.0);
		border.SetValue(View.MarginProperty, new Thickness(1.0));
		border.Focused += BorderFocusChanged;
		border.SetValue(Border.StrokeProperty, new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush);
		border.SetValue(Border.StrokeThicknessProperty, 2.0);
		border.Unfocused += BorderFocusChanged;
		referenceExtension.Name = "AccordionItem";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 25);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "TitleTappedCommand";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 42, 25);
		}
		a11YBehavior.SetBinding(A11YBehavior.CommandProperty, binding);
		referenceExtension2.Name = "AccordionItem";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 25);
		}
		bindingExtension2.Source = this;
		bindingExtension2.Path = "Title";
		Binding binding2 = new Binding(bindingExtension2.Path, bindingExtension2.Mode, bindingExtension2.Converter, bindingExtension2.ConverterParameter, bindingExtension2.StringFormat, bindingExtension2.Source)
		{
			UpdateSourceEventName = bindingExtension2.UpdateSourceEventName,
			FallbackValue = bindingExtension2.FallbackValue,
			TargetNullValue = bindingExtension2.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 43, 25);
		}
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, binding2);
		a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
		referenceExtension3.Name = "AccordionItem";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		}
		bindingExtension3.Source = this;
		bindingExtension3.Path = "IsOpen";
		staticResourceExtension.Key = "OpenCloseConverter";
		ICommunityToolkitValueConverter communityToolkitValueConverter2 = communityToolkitValueConverter;
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		}
		bindingExtension3.Converter = communityToolkitValueConverter2;
		Binding binding3 = new Binding(bindingExtension3.Path, bindingExtension3.Mode, bindingExtension3.Converter, bindingExtension3.ConverterParameter, bindingExtension3.StringFormat, bindingExtension3.Source)
		{
			UpdateSourceEventName = bindingExtension3.UpdateSourceEventName,
			FallbackValue = bindingExtension3.FallbackValue,
			TargetNullValue = bindingExtension3.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding3, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 45, 25);
		}
		a11YBehavior.SetBinding(A11YBehavior.StateDescriptionProperty, binding3);
		((IList<Behavior>)border.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
		tapGestureRecognizer.Tapped += TitleTapped;
		border.GestureRecognizers.Add(tapGestureRecognizer);
		horizontalStackLayout.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(6.0));
		horizontalStackLayout.SetValue(Microsoft.Maui.Controls.Layout.IsClippedToBoundsProperty, true);
		bindingExtension4.Path = "AccessibilityId";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 59, 25);
		}
		accordionButton.SetBinding(Element.AutomationIdProperty, bindingBase);
		accordionButton.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		accordionButton.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		onPlatformExtension.Default = "False";
		onPlatformExtension.WinUI = "True";
		onPlatformExtension.Android = "True";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[5] { accordionButton, horizontalStackLayout, border, verticalStackLayout, this }, VisualElement.IsEnabledProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(62, 25)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 62, 25);
		}
		accordionButton.SetValue(VisualElement.IsEnabledProperty, obj);
		staticResourceExtension2.Key = "ButtonAsLabelStyle";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { accordionButton, horizontalStackLayout, border, verticalStackLayout, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(65, 25)));
		object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 65, 25);
		}
		accordionButton.SetValue(VisualElement.StyleProperty, obj2);
		accordionButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		accordionButton.SetValue(VisualElement.WidthRequestProperty, maxButtonWidth);
		onPlatformExtension2.Default = "10";
		onPlatformExtension2.Android = "0";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { accordionButton, horizontalStackLayout, border, verticalStackLayout, this }, VisualElement.ZIndexProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(68, 25)));
		object obj3 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("Controls\\Accordion.xaml;assembly=DigiD.Mobile", UriKind.Relative), 68, 25);
		}
		accordionButton.SetValue(VisualElement.ZIndexProperty, obj3);
		horizontalStackLayout.Children.Add(accordionButton);
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		image.SetValue(VisualElement.HeightRequestProperty, 20.0);
		image.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		((IDynamicResourceHandler)image).SetDynamicResource(Image.SourceProperty, dynamicResource.Key);
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		image.SetValue(VisualElement.WidthRequestProperty, 20.0);
		horizontalStackLayout.Children.Add(image);
		border.SetValue(Border.ContentProperty, horizontalStackLayout);
		verticalStackLayout.Children.Add(border);
		contentView.SetValue(View.MarginProperty, new Thickness(17.5));
		contentView.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		contentView.SetValue(VisualElement.IsVisibleProperty, (bool)new VisibilityConverter().ConvertFromInvariantString("False"));
		contentView.SetValue(View.VerticalOptionsProperty, LayoutOptions.Fill);
		verticalStackLayout.Children.Add(contentView);
		SetValue(ContentView.ContentProperty, verticalStackLayout);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<AccordionItem, string> setter = null;
			return new TypedBinding<AccordionItem, string>((AccordionItem source) => (value: source.AccessibilityId, success: true), setter, new Tuple<Func<AccordionItem, object>, string>[1]
			{
				new Tuple<Func<AccordionItem, object>, string>((AccordionItem source) => source, "AccessibilityId")
			});
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
	[MemberNotNull("AccordionItem")]
	[MemberNotNull("OpenCloseConverter")]
	[MemberNotNull("TitleViewBehavior")]
	[MemberNotNull("TitleView")]
	[MemberNotNull("_titleButton")]
	[MemberNotNull("ChevronImage")]
	[MemberNotNull("ContentView")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(Accordion));
		AccordionItem = this.FindByName<ContentView>("AccordionItem");
		OpenCloseConverter = this.FindByName<BoolToObjectConverter>("OpenCloseConverter");
		TitleViewBehavior = this.FindByName<A11YBehavior>("TitleViewBehavior");
		TitleView = this.FindByName<HorizontalStackLayout>("TitleView");
		_titleButton = this.FindByName<AccordionButton>("_titleButton");
		ChevronImage = this.FindByName<Image>("ChevronImage");
		ContentView = this.FindByName<ContentView>("ContentView");
	}
}
