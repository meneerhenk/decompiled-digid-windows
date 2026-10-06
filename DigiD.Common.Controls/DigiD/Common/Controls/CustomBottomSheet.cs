using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Plugin.BottomSheet;
using Plugin.Maui.BottomSheet;

namespace DigiD.Common.Controls;

[XamlFilePath("CustomBottomSheet.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class CustomBottomSheet : BottomSheet
{
	private ImageButton? closeButton;

	public CustomBottomSheet(BottomSheetViewModel viewModel)
	{
		InitializeComponent();
		base.BindingContext = viewModel;
		base.IsCancelable = !viewModel.IsInA11YMode;
		base.IsModal = true;
		base.HasHandle = !viewModel.IsInA11YMode;
		base.Opened += CustomBottomSheet_Opened;
	}

	private void CustomBottomSheet_Opened(object? sender, EventArgs e)
	{
		if (base.BindingContext is BottomSheetViewModel bottomSheetViewModel)
		{
			bottomSheetViewModel.Opened(closeButton);
		}
	}

	private void Element_OnChildAdded(object? sender, ElementEventArgs e)
	{
		Element element = e.Element;
		if (element is ImageButton imageButton && element.StyleId == "CloseButton")
		{
			closeButton = imageButton;
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(CustomBottomSheet).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(CustomBottomSheet)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		DynamicResource dynamicResource = new DynamicResource("BackgroundColor");
		VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 5);
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 17, 18);
		BottomSheetContent bottomSheetContent = new BottomSheetContent();
		VisualDiagnostics.RegisterSourceInfo(bottomSheetContent, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 15, 10);
		CustomBottomSheet __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 1, 2);
		INameScope iNameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, iNameScope);
		__root.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		((IDynamicResourceHandler)__root).SetDynamicResource(VisualElement.BackgroundColorProperty, dynamicResource.Key);
		__root.SetValue(BottomSheet.CornerRadiusProperty, 16f);
		onPlatformExtension.Default = "True";
		onPlatformExtension.MacCatalyst = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(__root);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { __root }, BottomSheet.HasHandleProperty, new INameScope[1] { iNameScope }, __root);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(11, 5)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 5);
		}
		__root.SetValue(BottomSheet.HasHandleProperty, obj);
		__root.SetValue(BottomSheet.IsModalProperty, true);
		__root.SetValue(BottomSheet.SizeModeProperty, BottomSheetSizeMode.FitToContent);
		dataTemplate.LoadTemplate = delegate
		{
			DynamicResource dynamicResource2 = new DynamicResource("LabelHeader");
			VisualDiagnostics.RegisterSourceInfo(dynamicResource2, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 31, 37);
			BindingExtension bindingExtension = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 37);
			Label label = new Label();
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 27, 30);
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 40, 37);
			string alg_Close = CommonResources.Alg_Close;
			VisualDiagnostics.RegisterSourceInfo(alg_Close, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 37);
			DynamicResource dynamicResource3 = new DynamicResource("BottomSheetCloseIcon");
			VisualDiagnostics.RegisterSourceInfo(dynamicResource3, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 44, 37);
			ImageButton imageButton = new ImageButton();
			VisualDiagnostics.RegisterSourceInfo(imageButton, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 34, 30);
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 89);
			BottomSheetLabel bottomSheetLabel = new BottomSheetLabel();
			VisualDiagnostics.RegisterSourceInfo(bottomSheetLabel, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 30);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 33);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 33);
			BindingExtension bindingExtension5 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 41);
			BindingExtension bindingExtension6 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 41);
			BindingExtension bindingExtension7 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 41);
			BorderedButton borderedButton = new BorderedButton();
			VisualDiagnostics.RegisterSourceInfo(borderedButton, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 34);
			BindingExtension bindingExtension8 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 41);
			StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 41);
			BindingExtension bindingExtension9 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 41);
			BindingExtension bindingExtension10 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 41);
			LinkLabel linkLabel = new LinkLabel();
			VisualDiagnostics.RegisterSourceInfo(linkLabel, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 63, 34);
			VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
			VisualDiagnostics.RegisterSourceInfo(verticalStackLayout, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 30);
			Grid grid = new Grid();
			VisualDiagnostics.RegisterSourceInfo(grid, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 21, 26);
			ScrollView scrollView = new ScrollView();
			VisualDiagnostics.RegisterSourceInfo(scrollView, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 19, 22);
			ContentView contentView = new ContentView();
			VisualDiagnostics.RegisterSourceInfo(contentView, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 22);
			INameScope nameScope = new NameScope();
			NameScope.SetNameScope(contentView, nameScope);
			scrollView.transientNamescope = nameScope;
			grid.transientNamescope = nameScope;
			label.transientNamescope = nameScope;
			imageButton.transientNamescope = nameScope;
			nameScope.RegisterName("CloseButton", imageButton);
			ImageButton imageButton2 = imageButton;
			if (imageButton2.StyleId == null)
			{
				string text = (imageButton2.StyleId = "CloseButton");
			}
			bottomSheetLabel.transientNamescope = nameScope;
			verticalStackLayout.transientNamescope = nameScope;
			borderedButton.transientNamescope = nameScope;
			linkLabel.transientNamescope = nameScope;
			scrollView.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			grid.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(20.0, 0.0, 20.0, 20.0));
			grid.ChildAdded += Element_OnChildAdded;
			grid.SetValue(Grid.ColumnSpacingProperty, 20.0);
			grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto)));
			grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
			grid.SetValue(Grid.RowSpacingProperty, 20.0);
			label.SetValue(Grid.RowProperty, 0);
			label.SetValue(Grid.ColumnProperty, 0);
			label.SetValue(Element.AutomationIdProperty, "PageHeaderID");
			((IDynamicResourceHandler)label).SetDynamicResource(VisualElement.StyleProperty, dynamicResource2.Key);
			bindingExtension.Path = "Title";
			BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
			if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 37);
			}
			label.SetBinding(Label.TextProperty, bindingBase);
			grid.Children.Add(label);
			imageButton.SetValue(Grid.RowProperty, 0);
			imageButton.SetValue(Grid.ColumnProperty, 1);
			imageButton.SetValue(View.MarginProperty, new Microsoft.Maui.Thickness(0.0, 0.0, 0.0, 0.0));
			imageButton.SetValue(ImageButton.PaddingProperty, new Microsoft.Maui.Thickness(10.0, 0.0));
			bindingExtension2.Path = "CloseCommand";
			BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
			if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 40, 37);
			}
			imageButton.SetBinding(ImageButton.CommandProperty, bindingBase2);
			imageButton.SetValue(VisualElement.HeightRequestProperty, 44.0);
			imageButton.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
			imageButton.SetValue(SemanticProperties.DescriptionProperty, alg_Close);
			((IDynamicResourceHandler)imageButton).SetDynamicResource(ImageButton.SourceProperty, dynamicResource3.Key);
			imageButton.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
			imageButton.SetValue(VisualElement.WidthRequestProperty, 44.0);
			grid.Children.Add(imageButton);
			bottomSheetLabel.SetValue(Grid.RowProperty, 1);
			bottomSheetLabel.SetValue(Grid.ColumnSpanProperty, 2);
			bindingExtension3.Path = "Message";
			BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 51, 89);
			}
			bottomSheetLabel.SetBinding(Label.TextProperty, bindingBase3);
			grid.Children.Add(bottomSheetLabel);
			verticalStackLayout.SetValue(Grid.RowProperty, 2);
			verticalStackLayout.SetValue(Grid.ColumnSpanProperty, 2);
			staticResourceExtension.Key = "IsNotNullConverter";
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[8] { bindingExtension4, verticalStackLayout, grid, scrollView, contentView, dataTemplate, bottomSheetContent, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(56, 33)));
			object obj2 = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider2);
			if (VisualDiagnostics.GetSourceInfo(obj2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 33);
			}
			bindingExtension4.Converter = (IValueConverter)obj2;
			bindingExtension4.Path = "ActionText";
			BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 56, 33);
			}
			verticalStackLayout.SetBinding(VisualElement.IsVisibleProperty, bindingBase4);
			borderedButton.SetValue(BorderedButton.ButtonTypeProperty, ButtonType.Primary);
			bindingExtension5.Path = "ActionButtonClickedCommand";
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 59, 41);
			}
			borderedButton.SetBinding(Button.CommandProperty, bindingBase5);
			bindingExtension6.Path = "IsActionButton";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 60, 41);
			}
			borderedButton.SetBinding(VisualElement.IsVisibleProperty, bindingBase6);
			bindingExtension7.Path = "ActionText";
			BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
			if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 41);
			}
			borderedButton.SetBinding(Button.TextProperty, bindingBase7);
			verticalStackLayout.Children.Add(borderedButton);
			bindingExtension8.Path = "ActionButtonClickedCommand";
			BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
			if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 64, 41);
			}
			linkLabel.SetBinding(LinkLabel.CommandProperty, bindingBase8);
			staticResourceExtension2.Key = "BooleanInvertConverter";
			XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[9] { bindingExtension9, linkLabel, verticalStackLayout, grid, scrollView, contentView, dataTemplate, bottomSheetContent, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
			xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
			xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(65, 41)));
			object obj3 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider3);
			if (VisualDiagnostics.GetSourceInfo(obj3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 41);
			}
			bindingExtension9.Converter = (IValueConverter)obj3;
			bindingExtension9.Path = "IsActionButton";
			BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
			if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 41);
			}
			linkLabel.SetBinding(VisualElement.IsVisibleProperty, bindingBase9);
			bindingExtension10.Path = "ActionText";
			BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
			if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("CustomBottomSheet.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 41);
			}
			linkLabel.SetBinding(LinkLabel.TextProperty, bindingBase10);
			verticalStackLayout.Children.Add(linkLabel);
			grid.Children.Add(verticalStackLayout);
			scrollView.Content = grid;
			contentView.SetValue(ContentView.ContentProperty, scrollView);
			return contentView;
		};
		bottomSheetContent.SetValue(BottomSheetContentView.ContentTemplateProperty, dataTemplate);
		__root.SetValue(BottomSheet.ContentProperty, bottomSheetContent);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<BottomSheetViewModel, string> setter = delegate(BottomSheetViewModel source, string? value)
			{
				source.Title = value;
			};
			return new TypedBinding<BottomSheetViewModel, string>((BottomSheetViewModel source) => (value: source.Title, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "Title")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<BottomSheetViewModel, string> setter = delegate(BottomSheetViewModel source, string? value)
			{
				source.ActionText = value;
			};
			return new TypedBinding<BottomSheetViewModel, string>((BottomSheetViewModel source) => (value: source.ActionText, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "ActionText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<BottomSheetViewModel, ICommand> setter = null;
			return new TypedBinding<BottomSheetViewModel, ICommand>((BottomSheetViewModel source) => ((ICommand value, bool success))(value: source.CloseCommand, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "CloseCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<BottomSheetViewModel, string> setter = delegate(BottomSheetViewModel source, string? value)
			{
				source.Message = value;
			};
			return new TypedBinding<BottomSheetViewModel, string>((BottomSheetViewModel source) => (value: source.Message, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "Message")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<BottomSheetViewModel, string> setter = delegate(BottomSheetViewModel source, string? value)
			{
				source.ActionText = value;
			};
			return new TypedBinding<BottomSheetViewModel, string>((BottomSheetViewModel source) => (value: source.ActionText, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "ActionText")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<BottomSheetViewModel, ICommand> setter = null;
			return new TypedBinding<BottomSheetViewModel, ICommand>((BottomSheetViewModel source) => ((ICommand value, bool success))(value: source.ActionButtonClickedCommand, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "ActionButtonClickedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<BottomSheetViewModel, bool?> setter = delegate(BottomSheetViewModel source, bool? value)
			{
				source.IsActionButton = value;
			};
			return new TypedBinding<BottomSheetViewModel, bool?>((BottomSheetViewModel source) => (value: source.IsActionButton, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "IsActionButton")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<BottomSheetViewModel, string> setter = delegate(BottomSheetViewModel source, string? value)
			{
				source.ActionText = value;
			};
			return new TypedBinding<BottomSheetViewModel, string>((BottomSheetViewModel source) => (value: source.ActionText, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "ActionText")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<BottomSheetViewModel, ICommand> setter = null;
			return new TypedBinding<BottomSheetViewModel, ICommand>((BottomSheetViewModel source) => ((ICommand value, bool success))(value: source.ActionButtonClickedCommand, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "ActionButtonClickedCommand")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<BottomSheetViewModel, bool?> setter = delegate(BottomSheetViewModel source, bool? value)
			{
				source.IsActionButton = value;
			};
			return new TypedBinding<BottomSheetViewModel, bool?>((BottomSheetViewModel source) => (value: source.IsActionButton, success: true), setter, new Tuple<Func<BottomSheetViewModel, object>, string>[1]
			{
				new Tuple<Func<BottomSheetViewModel, object>, string>((BottomSheetViewModel source) => source, "IsActionButton")
			})
			{
				Converter = extension.Converter
			};
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(CustomBottomSheet));
	}
}
