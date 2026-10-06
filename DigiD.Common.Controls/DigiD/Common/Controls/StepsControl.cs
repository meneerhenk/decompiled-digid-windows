using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("StepsControl.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class StepsControl : StackLayout
{
	public static readonly BindableProperty ItemsProperty = BindableProperty.Create("Items", typeof(IEnumerable<IStepModel>), typeof(StepsControl), null, BindingMode.OneWay, null, ItemsPropertyChanged);

	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(StepsControl), null, BindingMode.OneWay, null, CommandPropertyChanged);

	public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(StepsControl));

	private readonly ILocalizationResourceManager resourceManager;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private StackLayout StepControl;

	public IEnumerable<IStepModel>? Items
	{
		get
		{
			return (IEnumerable<IStepModel>)GetValue(ItemsProperty);
		}
		set
		{
			SetValue(ItemsProperty, value);
		}
	}

	public ICommand? Command
	{
		get
		{
			return (ICommand)GetValue(CommandProperty);
		}
		set
		{
			SetValue(CommandProperty, value);
		}
	}

	public object? CommandParameter
	{
		get
		{
			return GetValue(CommandParameterProperty);
		}
		set
		{
			SetValue(CommandParameterProperty, value);
		}
	}

	private A11YBehavior A11YBehavior { get; }

	private static void ItemsPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (newValue is IEnumerable<IStepModel> value)
		{
			BindableLayout.SetItemsSource(bindable, value);
		}
	}

	private static void CommandPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is StepsControl stepsControl && newValue is ICommand command)
		{
			stepsControl.A11YBehavior.Command = command;
		}
	}

	public StepsControl()
	{
		resourceManager = ((IApp)Application.Current).ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		A11YBehavior = new A11YBehavior();
		InitializeComponent();
	}

	private void Border_HandlerChanged(object? sender, EventArgs e)
	{
		if (sender is Border { BindingContext: IStepModel bindingContext, Handler: not null } border && bindingContext != null && bindingContext.IsActive && !bindingContext.IsCompleted)
		{
			SetButtonA11YProperties(bindingContext);
			border.Behaviors.Add(A11YBehavior);
		}
	}

	private void SetButtonA11YProperties(IStepModel stepModel)
	{
		A11YBehavior.Role = A11YRole.Button;
		A11YBehavior.Description = $"{resourceManager["Alg_Step"]}{stepModel.Index}, {stepModel.Title?.Localized}, {stepModel.Text?.Localized}";
		A11YBehavior.Command = Command;
		A11YBehavior.CommandParameter = CommandParameter;
	}

	private void Title_OnHandlerChanged(object? sender, EventArgs e)
	{
		if (sender is Label { BindingContext: IStepModel bindingContext, Handler: not null } label)
		{
			A11YBehavior a11YBehavior = new A11YBehavior();
			SetProperties(ref a11YBehavior, bindingContext);
			if (a11YBehavior.Role != A11YRole.None)
			{
				label.Behaviors.Add(a11YBehavior);
			}
		}
	}

	private void SetProperties(ref A11YBehavior a11YBehavior, IStepModel stepModel)
	{
		a11YBehavior.Role = A11YRole.Text;
		a11YBehavior.Description = $"{resourceManager["Alg_Step"]}{stepModel.Index}, {stepModel.Title?.Localized}";
		if (stepModel != null && !stepModel.IsActive)
		{
			if (!stepModel.HasSkipped)
			{
				if (stepModel.IsCompleted)
				{
					a11YBehavior.StateDescription = resourceManager["Alg_Executed"];
				}
				else
				{
					a11YBehavior.Role = A11YRole.Header;
				}
			}
			else
			{
				a11YBehavior.StateDescription = resourceManager["Alg_Skipped"];
			}
		}
		else
		{
			a11YBehavior.Role = A11YRole.None;
		}
	}

	private void OnLabelPropertyChanged(object? sender, PropertyChangedEventArgs e)
	{
		if (sender is Label { BindingContext: IStepModel bindingContext } label && e.PropertyName == "Text")
		{
			A11YBehavior a11YBehavior = label.Behaviors.FirstOrDefault((Behavior b) => b is A11YBehavior) as A11YBehavior;
			if (a11YBehavior != null)
			{
				SetProperties(ref a11YBehavior, bindingContext);
			}
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("StepControl")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(StepsControl).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(StepsControl)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		DataTemplate dataTemplate = new DataTemplate();
		VisualDiagnostics.RegisterSourceInfo(dataTemplate, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 11, 10);
		StepsControl __root = this;
		VisualDiagnostics.RegisterSourceInfo(__root, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope iNameScope = NameScope.GetNameScope(__root) ?? new NameScope();
		NameScope.SetNameScope(__root, iNameScope);
		iNameScope.RegisterName("StepControl", __root);
		StepsControl stepsControl = __root;
		if (stepsControl.StyleId == null)
		{
			string text = (stepsControl.StyleId = "StepControl");
		}
		StepControl = __root;
		__root.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
		__root.SetValue(StackBase.SpacingProperty, 0.0);
		dataTemplate.LoadTemplate = delegate
		{
			BindingExtension bindingExtension = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 17);
			BindingExtension bindingExtension2 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 17);
			BindingExtension bindingExtension3 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 25);
			DynamicResource dynamicResource = new DynamicResource("ActiveStepBackgroundColor");
			VisualDiagnostics.RegisterSourceInfo(dynamicResource, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 60);
			Setter setter = new Setter();
			VisualDiagnostics.RegisterSourceInfo(setter, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 26);
			DataTrigger dataTrigger = new DataTrigger(typeof(Border));
			VisualDiagnostics.RegisterSourceInfo(dataTrigger, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 65, 22);
			BindingExtension bindingExtension4 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension4, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 25);
			DataTrigger dataTrigger2 = new DataTrigger(typeof(Border));
			VisualDiagnostics.RegisterSourceInfo(dataTrigger2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 71, 22);
			BindingExtension bindingExtension5 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension5, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 78, 25);
			DataTrigger dataTrigger3 = new DataTrigger(typeof(Border));
			VisualDiagnostics.RegisterSourceInfo(dataTrigger3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 77, 22);
			BindingExtension bindingExtension6 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension6, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 85, 25);
			DataTrigger dataTrigger4 = new DataTrigger(typeof(Border));
			VisualDiagnostics.RegisterSourceInfo(dataTrigger4, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 84, 22);
			StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 25);
			BindingExtension bindingExtension7 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension7, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 25);
			StaticResourceExtension staticResourceExtension2 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 25);
			BindingExtension bindingExtension8 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension8, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 25);
			Label label = new Label();
			VisualDiagnostics.RegisterSourceInfo(label, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 25, 22);
			BindingExtension bindingExtension9 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension9, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 25);
			BindingExtension bindingExtension10 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension10, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 25);
			Image image = new Image();
			VisualDiagnostics.RegisterSourceInfo(image, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 36, 22);
			StaticResourceExtension staticResourceExtension3 = new StaticResourceExtension();
			VisualDiagnostics.RegisterSourceInfo(staticResourceExtension3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 25);
			BindingExtension bindingExtension11 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension11, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 54, 25);
			Label label2 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 47, 22);
			BindingExtension bindingExtension12 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension12, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 25);
			BindingExtension bindingExtension13 = new BindingExtension();
			VisualDiagnostics.RegisterSourceInfo(bindingExtension13, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 25);
			Label label3 = new Label();
			VisualDiagnostics.RegisterSourceInfo(label3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 57, 22);
			Grid grid = new Grid();
			VisualDiagnostics.RegisterSourceInfo(grid, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 18, 18);
			Border border = new Border();
			VisualDiagnostics.RegisterSourceInfo(border, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 12, 14);
			INameScope nameScope = new NameScope();
			NameScope.SetNameScope(border, nameScope);
			grid.transientNamescope = nameScope;
			label.transientNamescope = nameScope;
			image.transientNamescope = nameScope;
			label2.transientNamescope = nameScope;
			nameScope.RegisterName("Title", label2);
			Label label4 = label2;
			if (label4.StyleId == null)
			{
				string text3 = (label4.StyleId = "Title");
			}
			label3.transientNamescope = nameScope;
			nameScope.RegisterName("SubTitle", label3);
			label4 = label3;
			if (label4.StyleId == null)
			{
				string text3 = (label4.StyleId = "SubTitle");
			}
			bindingExtension.StringFormat = "Stap {0}";
			bindingExtension.Path = "Index";
			BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
			if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 13, 17);
			}
			border.SetBinding(Element.AutomationIdProperty, bindingBase);
			bindingExtension2.Path = "IsActive";
			BindingBase bindingBase2 = CreateTypedBindingFrom_bindingExtension2(bindingExtension2);
			if (VisualDiagnostics.GetSourceInfo(bindingBase2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 14, 17);
			}
			border.SetBinding(AutomationProperties.IsInAccessibleTreeProperty, bindingBase2);
			border.SetValue(VisualElement.BackgroundColorProperty, Colors.Transparent);
			border.HandlerChanged += Border_HandlerChanged;
			border.SetValue(Border.StrokeShapeProperty, new StrokeShapeTypeConverter().ConvertFromInvariantString("RoundRectangle 4") as IShape);
			bindingExtension3.Path = "IsActive";
			BindingBase bindingBase3 = CreateTypedBindingFrom_bindingExtension3(bindingExtension3);
			if (VisualDiagnostics.GetSourceInfo(bindingBase3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 66, 25);
			}
			dataTrigger.Binding = bindingBase3;
			dataTrigger.Value = "True";
			setter.Property = VisualElement.BackgroundColorProperty;
			setter.Value = dynamicResource;
			Setter setter2 = new Setter
			{
				Property = VisualElement.BackgroundColorProperty,
				Value = dynamicResource
			};
			if (VisualDiagnostics.GetSourceInfo(setter2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 69, 26);
			}
			dataTrigger.Setters.Add(setter2);
			IList<TriggerBase> list = (IList<TriggerBase>)border.GetValue(VisualElement.TriggersProperty);
			list.Add(dataTrigger);
			bindingExtension4.Path = "IsActive";
			BindingBase bindingBase4 = CreateTypedBindingFrom_bindingExtension4(bindingExtension4);
			if (VisualDiagnostics.GetSourceInfo(bindingBase4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase4, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 72, 25);
			}
			dataTrigger2.Binding = bindingBase4;
			dataTrigger2.Value = "False";
			Setter setter3 = new Setter
			{
				Property = VisualElement.BackgroundColorProperty,
				Value = Colors.Transparent
			};
			if (VisualDiagnostics.GetSourceInfo(setter3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 75, 26);
			}
			dataTrigger2.Setters.Add(setter3);
			list.Add(dataTrigger2);
			bindingExtension5.Path = "IsCompleted";
			BindingBase bindingBase5 = CreateTypedBindingFrom_bindingExtension5(bindingExtension5);
			if (VisualDiagnostics.GetSourceInfo(bindingBase5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase5, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 78, 25);
			}
			dataTrigger3.Binding = bindingBase5;
			dataTrigger3.Value = "True";
			Setter setter4 = new Setter
			{
				Property = View.MarginProperty,
				Value = new Thickness(0.0, 0.0, 0.0, 0.0)
			};
			if (VisualDiagnostics.GetSourceInfo(setter4) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter4, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 81, 26);
			}
			dataTrigger3.Setters.Add(setter4);
			Setter setter5 = new Setter
			{
				Property = Border.PaddingProperty,
				Value = new Thickness(0.0)
			};
			if (VisualDiagnostics.GetSourceInfo(setter5) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter5, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 82, 26);
			}
			dataTrigger3.Setters.Add(setter5);
			list.Add(dataTrigger3);
			bindingExtension6.Path = "IsCompleted";
			BindingBase bindingBase6 = CreateTypedBindingFrom_bindingExtension6(bindingExtension6);
			if (VisualDiagnostics.GetSourceInfo(bindingBase6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase6, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 85, 25);
			}
			dataTrigger4.Binding = bindingBase6;
			dataTrigger4.Value = "False";
			Setter setter6 = new Setter
			{
				Property = View.MarginProperty,
				Value = new Thickness(0.0, 0.0, 0.0, 0.0)
			};
			if (VisualDiagnostics.GetSourceInfo(setter6) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter6, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 88, 26);
			}
			dataTrigger4.Setters.Add(setter6);
			Setter setter7 = new Setter
			{
				Property = Border.PaddingProperty,
				Value = new Thickness(8.0)
			};
			if (VisualDiagnostics.GetSourceInfo(setter7) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(setter7, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 89, 26);
			}
			dataTrigger4.Setters.Add(setter7);
			list.Add(dataTrigger4);
			grid.SetValue(View.MarginProperty, new Thickness(2.0));
			grid.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			grid.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection(new ColumnDefinition(new GridLength(24.0, GridUnitType.Absolute)), new ColumnDefinition(GridLength.Star)));
			grid.SetValue(Grid.ColumnSpacingProperty, 10.0);
			grid.SetValue(Grid.RowDefinitionsProperty, new RowDefinitionCollection(new RowDefinition(GridLength.Auto), new RowDefinition(GridLength.Auto)));
			grid.SetValue(Grid.RowSpacingProperty, 4.0);
			label.SetValue(Grid.RowProperty, 0);
			label.SetValue(Grid.ColumnProperty, 0);
			label.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			label.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
			staticResourceExtension.Key = "BooleanInvertConverter";
			XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
			SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[6] { bindingExtension7, label, grid, border, dataTemplate, __root }, typeof(BindingExtension).GetProperty("Converter"), new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider.Add(typeof(IReferenceProvider), service);
			xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
			xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(30, 25)));
			object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
			if (VisualDiagnostics.GetSourceInfo(obj) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 25);
			}
			bindingExtension7.Converter = (IValueConverter)obj;
			bindingExtension7.Path = "IsCompleted";
			BindingBase bindingBase7 = CreateTypedBindingFrom_bindingExtension7(bindingExtension7);
			if (VisualDiagnostics.GetSourceInfo(bindingBase7) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase7, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 30, 25);
			}
			label.SetBinding(VisualElement.IsVisibleProperty, bindingBase7);
			label.SetValue(SemanticProperties.HeadingLevelProperty, SemanticHeadingLevel.None);
			staticResourceExtension2.Key = "LabelBold";
			XamlServiceProvider xamlServiceProvider2 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service2 = new SimpleValueTargetProvider(new object[5] { label, grid, border, dataTemplate, __root }, VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider2.Add(typeof(IReferenceProvider), service2);
			xamlServiceProvider2.Add(typeof(IProvideValueTarget), service2);
			xamlServiceProvider2.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(32, 25)));
			object obj2 = ((IMarkupExtension)staticResourceExtension2).ProvideValue((IServiceProvider)xamlServiceProvider2);
			if (VisualDiagnostics.GetSourceInfo(obj2) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj2, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 32, 25);
			}
			label.SetValue(VisualElement.StyleProperty, obj2);
			bindingExtension8.Path = "Index";
			BindingBase bindingBase8 = CreateTypedBindingFrom_bindingExtension8(bindingExtension8);
			if (VisualDiagnostics.GetSourceInfo(bindingBase8) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase8, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 33, 25);
			}
			label.SetBinding(Label.TextProperty, bindingBase8);
			label.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
			grid.Children.Add(label);
			image.SetValue(Grid.RowProperty, 0);
			image.SetValue(Grid.RowSpanProperty, 2);
			image.SetValue(Grid.ColumnProperty, 0);
			image.SetValue(AutomationProperties.IsInAccessibleTreeProperty, false);
			image.SetValue(VisualElement.HeightRequestProperty, 24.0);
			bindingExtension9.Path = "IsCompleted";
			BindingBase bindingBase9 = CreateTypedBindingFrom_bindingExtension9(bindingExtension9);
			if (VisualDiagnostics.GetSourceInfo(bindingBase9) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase9, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 42, 25);
			}
			image.SetBinding(VisualElement.IsVisibleProperty, bindingBase9);
			bindingExtension10.Path = "ImageSource";
			BindingBase bindingBase10 = CreateTypedBindingFrom_bindingExtension10(bindingExtension10);
			if (VisualDiagnostics.GetSourceInfo(bindingBase10) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase10, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 43, 25);
			}
			image.SetBinding(Image.SourceProperty, bindingBase10);
			image.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
			image.SetValue(VisualElement.WidthRequestProperty, 24.0);
			grid.Children.Add(image);
			label2.SetValue(Grid.RowProperty, 0);
			label2.SetValue(Grid.ColumnProperty, 1);
			label2.HandlerChanged += Title_OnHandlerChanged;
			label2.PropertyChanged += OnLabelPropertyChanged;
			staticResourceExtension3.Key = "LabelBold";
			XamlServiceProvider xamlServiceProvider3 = new XamlServiceProvider(this);
			SimpleValueTargetProvider service3 = new SimpleValueTargetProvider(new object[5] { label2, grid, border, dataTemplate, __root }, VisualElement.StyleProperty, new INameScope[2] { nameScope, iNameScope }, this);
			xamlServiceProvider3.Add(typeof(IReferenceProvider), service3);
			xamlServiceProvider3.Add(typeof(IProvideValueTarget), service3);
			xamlServiceProvider3.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(53, 25)));
			object obj3 = ((IMarkupExtension)staticResourceExtension3).ProvideValue((IServiceProvider)xamlServiceProvider3);
			if (VisualDiagnostics.GetSourceInfo(obj3) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(obj3, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 53, 25);
			}
			label2.SetValue(VisualElement.StyleProperty, obj3);
			bindingExtension11.Path = "Title.Localized";
			BindingBase bindingBase11 = CreateTypedBindingFrom_bindingExtension11(bindingExtension11);
			if (VisualDiagnostics.GetSourceInfo(bindingBase11) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase11, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 54, 25);
			}
			label2.SetBinding(Label.TextProperty, bindingBase11);
			label2.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
			grid.Children.Add(label2);
			label3.SetValue(Grid.RowProperty, 1);
			label3.SetValue(Grid.ColumnProperty, 1);
			bindingExtension12.Path = "SubTextVisible";
			BindingBase bindingBase12 = CreateTypedBindingFrom_bindingExtension12(bindingExtension12);
			if (VisualDiagnostics.GetSourceInfo(bindingBase12) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase12, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 61, 25);
			}
			label3.SetBinding(VisualElement.IsVisibleProperty, bindingBase12);
			bindingExtension13.Path = "Text.Localized";
			BindingBase bindingBase13 = CreateTypedBindingFrom_bindingExtension13(bindingExtension13);
			if (VisualDiagnostics.GetSourceInfo(bindingBase13) == null)
			{
				VisualDiagnostics.RegisterSourceInfo(bindingBase13, new Uri("StepsControl.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 62, 25);
			}
			label3.SetBinding(Label.TextProperty, bindingBase13);
			grid.Children.Add(label3);
			border.SetValue(Border.ContentProperty, grid);
			return border;
		};
		__root.SetValue(BindableLayout.ItemTemplateProperty, dataTemplate);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<IStepModel, int> setter = delegate(IStepModel source, int value)
			{
				source.Index = value;
			};
			return new TypedBinding<IStepModel, int>((IStepModel source) => (value: source.Index, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "Index")
			})
			{
				StringFormat = extension.StringFormat
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension10(BindingExtension extension)
		{
			Action<IStepModel, string> setter = null;
			return new TypedBinding<IStepModel, string>((IStepModel source) => (value: source.ImageSource, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "ImageSource")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension11(BindingExtension extension)
		{
			Action<IStepModel, string> setter = null;
			return new TypedBinding<IStepModel, string>((IStepModel source) => (value: source.Title.Localized, success: true), setter, new Tuple<Func<IStepModel, object>, string>[2]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "Title"),
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source.Title, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension12(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.SubTextVisible, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "SubTextVisible")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension13(BindingExtension extension)
		{
			Action<IStepModel, string> setter = null;
			return new TypedBinding<IStepModel, string>((IStepModel source) => (value: source.Text.Localized, success: true), setter, new Tuple<Func<IStepModel, object>, string>[2]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "Text"),
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source.Text, "Localized")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension2(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsActive, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsActive")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension3(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsActive, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsActive")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension4(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsActive, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsActive")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension5(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsCompleted, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsCompleted")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension6(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsCompleted, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsCompleted")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension7(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsCompleted, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsCompleted")
			})
			{
				Converter = extension.Converter
			};
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension8(BindingExtension extension)
		{
			Action<IStepModel, int> setter = delegate(IStepModel source, int value)
			{
				source.Index = value;
			};
			return new TypedBinding<IStepModel, int>((IStepModel source) => (value: source.Index, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "Index")
			});
		}
		static BindingBase CreateTypedBindingFrom_bindingExtension9(BindingExtension extension)
		{
			Action<IStepModel, bool> setter = null;
			return new TypedBinding<IStepModel, bool>((IStepModel source) => (value: source.IsCompleted, success: true), setter, new Tuple<Func<IStepModel, object>, string>[1]
			{
				new Tuple<Func<IStepModel, object>, string>((IStepModel source) => source, "IsCompleted")
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
	[MemberNotNull("StepControl")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(StepsControl));
		StepControl = this.FindByName<StackLayout>("StepControl");
	}
}
