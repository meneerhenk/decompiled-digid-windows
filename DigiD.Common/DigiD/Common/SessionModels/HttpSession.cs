using System;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.ResponseModels;
using Microsoft.Maui.Controls;

namespace DigiD.Common.SessionModels;

public static class HttpSession
{
	private const int IDCheckWarningDays = 30;

	public static string HostName => "https://" + ((IApp)Application.Current).GeneralPreferences.SelectedHost;

	public static string? SourceApplication { get; set; }

	public static string? AppSessionId { get; set; }

	public static string? AuthenticationSessionId { get; set; }

	public static Browser Browser { get; set; }

	public static bool IsApp2AppSession { get; private set; }

	public static bool IsWeb2AppSession { get; private set; }

	public static bool IsApp2AppSessionStarted { get; set; }

	public static bool RemoveOldApp { get; set; }

	public static bool IsDeceased { get; set; }

	public static DateTime? SubExpiryDate { get; set; }

	public static bool WillIDCheckExpire => SubExpiryDate.HasValue && Math.Abs((DateTime.Now.Date - SubExpiryDate.Value).TotalDays) <= 30.0;

	public static BasicAuthenticationResponse? AuthenticationResponse { get; set; }

	public static WebSessionInfoResponse? WebSessionInfoResponse { get; set; }

	public static WidSessionResponse? WidSessionResponse { get; set; }

	public static TempSessionData? TempSessionData { get; set; }

	public static ActivationSessionData? ActivationSessionData { get; set; }

	public static void SetAuthenticationType(AuthenticationType authenticationType)
	{
		IsApp2AppSession = authenticationType == AuthenticationType.App2App;
		IsWeb2AppSession = authenticationType == AuthenticationType.Web2App;
	}
}
