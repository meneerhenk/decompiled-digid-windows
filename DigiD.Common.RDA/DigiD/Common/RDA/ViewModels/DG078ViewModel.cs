using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Pages.Pages;
using DigiD.Common.Pages.ViewModels;
using DigiD.Common.RDA.Pages;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using WinRT;
using WinRT.DigiD_Common_RDAVtableClasses;

namespace DigiD.Common.RDA.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_RDA_ViewModels_DG078ViewModelWinRTTypeDetails))]
public class DG078ViewModel : CommonBaseViewModel
{
	private readonly IRdaApi api;

	private readonly IRdaService rdaService;

	private readonly IPopupService _popupService;

	private RdaSessionResponse? _session;

	private Func<RdaResult, Task>? _completeAction;

	private Func<Task>? _retryAction;

	private Func<Task>? _cancelAction;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<DocumentType>? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? openBottomSheetCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<DocumentType> NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand<DocumentType>(NextAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand OpenBottomSheetCommand => openBottomSheetCommand ?? (openBottomSheetCommand = new AsyncRelayCommand(OpenBottomSheet));

	public DG078ViewModel(IRdaApi api, IRdaService rdaService, IPopupService popupService)
	{
		this.api = api;
		this.rdaService = rdaService;
		_popupService = popupService;
		base.CloseButtonVisible = true;
	}

	protected override async Task CloseButtonClicked()
	{
		if (_cancelAction != null)
		{
			await _cancelAction();
			return;
		}
		await api.Cancel();
		await base.CloseButtonClicked();
	}

	public void Initialize(RdaSessionResponse session, Func<RdaResult, Task> completeAction, Func<Task>? retryAction, Func<Task>? cancelAction)
	{
		_session = session;
		_completeAction = completeAction;
		_retryAction = retryAction;
		_cancelAction = cancelAction;
	}

	[RelayCommand]
	private Task NextAsync(DocumentType documentType)
	{
		ArgumentNullException.ThrowIfNull(_completeAction, "_completeAction");
		ArgumentNullException.ThrowIfNull(_session, "_session");
		base.MatomoService.TrackAction("RDA", "Scan NFC", documentType.ToString());
		return base.NavigationService.NavigateAsync<DG079, DG079ViewModel>(delegate(DG079ViewModel vm)
		{
			vm.Initialize(documentType, () => OpenDG080(documentType), _cancelAction);
		});
	}

	private Task OpenDG080(DocumentType documentType)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		ArgumentNullException.ThrowIfNull(_completeAction, "_completeAction");
		return base.NavigationService.NavigateAsync<DG080, DG080ViewModel>(delegate(DG080ViewModel vm)
		{
			vm.Initialize(documentType, _session, _completeAction, _retryAction);
		});
	}

	[RelayCommand]
	private Task OpenBottomSheet()
	{
		if (HttpSession.ActivationSessionData != null)
		{
			return _popupService.OpenBottomSheet("HLP15a", CommonResources.DG078_BottomSheet_Title, CommonResources.DG078_BottomSheet_Message, CommonResources.DG078_BottomSheet_ButtonText, async delegate
			{
				if (await rdaService.RequestCancel())
				{
					await _retryAction();
				}
			}, actionAsButton: true, firstCloseThenExecuteAction: true);
		}
		return _popupService.OpenBottomSheet("HLP15b", CommonResources.DG078_BottomSheet_Title, CommonResources.DG078_BottomSheet_MessageWithoutEscape);
	}
}
