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
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Mobile.Pages;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG007ViewModel(IEnrollmentApi enrollmentApi) : CommonBaseViewModel()
{
	private bool _pollingActive = true;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CQrCode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CQrCodeData_003Ek__BackingField;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? QrCode
	{
		get
		{
			return _003CQrCode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CQrCode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.QrCode);
				_003CQrCode_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.QrCode);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? QrCodeData
	{
		get
		{
			return _003CQrCodeData_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CQrCodeData_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.QrCodeData);
				_003CQrCodeData_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.QrCodeData);
			}
		}
	}

	public void Initialize(StartSessionResponse response)
	{
		QrCode = $"digid-app-auth://app_session_id={response.AppSessionId}&host={base.GeneralPreferences.SelectedHost}&verification_code={response.VerificationCode}";
	}

	protected override Task OnAppearing()
	{
		Task.Run((Func<Task?>)StartTimer);
		return base.OnAppearing();
	}

	protected override Task OnDisappearing()
	{
		_pollingActive = false;
		return base.OnDisappearing();
	}

	private async Task StartTimer()
	{
		AuthenticationStatusResponse statusResponse = await enrollmentApi.ActivationByAppPolling();
		PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(1L));
		while (true)
		{
			bool pollingActive = _pollingActive;
			bool flag = pollingActive;
			if (flag)
			{
				flag = await timer.WaitForNextTickAsync();
			}
			if (!flag || statusResponse == null || statusResponse.ApiResult != ApiResult.Pending || statusResponse.SessionReceived)
			{
				break;
			}
			statusResponse = await enrollmentApi.ActivationByAppPolling();
		}
		timer.Dispose();
		if (_pollingActive)
		{
			await MainThread.InvokeOnMainThreadAsync(async delegate
			{
				await base.NavigationService.NavigateAsync<DG008>();
			});
		}
	}
}
