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
using DigiD.Common.Interfaces;
using DigiD.Common.Resources;
using DigiD.Mobile.Models;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class CarouselViewModel : CommonBaseViewModel, IPopupViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CarouselViewItemModel? _003CCurrentItem_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003CCurrentIndex_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand<int?>? scrollCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private RelayCommand? previousCommand;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? closeCommand;

	public string NextButtonText => (CurrentIndex == Items.Count - 1) ? CommonResources.Alg_Close : CommonResources.Alg_Next;

	public bool PreviousEnabled => CurrentIndex > 0;

	public bool IndicatorVisible => !base.A11YService.IsInVoiceOverMode;

	public List<CarouselViewItemModel> Items { get; set; } = new List<CarouselViewItemModel>();

	[ObservableProperty]
	[NotifyPropertyChangedFor("PreviousEnabled")]
	[NotifyPropertyChangedFor("NextButtonText")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public CarouselViewItemModel? CurrentItem
	{
		get
		{
			return _003CCurrentItem_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<CarouselViewItemModel>.Default.Equals(_003CCurrentItem_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.CurrentItem);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.PreviousEnabled);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.NextButtonText);
				_003CCurrentItem_003Ek__BackingField = value;
				OnCurrentItemChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.CurrentItem);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.PreviousEnabled);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.NextButtonText);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public int CurrentIndex
	{
		get
		{
			return _003CCurrentIndex_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(_003CCurrentIndex_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.CurrentIndex);
				_003CCurrentIndex_003Ek__BackingField = value;
				OnCurrentIndexChanged(value);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.CurrentIndex);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand<int?> ScrollCommand => scrollCommand ?? (scrollCommand = new RelayCommand<int?>(Scroll));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand PreviousCommand => previousCommand ?? (previousCommand = new RelayCommand(Previous));

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand CloseCommand => closeCommand ?? (closeCommand = new AsyncRelayCommand(CloseAsync));

	public event EventHandler CloseClicked
	{
		add
		{
			WeakEventManager.AddEventHandler(value, "CloseClicked");
		}
		remove
		{
			WeakEventManager.RemoveEventHandler(value, "CloseClicked");
		}
	}

	public CarouselViewModel()
	{
		base.CloseButtonVisible = true;
	}

	protected override Task CloseButtonClicked()
	{
		return base.NavigationService.PopCurrentModalPage();
	}

	[RelayCommand]
	private void Scroll(int? index)
	{
		if (index.HasValue)
		{
			if (index != CurrentIndex)
			{
				base.A11YService.Speak(string.Format(CommonResources.Alg_PageOfNumberOfPages, index + 1, Items.Count), 1000);
			}
			CarouselViewItemModel carouselViewItemModel = Items[CurrentIndex];
			if (carouselViewItemModel.IsPlaying)
			{
				carouselViewItemModel.IsPlaying = false;
			}
			if (index > -1 && index < Items.Count)
			{
				CurrentIndex = index.Value;
			}
		}
	}

	[RelayCommand]
	private async Task NextAsync()
	{
		if (CurrentIndex < Items.Count - 1)
		{
			CurrentIndex++;
		}
		else
		{
			await CloseAsync();
		}
	}

	[RelayCommand]
	private void Previous()
	{
		CurrentIndex--;
	}

	[RelayCommand]
	protected async Task CloseAsync()
	{
		await base.NavigationService.PopCurrentModalPage();
		WeakEventManager.HandleEvent(this, EventArgs.Empty, "CloseClicked");
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnCurrentItemChanged(CarouselViewItemModel? value)
	{
		if (value == null || !value.IsImage)
		{
			value.IsPlaying = true;
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	private void OnCurrentIndexChanged(int value)
	{
		if (value >= 0 && value < Items.Count)
		{
			if (CurrentItem != null)
			{
				CurrentItem.IsVisible = false;
			}
			CurrentItem = Items[value];
			CurrentItem.IsVisible = true;
		}
	}
}
