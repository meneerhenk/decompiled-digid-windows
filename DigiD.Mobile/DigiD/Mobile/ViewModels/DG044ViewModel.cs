using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using DigiD.Common.BaseClasses;
using DigiD.Common.Controls.Models;
using DigiD.Common.Enums;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG044ViewModel : CommonBaseViewModel
{
	private readonly IMobileSettings settings;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CSecondMenuVisible_003Ek__BackingField;

	public List<MenuItem> PrimaryMenuItems { get; set; } = new List<MenuItem>();

	public List<MenuItem> SecondMenuItems { get; set; } = new List<MenuItem>();

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public bool SecondMenuVisible
	{
		get
		{
			return _003CSecondMenuVisible_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<bool>.Default.Equals(_003CSecondMenuVisible_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.SecondMenuVisible);
				_003CSecondMenuVisible_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.SecondMenuVisible);
			}
		}
	}

	public DG044ViewModel(IMobileSettings settings)
	{
		base.PageId = (AppSession.IsAuthenticated ? "DG044A" : "DG044B");
		base.CloseButtonVisible = true;
		this.settings = settings;
	}

	public Task Initialize()
	{
		LoadItems();
		return Task.CompletedTask;
	}

	internal void LoadItems()
	{
		MenuFactory.BuildMainMenu();
		SecondMenuVisible = settings.ActivationStatus == ActivationStatus.Activated && AppSession.IsAuthenticated;
		PrimaryMenuItems = MenuFactory.PrimaryMenuItems;
		SecondMenuItems = MenuFactory.SecondMenuItems;
	}
}
