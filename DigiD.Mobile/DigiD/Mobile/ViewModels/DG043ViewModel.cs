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
using DigiD.Common.SessionModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using LocalizationResourceManager.Maui;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG043ViewModel : CommonBaseViewModel
{
	private readonly IApp2AppService app2AppService;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString _003CTitle_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString _003CIntro_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private LocalizedString _003CExplanation_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CMoreInfoVisible_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? moreInfoCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public LocalizedString Title
	{
		get
		{
			return _003CTitle_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CTitle_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Title);
				_003CTitle_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Title);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public LocalizedString Intro
	{
		get
		{
			return _003CIntro_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CIntro_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Intro);
				_003CIntro_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Intro);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public LocalizedString Explanation
	{
		get
		{
			return _003CExplanation_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<LocalizedString>.Default.Equals(_003CExplanation_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Explanation);
				_003CExplanation_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Explanation);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool MoreInfoVisible
	{
		get
		{
			return _003CMoreInfoVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CMoreInfoVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.MoreInfoVisible);
				_003CMoreInfoVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.MoreInfoVisible);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand MoreInfoCommand => moreInfoCommand ?? (moreInfoCommand = new AsyncRelayCommand(MoreInfoAsync));

	public DG043ViewModel(IApp2AppService app2AppService)
	{
		this.app2AppService = app2AppService;
		Title = new LocalizedString(() => base.ResourceManager[HttpSession.IsDeceased ? "DG043A_Titel" : "DG043_Titel"]);
		Intro = new LocalizedString(() => base.ResourceManager[HttpSession.IsDeceased ? "DG043A_Intro" : "DG043_Intro"]);
		Explanation = new LocalizedString(() => base.ResourceManager[HttpSession.IsDeceased ? "DG043A_Uitleg" : "DG043_Uitleg"]);
		MoreInfoVisible = !HttpSession.IsDeceased;
		base.HasBackButton = !HttpSession.IsDeceased;
		base.CloseButtonVisible = HttpSession.IsDeceased;
		base.PageId = "DG043";
	}

	protected override async Task CloseButtonClicked()
	{
		if (HttpSession.IsApp2AppSession)
		{
			await app2AppService.AbortSession("no_nfc");
		}
		else
		{
			await base.CloseButtonClicked();
		}
	}

	[RelayCommand]
	private async Task MoreInfoAsync()
	{
		await base.NavigationService.PushModalAsync<HLP010>();
	}
}
