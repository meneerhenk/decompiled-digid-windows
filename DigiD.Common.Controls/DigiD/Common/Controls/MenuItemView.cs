using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Maui.Converters;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Controls.Models;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Controls;

[XamlFilePath("MenuItemView.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class MenuItemView : ContentView
{
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private BoolToObjectConverter ExternalLinkConverter;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private A11YBehavior MenuBehavior;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Border Border;

	public MenuItemView()
	{
		InitializeComponent();
	}

	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		if (base.BindingContext is DigiD.Common.Controls.Models.MenuItem menuItem)
		{
			if (menuItem.IsExternalLink)
			{
				MenuBehavior.Role = A11YRole.Link;
				MenuBehavior.StateDescription = CommonResources.Alg_AccessibilityMenuItemLinkText;
			}
			else
			{
				MenuBehavior.Role = A11YRole.Button;
				MenuBehavior.Description = menuItem.Title?.Localized;
				MenuBehavior.StateDescription = null;
			}
			MenuBehavior.Command = menuItem.ItemSelectedCommand;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("ExternalLinkConverter")]
	[MemberNotNull("MenuBehavior")]
	[MemberNotNull("Border")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(MenuItemView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(MenuItemView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		string empty = string.Empty;
		VisualDiagnostics.RegisterSourceInfo(empty, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 13);
		string alg_External = CommonResources.Alg_External;
		VisualDiagnostics.RegisterSourceInfo(alg_External, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 13);
		BoolToObjectConverter boolToObjectConverter = new BoolToObjectConverter();
		VisualDiagnostics.RegisterSourceInfo(boolToObjectConverter, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 10);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 13);
		BindingExtension bindingExtension2 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 13);
		BindingExtension bindingExtension3 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 22);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 30);
		BindingExtension bindingExtension4 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 22);
		MultiBinding multiBinding = new MultiBinding();
		VisualDiagnostics.RegisterSourceInfo(multiBinding, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 24, 18);
		A11YBehavior a11YBehavior = new A11YBehavior();
		VisualDiagnostics.RegisterSourceInfo(a11YBehavior, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 10);
		DynamicResource dynamicResource = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 74);
		Setter setter = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 22);
		VisualState visualState = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 73, 14);
		DynamicResource dynamicResource2 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 74);
		Setter setter2 = new Setter();
		VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 22);
		VisualState visualState2 = new VisualState();
		VisualDiagnostics.RegisterSourceInfo(visualState2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 79, 14);
		VisualStateGroup visualStateGroup = new VisualStateGroup();
		VisualDiagnostics.RegisterSourceInfo(visualStateGroup, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 10);
		DynamicResource dynamicResource3 = new DynamicResource("MenuItemBackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 9);
		DynamicResource dynamicResource4 = new DynamicResource("FocusRectangleColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource4, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 45, 13);
		Border border = new Border();
		VisualDiagnostics.RegisterSourceInfo(border, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 39, 10);
		BindingExtension bindingExtension5 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 13);
		Image image = new Image();
		VisualDiagnostics.RegisterSourceInfo(image, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 47, 10);
		BindingExtension bindingExtension6 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 13);
		DynamicResource dynamicResource5 = new DynamicResource("FontTextColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource5, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 13);
		Label label = new Label();
		VisualDiagnostics.RegisterSourceInfo(label, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 10);
		BindingExtension bindingExtension7 = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 13);
		DynamicResource dynamicResource6 = new DynamicResource("digidIconMenuChevronInterneLink");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource6, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 68, 13);
		Image image2 = new Image();
		VisualDiagnostics.RegisterSourceInfo(image2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 10);
		Grid grid = new Grid();
		VisualDiagnostics.RegisterSourceInfo(grid, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("ExternalLinkConverter", boolToObjectConverter);
		nameScope.RegisterName("MenuBehavior", a11YBehavior);
		INameScope nameScope2 = new NameScope();
		grid.transientNamescope = nameScope;
		border.transientNamescope = nameScope;
		nameScope.RegisterName("Border", border);
		Border border2 = border;
		if (border2.StyleId == null)
		{
			string text = (border2.StyleId = "Border");
		}
		image.transientNamescope = nameScope;
		label.transientNamescope = nameScope;
		image2.transientNamescope = nameScope;
		ExternalLinkConverter = boolToObjectConverter;
		MenuBehavior = a11YBehavior;
		Border = border;
		boolToObjectConverter.FalseObject = empty;
		boolToObjectConverter.TrueObject = alg_External;
		ICommunityToolkitValueConverter communityToolkitValueConverter = ((IMarkupExtension<ICommunityToolkitValueConverter>)boolToObjectConverter).ProvideValue((IServiceProvider)null);
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 10);
		}
		Resources["ExternalLinkConverter"] = communityToolkitValueConverter;
		bindingExtension.Path = "ItemSelectedCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 13);
		}
		a11YBehavior.SetBinding(A11YBehavior.CommandProperty, bindingBase);
		bindingExtension2.Path = "State";
		BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
		if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 13);
		}
		a11YBehavior.SetBinding(A11YBehavior.StateDescriptionProperty, bindingBase2);
		multiBinding.StringFormat = "{0}, {1}";
		bindingExtension3.Path = "Title.Localized";
		BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
		if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 22);
		}
		multiBinding.Bindings.Add(bindingBase3);
		staticResourceExtension.Key = "ExternalLinkConverter";
		ICommunityToolkitValueConverter communityToolkitValueConverter2 = communityToolkitValueConverter;
		if (VisualDiagnostics.GetSourceInfo(communityToolkitValueConverter2) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(communityToolkitValueConverter2, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 30);
		}
		bindingExtension4.Converter = communityToolkitValueConverter2;
		bindingExtension4.Path = "IsExternalLink";
		BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
		if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 26, 22);
		}
		multiBinding.Bindings.Add(bindingBase4);
		a11YBehavior.SetBinding(A11YBehavior.DescriptionProperty, multiBinding);
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
			VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 22);
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
			VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 76, 22);
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
			VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 81, 22);
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
			VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 22);
		}
		setters2.Add(setter6);
		visualStateGroup.States.Add(visualState2);
		((IList<VisualStateGroup>)GetValue(VisualStateManager.VisualStateGroupsProperty)).Add(visualStateGroup);
		grid.SetValue(Microsoft.Maui.Controls.Layout.PaddingProperty, new Thickness(10.0, 0.0, 0.0, 0.0));
		((IDynamicResourceHandler)grid).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource3.Key);
		grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(48.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star), new ColumnDefinition(new GridLength(48.0, GridUnitType.Absolute))));
		grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
		grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Star)));
		border.SetValue(Grid.ColumnSpanProperty, 3);
		border.SetValue(View.MarginProperty, new Thickness(2.0));
		border.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		border.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
		((IDynamicResourceHandler)border).SetDynamicResource(Border.StrokeProperty, dynamicResource4.Key);
		grid.Children.Add(border);
		image.SetValue(Grid.ColumnProperty, 0);
		image.SetValue(View.MarginProperty, new Thickness(10.0, 10.0, 0.0, 10.0));
		image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension5.Path = "IconSource";
		BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
		if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 13);
		}
		image.SetBinding(Image.SourceProperty, bindingBase5);
		grid.Children.Add(image);
		label.SetValue(Grid.ColumnProperty, 1);
		label.SetValue(Label.PaddingProperty, new Thickness(0.0, 4.0, 0.0, 4.0));
		label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		label.SetValue(VisualElement.MinimumHeightRequestProperty, 34.0);
		bindingExtension6.Path = "Title.Localized";
		BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
		if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 58, 13);
		}
		label.SetBinding(Label.TextProperty, bindingBase6);
		((IDynamicResourceHandler)label).SetDynamicResource(Label.TextColorProperty, dynamicResource5.Key);
		label.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
		grid.Children.Add(label);
		image2.SetValue(Grid.ColumnProperty, 2);
		image2.SetValue(View.MarginProperty, new Thickness(16.0, 0.0));
		image2.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		bindingExtension7.Path = "IsChevronVisible";
		BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
		if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("MenuItemView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 67, 13);
		}
		image2.SetBinding(VisualElement.IsVisibleProperty, bindingBase7);
		((IDynamicResourceHandler)image2).SetDynamicResource(Image.SourceProperty, dynamicResource6.Key);
		grid.Children.Add(image2);
		SetValue(ContentView.ContentProperty, grid);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, ICommand> setter7 = null;
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, ICommand>((DigiD.Common.Controls.Models.MenuItem source) => ((ICommand value, bool success))(value: source.ItemSelectedCommand, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "ItemSelectedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, string> setter7 = delegate(DigiD.Common.Controls.Models.MenuItem source, string? value)
			{
				source.State = value;
			};
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, string>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.State, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "State")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, string> setter7 = null;
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, string>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.Title.Localized, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[2]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "Title"),
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source.Title, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, bool> setter7 = null;
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, bool>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.IsExternalLink, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "IsExternalLink")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, ImageSource> setter7 = delegate(DigiD.Common.Controls.Models.MenuItem source, ImageSource? value)
			{
				source.IconSource = value;
			};
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, ImageSource>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.IconSource, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "IconSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, string> setter7 = null;
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, string>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.Title.Localized, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[2]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "Title"),
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source.Title, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<DigiD.Common.Controls.Models.MenuItem, bool> setter7 = delegate(DigiD.Common.Controls.Models.MenuItem source, bool value)
			{
				source.IsChevronVisible = value;
			};
			return new TypedBinding<DigiD.Common.Controls.Models.MenuItem, bool>((DigiD.Common.Controls.Models.MenuItem source) => (value: source.IsChevronVisible, success: true), setter7, new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>[1]
			{
				new Tuple<Func<DigiD.Common.Controls.Models.MenuItem, object>, string>((DigiD.Common.Controls.Models.MenuItem source) => source, "IsChevronVisible")
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
	[MemberNotNull("ExternalLinkConverter")]
	[MemberNotNull("MenuBehavior")]
	[MemberNotNull("Border")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(MenuItemView));
		ExternalLinkConverter = this.FindByName<BoolToObjectConverter>("ExternalLinkConverter");
		MenuBehavior = this.FindByName<A11YBehavior>("MenuBehavior");
		Border = this.FindByName<Border>("Border");
	}
}
