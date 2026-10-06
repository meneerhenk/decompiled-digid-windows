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
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.SessionModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls.Models;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_HyperlinkLabelWinRTTypeDetails))]
public class MenuItem : ObservableObject
{
	private readonly IMatomoService matomoService;

	private bool canTap = true;

	private readonly Func<Task>? command;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string? _003CState_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource? _003CIconSource_003Ek__BackingField;

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	private AsyncRelayCommand? itemSelectedCommand;

	public LocalizedString Title { get; private set; }

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public string? State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<string>.Default.Equals(_003CState_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.State);
				_003CState_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.State);
			}
		}
	}

	[ObservableProperty]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public ImageSource? IconSource
	{
		get
		{
			return _003CIconSource_003Ek__BackingField;
		}
		set
		{
			if (!EqualityComparer<ImageSource>.Default.Equals(_003CIconSource_003Ek__BackingField, value))
			{
				OnPropertyChanging(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangingArgs.IconSource);
				_003CIconSource_003Ek__BackingField = value;
				OnPropertyChanged(CommunityToolkit.Mvvm.ComponentModel.__Internals.__KnownINotifyPropertyChangedArgs.IconSource);
			}
		}
	}

	public bool IsChevronVisible { get; set; }

	public string AutomationId { get; }

	public string MatomoEventName { get; }

	public bool IsExternalLink { get; init; }

	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.4.0.0")]
	[ExcludeFromCodeCoverage]
	public IAsyncRelayCommand ItemSelectedCommand => itemSelectedCommand ?? (itemSelectedCommand = new AsyncRelayCommand(ItemSelectedAsync));

	[RelayCommand]
	private async Task? ItemSelectedAsync()
	{
		if (command != null && canTap)
		{
			canTap = false;
			matomoService.TrackAction("Menu", "Click", MatomoEventName);
			await command();
			canTap = true;
		}
	}

	protected MenuItem(string automationTestId, string title, string icon, Func<Task>? command, bool isExternalLink = false)
	{
		MenuItem menuItem = this;
		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, delegate
		{
			menuItem.IconSource = (ImageSource)Application.Current.Resources[icon];
		});
		matomoService = ((IApp)Application.Current).ServiceProvider.GetRequiredService<IMatomoService>();
		IconSource = (ImageSource)Application.Current.Resources[icon];
		AutomationId = "MenuItem" + automationTestId;
		MatomoEventName = automationTestId;
		Title = new LocalizedString(() => AppSession.ServiceProvider.GetRequiredService<ILocalizationResourceManager>()[title]);
		IsExternalLink = icon.Contains("ExternalLink") || isExternalLink;
		this.command = command;
	}
}
