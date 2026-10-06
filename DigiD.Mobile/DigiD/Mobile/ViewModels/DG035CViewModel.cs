using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG035CViewModel : CommonBaseViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CNotificationsEnabled_003Ek__BackingField = true;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CTwoFactorEnabled_003Ek__BackingField = true;

	private readonly IAccountInformationApi accountInformationApi;

	private readonly IAlertService alertService;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<bool>? twoFactorChangedCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool NotificationsEnabled
	{
		get
		{
			return _003CNotificationsEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CNotificationsEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.NotificationsEnabled);
				_003CNotificationsEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.NotificationsEnabled);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool TwoFactorEnabled
	{
		get
		{
			return _003CTwoFactorEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CTwoFactorEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TwoFactorEnabled);
				_003CTwoFactorEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TwoFactorEnabled);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<bool> TwoFactorChangedCommand => twoFactorChangedCommand ?? (twoFactorChangedCommand = new AsyncRelayCommand<bool>(TwoFactorChangedAsync));

	public DG035CViewModel(IAccountInformationApi accountInformationApi, IAlertService alertService)
	{
		base.CloseButtonVisible = true;
		this.accountInformationApi = accountInformationApi;
		this.alertService = alertService;
	}

	private async Task Set(bool value)
	{
		if (await accountInformationApi.SetTwoFactor(value) != ApiResult.Ok)
		{
			TwoFactorEnabled = !value;
		}
		else
		{
			TwoFactorEnabled = value;
		}
	}

	[RelayCommand]
	private async Task TwoFactorChangedAsync(bool value)
	{
		if (!value)
		{
			if (!(await alertService.DisplayAlert(AlertMessageType.FM059)) == true)
			{
				TwoFactorEnabled = true;
				return;
			}
			PinCodeModel model = new PinCodeModel(PinEntryType.Authentication)
			{
				MessageText = new LocalizedString(() => base.ResourceManager["DG035C_PinConfirmText"]),
				HasBackButton = false,
				BiometricEnabled = false,
				NextAction = async delegate
				{
					await Set(value: false);
					await base.NavigationService.PopCurrentModalPage();
				},
				CancelAction = delegate
				{
					TwoFactorEnabled = true;
					return base.NavigationService.PopCurrentModalPage();
				}
			};
			await base.NavigationService.PushModalAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
			{
				vm.Initialize(model);
			});
		}
		else
		{
			await Set(value: true);
		}
	}
}
