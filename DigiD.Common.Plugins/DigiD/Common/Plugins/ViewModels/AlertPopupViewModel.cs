using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using WinRT;
using WinRT.DigiD_Common_PluginsVtableClasses;

namespace DigiD.Common.Plugins.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Plugins_ViewModels_SpinnerPopupViewModelWinRTTypeDetails))]
public class AlertPopupViewModel : CommonBaseViewModel, IPopupViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CPrimaryButtonVisible_003Ek__BackingField = true;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsTimerVisible_003Ek__BackingField = false;

	private Func<bool?, Task>? _resultAction;

	private bool _invertCallToAction;

	private bool _invoked;

	private PeriodicTimer? timer;

	private CancellationTokenSource? token;

	private Task? timerTask;

	private TimeSpan? timerTime;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CTitle_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CMessage_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CAcceptButtonText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CCancelButtonText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CCancelButtonVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CPageLabelVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CImageSource_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CCloseIconVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CSecondsUsed_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CSecondsLeft_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? closeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? acceptCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? cancelCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CTitle_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Title);
				_003CTitle_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Title);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CMessage_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Message);
				_003CMessage_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Message);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? AcceptButtonText
	{
		get
		{
			return _003CAcceptButtonText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CAcceptButtonText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.AcceptButtonText);
				_003CAcceptButtonText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.AcceptButtonText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? CancelButtonText
	{
		get
		{
			return _003CCancelButtonText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CCancelButtonText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.CancelButtonText);
				_003CCancelButtonText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.CancelButtonText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CancelButtonVisible
	{
		get
		{
			return _003CCancelButtonVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CCancelButtonVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.CancelButtonVisible);
				_003CCancelButtonVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.CancelButtonVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool PageLabelVisible
	{
		get
		{
			return _003CPageLabelVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CPageLabelVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.PageLabelVisible);
				_003CPageLabelVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.PageLabelVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool PrimaryButtonVisible
	{
		get
		{
			return _003CPrimaryButtonVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CPrimaryButtonVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.PrimaryButtonVisible);
				_003CPrimaryButtonVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.PrimaryButtonVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ImageSource
	{
		get
		{
			return _003CImageSource_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CImageSource_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ImageSource);
				_003CImageSource_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ImageSource);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CloseIconVisible
	{
		get
		{
			return _003CCloseIconVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CCloseIconVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.CloseIconVisible);
				_003CCloseIconVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.CloseIconVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SecondsUsed
	{
		get
		{
			return _003CSecondsUsed_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CSecondsUsed_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SecondsUsed);
				_003CSecondsUsed_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SecondsUsed);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int SecondsLeft
	{
		get
		{
			return _003CSecondsLeft_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CSecondsLeft_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SecondsLeft);
				_003CSecondsLeft_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SecondsLeft);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsTimerVisible
	{
		get
		{
			return _003CIsTimerVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsTimerVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsTimerVisible);
				_003CIsTimerVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsTimerVisible);
			}
		}
	}

	public bool ButtonsVisible => PrimaryButtonVisible || CancelButtonVisible;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand CloseCommand => closeCommand ?? (closeCommand = new RelayCommand(Close));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand AcceptCommand => acceptCommand ?? (acceptCommand = new AsyncRelayCommand(Accept));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CancelCommand => cancelCommand ?? (cancelCommand = new AsyncRelayCommand(Cancel));

	public event EventHandler CloseClicked
	{
		add
		{
			WeakEventManager.AddEventHandler(value, "CloseClicked");
		}
		remove
		{
			WeakEventManager.RemoveEventHandler(value, "CloseClicked");
		}
	}

	public void Initialize(AlertMessageType type, string title, string message)
	{
		base.PageId = type.ToString();
		Title = title;
		Message = message;
		PrimaryButtonVisible = false;
		CancelButtonVisible = false;
	}

	public void Initialize(AlertMessageType type, string title, string? message, string accept, string? cancel, bool invertCallToAction, Func<bool?, Task> resultAction, TimeSpan? autoHideDelay = null, string? imageSource = null, bool showCloseIcon = false)
	{
		base.PageId = type.ToString();
		Title = title;
		Message = message;
		AcceptButtonText = accept;
		CancelButtonText = cancel;
		ImageSource = imageSource;
		CloseIconVisible = showCloseIcon;
		_invertCallToAction = invertCallToAction;
		_resultAction = resultAction;
		CancelButtonVisible = !string.IsNullOrEmpty(cancel);
		if (invertCallToAction)
		{
			AcceptButtonText = cancel;
			CancelButtonText = accept;
		}
		if (autoHideDelay.HasValue)
		{
			SecondsLeft = autoHideDelay.Value.Seconds;
			SecondsUsed = 0;
			IsTimerVisible = true;
			timerTime = autoHideDelay;
			timerTask = Task.Run((Func<Task?>)SetTimer);
		}
	}

	private async Task SetTimer()
	{
		if (!timerTime.HasValue)
		{
			return;
		}
		token = new CancellationTokenSource();
		timer = new PeriodicTimer(TimeSpan.FromSeconds(1L));
		try
		{
			while (await timer.WaitForNextTickAsync(token.Token))
			{
				SecondsLeft--;
				SecondsUsed++;
				if (SecondsUsed % 10 == 0)
				{
					base.A11YService.Speak(string.Format(CommonResources.Alg_SecondsToConfirmUpdate, SecondsLeft), 1000);
				}
				if (SecondsLeft == 0 && !_invoked && _resultAction != null)
				{
					Close();
					await _resultAction(null);
				}
			}
		}
		catch (TaskCanceledException)
		{
		}
	}

	protected override async Task OnAppearing()
	{
		await base.DialogService.Hide();
		await base.OnAppearing();
	}

	protected override Task OnDisappearing()
	{
		base.OnDisappearing();
		CloseTimer();
		return Task.CompletedTask;
	}

	public override bool OnBackButtonPressed()
	{
		return true;
	}

	[RelayCommand]
	protected void Close()
	{
		base.NavigationService.PopCurrentModalPage(animate: false);
		WeakEventManager.HandleEvent(this, EventArgs.Empty, "CloseClicked");
	}

	private void CloseTimer()
	{
		timer?.Dispose();
		token?.Dispose();
		timerTask?.Dispose();
	}

	[RelayCommand]
	private async Task Accept()
	{
		if (_resultAction != null)
		{
			await _resultAction(!_invertCallToAction);
			_invoked = true;
		}
	}

	[RelayCommand]
	private async Task Cancel()
	{
		if (_resultAction != null)
		{
			await _resultAction(_invertCallToAction);
			_invoked = true;
		}
	}
}
