using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation.Peers;
using Microsoft.UI.Xaml.Input;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;
using Windows.System;

namespace DigiD.Common.Controls.Behaviors;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class A11YBehavior : PlatformBehavior<View>
{
	private bool _propertiesInitialized;

	private readonly ILogger<A11YBehavior> logger = ((IApp)Microsoft.Maui.Controls.Application.Current).ServiceProvider.GetRequiredService<ILogger<A11YBehavior>>();

	public static readonly BindableProperty RoleProperty = BindableProperty.Create("Role", typeof(A11YRole), typeof(A11YBehavior), A11YRole.None, BindingMode.TwoWay, null, A11YRolePropertyChanged);

	public static readonly BindableProperty DescriptionProperty = BindableProperty.Create("Description", typeof(string), typeof(A11YBehavior), null, BindingMode.TwoWay, null, DescriptionPropertyChanged);

	public static readonly BindableProperty StateDescriptionProperty = BindableProperty.Create("StateDescription", typeof(string), typeof(A11YBehavior), null, BindingMode.TwoWay, null, StateDescriptionPropertyChanged);

	public static readonly BindableProperty HintTextProperty = BindableProperty.Create("HintText", typeof(string), typeof(A11YBehavior), null, BindingMode.OneWay, null, HintTextPropertyChanged);

