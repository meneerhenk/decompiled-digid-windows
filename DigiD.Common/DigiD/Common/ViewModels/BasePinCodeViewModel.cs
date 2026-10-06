using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Enums;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Models;
using DigiD.Common.Models.Helpers;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Maui.Devices;

namespace DigiD.Common.ViewModels;

public abstract class BasePinCodeViewModel : CommonBaseViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CNumberOfTiles_003Ek__BackingField = 10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString _003CMessageText_003Ek__BackingField = new LocalizedString(() => string.Empty);

	protected bool IsInitialized;

	private SecureString? _cardPin;

	protected bool BiometricAuthenticationActive;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private SecureString? _003CPin1_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private SecureString? _003CPin2_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CPinLocked_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsCANInput_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHelpTextVisible_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<int>? numberEnteredCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public SecureString? Pin1
	{
		get
		{
			return _003CPin1_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<SecureString>.Default.Equals(_003CPin1_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.Pin1);
				_003CPin1_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.Pin1);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public SecureString? Pin2
	{
		get
		{
			return _003CPin2_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<SecureString>.Default.Equals(_003CPin2_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.Pin2);
				_003CPin2_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.Pin2);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool PinLocked
	{
		get
		{
			return _003CPinLocked_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CPinLocked_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.PinLocked);
				_003CPinLocked_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.PinLocked);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int NumberOfTiles
	{
		get
		{
			return _003CNumberOfTiles_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CNumberOfTiles_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.NumberOfTiles);
				_003CNumberOfTiles_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.NumberOfTiles);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsCANInput
	{
		get
		{
			return _003CIsCANInput_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsCANInput_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.IsCANInput);
				_003CIsCANInput_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.IsCANInput);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool HelpTextVisible
	{
		get
		{
			return _003CHelpTextVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CHelpTextVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.HelpTextVisible);
				_003CHelpTextVisible_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.HelpTextVisible);
			}
		}
	}

	public new LocalizedString MessageText
	{
		[CompilerGenerated]
		get
		{
			return _003CMessageText_003Ek__BackingField;
		}
		protected set
		{
			_003CMessageText_003Ek__BackingField = value;
			base.MessageText = value.Localized;
		}
	}

	private static string DocumentName => (EIDSession.Card != null) ? EIDSession.Card.DocumentType.Translate().ToLowerInvariant() : string.Empty;

	private int TileIndex => Pin2?.Length ?? Pin1?.Length ?? 0;

	public PinCodeModel Model { get; private set; } = new PinCodeModel(PinEntryType.Authentication);

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<int> NumberEnteredCommand => numberEnteredCommand ?? (numberEnteredCommand = new AsyncRelayCommand<int>(NumberEnteredAsync));

	public event EventHandler<PinChangeEventArgs> PinUpdateEvent
	{
		add
		{
			WeakEventManager.AddEventHandler((Delegate?)value, "PinUpdateEvent");
		}
		remove
		{
			WeakEventManager.RemoveEventHandler((Delegate?)value, "PinUpdateEvent");
		}
	}

	public event EventHandler<PinType> PinFocusChangedEvent
	{
		add
		{
			WeakEventManager.AddEventHandler((Delegate?)value, "PinFocusChangedEvent");
		}
		remove
		{
			WeakEventManager.RemoveEventHandler((Delegate?)value, "PinFocusChangedEvent");
		}
	}

	protected abstract Task PinCompleteAction();

	protected abstract Task ChangePinAction();

	protected abstract Task GoToNfcScannerPage(NfcScannerModel model);

	protected void SetInitialAuthenticationMessage()
	{
		SetLabels((AppSession.Process == Process.UpgradeAndAuthenticate) ? CommonResources.x_LoginAndUpgradeHeader : CommonResources.x_AuthenticationHeader, new LocalizedString(() => base.ResourceManager["DG030_Intro"]));
	}

	protected BasePinCodeViewModel()
	{
		Pin1 = new SecureString();
	}

	protected override async Task OnAppearing()
	{
		await base.DialogService.Hide();
		await base.OnAppearing();
	}

	protected void Initialize(PinCodeModel model)
	{
		Model = model;
		switch (Model.EntryType)
		{
		case PinEntryType.Authentication:
			if (Model.ChangeAppPin)
			{
				base.PageId = "DG030B";
				MessageText = new LocalizedString(() => base.ResourceManager["DG030B_Intro"]);
				base.HeaderText = DigiDAppResources.DG030B_Titel;
			}
			else
			{
				base.PageId = "DG030A";
				if (Model.EIDSessionResponse == null)
				{
					SetInitialAuthenticationMessage();
				}
				else if (Model.HasPinChanged.HasValue)
				{
					if (Model.HasPinChanged.Value)
					{
						SetLabels(string.Format(DigiDAppResources.DG030_Card_Title, DocumentName), new LocalizedString(() => base.ResourceManager["DG030_Card_Message", new object[1] { DocumentName }]));
					}
					else
					{
						SetLabels(DigiDAppResources.DG030_Letter_Title, new LocalizedString(() => base.ResourceManager["DG030_Letter_Message", new object[1] { DocumentName }]));
					}
				}
				else
				{
					SetLabels(CommonResources.x_AuthenticationHeader, new LocalizedString(() => (EIDSession.Card != null) ? base.ResourceManager["DG030_Message", new object[1] { DocumentName }] : "x_AuthenticationMessage"));
				}
			}
			SetNumberOfTiles(PincodeType.PIN);
			break;
		case PinEntryType.Enrollment:
			base.PageId = "DG016A";
			HelpTextVisible = true;
			SetLabels(CommonResources.Alg_ChoosePincode, new LocalizedString(() => base.ResourceManager["DG016_Intro"]));
			SetNumberOfTiles(PincodeType.PIN);
			break;
		case PinEntryType.ChangePIN_PIN:
			SetNumberOfTiles(PincodeType.PIN);
			base.PageId = "DG073C";
			SetLabels(string.Format(DigiDAppResources.DG073_Titel, DocumentName), new LocalizedString(() => base.ResourceManager["DG073C_Info", new object[1] { DocumentName }]));
			break;
		case PinEntryType.ChangeTransportPIN:
			base.PageId = "DG016E";
			_cardPin = Model.PIN;
			SetNumberOfTiles(PincodeType.PIN);
			SetLabels(string.Format(DigiDAppResources.DG016E_Titel, DocumentName), new LocalizedString(() => base.ResourceManager["DG016E_Intro", new object[1] { DocumentName }]));
			break;
		case PinEntryType.ResumePIN_CAN:
			SetNumberOfTiles(PincodeType.CAN);
			if (EIDSession.Card.DocumentType == DocumentType.DrivingLicense)
			{
				base.PageId = "DG075";
				SetLabels(DigiDAppResources.DG075_Titel, new LocalizedString(() => base.ResourceManager["DG075_Info"]));
			}
			else
			{
				base.PageId = "DG074";
				SetLabels(DigiDAppResources.DG074_Titel, new LocalizedString(() => base.ResourceManager["DG074_Info"]));
			}
			break;
		}
		PinCodeModel model2 = Model;
		bool flag;
		if (model2 != null && model2.TriesLeft.HasValue)
		{
			PinEntryType entryType = model2.EntryType;
			if (entryType == PinEntryType.Authentication || entryType == PinEntryType.ChangePIN_PIN)
			{
				flag = true;
				goto IL_02e9;
			}
		}
		flag = false;
		goto IL_02e9;
		IL_02e9:
		if (flag)
		{
			if (Model.NeedPinChange && DeviceInfo.Idiom == DeviceIdiom.Desktop)
			{
				base.PageId = "DA117";
				SetLabels(DesktopAppResources.DA117_Header, new LocalizedString(() => base.ResourceManager["DA117_Message", new object[2]
				{
					Model.TriesLeft.Value,
					(Model.TriesLeft.Value > 1) ? CommonResources.x_PluralSuffix : string.Empty
				}]), isError: true);
				return;
			}
			base.PageId = ((DeviceInfo.Idiom == DeviceIdiom.Desktop) ? "DA113" : "AP231");
			SetLabels(base.HeaderText, new LocalizedString(() => base.ResourceManager["x_WIDWrongPINMessage", new object[3]
			{
				Model.TriesLeft.Value,
				(Model.TriesLeft.Value > 1) ? CommonResources.x_PluralSuffix : string.Empty,
				EIDSession.Card.DocumentType.Translate().ToLower()
			}]), isError: true);
		}
		else if (Model.WrongCAN)
		{
			base.PageId = ((DeviceInfo.Idiom == DeviceIdiom.Desktop) ? "DA115" : "AP242");
			SetLabels(base.HeaderText, new LocalizedString(() => base.ResourceManager["x_WIDWrongCANMessage"]), isError: true);
		}
	}

	public void SetNumberOfTiles(PincodeType pinCodeType)
	{
		IsCANInput = pinCodeType == PincodeType.CAN;
		switch (pinCodeType)
		{
		case PincodeType.PIN:
			NumberOfTiles = 5;
			break;
		case PincodeType.CAN:
			NumberOfTiles = EIDSession.Card.CANLength;
			break;
		case PincodeType.PUK:
			NumberOfTiles = 8;
			break;
		}
	}

	public void SetLabels(string? header, LocalizedString message, bool isError = false)
	{
		base.HeaderText = header;
		MessageText = message;
		base.IsError = isError;
	}

	[RelayCommand]
	private Task NumberEnteredAsync(int number)
	{
		if (BiometricAuthenticationActive)
		{
			return Task.CompletedTask;
		}
		return NumberEnteredAsync(number, DeviceInfo.Platform != DevicePlatform.MacCatalyst);
	}

	protected async Task NumberEnteredAsync(int number, bool vibrate)
	{
		if (!IsInitialized || TileIndex >= NumberOfTiles)
		{
			return;
		}
		if (vibrate)
		{
			HapticFeedback.Default.Perform(HapticFeedbackType.Click);
		}
		switch (number)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		{
			if (Pin2 != null)
			{
				Pin2.AppendChar(number);
				WeakEventManager.HandleEvent(this, new PinChangeEventArgs
				{
					PinType = PinType.Secondary,
					Next = true
				}, "PinUpdateEvent");
			}
			else
			{
				Pin1.AppendChar(number);
				WeakEventManager.HandleEvent(this, new PinChangeEventArgs
				{
					PinType = PinType.Primary,
					Next = true
				}, "PinUpdateEvent");
			}
			PinEntryType entryType = Model.EntryType;
			bool flag = ((entryType == PinEntryType.Enrollment || entryType == PinEntryType.ChangeTransportPIN || entryType == PinEntryType.ChangePIN_PIN) ? true : false);
			if (flag && TileIndex == NumberOfTiles && Pin2 == null)
			{
				await Task.Delay(400);
				if (_cardPin == null && EIDSession.Card != null && Model.EntryType == PinEntryType.ChangePIN_PIN)
				{
					_cardPin = Pin1;
					Pin1 = new SecureString();
					base.PageId = "DG016G";
					SetLabels(string.Format(DigiDAppResources.DG016G_Titel, DocumentName), new LocalizedString(() => base.ResourceManager["DG016G_Intro", new object[1] { DocumentName }]));
					return;
				}
				ArgumentNullException.ThrowIfNull(Pin1, "Pin1");
				PinCodeValidationResult result = PinCodeHelper.IsPinCodeComplexEnough(Pin1);
				if (result.Success)
				{
					if (EIDSession.Card != null)
					{
						base.PageId = "DG016H";
					}
					else
					{
						SetLabels(CommonResources.Alg_ChoosePincode, new LocalizedString(() => (Model.EntryType == PinEntryType.Enrollment) ? base.ResourceManager["DG016_Intro"] : base.ResourceManager["DG016C_Intro"]));
						base.PageId = ((Model.EntryType == PinEntryType.Enrollment) ? "DG016B" : "DG016D");
					}
					base.A11YService.Speak(DigiDAppResources.DG016B_Intro);
					Pin2 = new SecureString();
					PinLocked = true;
					HelpTextVisible = false;
					WeakEventManager.HandleEvent(this, PinType.Secondary, "PinFocusChangedEvent");
				}
				else
				{
					base.PageId = "DG016A";
					OnError();
					Pin1 = new SecureString();
					Pin2 = null;
					PinLocked = false;
					HelpTextVisible = true;
					WeakEventManager.HandleEvent(this, PinType.Primary, "PinFocusChangedEvent");
					SetLabels(result.Header, new LocalizedString(() => result.Message), isError: true);
				}
			}
			else
			{
				if (Model.EntryType == PinEntryType.Authentication || TileIndex != NumberOfTiles)
				{
					break;
				}
				await Task.Delay(200);
				if (Pin2 == null && _cardPin == null)
				{
					SetNumberOfTiles(PincodeType.PIN);
					if (Model.EntryType == PinEntryType.ResumePIN_CAN)
					{
						_cardPin = Pin1;
						Pin1 = new SecureString();
						if (Model.EIDSessionResponse != null)
						{
							SetLabels(CommonResources.x_AuthenticationHeader, new LocalizedString(() => CommonResources.x_AuthenticationMessage));
							return;
						}
						SetLabels(string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDExistingPINHeader, DocumentName), new LocalizedString(() => base.ResourceManager["x_WIDExistingPINMessage", new object[1] { DocumentName }]));
						base.MatomoService.TrackScreen("AP400");
						if (Model.TriesLeft.HasValue)
						{
							MessageText = new LocalizedString(() => base.ResourceManager["x_WIDWrongPIN_CANMessage", new object[3]
							{
								"pin",
								Model.TriesLeft.Value,
								(Model.TriesLeft.Value > 1) ? "en" : ""
							}]);
						}
						SetNumberOfTiles((Model.EntryType != PinEntryType.ResumePIN_CAN) ? PincodeType.PUK : PincodeType.PIN);
						return;
					}
					SetLabels(string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDNewPINHeader, DocumentName), new LocalizedString(() => base.ResourceManager["x_WIDNewPINMessage", new object[1] { DocumentName }]));
					base.PageId = "DA010";
					Pin2 = new SecureString();
				}
				else if (Pin2 == null && Model.EntryType != PinEntryType.Enrollment)
				{
					if (Model.EntryType == PinEntryType.ResumePIN_CAN)
					{
						await ShowNFCScanner();
						break;
					}
					ArgumentNullException.ThrowIfNull(Pin2, "Pin2");
					PinCodeValidationResult result2 = PinCodeHelper.IsPinCodeComplexEnough(Pin2);
					if (result2.Success)
					{
						if (Model.ChangeAppPin)
						{
							SetLabels(CommonResources.x_AppChangePinHeader, new LocalizedString(() => CommonResources.x_AppChangePinReenterMessage));
							base.MatomoService.TrackScreen("DG016D");
						}
						else
						{
							SetLabels(string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDReenterPINHeader, DocumentName), new LocalizedString(() => base.ResourceManager["x_WIDReenterPINMessage", new object[1] { DocumentName }]));
						}
						Pin2 = null;
						base.MatomoService.TrackScreen("AP402");
					}
					else
					{
						OnError();
						Pin2 = new SecureString();
						SetLabels(result2.Header, new LocalizedString(() => result2.Message), isError: true);
					}
				}
				else
				{
					if (Model.EntryType == PinEntryType.Enrollment)
					{
						break;
					}
					if (Pin1.ToPlain() == Pin2.ToPlain())
					{
						if (Model.ChangeAppPin)
						{
							await ChangePinAction();
						}
						else
						{
							await ShowNFCScanner();
						}
						break;
					}
					OnError();
					Pin1 = new SecureString();
					Pin2 = null;
					PinLocked = false;
					SetLabels(string.Format(CultureInfo.InvariantCulture, CommonResources.x_WIDNewPINHeader, DocumentName), new LocalizedString(() => (DeviceInfo.Idiom == DeviceIdiom.Desktop) ? base.ResourceManager["DA112_Message"] : base.ResourceManager["x_PincodeMatchErrorMessage"]), isError: true);
				}
			}
			break;
		}
		case 11:
			if (TileIndex > 0)
			{
				if (Pin2 != null)
				{
					Pin2.RemoveChar();
					WeakEventManager.HandleEvent(this, new PinChangeEventArgs
					{
						PinType = PinType.Secondary
					}, "PinUpdateEvent");
				}
				else
				{
					Pin1.RemoveChar();
					WeakEventManager.HandleEvent(this, new PinChangeEventArgs
					{
						PinType = PinType.Primary
					}, "PinUpdateEvent");
				}
			}
			break;
		}
		bool flag2 = TileIndex == NumberOfTiles;
		bool flag3 = flag2;
		if (flag3)
		{
			PinEntryType entryType = Model.EntryType;
			bool flag = (uint)(entryType - 1) <= 1u;
			flag3 = flag;
		}
		if (!flag3)
		{
			return;
		}
		await Task.Delay(200);
		if (base.A11YService.IsInVoiceOverMode)
		{
			MessageText = new LocalizedString(() => string.Empty);
		}
		await PinCompleteAction();
	}

	protected void OnError()
	{
		if (DeviceInfo.Idiom != DeviceIdiom.Desktop)
		{
			Vibration.Vibrate(500.0);
		}
		WeakEventManager.HandleEvent(this, PinType.Primary, "PinFocusChangedEvent");
	}

	public Task ShowNFCScanner()
	{
		NfcScannerModel model = new NfcScannerModel(Model.EntryType)
		{
			Pin = (_cardPin ?? Pin1),
			EIDSessionResponse = Model.EIDSessionResponse,
			NewPin = ((Model.EntryType == PinEntryType.ResumePIN_CAN) ? Pin1 : Pin2),
			IsStatusChecked = Model.IsStatusChecked,
			IsActivation = Model.IsWIDActivation,
			NeedAppDeactivation = Model.NeedAppDeactivation
		};
		return GoToNfcScannerPage(model);
	}
}
