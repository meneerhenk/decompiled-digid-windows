using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_CommonVtableClasses;

namespace DigiD.Common.BaseClasses;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_BaseClasses_BaseNfcViewModelWinRTTypeDetails))]
public class CommonBaseViewModel : ObservableObject, IViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasBackButton_003Ek__BackingField = true;

	protected readonly WeakEventManager WeakEventManager = new WeakEventManager();

	private DateTime? _lastTap;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICommand? _003CButtonCommand_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CPageId_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsError_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CHeaderText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CButtonText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CMessageText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsHeaderLogoVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsMenuImageVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CCloseButtonVisible_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? showMenuCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? backButtonPressedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? closeButtonClickCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? headerLogoClickedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? appearingCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? disappearingCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<NavigatedToEventArgs>? navigatedToCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<NavigatedFromEventArgs>? navigatedFromCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasBackButton
	{
		get
		{
			return _003CHasBackButton_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasBackButton_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.HasBackButton);
				_003CHasBackButton_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.HasBackButton);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ICommand? ButtonCommand
	{
		get
		{
			return _003CButtonCommand_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ICommand>.Default.Equals(_003CButtonCommand_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.ButtonCommand);
				_003CButtonCommand_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.ButtonCommand);
			}
		}
	}

	public IAsyncRelayCommand? DemoBarPressed { get; protected set; }

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string PageId
	{
		get
		{
			return _003CPageId_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CPageId_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.PageId);
				_003CPageId_003Ek__BackingField = value;
				OnPageIdChanged(value);
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.PageId);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsError
	{
		get
		{
			return _003CIsError_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsError_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.IsError);
				_003CIsError_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.IsError);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? HeaderText
	{
		get
		{
			return _003CHeaderText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CHeaderText_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.HeaderText);
				_003CHeaderText_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.HeaderText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ButtonText
	{
		get
		{
			return _003CButtonText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CButtonText_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.ButtonText);
				_003CButtonText_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.ButtonText);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("AccessibilityMessageText")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? MessageText
	{
		get
		{
			return _003CMessageText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CMessageText_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.MessageText);
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.AccessibilityMessageText);
				_003CMessageText_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.MessageText);
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.AccessibilityMessageText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsHeaderLogoVisible
	{
		get
		{
			return _003CIsHeaderLogoVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsHeaderLogoVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.IsHeaderLogoVisible);
				_003CIsHeaderLogoVisible_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.IsHeaderLogoVisible);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsMenuImageVisible
	{
		get
		{
			return _003CIsMenuImageVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsMenuImageVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.IsMenuImageVisible);
				_003CIsMenuImageVisible_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.IsMenuImageVisible);
			}
		}
	}

	public string AccessibilityMessageText => MessageText?.StripHtml() + ((IsError && !string.IsNullOrWhiteSpace(MessageText) && !MessageText.Contains(CommonResources.Alg_TryAgain)) ? (", " + CommonResources.Alg_TryAgain) : string.Empty);

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool CloseButtonVisible
	{
		get
		{
			return _003CCloseButtonVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CCloseButtonVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.CloseButtonVisible);
				_003CCloseButtonVisible_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.CloseButtonVisible);
			}
		}
	}

	protected INavigationService NavigationService { get; }

	protected IDialogService DialogService { get; }

	protected IMatomoService MatomoService { get; }

	protected IServiceProvider ServiceProvider { get; }

	protected IA11YService A11YService { get; }

	protected IToastService ToastService { get; }

	protected IGeneralPreferences GeneralPreferences { get; }

	public ILocalizationResourceManager ResourceManager { get; }

	protected IKeyboardService KeyboardService { get; set; }

	protected bool CanExecute { get; set; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ShowMenuCommand => showMenuCommand ?? (showMenuCommand = new AsyncRelayCommand(ShowMenu));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand BackButtonPressedCommand => backButtonPressedCommand ?? (backButtonPressedCommand = new AsyncRelayCommand(BackButtonPressed));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CloseButtonClickCommand => closeButtonClickCommand ?? (closeButtonClickCommand = new AsyncRelayCommand(CloseButtonClickAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand HeaderLogoClickedCommand => headerLogoClickedCommand ?? (headerLogoClickedCommand = new AsyncRelayCommand(HeaderLogoClickedAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand AppearingCommand => appearingCommand ?? (appearingCommand = new AsyncRelayCommand(AppearingAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand DisappearingCommand => disappearingCommand ?? (disappearingCommand = new AsyncRelayCommand(DisappearingAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<NavigatedToEventArgs> NavigatedToCommand => navigatedToCommand ?? (navigatedToCommand = new AsyncRelayCommand<NavigatedToEventArgs>(NavigatedToAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<NavigatedFromEventArgs> NavigatedFromCommand => navigatedFromCommand ?? (navigatedFromCommand = new AsyncRelayCommand<NavigatedFromEventArgs>(NavigatedFromAsync));

	public event EventHandler ChangeFocus
	{
		add
		{
			WeakEventManager.AddEventHandler(value, "ChangeFocus");
		}
		remove
		{
			WeakEventManager.RemoveEventHandler(value, "ChangeFocus");
		}
	}

	public CommonBaseViewModel()
	{
		ArgumentNullException.ThrowIfNull(Application.Current, "Application.Current");
		ServiceProvider = ((IApp)Application.Current).ServiceProvider;
		NavigationService = ServiceProvider.GetRequiredService<INavigationService>();
		MatomoService = ServiceProvider.GetRequiredService<IMatomoService>();
		DialogService = ServiceProvider.GetRequiredService<IDialogService>();
		A11YService = ServiceProvider.GetRequiredService<IA11YService>();
		ToastService = ServiceProvider.GetRequiredService<IToastService>();
		GeneralPreferences = ServiceProvider.GetRequiredService<IGeneralPreferences>();
		ResourceManager = ServiceProvider.GetRequiredService<ILocalizationResourceManager>();
		KeyboardService = ServiceProvider.GetRequiredService<IKeyboardService>();
		CanExecute = true;
		IsError = false;
		PageId = GetType().Name.Replace("ViewModel", string.Empty);
	}

	[RelayCommand]
	private Task ShowMenu()
	{
		if (_lastTap.HasValue)
		{
			DateTime now = DateTime.Now;
			DateTime? lastTap = _lastTap;
			if (now - lastTap < TimeSpan.FromSeconds(1L))
			{
				return Task.CompletedTask;
			}
		}
		_lastTap = DateTime.Now;
		return ShowMenuClicked();
	}

	[RelayCommand]
	private Task BackButtonPressed()
	{
		return BackButtonClicked();
	}

	[RelayCommand]
	private Task CloseButtonClickAsync()
	{
		return CloseButtonClicked();
	}

	[RelayCommand]
	private Task HeaderLogoClickedAsync()
	{
		return HeaderLogoClicked();
	}

	protected virtual Task HeaderLogoClicked()
	{
		return Task.CompletedTask;
	}

	protected virtual Task BackButtonClicked()
	{
		return NavigationService.PopAsync();
	}

	protected virtual Task ShowMenuClicked()
	{
		return Task.CompletedTask;
	}

	protected virtual async Task CloseButtonClicked()
	{
		await NavigationService.PopToRootAsync();
	}

	private void TrackView()
	{
		MatomoService.TrackScreen(PageId ?? "");
	}

	protected virtual Task EnterPressed()
	{
		return Task.CompletedTask;
	}

	private async void KeyboardServiceOnEnterPressed(object? sender, EventArgs e)
	{
		try
		{
			await EnterPressed();
		}
		catch
		{
		}
	}

	[RelayCommand]
	private Task AppearingAsync()
	{
		KeyboardService.EnterPressed -= KeyboardServiceOnEnterPressed;
		KeyboardService.EnterPressed += KeyboardServiceOnEnterPressed;
		try
		{
			return OnAppearing();
		}
		catch (Exception)
		{
			return Task.CompletedTask;
		}
	}

	[RelayCommand]
	private Task DisappearingAsync()
	{
		KeyboardService.EnterPressed -= KeyboardServiceOnEnterPressed;
		try
		{
			return OnDisappearing();
		}
		catch (Exception)
		{
			return Task.CompletedTask;
		}
	}

	[RelayCommand]
	private Task NavigatedToAsync(NavigatedToEventArgs args)
	{
		try
		{
			return OnNavigatingTo(args);
		}
		catch (Exception)
		{
			return Task.CompletedTask;
		}
	}

	[RelayCommand]
	private Task NavigatedFromAsync(NavigatedFromEventArgs args)
	{
		try
		{
			return OnNavigatedFrom(args);
		}
		catch (Exception)
		{
			return Task.CompletedTask;
		}
	}

	protected virtual Task OnNavigatedFrom(NavigatedFromEventArgs args)
	{
		return Task.CompletedTask;
	}

	protected virtual Task OnNavigatingTo(NavigatedToEventArgs args)
	{
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			A11YService.NotifyForNewPage();
		}
		return Task.CompletedTask;
	}

	protected virtual Task OnAppearing()
	{
		return Task.CompletedTask;
	}

	protected virtual Task OnDisappearing()
	{
		return Task.CompletedTask;
	}

	public virtual bool OnBackButtonPressed()
	{
		return !HasBackButton;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnPageIdChanged(string value)
	{
		TrackView();
	}
}
