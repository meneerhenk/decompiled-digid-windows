using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Models.Enums;
using WinRT;
using WinRT.DigiD_Common_RDAVtableClasses;

namespace DigiD.Common.RDA.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_RDA_ViewModels_DG078ViewModelWinRTTypeDetails))]
public class DG083ViewModel : CommonBaseViewModel
{
	private Func<RdaResult, Task>? _completeAction;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public DG083ViewModel()
	{
		base.HasBackButton = false;
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		await _completeAction(RdaResult.Success);
	}

	public void Initialize(Func<RdaResult, Task> completeAction)
	{
		_completeAction = completeAction;
	}
}
