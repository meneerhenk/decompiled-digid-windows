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
using DigiD.Common.Models.Config;
using DigiD.Mobile.Models;
using WinRT;
using WinRT.DigiD_MobileVtableClasses;

namespace DigiD.Mobile.ViewModels;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Mobile_Pages_DG037WinRTTypeDetails))]
public class DM001ViewModel : CommonBaseViewModel
{
	private Func<string, Task>? _confirm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private List<DemoActionModel>? _003CActions_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand<string>? confirmCommand;

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public List<DemoActionModel>? Actions
	{
		get
		{
			return _003CActions_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<List<DemoActionModel>>.Default.Equals(_003CActions_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.Actions);
				_003CActions_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.Actions);
			}
		}
	}

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand<string> ConfirmCommand => confirmCommand ?? (confirmCommand = new AsyncRelayCommand<string>(ConfirmAsync));

	public void Initialize(Func<string, Task> confirm, bool widAuthentication)
	{
		_confirm = confirm;
		List<DemoActionModel> list = new List<DemoActionModel>
		{
			new DemoActionModel
			{
				Title = "Wijzigen telefoonnummer",
				Action = "change_phone_number"
			},
			new DemoActionModel
			{
				Title = "Activeren SMS",
				Action = "activate_sms_authenticator"
			},
			new DemoActionModel
			{
				Title = "Wijzigen wachtwoord",
				Action = "change_password"
			},
			new DemoActionModel
			{
				Title = "Toevoegen e-mail",
				Action = "add_email"
			},
			new DemoActionModel
			{
				Title = "Wijzigen e-mail",
				Action = "change_email"
			},
			new DemoActionModel
			{
				Title = "Verwijderen e-mail",
				Action = "remove_email"
			},
			new DemoActionModel
			{
				Title = "Opzeggen DigiD",
				Action = "cancel_account"
			},
			new DemoActionModel
			{
				Title = "App deactiveren",
				Action = "deactivate_app"
			},
			new DemoActionModel
			{
				Title = "Intrekken Identiteitskaart",
				Action = "revoke_identity_card"
			},
			new DemoActionModel
			{
				Title = "Intrekken rijbewijs",
				Action = "revoke_driving_license"
			}
		};
		if (widAuthentication)
		{
			list.Add(new DemoActionModel
			{
				Title = "Activeren Identiteitskaart",
				Action = "activate_identity_card"
			});
			list.Add(new DemoActionModel
			{
				Title = "Heractiveren Identiteitskaart",
				Action = "reactivate_identity_card"
			});
			list.Add(new DemoActionModel
			{
				Title = "Activeren Rijbewijs",
				Action = "activate_driving_licence"
			});
			list.Add(new DemoActionModel
			{
				Title = "Heractiveren Rijbewijs",
				Action = "activate_driving_licence"
			});
		}
		list.Insert(0, new DemoActionModel
		{
			Title = (DemoConfig.EIDASUser ? "Inloggen bij EIDAS Demo" : "Inloggen bij DigiD Demo"),
			Action = "webservice"
		});
		Actions = list;
	}

	[RelayCommand]
	private async Task ConfirmAsync(string action)
	{
		ArgumentNullException.ThrowIfNull(_confirm, "_confirm");
		await _confirm(action);
	}
}
