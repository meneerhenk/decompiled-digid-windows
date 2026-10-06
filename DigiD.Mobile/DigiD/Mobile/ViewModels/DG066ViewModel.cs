using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel.__Internals;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.BaseClasses;
using DigiD.Common.Models;
using Microsoft.Maui.ApplicationModel;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG066ViewModel : CommonBaseViewModel
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private List<OpenSourceLibraryModel>? _003CItems_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<Uri?>? openWebsiteCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public List<OpenSourceLibraryModel>? Items
	{
		get
		{
			return _003CItems_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<List<OpenSourceLibraryModel>>.Default.Equals(_003CItems_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Items);
				_003CItems_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Items);
			}
		}
	}

	private static Lazy<List<OpenSourceLibraryModel>> OpenSourceItems => new Lazy<List<OpenSourceLibraryModel>>(delegate
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("opensource-packages.json");
		if (stream == null)
		{
			return new List<OpenSourceLibraryModel>();
		}
		return JsonSerializer.Deserialize<List<OpenSourceLibraryModel>>(stream) ?? new List<OpenSourceLibraryModel>();
	});

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<Uri?> OpenWebsiteCommand => openWebsiteCommand ?? (openWebsiteCommand = new AsyncRelayCommand<Uri>(OpenWebsite));

	public DG066ViewModel()
	{
		base.CloseButtonVisible = true;
		Items = OpenSourceItems.Value.OrderBy((OpenSourceLibraryModel x) => x.Title).ToList();
	}

	[RelayCommand]
	private static async Task OpenWebsite(Uri? uri)
	{
		if (!(uri == null))
		{
			await Browser.OpenAsync(uri);
		}
	}
}
