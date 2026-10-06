using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG033ViewModel : CommonBaseViewModel
{
	private readonly IAlertService alertService;

	private readonly IEmailApi emailApi;

	private RegisterEmailModel? _model;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CEmailAddress_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? registerCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? skipCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValid")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? EmailAddress
	{
		get
		{
			return _003CEmailAddress_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CEmailAddress_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.EmailAddress);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValid);
				_003CEmailAddress_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.EmailAddress);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValid);
			}
		}
	}

	public bool IsValid => !string.IsNullOrEmpty(EmailAddress) && EmailAddressRegex().IsMatch(EmailAddress);

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand RegisterCommand => registerCommand ?? (registerCommand = new AsyncRelayCommand(RegisterAsync, () => IsValid));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SkipCommand => skipCommand ?? (skipCommand = new AsyncRelayCommand(SkipAsync));

	[GeneratedRegex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])")]
	[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.42308")]
	private static Regex EmailAddressRegex()
	{
		return _003CRegexGenerator_g_003EF67D0EC8C2AE65A6E7E88A34D2B97BEE634E814A5B5289ADB41109CE940307C54__EmailAddressRegex_0.Instance;
	}

	public DG033ViewModel(IAlertService alertService, IEmailApi emailApi)
	{
		base.PageId = "DG033";
		this.alertService = alertService;
		this.emailApi = emailApi;
	}

	public void Initialize(RegisterEmailModel model, bool hasBackButton = true)
	{
		_model = model;
		base.HasBackButton = hasBackButton;
	}

	[RelayCommand(CanExecute = "IsValid")]
	private async Task RegisterAsync()
	{
		base.DialogService.Show();
		EmailRegisterResponse result = await emailApi.Register(EmailAddress);
		switch (result.ApiResult)
		{
		case ApiResult.Ok:
			_model.EmailAddress = result.EmailAddress;
			await base.NavigationService.NavigateAsync<DG034, DG034ViewModel>(delegate(DG034ViewModel vm)
			{
				vm.Initialize(_model);
			});
			break;
		case ApiResult.Nok:
			switch (result.ErrorMessage)
			{
			case "too_many_emails":
				await alertService.DisplayAlert(AlertMessageType.FM047);
				break;
			case "email_address_maximum_reached":
				await alertService.DisplayAlert(AlertMessageType.FM045);
				break;
			case "email_already_verified":
				await alertService.DisplayAlert(AlertMessageType.FM046);
				break;
			}
			await ContinueAfterEmailRegistration(success: false);
			break;
		}
		await base.DialogService.Hide();
	}

	private async Task ContinueAfterEmailRegistration(bool success)
	{
		if (_model.AbortAction != null)
		{
			await _model.AbortAction();
		}
		else
		{
			await _model.NextAction(success);
		}
	}

	[RelayCommand]
	private async Task SkipAsync()
	{
		if (await alertService.DisplayAlert(AlertMessageType.FM056) == true)
		{
			await emailApi.Register(null);
			await ContinueAfterEmailRegistration(success: false);
		}
	}
}
