using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Pages.Pages;
using DigiD.Common.Pages.ViewModels;
using DigiD.Common.RDA.Interfaces;
using DigiD.Common.RDA.Pages;
using Microsoft.Maui.Devices;
using WinRT;
using WinRT.DigiD_Common_RDAVtableClasses;

namespace DigiD.Common.RDA.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_RDA_ViewModels_DG078ViewModelWinRTTypeDetails))]
public class DG080ViewModel : RdaViewModel
{
	private readonly IRdaService rdaService;

	private Func<RdaResult, Task>? _completeAction;

	private RdaResult _result;

	private Func<Task>? _retryAction;

	private bool _stopScanning;

	private RdaSessionResponse? _session;

	private bool _initialized;

	private readonly IRdaApi api;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public DG080ViewModel(IRdaApi api, IRdaScanService rdaScanService, IPopupService popupService, IRdaService rdaService)
		: base(api, rdaScanService, popupService)
	{
		this.rdaService = rdaService;
		this.api = api;
		base.HasBackButton = true;
		base.CloseButtonVisible = true;
	}

	protected override async Task OnAppearing()
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		if (!_stopScanning)
		{
			if (DeviceInfo.Platform == DevicePlatform.Android && _initialized)
			{
				await Task.Delay(1000);
			}
			_initialized = true;
			await Initialize(_session, CompleteAction, base.DocumentType);
		}
	}

	public void Initialize(DocumentType documentType, RdaSessionResponse session, Func<RdaResult, Task> completeAction, Func<Task>? retryAction)
	{
		base.DocumentType = documentType;
		_session = session;
		_completeAction = completeAction;
		_retryAction = retryAction;
	}

	private async Task CompleteAction(RdaResult result)
	{
		if (result == RdaResult.Success || result == RdaResult.Failed)
		{
			_stopScanning = true;
		}
		else if (result == RdaResult.AuthenticationFailed)
		{
			_session = await rdaService.GetRdaSessionUrl();
		}
		_result = result;
		await NextAsync();
	}

	protected override Task RetryAction()
	{
		if (DeviceInfo.Platform == DevicePlatform.iOS)
		{
			_stopScanning = true;
		}
		return base.NavigationService.PushModalAsync<DG084, DG084ViewModel>(delegate(DG084ViewModel vm)
		{
			vm.Initialize(async delegate
			{
				if (await rdaService.RequestCancel())
				{
					await api.Cancel();
					_stopScanning = true;
					await base.NavigationService.PopCurrentModalPage();
					await _retryAction();
				}
			});
		});
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		ArgumentNullException.ThrowIfNull(_completeAction, "_completeAction");
		if (_result == RdaResult.Success)
		{
			await base.NavigationService.NavigateAsync<DG083, DG083ViewModel>(delegate(DG083ViewModel vm)
			{
				vm.Initialize(_completeAction);
			});
		}
		else
		{
			await _completeAction(_result);
		}
	}
}
