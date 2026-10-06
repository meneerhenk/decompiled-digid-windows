using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Graphics;

namespace DigiD.Common.Controls;

[XamlCompilation(XamlCompilationOptions.Compile)]
[XamlFilePath("PinTilesCodeEntryView.xaml")]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
public class PinTilesCodeEntryView : Grid
{
	public static readonly BindableProperty CodeTypeProperty = BindableProperty.Create("CodeType", typeof(CodeType), typeof(PinTilesCodeEntryView), CodeType.NotSet, BindingMode.OneTime, null, CodeTypePropertyChanged);

	public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(PinTilesCodeEntryView), string.Empty, BindingMode.TwoWay);

	public static readonly BindableProperty InitialCharProperty = BindableProperty.Create("InitialChar", typeof(string), typeof(PinTilesCodeEntryView), string.Empty, BindingMode.OneTime, null, InitialCharPropertyChanged);

	public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create("ReturnType", typeof(ReturnType), typeof(CustomEntryField), ReturnType.Default, BindingMode.OneWay, null, ReturnTypePropertyChanged);

	public static readonly BindableProperty ReturnCommandProperty = BindableProperty.Create("ReturnCommand", typeof(IAsyncRelayCommand), typeof(CustomEntryField), null, BindingMode.OneWay, null, ReturnCommandPropertyChanged);

	public static readonly BindableProperty ReturnCommandParameterProperty = BindableProperty.Create("ReturnCommandParameter", typeof(object), typeof(CustomEntryField), null, BindingMode.OneWay, null, ReturnCommandParameterPropertyChanged);

	protected readonly Grid Grid;

	private readonly Border gridBorder;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Grid entryView;

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private Entry txt;

	public CodeType CodeType
	{
		get
		{
			return (CodeType)GetValue(CodeTypeProperty);
		}
		set
		{
			SetValue(CodeTypeProperty, value);
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

	public string InitialChar
	{
		get
		{
			return (string)GetValue(InitialCharProperty);
		}
		set
		{
			SetValue(InitialCharProperty, value);
		}
	}

	public ReturnType ReturnType
	{
		get
		{
			return (ReturnType)GetValue(ReturnTypeProperty);
		}
		set
		{
			SetValue(ReturnTypeProperty, value);
		}
	}

	public IAsyncRelayCommand ReturnCommand
	{
		get
		{
			return (IAsyncRelayCommand)GetValue(ReturnCommandProperty);
		}
		set
		{
			SetValue(ReturnCommandProperty, value);
		}
	}

	public object ReturnCommandParameter
	{
		get
		{
			return GetValue(ReturnCommandParameterProperty);
		}
		set
		{
			SetValue(ReturnCommandParameterProperty, value);
		}
	}

	private static bool IsPhone => DeviceInfo.Idiom == DeviceIdiom.Phone;

	private static bool IsInA11YMode => ((IApp)Application.Current).A11YService.IsInVoiceOverMode;

	private static void CodeTypePropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (!(bindable is PinTilesCodeEntryView pinTilesCodeEntryView))
		{
			return;
		}
		if (newValue is CodeType)
		{
			switch ((CodeType)newValue)
			{
			case CodeType.SMS:
				pinTilesCodeEntryView.txt.MaxLength = 6;
				pinTilesCodeEntryView.txt.Keyboard = Keyboard.Numeric;
				break;
			case CodeType.Letter:
			case CodeType.Email:
				pinTilesCodeEntryView.txt.MaxLength = 9;
				break;
			case CodeType.KoppelCode:
				pinTilesCodeEntryView.txt.MaxLength = 4;
				break;
			}
		}
		pinTilesCodeEntryView.CreateTiles();
		pinTilesCodeEntryView.SetPlaceholder();
	}

	private static void InitialCharPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is PinTilesCodeEntryView pinTilesCodeEntryView)
		{
			pinTilesCodeEntryView.CreateTiles();
		}
	}

	private static void ReturnTypePropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is PinTilesCodeEntryView pinTilesCodeEntryView && newValue is ReturnType returnType)
		{
			pinTilesCodeEntryView.txt.ReturnType = returnType;
		}
	}

	private static void ReturnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is PinTilesCodeEntryView pinTilesCodeEntryView && newValue is IAsyncRelayCommand returnCommand)
		{
			pinTilesCodeEntryView.txt.ReturnCommand = returnCommand;
		}
	}

	private static void ReturnCommandParameterPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is PinTilesCodeEntryView pinTilesCodeEntryView)
		{
			pinTilesCodeEntryView.txt.ReturnCommandParameter = newValue;
		}
	}

	public PinTilesCodeEntryView()
	{
		InitializeComponent();
		gridBorder = new Border
		{
			StrokeThickness = 2.0,
			Stroke = Colors.Transparent
		};
		base.Children.Add(gridBorder);
		Grid = new Grid
		{
			HorizontalOptions = (IsPhone ? LayoutOptions.Fill : LayoutOptions.Center)
		};
		gridBorder.Content = Grid;
		txt.HandlerChanged += Entry_HandlerChanged;
		CreateTiles();
		txt.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeCharacter);
		A11YOnOff();
		txt.SetDynamicResource(Entry.FontFamilyProperty, "FontRegular");
	}

	private void OnTxtFocusChanged(object? sender, FocusEventArgs e)
	{
		if (e.IsFocused)
		{
			Focus();
		}
		else
		{
			UnFocus();
		}
		gridBorder.Stroke = ((!txt.IsFocused) ? Colors.Transparent : (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black));
	}

	private void A11YOnOff()
	{
		if (IsInA11YMode)
		{
			this.SetAppThemeColor(VisualElement.BackgroundColorProperty, (Color)Application.Current.Resources["Gray6"], (Color)Application.Current.Resources["Gray7"]);
			SetTextEntryForA11Y();
			Grid.IsVisible = false;
		}
		else
		{
			SetDynamicResource(VisualElement.BackgroundColorProperty, "AppPageBackground");
			Grid.IsVisible = true;
		}
	}

	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
		if (IsInA11YMode && base.Handler != null && txt != null)
		{
			Entry_HandlerChanged(this, EventArgs.Empty);
			txt.SetSemanticFocus();
		}
	}

	private void SetTextEntryForA11Y()
	{
		txt.BackgroundColor = (Color)Application.Current.Resources["CustomEntryFieldActiveBackgroundColor"];
		txt.TextColor = Colors.Black;
		txt.SetAppTheme(VisualElement.OpacityProperty, 1.0, 0.9);
		txt.Margin = new Thickness(1.0);
		txt.IsVisible = true;
		AutomationProperties.SetIsInAccessibleTree(this, false);
		AutomationProperties.SetIsInAccessibleTree(Grid, !IsInA11YMode);
		AutomationProperties.SetIsInAccessibleTree(txt, true);
		SetPlaceholder();
		txt.SetDynamicResource(Entry.FontFamilyProperty, "FontRegular");
		txt.SetDynamicResource(Entry.FontSizeProperty, "DefaultFontSize");
		txt.HeightRequest = 48.0;
		txt.HorizontalOptions = LayoutOptions.Start;
		txt.MinimumHeightRequest = 48.0;
		txt.WidthRequest = 11.0 * txt.FontSize;
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			txt.HorizontalOptions = LayoutOptions.Center;
			txt.VerticalOptions = LayoutOptions.Center;
			txt.VerticalTextAlignment = TextAlignment.End;
			txt.HorizontalTextAlignment = TextAlignment.Start;
		}
		if (IsInA11YMode && !string.IsNullOrWhiteSpace(InitialChar) && !txt.Text.StartsWith(InitialChar))
		{
			txt.Text = InitialChar + Text;
		}
	}

	private void SetPlaceholder()
	{
		txt.Placeholder(CodeType.Translate(), Colors.Transparent);
	}

	private void CreateTiles()
	{
		if (txt.MaxLength == 0)
		{
			return;
		}
		Grid.Children.Clear();
		Grid.ColumnDefinitions.Clear();
		Grid.RowDefinitions.Clear();
		Grid.SetDynamicResource(VisualElement.BackgroundColorProperty, "AppPageBackground");
		Grid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));
		int num = 0;
		for (int i = 0; i <= txt.MaxLength - 1; i++)
		{
			if (CodeType == CodeType.SMS && i == 3)
			{
				Grid.ColumnDefinitions.Add(new ColumnDefinition
				{
					Width = GridLength.Auto
				});
				Label label = new Label
				{
					Text = "-",
					FontSize = 17.0,
					VerticalTextAlignment = TextAlignment.Center,
					HorizontalTextAlignment = TextAlignment.Center,
					FontAutoScalingEnabled = false,
					Margin = new Thickness(5.0)
				};
				label.SetDynamicResource(Entry.FontFamilyProperty, "FontBold");
				Grid.Add(label, num);
				num++;
			}
			Grid.ColumnDefinitions.Add(new ColumnDefinition
			{
				Width = (IsPhone ? GridLength.Star : GridLength.Auto)
			});
			PinTile view = new PinTile(txt.MaxLength, i, hideStar: true);
			Grid.Add(view, num);
			num++;
		}
		if (!string.IsNullOrEmpty(InitialChar))
		{
			((PinTile)Grid.Children[0]).Text = InitialChar;
			((PinTile)Grid.Children[0]).State = PinTileState.Active;
			((PinTile)Grid.Children[1]).State = PinTileState.Current;
		}
	}

	protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if ((propertyName != null && !(propertyName == "Text")) || 1 == 0)
		{
			if (propertyName.Equals(SemanticProperties.DescriptionProperty.PropertyName) || propertyName.Equals("MaxLength") || propertyName.Equals(Entry.PlaceholderProperty.PropertyName))
			{
				SetPlaceholder();
			}
			else if (propertyName == "AutomationId")
			{
				txt.AutomationId = "Entry_" + base.AutomationId;
			}
			else if (propertyName == "IsFocused")
			{
				txt.Focus();
			}
		}
	}

	private void HandleRemove()
	{
		if (Grid.Children.FirstOrDefault((IView v) => v is PinTile pinTile3 && pinTile3.State == PinTileState.Current) is PinTile pinTile)
		{
			pinTile.State = PinTileState.Inactive;
		}
		if (Grid.Children.LastOrDefault((IView v) => v is PinTile pinTile3 && pinTile3.State == PinTileState.Active) is PinTile pinTile2)
		{
			pinTile2.Text = string.Empty;
			pinTile2.State = PinTileState.Current;
		}
	}

	private void HandleAdd(TextChangedEventArgs e)
	{
		gridBorder.Stroke = ((!txt.IsFocused) ? Colors.Transparent : (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black));
		if (e.OldTextValue == null)
		{
			string newTextValue = e.NewTextValue;
			if (newTextValue != null && newTextValue.Length > 1)
			{
				foreach (char item in e.NewTextValue.Where((char newChar) => newChar.ToString() != InitialChar))
				{
					ChangeTile(item.ToString());
				}
				return;
			}
		}
		string? text = Text;
		ChangeTile(text?.Substring(text.Length - 1));
	}

	private void ChangeTile(string? newChar)
	{
		if (newChar == null)
		{
			return;
		}
		if (newChar == "\n" && DeviceInfo.Idiom == DeviceIdiom.Desktop && txt.ReturnCommand != null && txt.ReturnType == ReturnType.Go)
		{
			object returnCommandParameter = txt.ReturnCommandParameter;
			if (txt.ReturnCommand.CanExecute(returnCommandParameter))
			{
				txt.ReturnCommand.Execute(returnCommandParameter);
				return;
			}
		}
		if (Grid.Children.FirstOrDefault((IView v) => v is PinTile pinTile3 && pinTile3.State == PinTileState.Current) is PinTile pinTile)
		{
			pinTile.Text = newChar.ToUpperInvariant();
			pinTile.State = PinTileState.Active;
		}
		if (Grid.Children.FirstOrDefault((IView v) => v is PinTile pinTile3 && pinTile3.State == PinTileState.Inactive) is PinTile pinTile2)
		{
			pinTile2.State = PinTileState.Current;
		}
	}

	private void ClearEntry()
	{
		int num = -1;
		txt.Text = string.Empty;
		foreach (PinTile item in Grid.Children.Where((IView v) => v is PinTile).Cast<PinTile>())
		{
			num++;
			if (num != 0 || string.IsNullOrEmpty(InitialChar))
			{
				item.Text = string.Empty;
				item.State = PinTileState.Inactive;
			}
		}
		if (string.IsNullOrEmpty(InitialChar))
		{
			((PinTile)Grid.Children[0]).State = PinTileState.Current;
		}
		else
		{
			((PinTile)Grid.Children[1]).State = PinTileState.Current;
		}
	}

	private void Handle_TextChanged(object? _, TextChangedEventArgs e)
	{
		if (string.IsNullOrWhiteSpace(e.OldTextValue) && string.IsNullOrWhiteSpace(e.NewTextValue))
		{
			ClearEntry();
			return;
		}
		if (string.IsNullOrWhiteSpace(e.NewTextValue))
		{
			ClearEntry();
		}
		else if (e != null && e.OldTextValue != null && e.NewTextValue != null && e.NewTextValue.Length < e.OldTextValue.Length)
		{
			HandleRemove();
		}
		else if (!string.IsNullOrWhiteSpace(Text))
		{
			HandleAdd(e);
		}
		int num = ((Text == null || !Text.StartsWith(InitialChar, StringComparison.CurrentCultureIgnoreCase)) ? InitialChar.Length : 0);
		string? text = Text;
		if (((text != null) ? new int?(text.Length + num) : ((int?)null)) == txt.MaxLength && DeviceInfo.Idiom != DeviceIdiom.Desktop)
		{
			UnFocus();
		}
		else if (txt?.Text != null && txt.Text.Equals(InitialChar))
		{
			txt.CursorPosition = txt.Text.Length;
		}
	}

	private void TapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
	{
		if (txt.IsSoftInputShowing())
		{
			UnFocus();
		}
		else
		{
			Focus();
		}
	}

	public new void Focus()
	{
		base.Focus();
	}

	public void UnFocus()
	{
		Unfocus();
	}

	private void Entry_HandlerChanged(object? sender, EventArgs? e)
	{
		AutomationProperties.SetIsInAccessibleTree(this, false);
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	[MemberNotNull("entryView")]
	[MemberNotNull("txt")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(PinTilesCodeEntryView).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(PinTilesCodeEntryView)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		OnPlatformExtension onPlatformExtension = new OnPlatformExtension();
		VisualDiagnostics.RegisterSourceInfo(onPlatformExtension, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 5);
		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		VisualDiagnostics.RegisterSourceInfo(tapGestureRecognizer, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 22, 10);
		ReferenceExtension referenceExtension = new ReferenceExtension();
		VisualDiagnostics.RegisterSourceInfo(referenceExtension, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		Entry entry = new Entry();
		VisualDiagnostics.RegisterSourceInfo(entry, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 6);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		nameScope.RegisterName("entryView", this);
		if (StyleId == null)
		{
			string text = (StyleId = "entryView");
		}
		tapGestureRecognizer.transientNamescope = nameScope;
		entry.transientNamescope = nameScope;
		nameScope.RegisterName("txt", entry);
		Entry entry2 = entry;
		if (entry2.StyleId == null)
		{
			string text = (entry2.StyleId = "txt");
		}
		entryView = this;
		txt = entry;
		onPlatformExtension.Android = "False";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, AutomationProperties.IsInAccessibleTreeProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(7, 5)));
		object obj = ((IMarkupExtension)onPlatformExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 7, 5);
		}
		SetValue(AutomationProperties.IsInAccessibleTreeProperty, obj);
		SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;
		GestureRecognizers.Add(tapGestureRecognizer);
		entry.SetValue(VisualElement.HeightRequestProperty, 1.0);
		entry.Focused += OnTxtFocusChanged;
		entry.SetValue(InputView.IsSpellCheckEnabledProperty, false);
		entry.SetValue(InputView.MaxLengthProperty, 0);
		entry.SetValue(Entry.PlaceholderColorProperty, Colors.Transparent);
		referenceExtension.Name = "entryView";
		if (VisualDiagnostics.GetSourceInfo(this) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(this, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		}
		bindingExtension.Source = this;
		bindingExtension.Path = "Text";
		bindingExtension.Mode = BindingMode.TwoWay;
		Binding binding = new Binding(bindingExtension.Path, bindingExtension.Mode, bindingExtension.Converter, bindingExtension.ConverterParameter, bindingExtension.StringFormat, bindingExtension.Source)
		{
			UpdateSourceEventName = bindingExtension.UpdateSourceEventName,
			FallbackValue = bindingExtension.FallbackValue,
			TargetNullValue = bindingExtension.TargetNullValue
		};
		if (VisualDiagnostics.GetSourceInfo(binding) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(binding, new Uri("PinTilesCodeEntryView.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 16, 9);
		}
		entry.SetBinding(Entry.TextProperty, binding);
		entry.TextChanged += Handle_TextChanged;
		entry.SetValue(Entry.TextColorProperty, Colors.Black);
		entry.Unfocused += OnTxtFocusChanged;
		entry.SetValue(VisualElement.WidthRequestProperty, 1.0);
		Children.Add(entry);
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
	[MemberNotNull("entryView")]
	[MemberNotNull("txt")]
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(PinTilesCodeEntryView));
		entryView = this.FindByName<Grid>("entryView");
		txt = this.FindByName<Entry>("txt");
	}
}
