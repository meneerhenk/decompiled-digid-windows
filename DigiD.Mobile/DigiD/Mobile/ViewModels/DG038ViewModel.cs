using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using Plugin.Maui.BottomSheet.Navigation;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG038ViewModel : BaseLoginConfirmViewModel
{
	private readonly IBottomSheetNavigationService? _bottomSheetNavigationService;

	private readonly IPopupService _popupService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CAppIcon_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsEHASession_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openEHAExplanationCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("AppIconVisible")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? AppIcon
	{
		get
		{
			return _003CAppIcon_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CAppIcon_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.AppIcon);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.AppIconVisible);
				_003CAppIcon_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.AppIcon);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.AppIconVisible);
			}
		}
	}

	public bool AppIconVisible => AppIcon != null;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsEHASession
	{
		get
		{
			return _003CIsEHASession_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsEHASession_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsEHASession);
				_003CIsEHASession_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsEHASession);
			}
		}
	}

	public string? CustomerName
	{
		get
		{
			WebSessionInfoResponse webSessionInfoResponse = HttpSession.WebSessionInfoResponse;
			if (webSessionInfoResponse != null && webSessionInfoResponse.IsOidcSession)
			{
				return HttpSession.WebSessionInfoResponse.WebService;
			}
			if (!string.IsNullOrEmpty(App2AppSession.AppIconUrl))
			{
				return App2AppSession.App?.Name;
			}
			return (HttpSession.WidSessionResponse != null) ? HttpSession.WidSessionResponse.WebService : HttpSession.WebSessionInfoResponse?.WebService;
		}
	}

	public string? IDCheckWillExpireMessage { get; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenEHAExplanationCommand => openEHAExplanationCommand ?? (openEHAExplanationCommand = new AsyncRelayCommand(OpenEHAExplanation));

	public DG038ViewModel(IAlertService alertService, IGeneralApi generalApi, IMobileSettings mobileSettings, IEIDApi eIdApi, IAuthenticationApi authenticationApi, IDialogService dialogService, IEmailService emailService, ISessionService sessionService, IApp2AppService app2AppService, IAuthenticationService authenticationService, IAppService appService, IRemoteNotificationService remoteNotificationService, IConfirmService confirmService, IMatomoService matomoService, IPopupService popupService, IDeviceLockService deviceLockService, ISignerService signerService, IBottomSheetNavigationService? bottomSheetNavigationService = null)
		: base(alertService, generalApi, mobileSettings, eIdApi, authenticationApi, dialogService, emailService, sessionService, app2AppService, authenticationService, appService, remoteNotificationService, confirmService, AlertMessageType.FM003, matomoService, deviceLockService, signerService)
	{
		_bottomSheetNavigationService = bottomSheetNavigationService;
		_popupService = popupService;
		IsEHASession = HttpSession.WebSessionInfoResponse is PendingSessionResponse;
		AppIcon = HttpSession.WebSessionInfoResponse?.IconUri ?? App2AppSession.AppIconUrl;
		WebSessionInfoResponse? webSessionInfoResponse = HttpSession.WebSessionInfoResponse;
		if (webSessionInfoResponse != null && webSessionInfoResponse.AuthenticationLevel == LoginLevel.Substantieel && HttpSession.WillIDCheckExpire)
		{
			string arg = HttpSession.SubExpiryDate?.ToString("d", DigiDAppResources.Culture);
			if (HttpSession.SubExpiryDate <= DateTime.Now.Date)
			{
				IDCheckWillExpireMessage = DigiDAppResources.DG038_IDCheckExpireSoonWarningMessage;
			}
			else
			{
				IDCheckWillExpireMessage = string.Format(DigiDAppResources.DG038_IDCheckExpireWarningMessage, arg);
			}
		}
	}

	protected override Task ContinueNfc(ConfirmResponse? response = null)
	{
		ArgumentNullException.ThrowIfNull(HttpSession.WidSessionResponse, "HttpSession.WidSessionResponse");
		NfcScannerModel model = new NfcScannerModel(PinEntryType.Authentication)
		{
			EIDSessionResponse = HttpSession.WidSessionResponse,
			NeedAppDeactivation = (response?.NeedDeactivation ?? false)
		};
		return base.NavigationService.NavigateAsync<DG051, DG051ViewModel>(delegate(DG051ViewModel vm)
		{
			vm.Initialize(model);
		});
	}

	protected override Task Dismiss()
	{
		if (_bottomSheetNavigationService != null)
		{
			return _bottomSheetNavigationService.ClearBottomSheetStackAsync();
		}
		return Task.CompletedTask;
	}

	[RelayCommand]
	private async Task OpenEHAExplanation()
	{
		await _popupService.OpenBottomSheet("HLP14", DigiDAppResources.HLP14_Title, DigiDAppResources.HLP14_Message);
	}
}
