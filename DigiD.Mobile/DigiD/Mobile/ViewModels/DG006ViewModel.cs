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
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG006ViewModel : CommonBaseViewModel
{
	private readonly IEnrollmentApi enrollmentApi;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CCode_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openHelpCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? startSessionCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValid")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Code
	{
		get
		{
			return _003CCode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CCode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Code);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValid);
				_003CCode_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Code);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValid);
			}
		}
	}

	public bool IsValid
	{
		get
		{
			string code = Code;
			return code != null && code.Length == 4;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenHelpCommand => openHelpCommand ?? (openHelpCommand = new AsyncRelayCommand(OpenHelpAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand StartSessionCommand => startSessionCommand ?? (startSessionCommand = new AsyncRelayCommand(StartSessionAsync, () => IsValid));

	public DG006ViewModel(IEnrollmentApi enrollmentApi)
	{
		this.enrollmentApi = enrollmentApi;
		base.CloseButtonVisible = true;
		if (base.A11YService.IsInVoiceOverMode)
		{
			Code = string.Empty;
		}
	}

	protected override Task EnterPressed()
	{
		if (IsValid)
		{
			return StartSessionAsync();
		}
		return Task.CompletedTask;
	}

	[RelayCommand]
	private async Task OpenHelpAsync()
	{
		await base.NavigationService.PushModalAsync<HLP003>();
	}

	[RelayCommand(CanExecute = "IsValid")]
	private async Task StartSessionAsync()
	{
		ArgumentNullException.ThrowIfNull(Code, "Code");
		StartSessionResponse sessionResponse = await enrollmentApi.InitSessionActivationByApp();
		if (sessionResponse.ApiResult == ApiResult.Ok)
		{
			HttpSession.AppSessionId = sessionResponse.AppSessionId;
			sessionResponse.VerificationCode = Code;
			HttpSession.ActivationSessionData = new ActivationSessionData
			{
				ActivationMethod = ActivationMethod.App
			};
			await base.NavigationService.NavigateAsync<DG007, DG007ViewModel>(delegate(DG007ViewModel vm)
			{
				vm.Initialize(sessionResponse);
			});
		}
		else
		{
			await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
		}
	}
}
