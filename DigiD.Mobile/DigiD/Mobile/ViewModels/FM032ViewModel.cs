using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Resources;
using DigiD.Mobile.Interfaces;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class FM032ViewModel : CommonBaseViewModel
{
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? cancelCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? continueCommand;

	public Func<bool, Task>? ResultAction { get; set; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CancelCommand => cancelCommand ?? (cancelCommand = new AsyncRelayCommand(Cancel));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ContinueCommand => continueCommand ?? (continueCommand = new AsyncRelayCommand(Continue));

	public FM032ViewModel(IConfigurationService configurationService)
	{
		base.HasBackButton = false;
		base.MessageText = string.Format(CommonResources.FM032_Intro, configurationService.Configuration.LetterRequestDelay);
	}

	[RelayCommand]
	private async Task Cancel()
	{
		ArgumentNullException.ThrowIfNull(ResultAction, "ResultAction");
		await ResultAction(arg: false);
	}

	[RelayCommand]
	private async Task Continue()
	{
		ArgumentNullException.ThrowIfNull(ResultAction, "ResultAction");
		await ResultAction(arg: true);
	}
}
