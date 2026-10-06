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
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DM002ViewModel : CommonBaseViewModel
{
	private readonly IAppService appService;

	private const string DefaultPin = "12345";

	private const string ActivationMethodAccountAndApp = "Account";

	private const string ActivationMethodPassword = "Password";

	private const string ActivationMethodSMS = "SMS";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CPin_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CTries_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CChangePinRequired_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsBlocked_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsSuspended_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasMessages_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CTwoFactorEnabled_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsEmailAddressVerified_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasEmailAddress_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CUserActionNeeded_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CEIDASUser_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CEIDASSuccess_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CRdaFailed_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasNoDocuments_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsSmsCheckRequested_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsEHAEnabled_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CActivationMethod_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsClassifiedDeceased_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasPendingActivation_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasNfc_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private VersionState _003CVersionState_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasNFCSupport_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsTrafficMeteringEnabled_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasTooManyActiveDevices_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsHealthCheckSuccess_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsMaintenanceModeEnabled_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NfcPosition _003CNfcPosition_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsKeyAttestationSuccess_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CNeedSubInFuture_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DateTime? _003CSubExpiryDate_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsDateSelectorOpen_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ButtonType _003CTabAccountButtonType_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ButtonType _003CTabCardButtonType_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CTabAccountSelected_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CTabCardSelected_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsEasterEggEnabled_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? resetCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? closeCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? deactivateCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? changeActivationMethodCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? changeVersionCheckResponseCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? changeNfcLocationCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<string>? tabSelectedCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? clearSubExpiryDateCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? openDateSelectorCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Pin
	{
		get
		{
			return _003CPin_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CPin_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Pin);
				_003CPin_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Pin);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int Tries
	{
		get
		{
			return _003CTries_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CTries_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Tries);
				_003CTries_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Tries);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool ChangePinRequired
	{
		get
		{
			return _003CChangePinRequired_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CChangePinRequired_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ChangePinRequired);
				_003CChangePinRequired_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ChangePinRequired);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsBlocked
	{
		get
		{
			return _003CIsBlocked_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsBlocked_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsBlocked);
				_003CIsBlocked_003Ek__BackingField = value;
				OnIsBlockedChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsBlocked);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsSuspended
	{
		get
		{
			return _003CIsSuspended_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsSuspended_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsSuspended);
				_003CIsSuspended_003Ek__BackingField = value;
				OnIsSuspendedChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsSuspended);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasMessages
	{
		get
		{
			return _003CHasMessages_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasMessages_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasMessages);
				_003CHasMessages_003Ek__BackingField = value;
				OnHasMessagesChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasMessages);
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

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsEmailAddressVerified
	{
		get
		{
			return _003CIsEmailAddressVerified_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsEmailAddressVerified_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsEmailAddressVerified);
				_003CIsEmailAddressVerified_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsEmailAddressVerified);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasEmailAddress
	{
		get
		{
			return _003CHasEmailAddress_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasEmailAddress_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasEmailAddress);
				_003CHasEmailAddress_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasEmailAddress);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool UserActionNeeded
	{
		get
		{
			return _003CUserActionNeeded_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CUserActionNeeded_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.UserActionNeeded);
				_003CUserActionNeeded_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.UserActionNeeded);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool EIDASUser
	{
		get
		{
			return _003CEIDASUser_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CEIDASUser_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.EIDASUser);
				_003CEIDASUser_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.EIDASUser);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool EIDASSuccess
	{
		get
		{
			return _003CEIDASSuccess_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CEIDASSuccess_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.EIDASSuccess);
				_003CEIDASSuccess_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.EIDASSuccess);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool RdaFailed
	{
		get
		{
			return _003CRdaFailed_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CRdaFailed_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.RdaFailed);
				_003CRdaFailed_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.RdaFailed);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasNoDocuments
	{
		get
		{
			return _003CHasNoDocuments_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasNoDocuments_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasNoDocuments);
				_003CHasNoDocuments_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasNoDocuments);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsSmsCheckRequested
	{
		get
		{
			return _003CIsSmsCheckRequested_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsSmsCheckRequested_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsSmsCheckRequested);
				_003CIsSmsCheckRequested_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsSmsCheckRequested);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsEHAEnabled
	{
		get
		{
			return _003CIsEHAEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsEHAEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsEHAEnabled);
				_003CIsEHAEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsEHAEnabled);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ActivationMethod
	{
		get
		{
			return _003CActivationMethod_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CActivationMethod_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ActivationMethod);
				_003CActivationMethod_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ActivationMethod);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsClassifiedDeceased
	{
		get
		{
			return _003CIsClassifiedDeceased_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsClassifiedDeceased_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsClassifiedDeceased);
				_003CIsClassifiedDeceased_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsClassifiedDeceased);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasPendingActivation
	{
		get
		{
			return _003CHasPendingActivation_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasPendingActivation_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasPendingActivation);
				_003CHasPendingActivation_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasPendingActivation);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasNfc
	{
		get
		{
			return _003CHasNfc_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasNfc_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasNfc);
				_003CHasNfc_003Ek__BackingField = value;
				OnHasNfcChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasNfc);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public VersionState VersionState
	{
		get
		{
			return _003CVersionState_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<VersionState>.Default.Equals(_003CVersionState_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.VersionState);
				_003CVersionState_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.VersionState);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasNFCSupport
	{
		get
		{
			return _003CHasNFCSupport_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasNFCSupport_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasNFCSupport);
				_003CHasNFCSupport_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasNFCSupport);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsTrafficMeteringEnabled
	{
		get
		{
			return _003CIsTrafficMeteringEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsTrafficMeteringEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsTrafficMeteringEnabled);
				_003CIsTrafficMeteringEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsTrafficMeteringEnabled);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HasTooManyActiveDevices
	{
		get
		{
			return _003CHasTooManyActiveDevices_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHasTooManyActiveDevices_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HasTooManyActiveDevices);
				_003CHasTooManyActiveDevices_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HasTooManyActiveDevices);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsHealthCheckSuccess
	{
		get
		{
			return _003CIsHealthCheckSuccess_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsHealthCheckSuccess_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsHealthCheckSuccess);
				_003CIsHealthCheckSuccess_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsHealthCheckSuccess);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsMaintenanceModeEnabled
	{
		get
		{
			return _003CIsMaintenanceModeEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsMaintenanceModeEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsMaintenanceModeEnabled);
				_003CIsMaintenanceModeEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsMaintenanceModeEnabled);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public NfcPosition NfcPosition
	{
		get
		{
			return _003CNfcPosition_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<NfcPosition>.Default.Equals(_003CNfcPosition_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.NfcPosition);
				_003CNfcPosition_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.NfcPosition);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsKeyAttestationSuccess
	{
		get
		{
			return _003CIsKeyAttestationSuccess_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsKeyAttestationSuccess_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsKeyAttestationSuccess);
				_003CIsKeyAttestationSuccess_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsKeyAttestationSuccess);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool NeedSubInFuture
	{
		get
		{
			return _003CNeedSubInFuture_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CNeedSubInFuture_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.NeedSubInFuture);
				_003CNeedSubInFuture_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.NeedSubInFuture);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public DateTime? SubExpiryDate
	{
		get
		{
			return _003CSubExpiryDate_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<DateTime?>.Default.Equals(_003CSubExpiryDate_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SubExpiryDate);
				_003CSubExpiryDate_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SubExpiryDate);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsDateSelectorOpen
	{
		get
		{
			return _003CIsDateSelectorOpen_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsDateSelectorOpen_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsDateSelectorOpen);
				_003CIsDateSelectorOpen_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsDateSelectorOpen);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ButtonType TabAccountButtonType
	{
		get
		{
			return _003CTabAccountButtonType_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ButtonType>.Default.Equals(_003CTabAccountButtonType_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TabAccountButtonType);
				_003CTabAccountButtonType_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TabAccountButtonType);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ButtonType TabCardButtonType
	{
		get
		{
			return _003CTabCardButtonType_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ButtonType>.Default.Equals(_003CTabCardButtonType_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TabCardButtonType);
				_003CTabCardButtonType_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TabCardButtonType);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool TabAccountSelected
	{
		get
		{
			return _003CTabAccountSelected_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CTabAccountSelected_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TabAccountSelected);
				_003CTabAccountSelected_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TabAccountSelected);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool TabCardSelected
	{
		get
		{
			return _003CTabCardSelected_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CTabCardSelected_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.TabCardSelected);
				_003CTabCardSelected_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.TabCardSelected);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsEasterEggEnabled
	{
		get
		{
			return _003CIsEasterEggEnabled_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsEasterEggEnabled_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsEasterEggEnabled);
				_003CIsEasterEggEnabled_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsEasterEggEnabled);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand ResetCommand => resetCommand ?? (resetCommand = new RelayCommand(Reset));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CloseCommand => closeCommand ?? (closeCommand = new AsyncRelayCommand(CloseAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand DeactivateCommand => deactivateCommand ?? (deactivateCommand = new AsyncRelayCommand(DeactivateAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ChangeActivationMethodCommand => changeActivationMethodCommand ?? (changeActivationMethodCommand = new AsyncRelayCommand(ChangeActivationMethodAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ChangeVersionCheckResponseCommand => changeVersionCheckResponseCommand ?? (changeVersionCheckResponseCommand = new AsyncRelayCommand(ChangeVersionCheckResponseAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ChangeNfcLocationCommand => changeNfcLocationCommand ?? (changeNfcLocationCommand = new AsyncRelayCommand(ChangeNfcLocationAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<string> TabSelectedCommand => tabSelectedCommand ?? (tabSelectedCommand = new RelayCommand<string>(TabSelected));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand ClearSubExpiryDateCommand => clearSubExpiryDateCommand ?? (clearSubExpiryDateCommand = new RelayCommand(ClearSubExpiryDate));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand OpenDateSelectorCommand => openDateSelectorCommand ?? (openDateSelectorCommand = new RelayCommand(OpenDateSelector));

	public DM002ViewModel(IAppService appService, INfcService nfcService)
	{
		this.appService = appService;
		Tries = EIDSession.CardState.PINTries;
		HasNFCSupport = nfcService.HasNFCSupport();
		base.HasBackButton = false;
		Pin = EIDSession.CardState.Pin;
		IsSuspended = EIDSession.CardState.IsSuspended;
		IsBlocked = EIDSession.CardState.IsBlocked;
		ChangePinRequired = EIDSession.CardState.ChangePinRequired;
		HasMessages = DemoConfig.HasMessages;
		TwoFactorEnabled = DemoConfig.TwoFactorEnabled;
		IsEmailAddressVerified = DemoConfig.IsEmailAddressVerified;
		HasEmailAddress = DemoConfig.HasEmailAddress;
		UserActionNeeded = DemoConfig.UserActionNeeded;
		EIDASUser = DemoConfig.EIDASUser;
		EIDASSuccess = DemoConfig.EIDASSuccess;
		RdaFailed = DemoConfig.RdaFailed;
		HasNoDocuments = DemoConfig.HasNoDocuments;
		IsSmsCheckRequested = DemoConfig.IsSmsCheckRequested;
		ActivationMethod = TranslateActivationMethod(DemoConfig.ActivationMethod);
		IsEHAEnabled = DemoConfig.IsEHAEnabled;
		SubExpiryDate = DemoConfig.SubExpiryDate;
		NeedSubInFuture = DemoConfig.NeedSubInFuture;
		IsClassifiedDeceased = DemoConfig.IsClassifiedDeceased;
		HttpSession.IsDeceased = DemoConfig.IsClassifiedDeceased;
		HasPendingActivation = DemoConfig.HasPendingActivation;
		HasNfc = DemoConfig.HasNfc;
		VersionState = DemoConfig.VersionState;
		IsTrafficMeteringEnabled = DemoConfig.TrafficMeteringEnabled;
		HasTooManyActiveDevices = DemoConfig.HasTooManyActiveDevices;
		IsMaintenanceModeEnabled = DemoConfig.MaintenanceEnabled;
		NfcPosition = DemoConfig.NfcPosition;
		IsHealthCheckSuccess = DemoConfig.IsHealthCheckSuccess;
		IsKeyAttestationSuccess = DemoConfig.KeyAttestationSuccess;
		IsEasterEggEnabled = DemoConfig.EnableEasterEgg;
		base.CloseButtonVisible = true;
		TabSelected("account");
	}

	protected override async Task CloseButtonClicked()
	{
		EIDSession.CardState.ChangePinRequired = ChangePinRequired;
		EIDSession.CardState.PINTries = Tries;
		DemoConfig.TwoFactorEnabled = TwoFactorEnabled;
		DemoConfig.HasMessages = HasMessages;
		DemoConfig.IsEmailAddressVerified = IsEmailAddressVerified;
		DemoConfig.HasEmailAddress = HasEmailAddress;
		DemoConfig.UserActionNeeded = UserActionNeeded;
		DemoConfig.EIDASUser = EIDASUser;
		DemoConfig.EIDASSuccess = EIDASSuccess;
		DemoConfig.RdaFailed = RdaFailed;
		DemoConfig.HasNoDocuments = HasNoDocuments;
		DemoConfig.IsSmsCheckRequested = IsSmsCheckRequested;
		DemoConfig.ActivationMethod = TranslateActivationMethod(ActivationMethod);
		DemoConfig.IsEHAEnabled = IsEHAEnabled;
		DemoConfig.SubExpiryDate = SubExpiryDate;
		DemoConfig.IsClassifiedDeceased = IsClassifiedDeceased;
		HttpSession.IsDeceased = IsClassifiedDeceased;
		DemoConfig.HasPendingActivation = HasPendingActivation;
		DemoConfig.HasNfc = HasNfc;
		DemoConfig.VersionState = VersionState;
		DemoConfig.TrafficMeteringEnabled = IsTrafficMeteringEnabled;
		DemoConfig.HasTooManyActiveDevices = HasTooManyActiveDevices;
		DemoConfig.MaintenanceEnabled = IsMaintenanceModeEnabled;
		DemoConfig.NfcPosition = NfcPosition;
		DemoConfig.KeyAttestationSuccess = IsKeyAttestationSuccess;
		DemoConfig.IsHealthCheckSuccess = IsHealthCheckSuccess;
		DemoConfig.NeedSubInFuture = NeedSubInFuture;
		DemoConfig.EnableEasterEgg = IsEasterEggEnabled;
		HttpSession.SubExpiryDate = SubExpiryDate;
		await base.NavigationService.PopCurrentModalPage();
	}

	[RelayCommand]
	private void Reset()
	{
		Tries = 5;
		ChangePinRequired = true;
		IsSuspended = false;
		IsBlocked = false;
		EIDSession.CardState.Pin = "12345";
		Pin = "12345";
	}

	[RelayCommand]
	private async Task CloseAsync()
	{
		await CloseButtonClicked();
	}

	[RelayCommand]
	private async Task DeactivateAsync()
	{
		await appService.Deactivate(AlertMessageType.FM054);
		await base.NavigationService.PopCurrentModalPage();
	}

	[RelayCommand]
	private async Task ChangeActivationMethodAsync()
	{
		string result = await base.NavigationService.CurrentPage.DisplayActionSheetAsync("Activation Method", null, null, TranslateActivationMethod(DigiD.Common.Models.Enums.ActivationMethod.SMS), TranslateActivationMethod(DigiD.Common.Models.Enums.ActivationMethod.Password), TranslateActivationMethod(DigiD.Common.Models.Enums.ActivationMethod.AccountAndApp));
		if (result != null)
		{
			ActivationMethod = result;
		}
	}

	[RelayCommand]
	private async Task ChangeVersionCheckResponseAsync()
	{
		string result = await base.NavigationService.CurrentPage.DisplayActionSheetAsync("Version State", null, null, "Active", "Warning", "ForcedUpdate", "Kill");
		if (result != null)
		{
			VersionState = Enum.Parse<VersionState>(result);
		}
	}

	[RelayCommand]
	private async Task ChangeNfcLocationAsync()
	{
		string result = await base.NavigationService.CurrentPage.DisplayActionSheetAsync("NFC Location", null, null, "Top", "Middle", "Bottom", "Unknown");
		if (result != null)
		{
			NfcPosition = Enum.Parse<NfcPosition>(result);
		}
	}

	[RelayCommand]
	private void TabSelected(string name)
	{
		TabCardButtonType = ((name == "card") ? ButtonType.TabActive : ButtonType.TabInActive);
		TabAccountButtonType = ((name == "account") ? ButtonType.TabActive : ButtonType.TabInActive);
		TabCardSelected = name == "card";
		TabAccountSelected = name == "account";
	}

	private static string TranslateActivationMethod(ActivationMethod method)
	{
		if (1 == 0)
		{
		}
		string result = method switch
		{
			DigiD.Common.Models.Enums.ActivationMethod.SMS => "SMS", 
			DigiD.Common.Models.Enums.ActivationMethod.AccountAndApp => "Account", 
			DigiD.Common.Models.Enums.ActivationMethod.Password => "Password", 
			_ => throw new NotImplementedException(), 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	private static ActivationMethod TranslateActivationMethod(string method)
	{
		if (1 == 0)
		{
		}
		ActivationMethod result = method switch
		{
			"SMS" => DigiD.Common.Models.Enums.ActivationMethod.SMS, 
			"Account" => DigiD.Common.Models.Enums.ActivationMethod.AccountAndApp, 
			"Password" => DigiD.Common.Models.Enums.ActivationMethod.Password, 
			_ => DigiD.Common.Models.Enums.ActivationMethod.Unsupported, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	[RelayCommand]
	private void ClearSubExpiryDate()
	{
		SubExpiryDate = null;
	}

	[RelayCommand]
	private void OpenDateSelector()
	{
		IsDateSelectorOpen = true;
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnIsBlockedChanged(bool value)
	{
		if (IsSuspended)
		{
			IsSuspended = false;
		}
		Tries = ((!value) ? EIDSession.CardState.PINTries : 0);
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnIsSuspendedChanged(bool value)
	{
		if (IsBlocked)
		{
			IsBlocked = false;
		}
		Tries = (value ? 1 : EIDSession.CardState.PINTries);
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnHasMessagesChanged(bool value)
	{
		DemoConfig.UnreadMessagesCount = (value ? 5 : 0);
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnHasNfcChanged(bool value)
	{
		AppSession.HasNfc = value;
	}
}
