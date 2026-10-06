using System;
using System.Text;
using System.Threading.Tasks;
using DigiD.Common.Helpers;
using DigiD.Common.Http.Demo;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Helpers;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.ResponseModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.Preferences;
using DigiD.Common.SessionModels;
using DigiD.Common.Settings;
using DigiD.Mobile.Helpers;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class AuthenticationApi : BaseApiService, IAuthenticationApi
{
	private int attempts;

	private int triesEHA;

	public AuthenticationApi(IMobileSettings mobileSettings, ILogger<AuthenticationApi> logger)
	{
		_003CmobileSettings_003EP = mobileSettings;
		base._002Ector(logger);
	}

	public async Task<BaseResponse> SessionStatus()
	{
		await Task.Delay(20);
		if (string.IsNullOrEmpty(HttpSession.AuthenticationSessionId))
		{
			return new BaseResponse
			{
				ApiResult = ApiResult.SessionNotFound
			};
		}
		return SendAsync(responseData: new BaseResponse
		{
			ApiResult = ApiResult.Ok
		}, url: "/apps/session_status", requestData: new BaseRequest());
	}

	public async Task<StartSessionBaseResponse> InitSessionAuthentication()
	{
		await Task.Delay(0);
		StartSessionBaseResponse response = SendAsync(responseData: new StartSessionBaseResponse
		{
			ApiResult = ApiResult.Ok,
			AppSessionId = DemoHelper.NewSession("new_session"),
			At = DateHelper.GetEpochSeconds()
		}, url: "/apps/request_session", requestData: new BaseRequest());
		if (DemoConfig.TrafficMeteringEnabled)
		{
			DemoConfig.TrafficMeteringEnabled = false;
		}
		if (DemoConfig.MaintenanceEnabled)
		{
			DemoConfig.MaintenanceEnabled = false;
		}
		return response;
	}

	public async Task<ChallengeResponse> Challenge(ChallengeRequest requestData)
	{
		await Task.Delay(0);
		DemoSession session = DemoHelper.GetSession(requestData.AuthenticationSessionId);
		return SendAsync("/apps/challenge", requestData, new ChallengeResponse
		{
			ApiResult = ApiResult.Ok,
			IV = session.IV,
			Challenge = session.Challenge
		});
	}

	public async Task<ValidatePinResponse> ValidatePin(ValidatePinRequest requestData)
	{
		await Task.Delay(0);
		attempts++;
		DemoSession session = DemoHelper.GetSession(requestData.AuthenticationSessionId);
		ArgumentNullException.ThrowIfNull(session, "session");
		ArgumentNullException.ThrowIfNull(session.Challenge, "session.Challenge");
		ArgumentNullException.ThrowIfNull(session.IV, "session.IV");
		ArgumentNullException.ThrowIfNull(requestData.Signature, "requestData.Signature");
		bool isValidSignature = false;
		if (requestData.PublicKey != null)
		{
			isValidSignature = SignerHelper.VerifySignature(challenge: Encoding.UTF8.GetBytes(session.Challenge), publicKey: requestData.PublicKey, signature: requestData.Signature);
		}
		bool keyAttestationSuccess = true;
		if (isValidSignature)
		{
			string maskedPin = EncryptionHelper.Decrypt(key: _003CmobileSettings_003EP.SymmetricKey.ToBytes(), data: requestData.PIN, iv: session.IV);
			if (maskedPin == DemoSettings.DemoPin)
			{
				if (requestData.KeyAttestation != null && DemoConfig.KeyAttestationSuccess)
				{
					ArgumentNullException.ThrowIfNull(session.Challenge, "session.Challenge");
					byte[] challenge = Encoding.UTF8.GetBytes(session.Challenge);
					keyAttestationSuccess = AttestationValidator.Validate(challenge);
				}
				attempts = 0;
				ArgumentNullException.ThrowIfNull(requestData.AuthenticationSessionId, "requestData.AuthenticationSessionId");
				DemoHelper.Sessions[requestData.AuthenticationSessionId].IsAuthenticated = true;
				if (DemoConfig.IsClassifiedDeceased)
				{
					switch (session.Action)
					{
					case "change_app_pin":
					case "activation_by_letter":
					case "upgrade_app":
						return new ValidatePinResponse
						{
							ApiResult = ApiResult.Nok,
							ErrorMessage = "classified_deceased",
							IsDeceased = DemoConfig.IsClassifiedDeceased
						};
					}
				}
				if (_003CmobileSettings_003EP.LoginLevel == LoginLevel.Substantieel && DemoConfig.SubExpiryDate.HasValue && DemoConfig.SubExpiryDate.Value.Date == DateTime.Now.Date)
				{
					_003CmobileSettings_003EP.LoginLevel = LoginLevel.Midden;
					DemoConfig.SubExpiryDate = null;
				}
				return SendAsync("/apps/check_pincode", requestData, new ValidatePinResponse
				{
					ApiResult = (keyAttestationSuccess ? ApiResult.Ok : ApiResult.Nok),
					AuthenticationLevel = _003CmobileSettings_003EP.LoginLevel,
					IsDeceased = DemoConfig.IsClassifiedDeceased,
					SubExpiryDate = DemoConfig.SubExpiryDate
				});
			}
			int remainingAttempts = 3 - attempts;
			ValidatePinResponse result = SendAsync("/apps/check_pincode", requestData, new ValidatePinResponse
			{
				ApiResult = ((remainingAttempts > 0) ? ApiResult.Nok : ApiResult.Blocked),
				RemainingAttempts = remainingAttempts
			});
			if (result.ApiResult == ApiResult.Blocked)
			{
				attempts = 0;
			}
			return result;
		}
		return SendAsync("apps/check_pincode", requestData, new ValidatePinResponse
		{
			ApiResult = ApiResult.Nok,
			ErrorMessage = "key_attestation_failed"
		});
	}

	public async Task<ConfirmResponse> Confirm(ConfirmRequest requestData)
	{
		await Task.Delay(10);
		ArgumentNullException.ThrowIfNull(HttpSession.AppSessionId, "HttpSession.AppSessionId");
		DemoHelper.Sessions.Remove(HttpSession.AppSessionId);
		return SendAsync("/apps/confirm", requestData, new ConfirmResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<WebSessionInfoResponse> SessionInfo()
	{
		await Task.Delay(10);
		ArgumentNullException.ThrowIfNull(HttpSession.AppSessionId, "HttpSession.AppSessionId");
		DemoSession session = DemoHelper.GetSession(HttpSession.AppSessionId);
		WebSessionInfoResponse result = new WebSessionInfoResponse
		{
			ApiResult = ApiResult.Ok,
			AuthenticationLevel = session.LoginLevel
		};
		if (DemoConfig.NeedSubInFuture)
		{
			result.NewAuthenticationLevel = LoginLevel.Substantieel;
			result.NewAuthenticationLevelStartDate = DateTime.Now.AddMonths(1);
		}
		if (DemoConfig.EIDASUser)
		{
			if (!DemoConfig.EIDASSuccess)
			{
				result.ApiResult = ApiResult.Nok;
				result.ErrorMessage = "aborted_contact_helpdesk";
				return result;
			}
			result.HashedPIP = "7c66a40841d1096dc919ad309671b72e35f0a24edf62e336515a14eabaadd60d";
		}
		switch (session.Action)
		{
		case "deactivate_app":
			result.AppIdToDestroy = _003CmobileSettings_003EP.AppId;
			result.LastSignInDate = DateTime.Now;
			result.DeviceName = "DigiD Demo App";
			break;
		case "webservice":
		case "app2app":
			result.WebService = "DigiD Demo";
			break;
		default:
			result.Action = session.Action;
			break;
		}
		return SendAsync("/apps/web_session_information", new BaseRequest(), result);
	}

	public async Task<ApiResult> AbortAuthentication(string abortCode)
	{
		await Task.Delay(0);
		return SendAsync("/apps/abort_authentication", new { abortCode }, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		}).ApiResult;
	}

	public async Task<ApiResult> LogOutSession(bool userAction)
	{
		await Task.Delay(0);
		return SendAsync("/apps/logout_session", new BaseRequest(), new BaseResponse
		{
			ApiResult = ApiResult.Ok
		}).ApiResult;
	}

	public async Task<PendingSessionResponse> CheckPendingSession()
	{
		await Task.Delay(0);
		PendingSessionResponse response = new PendingSessionResponse
		{
			ApiResult = ApiResult.Nok
		};
		if (DemoConfig.IsEHAEnabled)
		{
			triesEHA++;
			if (triesEHA > 1)
			{
				triesEHA = 0;
				response = new PendingSessionResponse
				{
					ApiResult = ApiResult.Ok,
					SessionId = DemoHelper.NewSession(),
					WebService = "DigiD Demo",
					AuthenticationLevel = LoginLevel.Midden
				};
				DemoConfig.IsEHAEnabled = false;
			}
		}
		return SendAsync("/apps/check_pending_session", new PendingSessionRequest
		{
			AppId = _003CmobileSettings_003EP.AppId
		}, response);
	}
}
