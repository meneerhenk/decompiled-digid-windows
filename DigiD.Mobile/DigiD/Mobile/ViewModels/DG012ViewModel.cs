using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Resources;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG012ViewModel : CommonBaseViewModel
{
	private readonly IAccountRequestService accountRequestService;

	private readonly IAlertService alertService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CPostalcode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CHouseNumber_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CHouseNumberSuffix_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsValidPostcode_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsValidHouseNumber_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	public static string? SelectedPostalCode { get; set; }

	public static string? SelectedHouseNumber { get; set; }

	public static string? SelectedHouseNumberSuffix { get; set; }

	public static string SelectedLanguage { get; set; } = "NL";

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? Postalcode
	{
		get
		{
			return _003CPostalcode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CPostalcode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Postalcode);
				_003CPostalcode_003Ek__BackingField = value;
				OnPostalcodeChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Postalcode);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? HouseNumber
	{
		get
		{
			return _003CHouseNumber_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CHouseNumber_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HouseNumber);
				_003CHouseNumber_003Ek__BackingField = value;
				OnHouseNumberChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HouseNumber);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? HouseNumberSuffix
	{
		get
		{
			return _003CHouseNumberSuffix_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CHouseNumberSuffix_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.HouseNumberSuffix);
				_003CHouseNumberSuffix_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.HouseNumberSuffix);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValidAddress")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsValidPostcode
	{
		get
		{
			return _003CIsValidPostcode_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsValidPostcode_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidPostcode);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidAddress);
				_003CIsValidPostcode_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidPostcode);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidAddress);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("IsValidAddress")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsValidHouseNumber
	{
		get
		{
			return _003CIsValidHouseNumber_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsValidHouseNumber_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidHouseNumber);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidAddress);
				_003CIsValidHouseNumber_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidHouseNumber);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidAddress);
			}
		}
	}

	public bool IsValidAddress => IsValidPostcode && IsValidHouseNumber;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(Next));

	public DG012ViewModel(IAccountRequestService accountRequestService, IAlertService alertService)
	{
		this.accountRequestService = accountRequestService;
		this.alertService = alertService;
		Postalcode = SelectedPostalCode;
		HouseNumber = SelectedHouseNumber;
		HouseNumberSuffix = SelectedHouseNumberSuffix;
	}

	[RelayCommand]
	private async Task Next()
	{
		SelectedPostalCode = Postalcode?.ToUpper();
		SelectedHouseNumber = HouseNumber;
		SelectedHouseNumberSuffix = HouseNumberSuffix;
		if (string.IsNullOrEmpty(SelectedLanguage))
		{
			string language = base.GeneralPreferences.Language.ToUpper(CultureInfo.InvariantCulture);
			if (language == "EN")
			{
				bool? confirm = await alertService.DisplayAlert(AlertMessageType.FM073);
				if (confirm.HasValue && !confirm.Value)
				{
					language = "NL";
				}
			}
			SelectedLanguage = language;
		}
		base.DialogService.Show();
		await accountRequestService.RequestAccount();
		await base.DialogService.Hide();
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnPostalcodeChanged(string? value)
	{
		IsValidPostcode = !string.IsNullOrEmpty(value) && value.IsValidZipcode();
		if (IsValidPostcode)
		{
			base.A11YService.Speak(DigiDAppResources.DG012_PostcodeCorrect);
		}
		else if (!IsValidPostcode && value != null && value.Length == 6)
		{
			base.A11YService.Speak(DigiDAppResources.DG012_PostcodeIncorrect);
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnHouseNumberChanged(string? value)
	{
		IsValidHouseNumber = !string.IsNullOrEmpty(value) && int.TryParse(value, out var result) && result > 0;
	}
}
