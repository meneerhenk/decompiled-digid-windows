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
using DigiD.Common.Controls.Enums;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Pages.Pages;
using DigiD.Common.Pages.ViewModels;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Models;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG085ViewModel : CommonBaseViewModel
{
	private readonly IEIDApi api;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ButtonType _003CButtonType_003Ek__BackingField = ButtonType.Primary;

	private NfcScannerModel? _scannerModel;

	private PinCodeModel? _pinCodeModel;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private List<IStepModel>? _003CSteps_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CHeaderText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CButtonText_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString? _003CMessageText_003Ek__BackingField;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public List<IStepModel>? Steps
	{
		get
		{
			return _003CSteps_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<List<IStepModel>>.Default.Equals(_003CSteps_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Steps);
				_003CSteps_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Steps);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ButtonType ButtonType
	{
		get
		{
			return _003CButtonType_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ButtonType>.Default.Equals(_003CButtonType_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ButtonType);
				_003CButtonType_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ButtonType);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public new LocalizedString? HeaderText
	{
		get
		{
			return _003CHeaderText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CHeaderText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HeaderText);
				_003CHeaderText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HeaderText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public new LocalizedString? ButtonText
	{
		get
		{
			return _003CButtonText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CButtonText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ButtonText);
				_003CButtonText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ButtonText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public new LocalizedString? MessageText
	{
		get
		{
			return _003CMessageText_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CMessageText_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.MessageText);
				_003CMessageText_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.MessageText);
			}
		}
	}

	public DG085ViewModel(IEIDApi api)
	{
		this.api = api;
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		string document = EIDSession.Card.DocumentType.Translate().ToLower();
		List<IStepModel> steps = new List<IStepModel>
		{
			new EIDActivationStepModel("DG085_Step1_Title", "DG085_Step1_Text", document)
			{
				Index = 1,
				State = EIDActivationState.ReadCardState
			},
			new EIDActivationStepModel("DG085_Step2_Title", "DG085_Step2_Text", document)
			{
				Index = 2,
				State = EIDActivationState.EnterPin
			},
			new EIDActivationStepModel("DG085_Step3_Title", "DG085_Step3_Text", document)
			{
				Index = 3,
				State = EIDActivationState.EnterNewPin
			},
			new EIDActivationStepModel("DG085_Step4_Title", "DG085_Step4_Text", document)
			{
				Index = 4,
				State = EIDActivationState.Randomize
			}
		};
		Steps = steps;
		base.HasBackButton = false;
		base.CloseButtonVisible = true;
		HeaderText = new LocalizedString(() => base.ResourceManager["DG085_Title"]);
		ButtonText = new LocalizedString(() => base.ResourceManager["Alg_Next"]);
		MessageText = new LocalizedString(() => base.ResourceManager["DG085_Message", new object[1] { document }]);
	}

	protected override async Task CloseButtonClicked()
	{
		await api.CancelAuthenticate();
		HttpSession.WidSessionResponse = null;
		await base.ToastService.ShowWarning(string.Format(CommonResources.x_WIDCancelledMessage, EIDSession.Card?.DocumentType.Translate().ToLower()), null, popToRoot: false);
		EIDSession.Card = null;
		await base.NavigationService.PopToRootAsync();
	}

	public void Initialize(NfcScannerModel? nfcModel, PinCodeModel? pinCodeModel)
	{
		_scannerModel = nfcModel;
		_pinCodeModel = pinCodeModel;
		switch (EIDSession.ActivationState)
		{
		case EIDActivationState.ReadCardState:
			base.ButtonCommand = new AsyncRelayCommand((Func<Task>)delegate
			{
				EIDSession.TransportPINChange = false;
				EIDSession.ActivationState = EIDActivationState.ReadCardState;
				return base.NavigationService.NavigateAsync<DG079, DG079ViewModel>(delegate(DG079ViewModel vm79)
				{
					vm79.Initialize(() => base.NavigationService.NavigateAsync<DG051, DG051ViewModel>(delegate(DG051ViewModel dG051ViewModel)
					{
						dG051ViewModel.Initialize(_scannerModel);
					}));
				});
			});
			break;
		case EIDActivationState.EnterPin:
			base.ButtonCommand = new AsyncRelayCommand((Func<Task>)async delegate
			{
				if (_pinCodeModel == null)
				{
					await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
					await base.NavigationService.PopToRootAsync();
				}
				else
				{
					await base.NavigationService.NavigateAsync<DG086, DG086ViewModel>(delegate(DG086ViewModel vm)
					{
						vm.Initialize(_pinCodeModel);
					});
				}
			});
			break;
		case EIDActivationState.EnterNewPin:
			base.ButtonCommand = new AsyncRelayCommand((Func<Task>)async delegate
			{
				if (_pinCodeModel == null)
				{
					await base.ToastService.ShowError(CommonResources.Alg_UnknownErrorOccurred);
					await base.NavigationService.PopToRootAsync();
				}
				else
				{
					await base.NavigationService.NavigateAsync<PinCodePage, PinCodeViewModel>(delegate(PinCodeViewModel vm)
					{
						vm.IsCardAuthentication = true;
						vm.Initialize(_pinCodeModel);
					});
				}
			});
			break;
		case EIDActivationState.Randomize:
			base.ButtonCommand = new AsyncRelayCommand((Func<Task>)delegate
			{
				ArgumentNullException.ThrowIfNull(_scannerModel, "_scannerModel");
				return base.NavigationService.NavigateAsync<DG051, DG051ViewModel>(delegate(DG051ViewModel vm)
				{
					vm.Initialize(_scannerModel);
				});
			});
			break;
		case EIDActivationState.Completed:
			ButtonType = ButtonType.Green;
			base.ButtonCommand = new AsyncRelayCommand(base.NavigationService.PopToRootAsync);
			ButtonText = new LocalizedString(() => base.ResourceManager["Alg_Continue"]);
			break;
		}
	}
}
