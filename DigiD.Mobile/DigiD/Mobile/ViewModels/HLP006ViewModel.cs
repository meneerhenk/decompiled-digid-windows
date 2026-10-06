using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class HLP006ViewModel : CommonBaseViewModel
{
	private readonly IEmailApi emailApi;

	private readonly IAlertService alertService;

	private RegisterEmailModel? _model;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? skipCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? newCodeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand SkipCommand => skipCommand ?? (skipCommand = new AsyncRelayCommand(SkipAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NewCodeCommand => newCodeCommand ?? (newCodeCommand = new AsyncRelayCommand(NewCodeAsync));

	public HLP006ViewModel(IEmailApi emailApi, IAlertService alertService)
	{
		this.emailApi = emailApi;
		this.alertService = alertService;
		base.PageId = "HLP006";
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
	}

	public void Initialize(RegisterEmailModel model)
	{
		_model = model;
	}

	protected override async Task CloseButtonClicked()
	{
		await base.NavigationService.PopCurrentModalPage();
	}

	[RelayCommand]
	private async Task SkipAsync()
	{
		if (await alertService.DisplayAlert(AlertMessageType.FM058) == true)
		{
			ArgumentNullException.ThrowIfNull(_model, "_model");
			await base.NavigationService.PopCurrentModalPage();
			if (_model.AbortAction != null)
			{
				await _model.AbortAction();
			}
			else
			{
				await _model.NextAction(arg: false);
			}
		}
	}

	[RelayCommand]
	private async Task NewCodeAsync()
	{
		ArgumentNullException.ThrowIfNull(_model, "_model");
		EmailRegisterResponse result = await emailApi.Register(_model.EmailAddress);
		if (result != null && result.ApiResult == ApiResult.Ok)
		{
			await alertService.DisplayAlert(AlertMessageType.FM057);
		}
		await base.NavigationService.PopCurrentModalPage();
	}
}
