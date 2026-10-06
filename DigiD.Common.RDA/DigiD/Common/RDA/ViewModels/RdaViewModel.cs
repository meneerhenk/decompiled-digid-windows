using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Preferences;
using DigiD.Common.RDA.Enums;
using DigiD.Common.RDA.Interfaces;
using DigiD.Common.Resources;
using DigiD.Common.Resources.Enums;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Devices;

namespace DigiD.Common.RDA.ViewModels;

public abstract class RdaViewModel(IRdaApi api, IRdaScanService rdaScanService, IPopupService popupService) : BaseNfcViewModel()
{
	private const string InitialPageId = "DG080";

	private const string ScanningPageId = "DG081";

	private const string DisconnectPageId = "DG082";

	private Func<RdaResult, Task>? _completeAction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CAnimationVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CImageSource_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? startScanCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("ImageVisible")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool AnimationVisible
	{
		get
		{
			return _003CAnimationVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CAnimationVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.AnimationVisible);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ImageVisible);
				_003CAnimationVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.AnimationVisible);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ImageVisible);
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

	public bool ImageVisible => !AnimationVisible;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand StartScanCommand => startScanCommand ?? (startScanCommand = new AsyncRelayCommand(StartScanAsync));

	protected abstract Task RetryAction();

	protected async Task Initialize(RdaSessionResponse session, Func<RdaResult, Task> completeAction, DocumentType documentType)
	{
		if (session == null)
		{
			throw new ArgumentException("RDA Session is required", "session");
		}
		_completeAction = completeAction;
		base.DocumentType = documentType;
		rdaScanService.Initialize(StatusChanged, base.ProgressChanged, new RdaSession(session));
		base.PageId = "DG080";
		base.MatomoService.TrackScreen(base.PageId);
		base.CloseButtonVisible = true;
		CancelAsync = new AsyncRelayCommand<bool>(async delegate(bool retry)
		{
			await NfcService.StopScanningAsync();
			if (retry)
			{
				await RetryAction();
			}
		});
		OnPropertyChanged("CancelButtonVisible");
		await Initialize();
	}

	[RelayCommand]
	private async Task StartScanAsync()
	{
		await rdaScanService.StartScanning(base.DocumentType);
	}

	protected override async Task CloseButtonClicked()
	{
		bool? result = await popupService.DisplayAlert(CommonResources.x_UpgradeRDACancelHeader, CommonResources.x_UpgradeRDACancelMessage, CommonResources.Alg_Yes, CommonResources.Alg_No);
		if (result.HasValue && result.Value)
		{
			await NfcService.StopScanningAsync();
			if (AppSession.Process != Process.UpgradeAndAuthenticate)
			{
				await api.Cancel();
			}
			ArgumentNullException.ThrowIfNull(_completeAction, "_completeAction");
			await _completeAction(RdaResult.Cancelled);
		}
	}

	private async Task Initialize(bool retry = false, bool autostartScan = true)
	{
		if (!(DeviceInfo.Platform == DevicePlatform.Android && retry) || (int)base.ProgressValue != 1)
		{
			base.ProgressVisible = false;
			base.ProgressValue = 0.0;
			AnimationVisible = true;
			if (retry && HttpSession.ActivationSessionData != null && DeviceInfo.Platform == DevicePlatform.iOS)
			{
				await NfcService.StopScanningAsync();
			}
			if (autostartScan)
			{
				await rdaScanService.StartScanning(base.DocumentType);
			}
		}
	}

	private async Task StatusChanged(RdaStatus status)
	{
		switch (status)
		{
		case RdaStatus.ReadingStarted:
			if (base.PageId != "DG081")
			{
				base.PageId = "DG081";
			}
			base.ProgressVisible = true;
			base.A11YService.Speak(string.Format(CultureInfo.InvariantCulture, CommonResources.x_ReadDocument, CommonResources.eID.ToLowerInvariant()));
			AnimationVisible = false;
			ImageSource = ((AppSession.Process == Process.IDChecker) ? "idchecker_afbeelding_idchecker_read_document" : "afbeelding_read_document");
			break;
		case RdaStatus.ReadingCompleted:
			base.ProgressValue = 1.0;
			await MainThread.InvokeOnMainThreadAsync((Func<Task>)GetStatus);
			break;
		case RdaStatus.ReadingCancelled:
			CancelAsync?.ExecuteAsync(parameter: false);
			break;
		case RdaStatus.ReadingFailed:
		case RdaStatus.AuthenticationFailed:
		case RdaStatus.UnknownCard:
		{
			ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
			if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.RequestNewDigidAccount)
			{
				await RetryAction();
			}
			else
			{
				await HandleFailed(status);
			}
			break;
		}
		case RdaStatus.CardLost:
			if (base.PageId != "DG082")
			{
				base.PageId = "DG082";
			}
			if (DeviceInfo.Platform == DevicePlatform.iOS)
			{
				await NfcService.StopScanningAsync(string.Format(CommonResources.DG080_Text_iOS_Overlay_Disconnected, base.DocumentType.Translate().ToLower()));
			}
			await Initialize(retry: true, DeviceInfo.Platform == DevicePlatform.Android);
			break;
		default:
			if (AppSession.Process == Process.UpgradeAndAuthenticate)
			{
				await HandleFailed(RdaStatus.AuthenticationFailed);
			}
			else
			{
				await base.ToastService.ShowWarning(CommonResources.x_UpgradeAccountWithNFCFailedMessage);
			}
			break;
		}
	}

	private async Task HandleFailed(RdaStatus status)
	{
		await NfcService.StopScanningAsync();
		if (status == RdaStatus.AuthenticationFailed)
		{
			ArgumentNullException.ThrowIfNull(_completeAction, "_completeAction");
			if (Localization.AppType == AppType.CheckID)
			{
				await _completeAction(RdaResult.Failed);
			}
			else
			{
				await _completeAction(RdaResult.AuthenticationFailed);
			}
		}
	}

	private async Task GetStatus()
	{
		base.DialogService.Show();
		ApiResult status;
		for (status = await api.Verified(); status == ApiResult.Pending; status = await api.Verified())
		{
			await Task.Delay(500);
		}
		await base.DialogService.Hide();
		if (status == ApiResult.Ok && Localization.AppType != AppType.CheckID)
		{
			IMobileSettings settings = base.ServiceProvider.GetRequiredService<IMobileSettings>();
			settings.LoginLevel = LoginLevel.Substantieel;
			ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
			settings.ActivationStatus = ((activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.RequestNewDigidAccount) ? ActivationStatus.Pending : ActivationStatus.Activated);
			if (DemoSettings.IsDemoModeEnabled)
			{
				DemoConfig.SubExpiryDate = DateTime.Now.Date.AddYears(1);
			}
			AppSession.IsAppActivated = settings.ActivationStatus == ActivationStatus.Activated;
			AppSession.ActivationStatus = settings.ActivationStatus;
		}
		ArgumentNullException.ThrowIfNull(_completeAction, "_completeAction");
		await _completeAction((status == ApiResult.Ok) ? RdaResult.Success : RdaResult.Failed);
	}
}
