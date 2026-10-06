using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG053ViewModel : CommonBaseViewModel
{
	private int _pageIndex;

	private bool _endOfData;

	private bool _isBusy;

	private readonly IUsageHistoryApi api;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ObservableCollection<UsageHistoryModel> _003CItems_003Ek__BackingField = new ObservableCollection<UsageHistoryModel>();

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? loadDataCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ObservableCollection<UsageHistoryModel> Items
	{
		get
		{
			return _003CItems_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ObservableCollection<UsageHistoryModel>>.Default.Equals(_003CItems_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Items);
				_003CItems_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Items);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand LoadDataCommand => loadDataCommand ?? (loadDataCommand = new AsyncRelayCommand(LoadDataAsync));

	public DG053ViewModel(IUsageHistoryApi api)
	{
		base.PageId = "DG053";
		base.CloseButtonVisible = true;
		this.api = api;
	}

	public async Task Initialize()
	{
		_pageIndex = 0;
		while (_pageIndex < 2)
		{
			await LoadDataAsync();
		}
	}

	[RelayCommand]
	public async Task LoadDataAsync()
	{
		if (_isBusy || _endOfData)
		{
			return;
		}
		base.DialogService.Show();
		_isBusy = true;
		List<UsageHistoryModel> data = await api.GetUsageHistory(_pageIndex);
		_pageIndex++;
		foreach (UsageHistoryModel row in data)
		{
			Items.Add(row);
		}
		_endOfData = data.Count == 0;
		_isBusy = false;
		await base.DialogService.Hide();
	}
}
