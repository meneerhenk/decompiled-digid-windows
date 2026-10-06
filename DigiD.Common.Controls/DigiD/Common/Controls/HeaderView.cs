using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Controls;

[XamlFilePath("HeaderView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class HeaderView : ContentView
{
	public static readonly BindableProperty BackButtonCommandProperty = BindableProperty.Create("BackButtonCommand", typeof(IAsyncRelayCommand), typeof(HeaderView));

	public static readonly BindableProperty MenuCommandProperty = BindableProperty.Create("MenuCommand", typeof(IAsyncRelayCommand), typeof(HeaderView));

	public static readonly BindableProperty LogoCommandProperty = BindableProperty.Create("LogoCommand", typeof(IAsyncRelayCommand), typeof(HeaderView));

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ImageButton MenuButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private A11YBehavior MenuButtonBehavior;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ImageButton ImgBackButton;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private LogoImageButton ImgLogo;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ImageButton ImgCloseButton;

	public IAsyncRelayCommand? BackButtonCommand
	{
		get
		{
			return (IAsyncRelayCommand)GetValue(BackButtonCommandProperty);
		}
		set
		{
			SetValue(BackButtonCommandProperty, value);
		}
	}

	public IAsyncRelayCommand? MenuCommand
	{
		get
		{
			return (IAsyncRelayCommand)GetValue(MenuCommandProperty);
		}
		set
		{
			SetValue(MenuCommandProperty, value);
		}
	}

	public IAsyncRelayCommand? LogoCommand
	{
		get
		{
			return (IAsyncRelayCommand)GetValue(LogoCommandProperty);
		}
		set
		{
			SetValue(LogoCommandProperty, value);
		}
	}

	public HeaderView(bool insideScroll)
	{
		InitializeComponent();
		SetImageSource();
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, delegate
		{
			SetImageSource();
		});
		string text = (insideScroll ? "Parent.BindingContext" : "BindingContext");
		ImgLogo.SetBinding(VisualElement.IsVisibleProperty, new Binding(text + ".IsHeaderLogoVisible", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		MenuButton.SetBinding(VisualElement.IsVisibleProperty, new Binding(text + ".IsMenuImageVisible", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		ImgBackButton.SetBinding(VisualElement.IsVisibleProperty, new Binding(text + ".HasBackButton", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		ImgCloseButton.SetBinding(VisualElement.IsVisibleProperty, new Binding(text + ".CloseButtonVisible", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		ImgCloseButton.SetBinding(ImageButton.CommandProperty, new Binding(text + ".CloseButtonClickCommand", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		SetBinding(LogoCommandProperty, new Binding(text + ".HeaderLogoClickedCommand", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		SetBinding(MenuCommandProperty, new Binding(text + ".ShowMenuCommand", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
		SetBinding(BackButtonCommandProperty, new Binding(text + ".BackButtonPressedCommand", BindingMode.Default, null, null, null, RelativeBindingSource.TemplatedParent));
	}

	private void SetImageSource()
	{
		MainThread.BeginInvokeOnMainThread(delegate
		{
			try
			{
				MenuButton.Source = (ImageSource)Application.Current.Resources["MenuIconSmall"];
			}
			catch (Exception)
			{
			}
		});
	}

	private async void MenuButtonClicked(object? sender, EventArgs e)
	{
		if (MenuCommand?.CanExecute(null) ?? false)
		{
			await MenuCommand.ExecuteAsync(null);
		}
	}

	private async void ImgLogo_Clicked(object? sender, EventArgs e)
	{
		if (LogoCommand?.CanExecute(null) ?? false)
		{
			await LogoCommand.ExecuteAsync(null);
		}
	}

	private async void ImgBackButton_OnClicked(object? sender, EventArgs e)
	{
		if (BackButtonCommand?.CanExecute(null) ?? false)
		{
			await BackButtonCommand.ExecuteAsync(null);
		}
	}

	private void HeaderView_OnLoaded(object? sender, EventArgs e)
	{
		if (sender is HeaderView headerView)
		{
			if (headerView.MenuButton.IsVisible)
			{
				SetFocus(headerView.MenuButton);
			}
			else if (headerView.ImgBackButton.IsVisible)
			{
				SetFocus(headerView.ImgBackButton);
			}
			else if (headerView.ImgCloseButton.IsVisible)
			{
				SetFocus(headerView.ImgCloseButton);
			}
		}
	}

	private static void SetFocus(ImageButton headerButton)
	{
		headerButton.Focus();
		headerButton.SetSemanticFocus();
		AppSession.ServiceProvider.GetRequiredService<IA11YService>().NotifyForNewPage(headerButton);
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("MenuButton")]
	[MemberNotNull("MenuButtonBehavior")]
	[MemberNotNull("ImgBackButton")]
	[MemberNotNull("ImgLogo")]
	[MemberNotNull("ImgCloseButton")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(HeaderView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(HeaderView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		DynamicResource dynamicResource = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 5);
		DynamicResource dynamicResource2 = new DynamicResource("DisabledButtonBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 86, 67);
		Setter setter = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 86, 38);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 84, 30);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 90, 30);
		DynamicResource dynamicResource3 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 99, 68);
		Setter setter2 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 99, 38);
		VisualState visualState3 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 96, 30);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 83, 26);
		VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 22);
		Setter setter3 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 81, 18);
		Style style = new Style(typeof(ImageButton));
		VisualDiagnostics.RegisterSourceInfo(style, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 14);
		ResourceDictionary resourceDictionary = new ResourceDictionary();
		VisualDiagnostics.RegisterSourceInfo(resourceDictionary, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 74, 10);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 26);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 13);
		DynamicResource dynamicResource4 = new DynamicResource("MenuButtonStyle");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource4, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 13);
		TranslateExtension translateExtension = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 21);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 18);
		ImageButton imageButton = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 10);
		OnPlatformExtension onPlatformExtension3 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 13);
		DynamicResource dynamicResource5 = new DynamicResource("ImageButtonBack");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource5, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 13);
		TranslateExtension translateExtension2 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 41);
		A11YBehavior a11YBehavior2 = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 18);
		ImageButton imageButton2 = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 10);
		LogoImageButton logoImageButton = new LogoImageButton();
		VisualDiagnostics.RegisterSourceInfo(logoImageButton, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 10);
		OnPlatformExtension onPlatformExtension4 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension4, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 13);
		DynamicResource dynamicResource6 = new DynamicResource("ImageButtonSluiten");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource6, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 13);
		TranslateExtension translateExtension3 = new TranslateExtension();
		VisualDiagnostics.RegisterSourceInfo(translateExtension3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 41);
		A11YBehavior a11YBehavior3 = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 18);
		ImageButton imageButton3 = new ImageButton();
		VisualDiagnostics.RegisterSourceInfo(imageButton3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 10);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		INameScope nameScope2 = new NameScope();
		INameScope nameScope3 = new NameScope();
		INameScope nameScope4 = new NameScope();
		INameScope nameScope5 = new NameScope();
		INameScope nameScope6 = new NameScope();
		INameScope nameScope7 = new NameScope();
		INameScope nameScope8 = new NameScope();
		nameScope8.RegisterName("ButtonState", visualStateGroup);
		nameScope8.RegisterName("Disabled", visualState);
		nameScope8.RegisterName("Normal", visualState2);
		nameScope8.RegisterName("Focused", visualState3);
		grid.transientNamescope = nameScope;
		imageButton.transientNamescope = nameScope;
		nameScope.RegisterName("MenuButton", imageButton);
		ImageButton imageButton4 = imageButton;
		if (imageButton4.StyleId == null)
		{
			string text = (imageButton4.StyleId = "MenuButton");
		}
		nameScope.RegisterName("MenuButtonBehavior", a11YBehavior);
		imageButton2.transientNamescope = nameScope;
		nameScope.RegisterName("ImgBackButton", imageButton2);
		imageButton4 = imageButton2;
		if (imageButton4.StyleId == null)
		{
			string text = (imageButton4.StyleId = "ImgBackButton");
		}
		logoImageButton.transientNamescope = nameScope;
		nameScope.RegisterName("ImgLogo", logoImageButton);
		LogoImageButton logoImageButton2 = logoImageButton;
		if (logoImageButton2.StyleId == null)
		{
			string text = (logoImageButton2.StyleId = "ImgLogo");
		}
		imageButton3.transientNamescope = nameScope;
		nameScope.RegisterName("ImgCloseButton", imageButton3);
		imageButton4 = imageButton3;
		if (imageButton4.StyleId == null)
		{
			string text = (imageButton4.StyleId = "ImgCloseButton");
		}
		MenuButton = imageButton;
		MenuButtonBehavior = a11YBehavior;
		ImgBackButton = imageButton2;
		ImgLogo = logoImageButton;
		ImgCloseButton = imageButton3;
		Resources = resourceDictionary;
		Setter setter4 = new Setter
		{
			Property = VisualElement.BackgroundColorProperty,
			Value = Colors.Transparent
		};
		if (VisualDiagnostics.GetSourceInfo(setter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 18);
		}
		style.Setters.Add(setter4);
		Setter setter5 = new Setter
		{
			Property = ImageButton.BorderWidthProperty,
			Value = 0.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 18);
		}
		style.Setters.Add(setter5);
		Setter setter6 = new Setter
		{
			Property = ImageButton.BorderColorProperty,
			Value = Colors.Transparent
		};
		if (VisualDiagnostics.GetSourceInfo(setter6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 78, 18);
		}
		style.Setters.Add(setter6);
		Setter setter7 = new Setter
		{
			Property = View.HorizontalOptionsProperty,
			Value = LayoutOptions.Start
		};
		if (VisualDiagnostics.GetSourceInfo(setter7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter7, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 79, 18);
		}
		style.Setters.Add(setter7);
		Setter setter8 = new Setter
		{
			Property = ImageButton.SourceProperty,
			Value = ImageSource.FromFile("digid_icon_menu_smallsize")
		};
		if (VisualDiagnostics.GetSourceInfo(setter8) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter8, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 80, 18);
		}
		style.Setters.Add(setter8);
		setter3.Property = VisualStateManager.VisualStateGroupsProperty;
		visualStateGroup.Name = "ButtonState";
		visualState.Name = "Disabled";
		setter.Property = VisualElement.BackgroundProperty;
		setter.Value = dynamicResource2;
		Setter setter9 = new Setter
		{
			Property = VisualElement.BackgroundProperty,
			Value = dynamicResource2
		};
		if (VisualDiagnostics.GetSourceInfo(setter9) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter9, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 86, 38);
		}
		IList<Setter> setters = visualState.Setters;
		setters.Add(setter9);
		Setter setter10 = new Setter
		{
			Property = ImageButton.BorderWidthProperty,
			Value = 0.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter10) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter10, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 87, 38);
		}
		setters.Add(setter10);
		visualStateGroup.States.Add(visualState);
		visualState2.Name = "Normal";
		Setter setter11 = new Setter();
		setter11.Property = VisualElement.BackgroundProperty;
		setter11.Value = new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush;
		Setter setter12 = setter11;
		if (VisualDiagnostics.GetSourceInfo(setter12) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter12, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 92, 38);
		}
		IList<Setter> setters2 = visualState2.Setters;
		setters2.Add(setter12);
		Setter setter13 = new Setter
		{
			Property = ImageButton.BorderWidthProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter13) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter13, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 93, 38);
		}
		setters2.Add(setter13);
		visualStateGroup.States.Add(visualState2);
		visualState3.Name = "Focused";
		setter11 = new Setter();
		setter11.Property = VisualElement.BackgroundProperty;
		setter11.Value = new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush;
		Setter setter14 = setter11;
		if (VisualDiagnostics.GetSourceInfo(setter14) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter14, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 98, 38);
		}
		IList<Setter> setters3 = visualState3.Setters;
		setters3.Add(setter14);
		setter2.Property = ImageButton.BorderColorProperty;
		setter2.Value = dynamicResource3;
		Setter setter15 = new Setter
		{
			Property = ImageButton.BorderColorProperty,
			Value = dynamicResource3
		};
		if (VisualDiagnostics.GetSourceInfo(setter15) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter15, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 99, 38);
		}
		setters3.Add(setter15);
		Setter setter16 = new Setter
		{
			Property = ImageButton.BorderWidthProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter16) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter16, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 100, 38);
		}
		setters3.Add(setter16);
		visualStateGroup.States.Add(visualState3);
		visualStateGroupList.Add(visualStateGroup);
		setter3.Value = visualStateGroupList;
		Setter setter17 = new Setter
		{
			Property = VisualStateManager.VisualStateGroupsProperty,
			Value = visualStateGroupList
		};
		if (VisualDiagnostics.GetSourceInfo(setter17) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter17, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 81, 18);
		}
		style.Setters.Add(setter17);
		resourceDictionary["MenuButtonStyle"] = style;
		((IDynamicResourceHandler)this).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		SetValue(VisualElement.HeightRequestProperty, 52.0);
		Loaded += HeaderView_OnLoaded;
		Resources = resourceDictionary;
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(10.0, 0.0));
		onPlatformExtension.iOS = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[2] { grid, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(16, 26)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 26);
		}
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		imageButton.SetValue(ImageButton.PaddingProperty, new Thickness(0.0, 0.0, 5.0, 0.0));
		imageButton.SetValue(Element.AutomationIdProperty, "MenuButton");
		onPlatformExtension2.Android = "True";
		onPlatformExtension2.Default = "False";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[3] { imageButton, grid, this }, AutomationProperties.ExcludedWithChildrenProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(21, 13)));
		object obj2 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 13);
		}
		imageButton.SetValue(AutomationProperties.ExcludedWithChildrenProperty, obj2);
		imageButton.Clicked += MenuButtonClicked;
		imageButton.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		((IDynamicResourceHandler)imageButton).SetDynamicResource(VisualElement.StyleProperty, dynamicResource4.Key);
		translateExtension.Text = "Alg_Menu";
		BindingBase bindingBase = ((IMarkupExtension<BindingBase>)translateExtension).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 29, 21);
		}
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, bindingBase);
		a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
		((IList<Behavior>)imageButton.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
		grid.Children.Add(imageButton);
		imageButton2.SetValue(Element.AutomationIdProperty, "BackButton");
		onPlatformExtension3.Android = "True";
		onPlatformExtension3.Default = "False";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[3] { imageButton2, grid, this }, AutomationProperties.ExcludedWithChildrenProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(37, 13)));
		object obj3 = ((IMarkupExtension)onPlatformExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 37, 13);
		}
		imageButton2.SetValue(AutomationProperties.ExcludedWithChildrenProperty, obj3);
		imageButton2.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		imageButton2.Clicked += ImgBackButton_OnClicked;
		imageButton2.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		((IDynamicResourceHandler)imageButton2).SetDynamicResource(ImageButton.SourceProperty, dynamicResource5.Key);
		translateExtension2.Text = "Alg_Back";
		BindingBase bindingBase2 = ((IMarkupExtension<BindingBase>)translateExtension2).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 41);
		}
		a11YBehavior2.SetBinding(A11YBehavior.DescriptionProperty, bindingBase2);
		a11YBehavior2.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
		((IList<Behavior>)imageButton2.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior2);
		grid.Children.Add(imageButton2);
		logoImageButton.SetValue(Element.AutomationIdProperty, "Logo");
		logoImageButton.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
		logoImageButton.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		logoImageButton.Clicked += ImgLogo_Clicked;
		logoImageButton.SetValue(VisualElement.HeightRequestProperty, 40.0);
		logoImageButton.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		logoImageButton.SetValue(SemanticProperties.DescriptionProperty, "Digid logo");
		logoImageButton.SetValue(ImageButton.SourceProperty, ImageSource.FromFile("afbeelding_digid_officiele_app.png"));
		logoImageButton.SetValue(VisualElement.WidthRequestProperty, 40.0);
		grid.Children.Add(logoImageButton);
		imageButton3.SetValue(Element.AutomationIdProperty, "MainCloseButton");
		onPlatformExtension4.Android = "True";
		onPlatformExtension4.Default = "False";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[3] { imageButton3, grid, this }, AutomationProperties.ExcludedWithChildrenProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(63, 13)));
		object obj4 = ((IMarkupExtension)onPlatformExtension4).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 13);
		}
		imageButton3.SetValue(AutomationProperties.ExcludedWithChildrenProperty, obj4);
		imageButton3.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		imageButton3.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
		((IDynamicResourceHandler)imageButton3).SetDynamicResource(ImageButton.SourceProperty, dynamicResource6.Key);
		translateExtension3.Text = "Alg_CloseButton";
		BindingBase bindingBase3 = ((IMarkupExtension<BindingBase>)translateExtension3).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("HeaderView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 41);
		}
		a11YBehavior3.SetBinding(A11YBehavior.DescriptionProperty, bindingBase3);
		a11YBehavior3.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
		((IList<Behavior>)imageButton3.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior3);
		grid.Children.Add(imageButton3);
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
	[MemberNotNull("MenuButton")]
	[MemberNotNull("MenuButtonBehavior")]
	[MemberNotNull("ImgBackButton")]
	[MemberNotNull("ImgLogo")]
	[MemberNotNull("ImgCloseButton")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(HeaderView));
		MenuButton = this.FindByName<ImageButton>("MenuButton");
		MenuButtonBehavior = this.FindByName<A11YBehavior>("MenuButtonBehavior");
		ImgBackButton = this.FindByName<ImageButton>("ImgBackButton");
		ImgLogo = this.FindByName<LogoImageButton>("ImgLogo");
		ImgCloseButton = this.FindByName<ImageButton>("ImgCloseButton");
	}
}
