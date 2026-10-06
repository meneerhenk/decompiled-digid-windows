using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.Exceptions;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using DigiD.Common.Models.RequestModels;
using DigiD.Common.Models.Responses;
using DigiD.Common.NFC.Enums;
using DigiD.Common.NFC.Helpers;
using DigiD.Common.NFC.Models;
using DigiD.Common.RDA.Enums;
using DigiD.Common.RDA.Interfaces;
using DigiD.Common.Resources;
using DigiD.Common.SessionModels;
using Microsoft.Maui.Devices;

namespace DigiD.Common.RDA.Services;

internal class RdaScanService(INfcService nfcService, IRdaApi rdaApi) : IRdaScanService
{
	private Func<RdaStatus, Task>? _statusChanged;

	private Action<float>? _progressChanged;

	private int _count;

	public bool IsReading { get; private set; }

	public void Initialize(Func<RdaStatus, Task> statusChanged, Action<float> progressChanged, RdaSession session)
	{
		rdaApi.Initialize(session);
		_statusChanged = statusChanged;
		_progressChanged = progressChanged;
	}

	public async Task StartScanning(DocumentType documentType)
	{
		if (_statusChanged == null || _progressChanged == null)
		{
			throw new InitializationException("Initialize must be called first");
		}
		await nfcService.StartScanningAsync(StartReading, HandleError, string.Format(CommonResources.DG080_Text_iOS_Overlay_Start, documentType.Translate().ToLower()));
	}

	private async Task HandleError(NfcError e)
	{
		ArgumentNullException.ThrowIfNull(_statusChanged, "_statusChanged");
		switch (e)
		{
		case NfcError.Cancelled:
			await _statusChanged(RdaStatus.ReadingCancelled);
			break;
		case NfcError.Timeout:
			await _statusChanged(RdaStatus.ReadingFailed);
			break;
		case NfcError.CardNotFound:
			await _statusChanged(RdaStatus.UnknownCard);
			break;
		}
	}

	private async Task StartReading()
	{
		ArgumentNullException.ThrowIfNull(_statusChanged, "_statusChanged");
		IsReading = true;
		bool cardLost = false;
		await _statusChanged(RdaStatus.ReadingStarted);
		try
		{
			RdaStatus result = await StartSession();
			IsReading = false;
			if (result == RdaStatus.CardLost)
			{
				cardLost = true;
			}
			if (!cardLost || !(DeviceInfo.Platform == DevicePlatform.iOS))
			{
				await nfcService.StopScanningAsync((result != RdaStatus.ReadingCompleted) ? CommonResources.Alg_Failed : null);
				await _statusChanged(result);
			}
			else
			{
				await _statusChanged(result);
			}
		}
		catch
		{
			await nfcService.StopScanningAsync(CommonResources.Alg_Failed);
			await _statusChanged(RdaStatus.ReadingFailed);
		}
	}

	private async Task<RdaStatus> StartSession()
	{
		ArgumentNullException.ThrowIfNull(_progressChanged, "_progressChanged");
		_progressChanged(0f);
		_progressChanged(0.125f);
		Card card = await nfcService.ReadCard();
		if (card == null)
		{
			return RdaStatus.UnknownCard;
		}
		EFCardAccess efCardAccess = await SelectAndReadFile.Execute<EFCardAccess>(CardFile.EFCardAccess);
		BaseResponse response = await rdaApi.Start(card.RDADocumentType, efCardAccess);
		if (response.ApiResult != ApiResult.Ok)
		{
			return RdaStatus.UnknownError;
		}
		if (efCardAccess == null || response.Status == "CHALLENGE")
		{
			return await ExecuteRdaWithBac(response);
		}
		return await ExecuteRdaWithPace(response);
	}

