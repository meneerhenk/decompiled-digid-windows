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
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Resources;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG034ViewModel(IEmailApi emailApi, IAlertService alertService) : CommonBaseViewModel()
{
	private RegisterEmailModel? _model;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CCode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CErrorMessage_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? validateCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? noMailReceivedCommand;

	public static string InitialChar => "E";

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

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ErrorMessage
	{
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CErrorMessage_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ErrorMessage);
				_003CErrorMessage_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ErrorMessage);
			}
		}
	}

	public bool IsValid
	{
		get
		{
			if (Code != null)
			{
				if (Code.StartsWith(InitialChar, StringComparison.CurrentCultureIgnoreCase))
				{
					return Code.Length == 9;
				}
				string code = Code;
				return code != null && code.Length == 8;
			}
			return false;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ValidateCodeCommand => validateCodeCommand ?? (validateCodeCommand = new AsyncRelayCommand(ValidateCode, () => IsValid));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NoMailReceivedCommand => noMailReceivedCommand ?? (noMailReceivedCommand = new AsyncRelayCommand(NoMailReceivedAsync));

	public void Initialize(RegisterEmailModel model)
	{
		_model = model;
		Code = (base.A11YService.IsInVoiceOverMode ? InitialChar : string.Empty);
		base.MessageText = _model.EmailAddress;
	}

	[RelayCommand(CanExecute = "IsValid")]
	private async Task ValidateCode()
	{
		ArgumentNullException.ThrowIfNull(_model, "_model");
		ArgumentNullException.ThrowIfNull(Code, "Code");
		string _code = Code.ToUpper();
		if (!_code.StartsWith(InitialChar))
		{
			_code = (InitialChar + Code).ToUpper();
		}
		EmailVerifyResponse result = await emailApi.Verify(_code);
		if (result.ApiResult == ApiResult.Ok)
		{
			await _model.NextAction(arg: true);
			return;
		}
		switch (result.ErrorMessage)
		{
		case "code_incorrect":
			Code = (base.A11YService.IsInVoiceOverMode ? InitialChar : string.Empty);
			base.IsError = true;
			ErrorMessage = string.Format(CommonResources.FM048_Melding, result.RemainingAttempts);
			break;
		case "code_blocked":
			await alertService.DisplayAlert(AlertMessageType.FM050);
			if (_model.AbortAction != null)
			{
				await _model.AbortAction();
			}
			else
			{
				await _model.NextAction(arg: false);
			}
			break;
		case "code_invalid":
			Code = (base.A11YService.IsInVoiceOverMode ? InitialChar : string.Empty);
			base.IsError = true;
			ErrorMessage = CommonResources.FM049_Melding;
			break;
		}
		if (base.IsError && !string.IsNullOrEmpty(ErrorMessage))
		{
			base.A11YService.Speak(ErrorMessage, 1000);
			WeakEventManager.HandleEvent(this, EventArgs.Empty, "ChangeFocus");
		}
	}

	[RelayCommand]
	private async Task NoMailReceivedAsync()
	{
		ArgumentNullException.ThrowIfNull(_model, "_model");
		await base.NavigationService.PushModalAsync<HLP006, HLP006ViewModel>(delegate(HLP006ViewModel vm)
		{
			vm.Initialize(_model);
		});
	}
}
