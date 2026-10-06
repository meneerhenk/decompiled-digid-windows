using System;
using System.Threading.Tasks;
using DigiD.Common.Controls.Behaviors;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;
using SkiaSharp.Extended.UI.Controls;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomAnimationViewWinRTTypeDetails))]
public class CustomAnimationView : SKLottieView, IDisposable
{
	public static readonly BindableProperty AnimationSourceProperty = BindableProperty.Create("AnimationSource", typeof(string), typeof(CustomAnimationView), null, BindingMode.OneWay, null, AnimationSourcePropertyChanged);

	public static readonly BindableProperty HideAnimationProperty = BindableProperty.Create("HideAnimation", typeof(bool), typeof(CustomAnimationView), false, BindingMode.OneWay, null, HideAnimationPropertyChanged);

	private static readonly BindableProperty PauseAnimationProperty = BindableProperty.Create("PauseAnimation", typeof(bool), typeof(CustomAnimationView), false, BindingMode.OneWay, null, PauseAnimationPropertyChanged);

	private readonly IGestureRecognizer doubleTapGesture;

	private readonly A11YBehavior _a11YBehavior;

	private Task? initializationTask;

	public bool PauseAnimation
	{
		get
		{
			return (bool)GetValue(PauseAnimationProperty);
		}
		set
		{
			SetValue(PauseAnimationProperty, value);
		}
	}

	public string? AnimationSource
	{
		get
		{
			return (string)GetValue(AnimationSourceProperty);
		}
		set
		{
			SetValue(AnimationSourceProperty, value);
		}
	}

	public bool HideAnimation
	{
		get
		{
			return (bool)GetValue(HideAnimationProperty);
		}
		set
		{
			SetValue(HideAnimationProperty, value);
		}
	}

	private static void PauseAnimationPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomAnimationView { IsVisible: not false } customAnimationView && newValue is bool isAnimationEnabled)
		{
			customAnimationView.IsAnimationEnabled = isAnimationEnabled;
		}
	}

	private static void HideAnimationPropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (bindable is CustomAnimationView customAnimationView)
		{
			customAnimationView.SetAnimationProperty();
		}
	}

	private static void AnimationSourcePropertyChanged(BindableObject bindable, object? oldValue, object? newValue)
	{
		if (newValue is string file && bindable is CustomAnimationView customAnimationView)
		{
			customAnimationView.Source = new SKFileLottieImageSource
			{
				File = file
			};
			customAnimationView.SetAnimationProperty();
			customAnimationView.RepeatCount = -1;
			customAnimationView.Progress = TimeSpan.Zero;
		}
	}

	public CustomAnimationView()
	{
		base.MinimumHeightRequest = 200.0;
		doubleTapGesture = new TapGestureRecognizer
		{
			NumberOfTapsRequired = 1,
			Command = new Command(TogglePauseAnimation),
			Buttons = ButtonsMask.Primary
		};
		base.GestureRecognizers.Add(doubleTapGesture);
		_a11YBehavior = new A11YBehavior
		{
			Role = A11YRole.Button
		};
		UpdateSemanticDescriptions();
		if (DeviceInfo.Platform == DevicePlatform.Android)
		{
			_a11YBehavior.Command = new Command(TogglePauseAnimation);
		}
		base.Behaviors.Add(_a11YBehavior);
		initializationTask = InitializationAsync();
	}

	private void TogglePauseAnimation()
	{
		PauseAnimation = !PauseAnimation;
		UpdateSemanticDescriptions();
	}

	private async Task InitializationAsync()
	{
		await Task.Delay(50);
		try
		{
			SetAnimationProperty();
			UpdateSemanticDescriptions();
		}
		catch (Exception)
		{
		}
		finally
		{
			initializationTask = null;
		}
	}

	private void UpdateSemanticDescriptions()
	{
		ILocalizationResourceManager requiredService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		_a11YBehavior.Description = requiredService["AccessibilityShowNfcLocationAnimation"];
		_a11YBehavior.StateDescription = (base.IsAnimationEnabled ? requiredService["AccessibilityAnimationIsPlayingState"] : requiredService["AccessibilityAnimationIsPausedState"]);
		_a11YBehavior.HintText = (base.IsAnimationEnabled ? requiredService["AccessibilityAnimationIsPlayingHint"] : requiredService["AccessibilityAnimationIsPausedHint"]);
	}

	protected override void OnPropertyChanged(string? propertyName = null)
	{
		base.OnPropertyChanged(propertyName);
		if (propertyName != null)
		{
			if (propertyName.Equals("IsVisible"))
			{
				SetTapGesture(base.IsVisible);
				AutomationProperties.SetIsInAccessibleTree(this, base.IsVisible);
			}
			else if (propertyName.Equals("IsInAccessibleTree"))
			{
				AutomationProperties.SetIsInAccessibleTree(this, base.IsVisible);
			}
			else if (propertyName.Equals("PauseAnimation"))
			{
				UpdateSemanticDescriptions();
			}
		}
	}

	private void SetTapGesture(bool isAnimationVisible)
	{
		bool flag = !isAnimationVisible && base.GestureRecognizers.Contains(doubleTapGesture);
		if (isAnimationVisible && !base.GestureRecognizers.Contains(doubleTapGesture))
		{
			base.GestureRecognizers.Add(doubleTapGesture);
		}
		if (flag)
		{
			base.GestureRecognizers.Remove(doubleTapGesture);
		}
	}

	private void SetAnimationProperty()
	{
		base.IsVisible = !((IApp)Application.Current).A11YService.HideAnimations && !HideAnimation;
		base.IsAnimationEnabled = base.IsVisible && !PauseAnimation;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		initializationTask?.Dispose();
	}
}