	private async Task<RdaStatus> ExecuteRdaWithBac(BaseResponse response)
	{
		ArgumentNullException.ThrowIfNull(_progressChanged, "_progressChanged");
		CommandApdu challengeCommand = null;
		bool next = false;
		_count = 0;
		while (true)
		{
			bool flag = !next && response.ApiResult == ApiResult.Ok;
			bool flag2 = flag;
			if (!flag2)
			{
				ApiResult apiResult = response.ApiResult;
				bool flag3 = ((apiResult == ApiResult.Failed || apiResult == ApiResult.Verified) ? true : false);
				flag2 = flag3;
			}
			if (!flag2)
			{
				break;
			}
			TransceiveResult data = null;
			ResponseApdu responseApdu = null;
			CommandApdu commandApdu;
			try
			{
				switch (response.Status)
				{
				case "CHALLENGE":
				{
					RdaStartResponse startResponse = (RdaStartResponse)response;
					await ExecuteCommand(startResponse.Select, "SELECT");
					ResponseApdu responseApdu2 = responseApdu;
					if (responseApdu2 != null && responseApdu2.SW == 36864)
					{
						challengeCommand = new CommandApdu(Convert.FromBase64String(((RdaStartResponse)response).Challenge));
						data = await nfcService.SendApduAsync(challengeCommand.Bytes);
						response = await rdaApi.Challenge(Convert.ToBase64String(data.Data));
						_progressChanged(0.25f);
					}
					else
					{
						next = true;
					}
					break;
				}
				case "AUTHENTICATE":
				{
					string command2 = ((response.GetType() == typeof(SelectResponse)) ? ((SelectResponse)response).Authenticate : ((CommandResponse)response).Authenticate);
					await ExecuteCommand(Convert.FromBase64String(command2), "AUTHENTICATE");
					ResponseApdu responseApdu3 = responseApdu;
					if (responseApdu3 != null && responseApdu3.SW == 36864 && data != null)
					{
						response = await rdaApi.Authenticate(Convert.ToBase64String(data.Data), null);
						_progressChanged(0.375f);
						break;
					}
					if (challengeCommand == null)
					{
						return RdaStatus.UnknownError;
					}
					data = await nfcService.SendApduAsync(challengeCommand.Bytes);
					response = await rdaApi.Authenticate(null, Convert.ToBase64String(data.Data));
					if (!(response.Status == "FAILED"))
					{
						break;
					}
					return RdaStatus.AuthenticationFailed;
				}
				case "SECURE_MESSAGING":
				{
					if (!(response is CommandResponse commands))
					{
						return RdaStatus.UnknownError;
					}
					_count++;
					float sub = (float)_count / 9f;
					_progressChanged(0.375f + 0.625f * sub);
					List<string> responseCommands = new List<string>();
					foreach (byte[] command in commands.Commands)
					{
						await ExecuteCommand(command, "SM");
						if (data != null && responseApdu != null)
						{
							responseCommands.Add(Convert.ToBase64String(data.Data));
							if (responseApdu.SW != 36864)
							{
								break;
							}
						}
					}
					response = await rdaApi.SecureMessaging(responseCommands);
					break;
				}
				default:
					return HandleExceptions(response.Status);
				}
			}
			catch (CardLostException)
			{
				return RdaStatus.CardLost;
			}
			catch
			{
				return RdaStatus.AuthenticationFailed;
			}
			continue;
			async Task ExecuteCommand(byte[] bytes, string header)
			{
				commandApdu = new CommandApdu(bytes);
				Debugger.DumpInfo(header, commandApdu);
				data = await nfcService.SendApduAsync(commandApdu.Bytes);
				if (data == null || data.IsCardLost)
				{
					throw new CardLostException();
				}
				responseApdu = new ResponseApdu(data.Data);
				Debugger.DumpInfo(header, responseApdu);
			}
			async Task ExecuteCommand(byte[] bytes, string header)
			{
				commandApdu = new CommandApdu(bytes);
				Debugger.DumpInfo(header, commandApdu);
				data = await nfcService.SendApduAsync(commandApdu.Bytes);
				if (data == null || data.IsCardLost)
				{
					throw new CardLostException();
				}
				responseApdu = new ResponseApdu(data.Data);
				Debugger.DumpInfo(header, responseApdu);
			}
		}
		return RdaStatus.AuthenticationFailed;
	}

