using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Http.Demo;
using DigiD.Common.Http.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Config;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.SessionModels;
using Microsoft.Extensions.Logging;

namespace DigiD.Common.RDA.Api.Demo;

public class RdaApi : BaseApiService, IRdaApi
{
	private int _secureMessagingCount;

	private int _pollCount;

	public RdaApi(ILogger<RdaApi> logger)
		: base(logger)
	{
	}

	public void Initialize(RdaSession session)
	{
	}

	public async Task<InitSessionResponse> InitSessionRDA()
	{
		await Task.Delay(0);
		return new InitSessionResponse
		{
			ApiResult = ApiResult.Ok,
			SessionId = DemoHelper.NewSession("upgrade_app")
		};
	}

	public async Task<BaseResponse> Documents()
	{
		await Task.Delay(0);
		_pollCount = 0;
		return new BaseResponse
		{
			ApiResult = ApiResult.Ok
		};
	}

	public async Task<RdaSessionResponse> Poll()
	{
		await Task.Delay(1);
		_pollCount++;
		if (_pollCount != 5)
		{
			return new RdaSessionResponse
			{
				ApiResult = ApiResult.Pending
			};
		}
		if (DemoConfig.HasNoDocuments)
		{
			return new RdaSessionResponse
			{
				ApiResult = ApiResult.NoDocumentsFound
			};
		}
		return new RdaSessionResponse
		{
			ApiResult = ApiResult.Ok,
			SessionId = DemoHelper.NewSession(),
			Url = "https://rda-demo.digid.local"
		};
	}

	public Task<ApiResult> Verified()
	{
		return Task.FromResult((!DemoConfig.RdaFailed) ? ApiResult.Ok : ApiResult.Nok);
	}

	public Task<BaseResponse> Cancel()
	{
		return Task.FromResult(new BaseResponse
		{
			ApiResult = ApiResult.Ok
		});
	}

	public async Task<RdaStartResponse> Start(string type, EFCardAccess? cardAccess)
	{
		await Task.Delay(0);
		return new RdaStartResponse
		{
			Select = ((type == "DRIVING_LICENCE") ? Convert.FromBase64String("AKQEDAugAAAEVkVETC0wMQ==") : Convert.FromBase64String("AKQEDAegAAACRxAB")),
			Status = "CHALLENGE",
			ApiResult = ApiResult.Ok,
			Challenge = "AIQAAAg="
		};
	}

	public async Task<SelectResponse> Challenge(string challenge)
	{
		await Task.Delay(0);
		return new SelectResponse
		{
			ApiResult = ApiResult.Ok,
			Status = "AUTHENTICATE",
			Authenticate = "AIQAAAg="
		};
	}

	public async Task<CommandResponse> Authenticate(string? authenticate, string? challenge)
	{
		_secureMessagingCount = 0;
		await Task.Delay(0);
		return new CommandResponse
		{
			ApiResult = ApiResult.Ok,
			Status = "SECURE_MESSAGING",
			Commands = new List<byte[]>(1) { Convert.FromBase64String("AIQAAAg=") }
		};
	}

	public async Task<CommandResponse> SecureMessaging(List<string> responses)
	{
		_secureMessagingCount++;
		await Task.Delay(200);
		return new CommandResponse
		{
			ApiResult = ApiResult.Ok,
			Status = ((_secureMessagingCount == 9) ? "VERIFIED" : "SECURE_MESSAGING"),
			Commands = new List<byte[]>(1) { Convert.FromBase64String("AIQAAAg=") }
		};
	}

	public Task<PrepareResponseModel> Prepare(byte[] encryptedNonce)
	{
		throw new NotImplementedException();
	}

	public Task<MapResponseModel> Map(byte[] mappedNonce)
	{
		throw new NotImplementedException();
	}

	public Task<AgreeKeyResponseModel> KeyAgreement(byte[] keyAgree)
	{
		throw new NotImplementedException();
	}

	public Task<MutualAuthResponseModel> MutualAuthenticate(byte[]? authenticate, byte[]? encryptedNonce = null)
	{
		throw new NotImplementedException();
	}
}
