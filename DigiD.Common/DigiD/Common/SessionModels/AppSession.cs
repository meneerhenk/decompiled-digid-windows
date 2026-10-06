using System;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Messages;
using Microsoft.Maui.Controls;

namespace DigiD.Common.SessionModels;

public static class AppSession
{
	public static bool HasNfc { get; set; }

	public static bool IsKeyAttestationSupported { get; set; }

	public static bool IsKeyAttestationFailed { get; set; }

	public static bool IsAppActivatedFromBrowser { get; set; }

	public static AppActivationState ActivationState { get; private set; }

	public static BiometricType BiometricType { get; set; }

	public static IServiceProvider ServiceProvider => ((IApp)Application.Current).ServiceProvider;

	public static Process Process { get; set; }

	public static bool IsAppActivated { get; set; }

	public static bool RDASkipped { get; set; }

	public static bool IsAuthenticated { get; set; }

	public static bool IsAppVisible { get; set; } = true;

	public static ActivationStatus ActivationStatus { get; set; }

	public static AppAuthenticationType AppAuthenticationType { get; set; }

	public static string MyDigiDUrl { get; set; } = null;

	public static bool LaunchMyDigiDFromMenu { get; set; }

	public static void SetNextState(AppActivationState? activationState = null)
	{
		if (!activationState.HasValue)
		{
			ActivationState++;
		}
		else
		{
			ActivationState = activationState.Value;
		}
		if (ActivationState == AppActivationState.ScanId && (!HasNfc || !IsKeyAttestationSupported || IsKeyAttestationFailed))
		{
			ActivationState++;
		}
		WeakReferenceMessenger.Default.Send(new AppStateChangedMessage(ActivationState));
	}

	public static void ResetActivationState(ActivationStatus status = ActivationStatus.NotActivated)
	{
		HttpSession.ActivationSessionData = null;
		ActivationStatus = status;
		SetNextState(AppActivationState.Login);
		RDASkipped = false;
		IsAppActivated = false;
		IsKeyAttestationFailed = false;
	}

	public static void Reset()
	{
		ResetActivationState();
		Process = Process.NotSet;
		IsAuthenticated = false;
	}
}