	private async Task<RdaStatus> ExecuteRdaWithPace(BaseResponse response)
	{
		ArgumentNullException.ThrowIfNull(_progressChanged, "_progressChanged");
		_count = 0;
		RdaStartResponse startResponse = (RdaStartResponse)response;
		while (true)
		{
			ApiResult apiResult = response.ApiResult;
			if ((apiResult != ApiResult.Ok && apiResult != ApiResult.Failed && apiResult != ApiResult.Verified) || 1 == 0)
			{
				break;
			}
			TransceiveResult data = null;
			ResponseApdu responseApdu = null;
			CommandApdu commandApdu;
			try
			{
				switch (response.Status)
				{
				case "PREPARE":
				{
					await ExecuteCommand(startResponse.Pace, "PACE");
					ResponseApdu responseApdu2 = responseApdu;
					if (responseApdu2 != null && responseApdu2.SW == 36864)
					{
						await ExecuteCommand(startResponse.Nonce, "NONCE");
						PrepareResponseModel prepareResponseModel = await rdaApi.Prepare(responseApdu.Bytes);
						response = prepareResponseModel;
						if (response.ApiResult == ApiResult.Failed)
						{
							return RdaStatus.AuthenticationFailed;
						}
					}
					_progressChanged(0.125f);
					goto end_IL_013a;
				}
				case "MAP":
					if (response is MutualAuthResponseModel model)
					{
						await Map(model.MappedNonce);
						continue;
					}
					if (!(response is PrepareResponseModel model2))
					{
						break;
					}
					await Map(model2.MappedNonce);
					goto end_IL_013a;
				case "KEY_AGREE":
					if (!(response is MapResponseModel mapResponse))
					{
						break;
					}
					await ExecuteCommand(mapResponse.KeyAgree, "KEY AGREE");
					if (responseApdu != null)
					{
						AgreeKeyResponseModel agreeKeyResponseModel = await rdaApi.KeyAgreement(responseApdu.Bytes);
						response = agreeKeyResponseModel;
						_progressChanged(0.375f);
					}
					goto end_IL_013a;
				case "MUTUAL_AUTH":
				{
					if (!(response is AgreeKeyResponseModel agreeKeyResponse))
					{
						break;
					}
					await ExecuteCommand(agreeKeyResponse.Token, "TOKEN");
					ResponseApdu responseApdu3 = responseApdu;
					if (responseApdu3 != null && responseApdu3.SW == 36864)
					{
						MutualAuthResponseModel mutualAuthResponseModel = await rdaApi.MutualAuthenticate(responseApdu.Bytes);
						response = mutualAuthResponseModel;
						continue;
					}
					await ExecuteCommand(startResponse.Pace, "PACE");
					ResponseApdu responseApdu4 = responseApdu;
					if (responseApdu4 != null && responseApdu4.SW == 36864)
					{
						await ExecuteCommand(startResponse.Nonce, "NONCE");
						MutualAuthResponseModel mutualAuthResponseModel2 = await rdaApi.MutualAuthenticate(null, responseApdu.Bytes);
						response = mutualAuthResponseModel2;
						if (response.Status == "FAILED")
						{
							return RdaStatus.AuthenticationFailed;
						}
						_progressChanged(0.125f);
					}
					goto end_IL_013a;
				}
				case "SECURE_MESSAGING":
				{
					if (!(response is CommandResponse commands))
					{
						return RdaStatus.UnknownError;
					}
					_count++;
					float sub = (float)_count / 9f;
					_progressChanged(0.375f + 0.625f * sub);
					List<string> responseCommands = new List<string>();
					foreach (byte[] command in commands.Commands)
					{
						await ExecuteCommand(command, "SM");
						if (data != null && responseApdu != null)
						{
							responseCommands.Add(Convert.ToBase64String(data.Data));
							if (responseApdu.SW != 36864)
							{
								break;
							}
						}
					}
					CommandResponse commandResponse = await rdaApi.SecureMessaging(responseCommands);
					response = commandResponse;
					goto end_IL_013a;
				}
				}
				return HandleExceptions(response.Status);
				end_IL_013a:;
			}
			catch (CardLostException)
			{
				return RdaStatus.CardLost;
			}
			catch
			{
				return RdaStatus.AuthenticationFailed;
			}
			continue;
			async Task ExecuteCommand(byte[] bytes, string header)
			{
				commandApdu = new CommandApdu(bytes);
				Debugger.DumpInfo(header, commandApdu);
				data = await nfcService.SendApduAsync(commandApdu.Bytes);
				if (data == null || data.IsCardLost)
				{
					throw new CardLostException();
				}
				responseApdu = new ResponseApdu(data.Data);
				Debugger.DumpInfo(header, responseApdu);
			}
			MapResponseModel mapResponseModel;
			async Task Map(byte[] mappedNonce)
			{
				await ExecuteCommand(mappedNonce, "MAPPED NONCE");
				if (responseApdu != null)
				{
					mapResponseModel = await rdaApi.Map(responseApdu.Bytes);
					response = mapResponseModel;
				}
			}
			async Task ExecuteCommand(byte[] bytes, string header)
			{
				commandApdu = new CommandApdu(bytes);
				Debugger.DumpInfo(header, commandApdu);
				data = await nfcService.SendApduAsync(commandApdu.Bytes);
				if (data == null || data.IsCardLost)
				{
					throw new CardLostException();
				}
				responseApdu = new ResponseApdu(data.Data);
				Debugger.DumpInfo(header, responseApdu);
			}
			async Task Map(byte[] mappedNonce)
			{
				await ExecuteCommand(mappedNonce, "MAPPED NONCE");
				if (responseApdu != null)
				{
					mapResponseModel = await rdaApi.Map(responseApdu.Bytes);
					response = mapResponseModel;
				}
			}
		}
		return RdaStatus.AuthenticationFailed;
	}

	private RdaStatus HandleExceptions(string? status)
	{
		ArgumentNullException.ThrowIfNull(_progressChanged, "_progressChanged");
		switch (status)
		{
		case "FAILED":
			return RdaStatus.ReadingFailed;
		case "CANCELLED":
			return RdaStatus.ReadingCancelled;
		case "ABORTED":
			return RdaStatus.ReadingAborted;
		case "VERIFIED":
			_progressChanged(1f);
			return RdaStatus.ReadingCompleted;
		default:
			return RdaStatus.UnknownError;
		}
	}
}
