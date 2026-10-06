using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Nfc;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_CommonVtableClasses;

namespace DigiD.Common.BaseClasses;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_BaseClasses_BaseNfcViewModelWinRTTypeDetails))]
public class BaseNfcViewModel : CommonBaseViewModel
{
	protected readonly INfcService NfcService;

	protected AsyncRelayCommand<bool>? CancelAsync;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double _003CProgressValue_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CProgressVisible_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CWaitForRemoval_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private NfcPosition _003CNfcPosition_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private DocumentType _003CDocumentType_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? cancelScanCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("ProgressPercentage")]
	[NotifyPropertyChangedFor("IsCompleted")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public double ProgressValue
	{
		get
		{
			return _003CProgressValue_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<double>.Default.Equals(_003CProgressValue_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.ProgressValue);
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.ProgressPercentage);
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.IsCompleted);
				_003CProgressValue_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.ProgressValue);
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.ProgressPercentage);
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.IsCompleted);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("CancelButtonVisible")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool ProgressVisible
	{
		get
		{
			return _003CProgressVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CProgressVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.ProgressVisible);
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.CancelButtonVisible);
				_003CProgressVisible_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.ProgressVisible);
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.CancelButtonVisible);
			}
		}
	}

	public int ProgressPercentage => (int)(ProgressValue * 100.0);

	public bool IsCompleted => ProgressPercentage == 100;

	public bool CancelButtonVisible => !ProgressVisible && CancelAsync != null;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool WaitForRemoval
	{
		get
		{
			return _003CWaitForRemoval_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CWaitForRemoval_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.WaitForRemoval);
				_003CWaitForRemoval_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.WaitForRemoval);
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
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.NfcPosition);
				_003CNfcPosition_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.NfcPosition);
			}
		}
	}

	[ObservableProperty]
	[NotifyPropertyChangedFor("CurrentDocumentType")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public DocumentType DocumentType
	{
		get
		{
			return _003CDocumentType_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<DocumentType>.Default.Equals(_003CDocumentType_003Ek__BackingField, value))
			{
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.DocumentType);
				OnPropertyChanging(__KnownINotifyPropertyChangingArgs.CurrentDocumentType);
				_003CDocumentType_003Ek__BackingField = value;
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.DocumentType);
				OnPropertyChanged(__KnownINotifyPropertyChangedArgs.CurrentDocumentType);
			}
		}
	}

	public string CurrentDocumentType => DocumentType.Translate().ToLower();

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CancelScanCommand => cancelScanCommand ?? (cancelScanCommand = new AsyncRelayCommand(CancelScanAsync));

	public BaseNfcViewModel()
	{
		NfcService = base.ServiceProvider.GetRequiredService<INfcService>();
		NfcPosition = base.ServiceProvider.GetRequiredService<INfcLocationService>().Position;
	}

	[RelayCommand]
	private async Task CancelScanAsync()
	{
		if (CancelAsync != null)
		{
			await CancelAsync.ExecuteAsync(parameter: true);
		}
	}

	protected void ProgressChanged(float f)
	{
		MainThread.BeginInvokeOnMainThread(delegate
		{
			if (!((double)f < ProgressValue))
			{
				ProgressValue = f;
				base.ServiceProvider.GetRequiredService<INfcService>().UpdateStatus(f);
				if (IsCompleted)
				{
					base.A11YService.Speak(CommonResources.Alg_ScanSucceeded, 1000);
				}
				else if (ProgressPercentage % 10 == 0)
				{
					base.A11YService.Speak(string.Format(CommonResources.Alg_PercentageRead, ProgressPercentage));
				}
			}
		});
	}
}
