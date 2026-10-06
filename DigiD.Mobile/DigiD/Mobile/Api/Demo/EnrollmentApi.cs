using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DigiD.Common.Enums;
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
using DigiD.Mobile.Models;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class EnrollmentApi : BaseApiService, IEnrollmentApi
{
	private bool _removeOldApp;

	private int _letterAttempts;

	private int _smsAttempts;

	private int _pollingCount;

	private DateTime? _smsSendDate;

	private string? _challenge;

	public EnrollmentApi(ILogger<EnrollmentApi> logger, IMobileSettings mobileSettings)
	{
		_003CmobileSettings_003EP = mobileSettings;
		base._002Ector(logger);
	}

	public async Task<EnrollmentChallengeResponse> EnrollmentChallenge(EnrollmentChallengeRequest requestData)
	{
		await Task.Delay(0);
		_challenge = RandomNumberGenerator.GetBytes(16).ToBase16();
		return SendAsync("/apps/challenge", requestData, new EnrollmentChallengeResponse
		{
			ApiResult = ApiResult.Ok,
			Challenge = _challenge
		});
	}

	public async Task<CompleteChallengeResponse> CompleteChallenge(CompleteChallengeRequest requestData)
	{
		await Task.Delay(0);
		CompleteChallengeResponse response = new CompleteChallengeResponse
		{
			IV = RandomNumberGenerator.GetBytes(16),
			SymmetricKey = RandomNumberGenerator.GetBytes(32),
			ApiResult = ApiResult.Ok
		};
		ArgumentNullException.ThrowIfNull(requestData.Signature, "requestData.Signature");
		ArgumentNullException.ThrowIfNull(requestData.PublicKey, "requestData.PublicKey");
		ArgumentNullException.ThrowIfNull(_challenge, "_challenge");
		byte[] challenge = Encoding.UTF8.GetBytes(_challenge);
		if (!SignerHelper.VerifySignature(requestData.PublicKey, challenge, requestData.Signature))
		{
			response.ApiResult = ApiResult.Nok;
			return response;
		}
		if (!DemoConfig.KeyAttestationSuccess)
		{
			response.ErrorMessage = "key_attestation_failed";
		}
		else if (requestData.KeyAttestation != null && !AttestationValidator.Validate(challenge))
		{
			response.ApiResult = ApiResult.Ok;
			response.ErrorMessage = "key_attestation_failed";
		}
		return SendAsync("/apps/challenge_response", requestData, response);
	}

	public async Task<CompleteActivationResponse> CompleteActivationAsync(PincodeRequest requestData)
	{
		await Task.Delay(0);
		ApiResult apiResult = ApiResult.Ok;
		if (AppSession.Process == Process.AppActivateWithRDA && !_removeOldApp)
		{
			apiResult = ApiResult.Pending;
		}
		else
		{
			ActivationSessionData? activationSessionData = HttpSession.ActivationSessionData;
			if (activationSessionData != null && activationSessionData.ActivationMethod == ActivationMethod.RequestNewDigidAccount)
			{
				apiResult = ApiResult.Pending;
			}
			else
			{
				bool flag = DemoConfig.ActivationMethod == ActivationMethod.Password;
				bool flag2 = flag;
				if (flag2)
				{
					bool flag3;
					switch (HttpSession.ActivationSessionData?.ActivationMethod)
					{
					case ActivationMethod.Letter:
					case ActivationMethod.Password:
						flag3 = true;
						break;
					default:
						flag3 = false;
						break;
					}
					flag2 = flag3;
				}
				if (flag2)
				{
					apiResult = ApiResult.Pending;
				}
			}
		}
		_003CmobileSettings_003EP.LoginLevel = LoginLevel.Midden;
		bool isDemoModeEnabled = DemoSettings.IsDemoModeEnabled;
		bool flag4 = isDemoModeEnabled;
		if (flag4)
		{
			ApiResult apiResult2 = apiResult;
			bool flag3 = ((apiResult2 == ApiResult.Ok || apiResult2 == ApiResult.Pending) ? true : false);
			flag4 = flag3;
		}
		if (flag4 && requestData.AppSessionId != null)
		{
			DemoHelper.Sessions[requestData.AppSessionId].IsAuthenticated = true;
			byte[] key = _003CmobileSettings_003EP.SymmetricKey.ToBytes();
			ArgumentNullException.ThrowIfNull(requestData.IV, "requestData.IV");
			DemoSettings.DemoPin = EncryptionHelper.Decrypt(requestData.MaskedPincode, requestData.IV, key);
			if (DemoConfig.HasEmailAddress)
			{
				DemoSettings.EmailAddress = (DemoConfig.IsEmailAddressVerified ? "verified" : "not_verified") + "@digid.nl";
			}
		}
		return SendAsync("/apps/pincode", requestData, new CompleteActivationResponse
		{
			ApiResult = apiResult,
			AuthenticationLevel = _003CmobileSettings_003EP.LoginLevel
		});
	}

	public async Task<BasicAuthenticationResponse> BasicAuthenticate(BasicAuthenticateRequest requestData)
	{
		await Task.Delay(0);
		if (DemoConfig.TrafficMeteringEnabled)
		{
			return new BasicAuthenticationResponse
			{
				ApiResult = ApiResult.TrafficMetered
			};
		}
		if (DemoConfig.MaintenanceEnabled)
		{
			return new BasicAuthenticationResponse
			{
				ApiResult = ApiResult.Maintenance
			};
		}
		_removeOldApp = requestData.RemoveOldApp;
		BasicAuthenticationResponse response = new BasicAuthenticationResponse
		{
			SessionId = DemoHelper.NewSession()
		};
		if (requestData != null && requestData.Username == "demo" && requestData.Password == "12345")
		{
			if (DemoConfig.HasTooManyActiveDevices && !requestData.RemoveOldApp)
			{
				response.ApiResult = ApiResult.Nok;
				response.ErrorMessage = "too_many_active";
				response.MaxAmount = 5;
				response.LastUsed = DateTime.Now.AddDays(-50.0).ToString();
				response.DeviceName = "Demo App";
			}
			else
			{
				if (DemoConfig.IsClassifiedDeceased)
				{
					HttpSession.IsDeceased = true;
					response.ApiResult = ApiResult.Nok;
					response.ErrorMessage = "classified_deceased";
					return response;
				}
				response.ApiResult = ApiResult.Ok;
				response.ActivationMethod = DemoConfig.ActivationMethod;
				response.IsSmsCheckRequested = DemoConfig.IsSmsCheckRequested;
				if (response.ActivationMethod == ActivationMethod.Password && requestData.IsIdCheckSkipped)
				{
					response.PendingActivation = DemoConfig.HasPendingActivation;
				}
			}
		}
		else
		{
			response.ApiResult = ApiResult.Nok;
			response.ErrorMessage = "invalid";
		}
		return SendAsync("/apps/auth", requestData, response);
	}

	public async Task<SessionResponse> InitSession(BasicAuthenticationSessionRequest requestData)
	{
		await Task.Delay(0);
		_smsAttempts++;
		SessionResponse result = new SessionResponse();
		string sMSCode = requestData.SMSCode;
		if ((sMSCode == "123456" || sMSCode == null) ? true : false)
		{
			_smsAttempts = 0;
			result.ApiResult = ApiResult.Ok;
			result.AppId = Guid.NewGuid().ToString();
		}
		else
		{
			result.ApiResult = ApiResult.Nok;
			result.ErrorMessage = ((_smsAttempts == 3) ? "smscode_blocked" : "smscode_incorrect");
			if (_smsAttempts == 3)
			{
				_smsAttempts = 0;
			}
		}
		return SendAsync("/apps/session", requestData, result);
	}

	public async Task<ResendSMSResponse> ResendSMS(bool spoken)
	{
		await Task.Delay(0);
		if (_smsSendDate.HasValue && DateTime.Now - _smsSendDate.Value < TimeSpan.FromSeconds(60L))
		{
			return new ResendSMSResponse
			{
				ApiResult = ApiResult.Nok,
				ErrorMessage = "sms_too_fast",
				Payload = JsonSerializer.Serialize(new SmsTooFastModel
				{
					TimeLeft = ((int)(DateTime.Now - _smsSendDate.Value).TotalSeconds).ToString()
				})
			};
		}
		_smsSendDate = DateTime.Now;
		return SendAsync("/apps/resend_sms", new ResendSmsRequest(spoken), new ResendSMSResponse
		{
			ApiResult = ApiResult.Ok,
			PhoneNumber = "+31612345678"
		});
	}

	public async Task<RequestSmsResponse> SendSMS()
	{
		await Task.Delay(0);
		_smsSendDate = DateTime.Now;
		return SendAsync("/apps/sms", new BaseRequest(), new RequestSmsResponse
		{
			ApiResult = ApiResult.Ok,
			PhoneNumber = "+31612345678"
		});
	}

	public async Task<ActivationLetterResponse> CompleteLetterActivation(LetterActivationRequest requestData)
	{
		return await CompleteLetterActivation(requestData, ActivationMethod.Letter);
	}

	public async Task<ActivationLetterResponse> ActivateAccountByApp(LetterActivationRequest requestData)
	{
		return await CompleteLetterActivation(requestData, ActivationMethod.AccountAndApp);
	}

	private async Task<ActivationLetterResponse> CompleteLetterActivation(LetterActivationRequest requestData, ActivationMethod method)
	{
		await Task.Delay(0);
		_letterAttempts++;
		ActivationLetterResponse result;
		if (requestData.ActivationCode == "A12345678")
		{
			DemoConfig.HasPendingActivation = false;
			_letterAttempts = 0;
			result = new ActivationLetterResponse
			{
				ApiResult = ApiResult.Ok
			};
		}
		else if (_letterAttempts == 3)
		{
			DemoConfig.HasPendingActivation = false;
			result = new ActivationLetterResponse
			{
				ApiResult = ApiResult.Blocked
			};
		}
		else
		{
			result = new ActivationLetterResponse
			{
				ErrorMessage = ((method == ActivationMethod.AccountAndApp) ? "activation_code_not_correct" : "invalid"),
				ApiResult = ApiResult.Nok,
				RemainingAttempts = 3 - _letterAttempts,
				DateLetterSent = DateTime.Now.AddDays(-3.0)
			};
		}
		return SendAsync((method == ActivationMethod.AccountAndApp) ? "/apps/activationcode_account" : "/apps/activationcode", requestData, result);
	}

	public async Task<BaseResponse> InitSessionLetterActivation()
	{
		await Task.Delay(0);
		_pollingCount = 0;
		return SendAsync("/apps/letter", new BaseRequest(), new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<BaseResponse> LetterActivationPolling()
	{
		await Task.Delay(0);
		_pollingCount++;
		if (_pollingCount == 3)
		{
			DemoConfig.HasPendingActivation = true;
		}
		return SendAsync("/apps/letter_poll", new BaseRequest(), new BaseResponse
		{
			ApiResult = ((_pollingCount == 3) ? ApiResult.Ok : ApiResult.Pending)
		});
	}

	public async Task<BaseResponse> InitSessionActivationRDA()
	{
		await Task.Delay(0);
		return SendAsync("/apps/rda_activation", new BaseRequest(), new InitSessionResponse
		{
			ApiResult = ApiResult.Ok,
			SessionId = DemoHelper.NewSession("upgrade_app")
		});
	}

	public async Task<BaseResponse> VerifyRDAActivation()
	{
		await Task.Delay(0);
		return SendAsync("/apps/rda_activation_verified", new BaseRequest(), new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<InitSessionResponse> InitSessionActivationCode(ActivationCodeSessionRequest requestData)
	{
		await Task.Delay(0);
		_letterAttempts = 0;
		return SendAsync("/apps/activationcode_session", requestData, new InitSessionResponse
		{
			ApiResult = ApiResult.Ok,
			SessionId = DemoHelper.NewSession(requestData.RequestNewLetter ? "re_request_letter" : "activation_by_letter")
		});
	}

	public async Task<StartSessionResponse> InitSessionActivationByApp()
	{
		await Task.Delay(0);
		_pollingCount = 0;
		return SendAsync("/apps/activate/start", new BaseRequest(), new StartSessionResponse
		{
			ApiResult = ApiResult.Ok,
			AppSessionId = DemoHelper.NewSession(),
			At = DateHelper.GetEpochSeconds()
		});
	}

	public async Task<AuthenticationStatusResponse> ActivationByAppPolling()
	{
		await Task.Delay(1000);
		_pollingCount++;
		ApiResult status = ApiResult.Pending;
		bool sessionReceived = false;
		switch (_pollingCount)
		{
		case 1:
			await Task.Delay(2000);
			break;
		case 2:
			sessionReceived = true;
			break;
		case 4:
			status = ApiResult.PendingConfirmed;
			break;
		case 6:
			status = ApiResult.Ok;
			break;
		}
		return SendAsync("/apps/authentication_status", new BaseRequest(), new AuthenticationStatusResponse
		{
			ApiResult = status,
			SessionReceived = sessionReceived
		});
	}

	public async Task<RequestAccountResponse> InitSessionAccountRequest(RequestAccountRequest requestData)
	{
		await Task.Delay(0);
		RequestAccountResponse result = ((requestData == null || !(requestData.Bsn == "000000012") || !(requestData.HouseNumber == "1") || !(requestData.Postalcode == "1000AA")) ? new RequestAccountResponse
		{
			ApiResult = ApiResult.Nok,
			ErrorMessage = "invalid_parameters"
		} : new RequestAccountResponse
		{
			ApiResult = ApiResult.Ok,
			AppSessionId = DemoHelper.NewSession()
		});
		return SendAsync("/apps/account_requests/start", requestData, result);
	}

	public async Task<BaseResponse> AccountRequestsCheckApp(BaseRequest requestData)
	{
		await Task.Delay(0);
		return SendAsync("/apps/account_requests/existing_application", requestData, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<BaseResponse> AccountRequestsReplaceApp(ReplaceExistingApplicationRequest requestData)
	{
		await Task.Delay(0);
		return SendAsync("/apps/account_requests/replace_application", requestData, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<BaseResponse> AccountRequestsBrpPoll(BaseRequest requestData)
	{
		await Task.Delay(100);
		BaseResponse result;
		if (DemoConfig.IsClassifiedDeceased)
		{
			HttpSession.IsDeceased = true;
			result = new BaseResponse
			{
				ApiResult = ApiResult.Nok,
				ErrorMessage = "gba_deceased"
			};
		}
		else
		{
			result = new BaseResponse
			{
				ApiResult = ApiResult.Ok
			};
		}
		return SendAsync("/apps/account_requests/brp_poll", requestData, result);
	}

	public async Task<BaseResponse> AccountRequestsCheckAccount(BaseRequest requestData)
	{
		await Task.Delay(1);
		return SendAsync("/apps/account_requests/existing_account", requestData, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<BaseResponse> AccountRequestsReplaceAccount(ReplaceExistingAccountRequest requestData)
	{
		await Task.Delay(0);
		return SendAsync("/apps/account_requests/replace_account", requestData, new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<BaseResponse> SkipRda()
	{
		await Task.Delay(0);
		return SendAsync("/apps/skip_rda", new BaseRequest(), new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}
}
