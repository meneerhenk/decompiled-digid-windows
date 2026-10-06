using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Resources;
using DigiD.Mobile.Pages;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG011ViewModel : CommonBaseViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CDateOfBirth_003Ek__BackingField = "";

	private const int MINIMAL_YEAR = 1900;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CDay_003Ek__BackingField = "";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CMonth_003Ek__BackingField = "";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CYear_003Ek__BackingField = "";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsValidDateOfBirth_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsValidDay_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsValidMonth_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsValidYear_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CShowError_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? unknownDateOfBirthCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	public static string? SelectedDateOfBirth { get; set; }

	public static string? SelectedDay { get; set; }

	public static string? SelectedMonth { get; set; }

	public static string? SelectedYear { get; set; }

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string DateOfBirth
	{
		get
		{
			return _003CDateOfBirth_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CDateOfBirth_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.DateOfBirth);
				_003CDateOfBirth_003Ek__BackingField = value;
				OnDateOfBirthChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.DateOfBirth);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("ShowError")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsValidDateOfBirth
	{
		get
		{
			return _003CIsValidDateOfBirth_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsValidDateOfBirth_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidDateOfBirth);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ShowError);
				_003CIsValidDateOfBirth_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidDateOfBirth);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ShowError);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsValidDay
	{
		get
		{
			return _003CIsValidDay_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsValidDay_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidDay);
				_003CIsValidDay_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidDay);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsValidMonth
	{
		get
		{
			return _003CIsValidMonth_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsValidMonth_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidMonth);
				_003CIsValidMonth_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidMonth);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool IsValidYear
	{
		get
		{
			return _003CIsValidYear_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CIsValidYear_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IsValidYear);
				_003CIsValidYear_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IsValidYear);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("DateOfBirth")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Day
	{
		get
		{
			return _003CDay_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CDay_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Day);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.DateOfBirth);
				_003CDay_003Ek__BackingField = value;
				OnDayChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Day);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.DateOfBirth);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("DateOfBirth")]
	[NotifyPropertyChangedFor("MonthIndex")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Month
	{
		get
		{
			return _003CMonth_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CMonth_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Month);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.DateOfBirth);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.MonthIndex);
				_003CMonth_003Ek__BackingField = value;
				OnMonthChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Month);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.DateOfBirth);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.MonthIndex);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("DateOfBirth")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string Year
	{
		get
		{
			return _003CYear_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CYear_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Year);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.DateOfBirth);
				_003CYear_003Ek__BackingField = value;
				OnYearChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Year);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.DateOfBirth);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool ShowError
	{
		get
		{
			return _003CShowError_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CShowError_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ShowError);
				_003CShowError_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ShowError);
			}
		}
	}

	public IList<string> Months { get; }

	private int MonthIndex => Months.IndexOf(Month);

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand UnknownDateOfBirthCommand => unknownDateOfBirthCommand ?? (unknownDateOfBirthCommand = new AsyncRelayCommand(UnknownDateOfBirth));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(Next));

	[RelayCommand]
	private async Task UnknownDateOfBirth()
	{
		await base.NavigationService.PushModalAsync<HLP004>();
	}

	[RelayCommand]
	private async Task Next()
	{
		base.DialogService.Show();
		SelectedDateOfBirth = DateOfBirth;
		SelectedDay = Day;
		SelectedMonth = Month;
		SelectedYear = Year;
		base.CloseButtonVisible = true;
		await base.NavigationService.NavigateAsync<DG012>();
		await base.DialogService.Hide();
	}

	public DG011ViewModel()
	{
		Months = DigiDAppResources.DG011_Months.Split(',').ToList();
		string selectedDateOfBirth = SelectedDateOfBirth;
		if (selectedDateOfBirth != null)
		{
			string[] array = selectedDateOfBirth.Split(CultureInfo.DefaultThreadCurrentCulture?.DateTimeFormat.DateSeparator);
			if (array.Length != 0)
			{
				Year = array[0];
			}
			if (array.Length > 1 && int.TryParse(array[1], out var result))
			{
				Month = Months[result];
			}
			if (array.Length > 2)
			{
				Day = array[2];
			}
		}
	}

	private void CheckDay()
	{
		CheckDate();
		int result;
		if (Day.Equals("00"))
		{
			IsValidDay = true;
		}
		else if (int.TryParse(Day, out result))
		{
			int result2;
			bool flag = int.TryParse(Year, out result2) && DateTime.IsLeapYear(result2);
			switch (MonthIndex)
			{
			case 2:
				IsValidDay = result < (flag ? 30 : 29);
				break;
			case 4:
			case 6:
			case 9:
			case 11:
				IsValidDay = int.Parse(Day) < 31;
				break;
			default:
				IsValidDay = int.Parse(Day) < 32;
				break;
			}
		}
	}

	private bool Validate(string dob)
	{
		DateTime result;
		return Year.PadLeft(4, '0').Equals("0000") || Day.PadLeft(2, '0').Equals("00") || $"{MonthIndex}".PadLeft(2, '0').Equals("00") || (DateTime.TryParse(dob, CultureInfo.DefaultThreadCurrentCulture, DateTimeStyles.None, out result) && DateTime.Now > result);
	}

	private void CheckDate()
	{
		if (!string.IsNullOrEmpty(Day) && !string.IsNullOrEmpty(Month) && !string.IsNullOrEmpty(Year) && Year.Length == 4)
		{
			string value = CultureInfo.DefaultThreadCurrentCulture?.DateTimeFormat.DateSeparator;
			DateOfBirth = $"{Year.PadLeft(4, '0')}{value}{MonthIndex.ToString().PadLeft(2, '0')}{value}{Day.PadLeft(2, '0')}";
		}
		else
		{
			IsValidDateOfBirth = false;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnDateOfBirthChanged(string value)
	{
		if (value.Length == 10)
		{
			IsValidDateOfBirth = Validate(value);
			if (IsValidDateOfBirth)
			{
				IsValidDay = true;
				IsValidMonth = true;
				IsValidYear = true;
			}
			ShowError = !IsValidDateOfBirth;
		}
		else
		{
			ShowError = false;
			IsValidDateOfBirth = false;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnDayChanged(string value)
	{
		ShowError = false;
		IsValidDay = false;
		CheckDay();
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnMonthChanged(string value)
	{
		ShowError = false;
		IsValidMonth = false;
		IsValidMonth = MonthIndex >= 0;
		CheckDate();
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnYearChanged(string value)
	{
		ShowError = false;
		int result;
		if (Year.PadLeft(4, '0').Equals("0000"))
		{
			CheckDate();
		}
		else if (int.TryParse(Year, out result) && result >= 1900)
		{
			CheckDate();
		}
	}
}
