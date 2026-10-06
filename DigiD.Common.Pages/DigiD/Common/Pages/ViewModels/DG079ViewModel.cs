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
using DigiD.Common.EID.SessionModels;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.NFC.Enums;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using WinRT;
using WinRT.DigiD_Common_PagesVtableClasses;

namespace DigiD.Common.Pages.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Pages_Pages_DG084WinRTTypeDetails))]
public class DG079ViewModel : CommonBaseViewModel
{
	private readonly IRdaApi rdaApi;

	private readonly IEIDApi eidApi;

	private DocumentType _documentType;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CCurrentDocumentType_003Ek__BackingField = "";

	private Func<Task>? _nextAction;

	private Func<Task>? _cancelAction;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CImageSource_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? nextCommand;

	[ObservableProperty]
	[NotifyPropertyChangedFor("DriversLicenseSelected")]
	[NotifyPropertyChangedFor("PassportSelected")]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string CurrentDocumentType
	{
		get
		{
			return _003CCurrentDocumentType_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CCurrentDocumentType_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.CurrentDocumentType);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.DriversLicenseSelected);
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.PassportSelected);
				_003CCurrentDocumentType_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.CurrentDocumentType);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.DriversLicenseSelected);
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.PassportSelected);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? ImageSource
	{
		get
		{
			return _003CImageSource_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CImageSource_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.ImageSource);
				_003CImageSource_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.ImageSource);
			}
		}
	}

	public bool DriversLicenseSelected => _documentType == DocumentType.DrivingLicense;

	public bool PassportSelected => _documentType == DocumentType.Passport;

	public string? DG079_Text2 { get; set; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand NextCommand => nextCommand ?? (nextCommand = new AsyncRelayCommand(NextAsync));

	public DG079ViewModel(IRdaApi rdaApi, IEIDApi eidApi)
	{
		this.rdaApi = rdaApi;
		this.eidApi = eidApi;
		base.CloseButtonVisible = true;
	}

	protected override async Task CloseButtonClicked()
	{
		if (_cancelAction != null)
		{
			await _cancelAction();
			return;
		}
		if (HttpSession.WidSessionResponse == null)
		{
			await rdaApi.Cancel();
		}
		else
		{
			await eidApi.CancelAuthenticate();
		}
		await base.CloseButtonClicked();
	}

	public void Initialize(DocumentType documentType, Func<Task> nextAction, Func<Task>? cancelAction)
	{
		_documentType = documentType;
		_nextAction = nextAction;
		_cancelAction = cancelAction;
		CurrentDocumentType = _documentType.Translate().ToLower();
		ImageSource = "afbeelding_phone_" + _documentType.ToString().ToLower();
		base.HeaderText = string.Format(CommonResources.DG079_Title_RDA, CurrentDocumentType);
		DG079_Text2 = CommonResources.DG079_Text2;
	}

	public void Initialize(Func<Task> nextAction)
	{
		ArgumentNullException.ThrowIfNull(EIDSession.Card, "EIDSession.Card");
		_documentType = EIDSession.Card.DocumentType;
		_nextAction = nextAction;
		CurrentDocumentType = _documentType.Translate().ToLower();
		ImageSource = "afbeelding_phone_" + _documentType.ToString().ToLower();
		base.HeaderText = string.Format(CommonResources.DG079_Title_PCA, _documentType.Translate());
		DG079_Text2 = CommonResources.DG079_Text2;
	}

	[RelayCommand]
	private Task NextAsync()
	{
		ArgumentNullException.ThrowIfNull(_nextAction, "_nextAction");
		return _nextAction();
	}
}