	public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(A11YBehavior), null, BindingMode.TwoWay);

	public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(A11YBehavior), null, BindingMode.TwoWay);

	public static readonly BindableProperty CanExecuteProperty = BindableProperty.Create("CanExecute", typeof(bool), typeof(A11YBehavior), true, BindingMode.TwoWay);

	private A11YBehaviorPeer? _a11YBehaviorPeer;

	private TapGestureRecognizer? _tapGestureRecognizer;

	public bool CanExecute
	{
		get
		{
			return (bool)GetValue(CanExecuteProperty);
		}
		set
		{
			SetValue(CanExecuteProperty, value);
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

	public A11YRole Role
	{
		get
		{
			return (A11YRole)GetValue(RoleProperty);
		}
		set
		{
			SetValue(RoleProperty, value);
		}
	}

	public string? Description
	{
		get
		{
			return (string)GetValue(DescriptionProperty);
		}
		set
		{
			SetValue(DescriptionProperty, value);
		}
	}

	public string? StateDescription
	{
		get
		{
			return (string)GetValue(StateDescriptionProperty);
		}
		set
		{
			SetValue(StateDescriptionProperty, value);
		}
	}

	public string? HintText
	{
		get
		{
			return (string)GetValue(HintTextProperty);
		}
		set
		{
			SetValue(HintTextProperty, value);
		}
	}

	private static void A11YRolePropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is A11YBehavior a11YBehavior && newValue is A11YRole role)
		{
			a11YBehavior.SetRole(role);
		}
	}

	private static void DescriptionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is A11YBehavior a11YBehavior)
		{
			a11YBehavior.SetDescription(newValue as string);
		}
	}

	private static void StateDescriptionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (!(bindable is A11YBehavior a11YBehavior))
		{
			return;
		}
		a11YBehavior.SetStateDescription(newValue as string);
		string announcement = newValue as string;
		if (announcement != null && a11YBehavior._propertiesInitialized)
		{
			MainThread.BeginInvokeOnMainThread(delegate
			{
				((IApp)Microsoft.Maui.Controls.Application.Current).A11YService.Speak(announcement, 100);
			});
		}
		a11YBehavior._propertiesInitialized = true;
	}

	private static void HintTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is A11YBehavior a11YBehavior)
		{
			a11YBehavior.SetHint(newValue as string);
		}
	}

	private void HandleClick(object? sender, EventArgs e)
	{
		ICommand? command = Command;
		if (command != null && command.CanExecute(CommandParameter) && CanExecute)
		{
			Command.Execute(CommandParameter);
		}
	}

	private static void DidFocusChanged(object? sender, bool isFocused)
	{
		if (sender is View view)
		{
			IViewHandler handler = view.Handler;
			if (handler != null && handler.PlatformView != null)
			{
				Microsoft.Maui.Controls.VisualStateManager.GoToState(view, isFocused ? "Focused" : "Normal");
			}
		}
	}

	protected override void OnAttachedTo(View bindable, FrameworkElement platformView)
	{
		try
		{
			base.OnAttachedTo(bindable, platformView);
			platformView.SetAutomationPropertiesAccessibilityView(bindable);
			platformView.Language = ((IApp)Microsoft.Maui.Controls.Application.Current).GeneralPreferences.Language;
			platformView.KeyDown += CheckEnterOrSpace;
			_tapGestureRecognizer = new TapGestureRecognizer();
			_tapGestureRecognizer.Command = Command;
			_tapGestureRecognizer.Tapped += ViewTapped;
			bindable.GestureRecognizers.Add(_tapGestureRecognizer);
			bindable.Focused += OnFocusChanged;
			bindable.Unfocused += OnFocusChanged;
			A11YRole role = Role;
			bool isTabStop = (uint)(role - 1) <= 1u;
			platformView.IsTabStop = isTabStop;
			AutomationPeer automationPeer = FrameworkElementAutomationPeer.FromElement(platformView);
			if (automationPeer is A11YBehaviorPeer a11YBehaviorPeer)
			{
				_a11YBehaviorPeer = a11YBehaviorPeer;
				_a11YBehaviorPeer.AutomationId = bindable.AutomationId;
				_a11YBehaviorPeer.Description = Description;
				_a11YBehaviorPeer.HelpText = HintText;
				_a11YBehaviorPeer.AccessibilityView = AccessibilityView.Content;
				_a11YBehaviorPeer.State = StateDescription;
				_a11YBehaviorPeer.Role = Role;
				_a11YBehaviorPeer.Command = Command;
				_a11YBehaviorPeer.CommandParameter = CommandParameter;
			}
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "Error during OnAttachedTo");
		}
	}

	protected override void OnDetachedFrom(View bindable, FrameworkElement platformView)
	{
		try
		{
			base.OnDetachedFrom(bindable, platformView);
			platformView.KeyDown -= CheckEnterOrSpace;
			WeakReferenceMessenger.Default.Unregister<LanguageChangedMessage>(this);
			bindable.Focused -= OnFocusChanged;
			bindable.Unfocused -= OnFocusChanged;
			if (_tapGestureRecognizer != null)
			{
				_tapGestureRecognizer.Command = null;
				bindable.GestureRecognizers.Remove(_tapGestureRecognizer);
				_tapGestureRecognizer = null;
			}
			_a11YBehaviorPeer = null;
			_tapGestureRecognizer = null;
		}
		catch (Exception exception)
		{
			logger.LogError(exception, "Error during OnDetachedFrom");
		}
	}

	private void CheckEnterOrSpace(object sender, KeyRoutedEventArgs e)
	{
		VirtualKey key = e.Key;
		if ((key == VirtualKey.Enter || key == VirtualKey.Space) ? true : false)
		{
			e.Handled = true;
			ViewTapped(this, new TappedEventArgs(null));
		}
	}

	private void OnFocusChanged(object? sender, FocusEventArgs e)
	{
		DidFocusChanged(sender, e.IsFocused);
	}

	private void ViewTapped(object? sender, TappedEventArgs e)
	{
		HandleClick(sender, EventArgs.Empty);
	}

	private void SetDescription(string? description)
	{
		if ((object)_a11YBehaviorPeer != null)
		{
			_a11YBehaviorPeer.Description = description;
		}
	}

	private void SetHint(string? hint)
	{
		if ((object)_a11YBehaviorPeer != null)
		{
			_a11YBehaviorPeer.HelpText = hint;
		}
	}

	private void SetStateDescription(string? description)
	{
		if ((object)_a11YBehaviorPeer != null)
		{
			_a11YBehaviorPeer.State = description;
		}
	}

	private void SetRole(A11YRole role)
	{
		if ((object)_a11YBehaviorPeer != null)
		{
			_a11YBehaviorPeer.Role = role;
		}
	}
}
