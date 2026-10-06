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
using DigiD.Common.Models;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DG054ViewModel : CommonBaseViewModel
{
	private RegisterEmailModel? _model;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CEmailAddress_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? confirmCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? EmailAddress
	{
		get
		{
			return _003CEmailAddress_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CEmailAddress_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.EmailAddress);
				_003CEmailAddress_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.EmailAddress);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> ConfirmCommand => confirmCommand ?? (confirmCommand = new AsyncRelayCommand<string>(Confirm));

	public DG054ViewModel()
	{
		base.CloseButtonVisible = AppSession.IsAuthenticated;
		base.HasBackButton = HttpSession.WebSessionInfoResponse == null;
	}

	public void Initialize(RegisterEmailModel model)
	{
		_model = model;
		if (model.Verified)
		{
			base.MessageText = DigiDAppResources.DG054_Body;
			base.PageId = "DG054A";
		}
		else
		{
			base.MessageText = DigiDAppResources.DG054B_Body;
			base.PageId = "DG054B";
		}
		EmailAddress = _model.EmailAddress;
	}

	protected override Task EnterPressed()
	{
		return Confirm("1");
	}

	[RelayCommand]
	private async Task Confirm(string value)
	{
		ArgumentNullException.ThrowIfNull(_model, "_model");
		if (value == "1")
		{
			await _model.NextAction(_model.Verified);
		}
		else if (_model.AbortAction != null)
		{
			await _model.AbortAction();
		}
	}
}
