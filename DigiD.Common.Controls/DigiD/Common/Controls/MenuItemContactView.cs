using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;

namespace DigiD.Common.Controls;

[XamlFilePath("MenuItemContactView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class MenuItemContactView : ContentView
{
	public static readonly BindableProperty ItemCommandProperty = BindableProperty.Create("ItemCommand", typeof(ICommand), typeof(MenuItemContactView), null, BindingMode.OneWay, null, ItemCommandPropertyChanged);

	public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(MenuItemContactView), null, BindingMode.OneWay, null, SemanticDescriptionChanged);

	public static readonly BindableProperty LinkProperty = BindableProperty.Create("Link", typeof(string), typeof(MenuItemContactView), null, BindingMode.OneWay, null, SemanticDescriptionChanged);

	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(MenuItemContactView), null, BindingMode.OneWay, null, SemanticDescriptionChanged);

	public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(ImageSource), typeof(MenuItemContactView));

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private ContentView This;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border MenuItemBorder;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private A11YBehavior ContactViewA11YBehavior;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Label TitleLabel;

	public string? Title
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

	public string? Link
	{
		get
		{
			return (string)GetValue(LinkProperty);
		}
		set
		{
			SetValue(LinkProperty, value);
		}
	}

	public string? Text
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

	public ImageSource? Image
	{
		get
		{
			return (ImageSource)GetValue(ImageProperty);
		}
		set
		{
			SetValue(ImageProperty, value);
		}
	}

	public ICommand? ItemCommand
	{
		get
		{
			return (ICommand)GetValue(ItemCommandProperty);
		}
		set
		{
			SetValue(ItemCommandProperty, value);
		}
	}

	private static void ItemCommandPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		if (bindable is MenuItemContactView menuItemContactView)
		{
			menuItemContactView.ContactViewA11YBehavior.Command = newvalue as ICommand;
		}
	}

	private static void SemanticDescriptionChanged(BindableObject bindable, object oldvalue, object newvalue)
	{
		if (bindable is MenuItemContactView menuItemContactView)
		{
			menuItemContactView.ContactViewA11YBehavior.Description = $"{menuItemContactView.Title} {(string.IsNullOrWhiteSpace(menuItemContactView.Link) ? "" : menuItemContactView.Link)}, {menuItemContactView.Text}";
		}
	}

	public MenuItemContactView()
	{
		InitializeComponent();
	}

	private void ContactViewLoaded(object? sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(Link))
		{
			Grid.SetColumnSpan((BindableObject)TitleLabel, 2);
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("This")]
	[MemberNotNull("MenuItemBorder")]
	[MemberNotNull("ContactViewA11YBehavior")]
	[MemberNotNull("TitleLabel")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(MenuItemContactView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(MenuItemContactView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 17);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 17);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 14);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 22);
		DynamicResource dynamicResource = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 90);
		Setter setter = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 30);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 22);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 68, 18);
		VisualStateGroupList visualStateGroupList = new VisualStateGroupList();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroupList, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 14);
		DynamicResource dynamicResource2 = new DynamicResource("AppPageBackground");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 13);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 17);
		ReferenceExtension referenceExtension2 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 17);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 17);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 17);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 28, 14);
		OnPlatformExtension onPlatformExtension2 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 17);
		ReferenceExtension referenceExtension3 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension3, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 17);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 17);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 17);
		LinkLabel linkLabel = new LinkLabel();
		VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 38, 14);
		ReferenceExtension referenceExtension4 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension4, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 17);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 54, 17);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 48, 14);
		OnPlatformExtension onPlatformExtension3 = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension3, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 17);
		ReferenceExtension referenceExtension5 = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension5, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 17);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 17);
		Label label2 = new Label();
		VisualDiagnostics.RegisterSourceInfo(label2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 14);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 10);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("This", this);
		if (StyleId == null)
		{
			string text = (StyleId = "This");
		}
		border.transientNamescope = nameScope;
		nameScope.RegisterName("MenuItemBorder", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "MenuItemBorder");
		}
		nameScope.RegisterName("ContactViewA11YBehavior", a11YBehavior);
		INameScope nameScope2 = new NameScope();
		grid.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		nameScope.RegisterName("TitleLabel", label);
		Label label3 = label;
		if (label3.StyleId == null)
		{
			string text = (label3.StyleId = "TitleLabel");
		}
		linkLabel.transientNamescope = nameScope;
		image.transientNamescope = nameScope;
		label2.transientNamescope = nameScope;
		This = this;
		MenuItemBorder = border;
		ContactViewA11YBehavior = a11YBehavior;
		TitleLabel = label;
		referenceExtension.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 17);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "ItemCommand";
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 17);
		}
		a11YBehavior.SetBinding(A11YBehavior.CommandProperty, binding);
		a11YBehavior.SetValue(A11YBehavior.RoleProperty, A11YRole.Button);
		((IList<Behavior>)border.GetValue(VisualElement.BehaviorsProperty)).Add(a11YBehavior);
		visualStateGroup.Name = "CommonStates";
		visualState.Name = "Normal";
		Setter setter2 = new Setter();
		setter2.TargetName = "MenuItemBorder";
		setter2.Property = Border.StrokeProperty;
		setter2.Value = new BrushTypeConverter().ConvertFromInvariantString("Transparent") as Brush;
		Setter setter3 = setter2;
		if (VisualDiagnostics.GetSourceInfo(setter3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 71, 30);
		}
		IList<Setter> setters = visualState.Setters;
		setters.Add(setter3);
		Setter setter4 = new Setter
		{
			TargetName = "MenuItemBorder",
			Property = Border.StrokeThicknessProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 30);
		}
		setters.Add(setter4);
		visualStateGroup.States.Add(visualState);
		visualState2.Name = "Focused";
		setter.TargetName = "MenuItemBorder";
		setter.Property = Border.StrokeProperty;
		setter.Value = dynamicResource;
		Setter setter5 = new Setter
		{
			TargetName = "MenuItemBorder",
			Property = Border.StrokeProperty,
			Value = dynamicResource
		};
		if (VisualDiagnostics.GetSourceInfo(setter5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 30);
		}
		IList<Setter> setters2 = visualState2.Setters;
		setters2.Add(setter5);
		Setter setter6 = new Setter
		{
			TargetName = "MenuItemBorder",
			Property = Border.StrokeThicknessProperty,
			Value = 2.0
		};
		if (VisualDiagnostics.GetSourceInfo(setter6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 78, 30);
		}
		setters2.Add(setter6);
		visualStateGroup.States.Add(visualState2);
		visualStateGroupList.Add(visualStateGroup);
		border.SetValue(VisualStateManager.VisualStateGroupsProperty, visualStateGroupList);
		grid.SetValue(AutomationProperties.ExcludedWithChildrenProperty, false);
		grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		((IDynamicResourceHandler)grid).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource2.Key);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Auto), new ColumnDefinition(GridLength.Star), new ColumnDefinition(new GridLength(48.0, GridUnitType.Absolute))));
		grid.SetValue(Grid.ColumnSpacingProperty, 2.0);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star), new RowDefinition(GridLength.Auto)));
		grid.Loaded += ContactViewLoaded;
		label.SetValue(Grid.RowProperty, 0);
		label.SetValue(Grid.ColumnProperty, 0);
		onPlatformExtension.Android = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[4] { label, grid, border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 17)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 17);
		}
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		referenceExtension2.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 17);
		}
		label.SetValue(BindableObject.BindingContextProperty, this);
		staticResourceExtension.Key = "LabelBold";
		XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[4] { label, grid, border, this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
		xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
		xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(34, 17)));
		object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
		if (VisualDiagnostics.GetSourceInfo(obj2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 17);
		}
		label.SetValue(VisualElement.StyleProperty, obj2);
		bindingExtension2.Path = "Title";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 35, 17);
		}
		label.SetBinding(Label.TextProperty, bindingBase);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
		grid.Children.Add(label);
		linkLabel.SetValue(Grid.RowProperty, 0);
		linkLabel.SetValue(Grid.ColumnProperty, 1);
		onPlatformExtension2.Android = "False";
		XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[4] { linkLabel, grid, border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
		xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
		xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(41, 17)));
		object obj3 = ((IMarkupExtension)onPlatformExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
		if (VisualDiagnostics.GetSourceInfo(obj3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 41, 17);
		}
		linkLabel.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj3);
		referenceExtension3.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 17);
		}
		linkLabel.SetValue(BindableObject.BindingContextProperty, this);
		bindingExtension3.Path = "ItemCommand";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 17);
		}
		linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase2);
		linkLabel.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
		bindingExtension4.Path = "Link";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 17);
		}
		linkLabel.SetBinding(LinkLabel.TextProperty, bindingBase3);
		linkLabel.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(linkLabel);
		image.SetValue(Grid.RowProperty, 0);
		image.SetValue(Grid.RowSpanProperty, 2);
		image.SetValue(Grid.ColumnProperty, 2);
		image.SetValue(View.MarginProperty, new Thickness(0.0, 12.0, 0.0, 0.0));
		referenceExtension4.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 17);
		}
		image.SetValue(BindableObject.BindingContextProperty, this);
		bindingExtension5.Path = "Image";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 54, 17);
		}
		image.SetBinding(Microsoft.Maui.Controls.Image.SourceProperty, bindingBase4);
		image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
		grid.Children.Add(image);
		label2.SetValue(Grid.RowProperty, 1);
		label2.SetValue(Grid.ColumnProperty, 0);
		label2.SetValue(Grid.ColumnSpanProperty, 2);
		onPlatformExtension3.Android = "False";
		XamlServiceProvider xamlServiceProvider4 = new XamlServiceProvider(this);
		SimpleValueTargetProvider service4 = new SimpleValueTargetProvider(new object[4] { label2, grid, border, this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider4.Add(typeof(IReferenceProvider), service4);
		xamlServiceProvider4.Add(typeof(IProvideValueTarget), service4);
		xamlServiceProvider4.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(61, 17)));
		object obj4 = ((IMarkupExtension)onPlatformExtension3).ProvideValue((IServiceProvider)xamlServiceProvider4);
		if (VisualDiagnostics.GetSourceInfo(obj4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj4, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 17);
		}
		label2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj4);
		referenceExtension5.Name = "This";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 17);
		}
		label2.SetValue(BindableObject.BindingContextProperty, this);
		bindingExtension6.Path = "Text";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("MenuItemContactView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 17);
		}
		label2.SetBinding(Label.TextProperty, bindingBase5);
		grid.Children.Add(label2);
		border.SetValue(Border.ContentProperty, grid);
		SetValue(ContentView.ContentProperty, border);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<MenuItemContactView, string> setter7 = delegate(MenuItemContactView source, string? value)
			{
				source.Title = value;
			};
			return new TypedBinding<MenuItemContactView, string>((MenuItemContactView source) => (value: source.Title, success: true), setter7, new Tuple<Func<MenuItemContactView, object>, string>[1]
			{
				new Tuple<Func<MenuItemContactView, object>, string>((MenuItemContactView source) => source, "Title")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<MenuItemContactView, ICommand> setter7 = delegate(MenuItemContactView source, ICommand? value)
			{
				source.ItemCommand = value;
			};
			return new TypedBinding<MenuItemContactView, ICommand>((MenuItemContactView source) => (value: source.ItemCommand, success: true), setter7, new Tuple<Func<MenuItemContactView, object>, string>[1]
			{
				new Tuple<Func<MenuItemContactView, object>, string>((MenuItemContactView source) => source, "ItemCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<MenuItemContactView, string> setter7 = delegate(MenuItemContactView source, string? value)
			{
				source.Link = value;
			};
			return new TypedBinding<MenuItemContactView, string>((MenuItemContactView source) => (value: source.Link, success: true), setter7, new Tuple<Func<MenuItemContactView, object>, string>[1]
			{
				new Tuple<Func<MenuItemContactView, object>, string>((MenuItemContactView source) => source, "Link")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<MenuItemContactView, ImageSource> setter7 = delegate(MenuItemContactView source, ImageSource? value)
			{
				source.Image = value;
			};
			return new TypedBinding<MenuItemContactView, ImageSource>((MenuItemContactView source) => (value: source.Image, success: true), setter7, new Tuple<Func<MenuItemContactView, object>, string>[1]
			{
				new Tuple<Func<MenuItemContactView, object>, string>((MenuItemContactView source) => source, "Image")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<MenuItemContactView, string> setter7 = delegate(MenuItemContactView source, string? value)
			{
				source.Text = value;
			};
			return new TypedBinding<MenuItemContactView, string>((MenuItemContactView source) => (value: source.Text, success: true), setter7, new Tuple<Func<MenuItemContactView, object>, string>[1]
			{
				new Tuple<Func<MenuItemContactView, object>, string>((MenuItemContactView source) => source, "Text")
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
	[MemberNotNull("This")]
	[MemberNotNull("MenuItemBorder")]
	[MemberNotNull("ContactViewA11YBehavior")]
	[MemberNotNull("TitleLabel")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(MenuItemContactView));
		This = this.FindByName<ContentView>("This");
		MenuItemBorder = this.FindByName<Border>("MenuItemBorder");
		ContactViewA11YBehavior = this.FindByName<A11YBehavior>("ContactViewA11YBehavior");
		TitleLabel = this.FindByName<Label>("TitleLabel");
	}
}
