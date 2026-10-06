using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Common.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Xaml.Internals;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[XamlFilePath("NumberPadButton.xaml")]
[XamlCompilation(XamlCompilationOptions.Skip)]
[GeneratedCode("Microsoft.Maui.Controls.SourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class NumberPadButton : ImageButton
{
	private int _number = -1;

	public int Number
	{
		get
		{
			return _number;
		}
		set
		{
			_number = value;
			base.CommandParameter = _number;
			int number = _number;
			int num = number;
			if (num > 9)
			{
				switch (num)
				{
				case 10:
				{
					BiometricType biometricType = AppSession.BiometricType;
					if (1 == 0)
					{
					}
					string text = biometricType switch
					{
						BiometricType.FingerPrint => DigiDAppResources.Fingerprint, 
						BiometricType.FaceID => DigiDAppResources.FaceID, 
						BiometricType.TouchID => DigiDAppResources.TouchID, 
						_ => string.Empty, 
					};
					if (1 == 0)
					{
					}
					string value2 = text;
					if (string.IsNullOrEmpty(value2))
					{
						return;
					}
					SemanticProperties.SetDescription(this, value2);
					base.AutomationId = "PinButton_Biometric";
					break;
				}
				case 11:
					SemanticProperties.SetDescription(this, CommonResources.AccessibilityRemove);
					base.AutomationId = "PinButton_BackSpace";
					break;
				}
			}
			else
			{
				SemanticProperties.SetDescription(this, _number.ToString());
				base.AutomationId = $"PinButton_{_number}";
			}
			SetImage();
		}
	}

	private void SetImage()
	{
		int number = _number;
		int num = number;
		if (num > 9)
		{
			switch (num)
			{
			case 10:
				SetDynamicResource(ImageButton.SourceProperty, $"pincode{AppSession.BiometricType}");
				break;
			case 11:
				SetDynamicResource(ImageButton.SourceProperty, "pincodeBackspace");
				break;
			}
		}
		else
		{
			SetDynamicResource(ImageButton.SourceProperty, $"pincode{_number}");
		}
	}

	public NumberPadButton()
	{
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, delegate
		{
			SetImage();
		});
		base.Aspect = Aspect.AspectFill;
		InitializeComponent();
		base.Pressed -= OnButtonPressed;
		base.Pressed += OnButtonPressed;
	}

	private async void OnButtonPressed(object? sender, EventArgs e)
	{
		try
		{
			WeakReferenceMessenger.Default.Send(new NumberPadIsTappedMessage());
			if (!((IApp)Application.Current).ServiceProvider.GetRequiredService<IMobileSettings>().ScreenshotEnabled)
			{
				double oldOpacity = base.Opacity;
				base.Opacity = 0.8;
				await Task.Delay(100);
				base.Opacity = oldOpacity;
			}
		}
		catch (Exception)
		{
		}
	}

	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void InitializeComponent()
	{
		if ((ResourceLoader.ResourceProvider2?.Invoke(new ResourceLoader.ResourceLoadingQuery
		{
			AssemblyName = typeof(NumberPadButton).Assembly.GetName(),
			ResourcePath = getPathForType(typeof(NumberPadButton)),
			Instance = this
		}))?.ResourceContent != null)
		{
			InitializeComponentRuntime();
			return;
		}
		BindingExtension bindingExtension = new BindingExtension();
		VisualDiagnostics.RegisterSourceInfo(bindingExtension, new Uri("NumberPadButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 5);
		StaticResourceExtension staticResourceExtension = new StaticResourceExtension();
		VisualDiagnostics.RegisterSourceInfo(staticResourceExtension, new Uri("NumberPadButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		VisualDiagnostics.RegisterSourceInfo(this, new Uri("NumberPadButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 2, 2);
		INameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		bindingExtension.Path = "NumberEnteredCommand";
		BindingBase bindingBase = CreateTypedBindingFrom_bindingExtension(bindingExtension);
		if (VisualDiagnostics.GetSourceInfo(bindingBase) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(bindingBase, new Uri("NumberPadButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 8, 5);
		}
		SetBinding(ImageButton.CommandProperty, bindingBase);
		staticResourceExtension.Key = "NumberPadButtonStyle";
		XamlServiceProvider xamlServiceProvider = new XamlServiceProvider(this);
		SimpleValueTargetProvider service = new SimpleValueTargetProvider(new object[1] { this }, VisualElement.StyleProperty, new INameScope[1] { nameScope }, this);
		xamlServiceProvider.Add(typeof(IReferenceProvider), service);
		xamlServiceProvider.Add(typeof(IProvideValueTarget), service);
		xamlServiceProvider.Add(typeof(IXmlLineInfoProvider), new XmlLineInfoProvider(new XmlLineInfo(9, 5)));
		object obj = ((IMarkupExtension)staticResourceExtension).ProvideValue((IServiceProvider)xamlServiceProvider);
		if (VisualDiagnostics.GetSourceInfo(obj) == null)
		{
			VisualDiagnostics.RegisterSourceInfo(obj, new Uri("NumberPadButton.xaml;assembly=DigiD.Common.Controls", UriKind.Relative), 9, 5);
		}
		SetValue(VisualElement.StyleProperty, obj);
		static BindingBase CreateTypedBindingFrom_bindingExtension(BindingExtension extension)
		{
			Action<BasePinCodeViewModel, IAsyncRelayCommand<int>> setter = null;
			return new TypedBinding<BasePinCodeViewModel, IAsyncRelayCommand<int>>((BasePinCodeViewModel source) => (value: source.NumberEnteredCommand, success: true), setter, new Tuple<Func<BasePinCodeViewModel, object>, string>[1]
			{
				new Tuple<Func<BasePinCodeViewModel, object>, string>((BasePinCodeViewModel source) => source, "NumberEnteredCommand")
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
	private void InitializeComponentRuntime()
	{
		this.LoadFromXaml(typeof(NumberPadButton));
	}
}
