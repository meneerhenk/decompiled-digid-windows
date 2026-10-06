using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Http;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.RDA.Api;

public class RdaApi : BaseApiService, IRdaApi
{
	private RdaSession? _session;

	public RdaApi(ILogger<RdaApi> logger, IGeneralPreferences preferences, IHttpClientFactory factory)
		: base(logger, preferences, factory)
	{
	}

	public void Initialize(RdaSession session)
	{
		_session = session;
	}

	public async Task<InitSessionResponse> InitSessionRDA()
	{
		return await PostAsync<InitSessionResponse>("apps/rda/init", new BaseAuthSessionRequest());
	}

	public async Task<BaseResponse> Documents()
	{
		var data = new
		{
			app_session_id = HttpSession.AppSessionId
		};
		return await PostAsync<BaseResponse>("apps/rda/documents", data);
	}

	public async Task<RdaSessionResponse> Poll()
	{
		var data = new
		{
			app_session_id = HttpSession.AppSessionId
		};
		return await PostAsync<RdaSessionResponse>("apps/rda/poll", data);
	}

	public async Task<ApiResult> Verified()
	{
		var data = new
		{
			app_session_id = HttpSession.AppSessionId
		};
		return (await PostAsync<BaseResponse>("apps/rda/verified", data)).ApiResult;
	}

	public async Task<BaseResponse> Cancel()
	{
		var data = new
		{
			app_session_id = HttpSession.AppSessionId
		};
		return await PostAsync<BaseResponse>("apps/rda/cancel", data);
	}

	public async Task<RdaStartResponse> Start(string? type, EFCardAccess? cardAccess)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<RdaStartResponse>(data: new
		{
			sessionId = _session.SessionId,
			type = type,
			cardAccessData = cardAccess?.Base64Encoded
		}, uri: new Uri(_session.Url + "/v1/start"));
	}

	public async Task<SelectResponse> Challenge(string? challenge)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<SelectResponse>(data: new
		{
			sessionId = _session.SessionId,
			challenge = challenge
		}, uri: new Uri(_session.Url + "/v1/challenge"));
	}

	public async Task<CommandResponse> Authenticate(string? authenticate, string? challenge)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<CommandResponse>(data: new
		{
			sessionId = _session.SessionId,
			authenticate = authenticate,
			challenge = challenge
		}, uri: new Uri(_session.Url + "/v1/authenticate"));
	}

	public async Task<CommandResponse> SecureMessaging(List<string> responses)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<CommandResponse>(data: new
		{
			sessionId = _session.SessionId,
			responses = responses
		}, uri: new Uri(_session.Url + "/v1/secure_messaging"));
	}

	public async Task<PrepareResponseModel> Prepare(byte[] encryptedNonce)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<PrepareResponseModel>(data: new
		{
			sessionId = _session.SessionId,
			encryptedNonce = encryptedNonce
		}, uri: new Uri(_session.Url + "/v1/prepare"));
	}

	public async Task<MapResponseModel> Map(byte[] mappedNonce)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<MapResponseModel>(data: new
		{
			sessionId = _session.SessionId,
			mappedNonce = mappedNonce
		}, uri: new Uri(_session.Url + "/v1/map"));
	}

	public async Task<AgreeKeyResponseModel> KeyAgreement(byte[] keyAgree)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<AgreeKeyResponseModel>(data: new
		{
			sessionId = _session.SessionId,
			keyAgree = keyAgree
		}, uri: new Uri(_session.Url + "/v1/key_agreement"));
	}

	public async Task<MutualAuthResponseModel> MutualAuthenticate(byte[]? authenticate, byte[]? encryptedNonce = null)
	{
		ArgumentNullException.ThrowIfNull(_session, "_session");
		return await PostAsync<MutualAuthResponseModel>(data: new
		{
			sessionId = _session.SessionId,
			authenticate = authenticate,
			encryptedNonce = encryptedNonce
		}, uri: new Uri(_session.Url + "/v1/mutual_auth"));
	}
}
