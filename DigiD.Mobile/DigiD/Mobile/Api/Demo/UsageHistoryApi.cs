using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using DigiD.Common.Http.Demo;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using Microsoft.Extensions.Logging;

namespace DigiD.Mobile.Api.Demo;

public class UsageHistoryApi : BaseApiService, IUsageHistoryApi
{
	private readonly IGeneralPreferences _preferences;

	private readonly List<UsageHistoryModel> _recordsNL = new List<UsageHistoryModel>();

	private readonly List<UsageHistoryModel> _recordsEN = new List<UsageHistoryModel>();

	private const int PageSize = 10;

	private readonly List<string> _optionsNL = new List<string> { "Bekijkt gebruiksgeschiedenis", "Pincode succesvol ingevoerd in DigiD app met ID-check voor webdienst Mijn DigiD (telefoon)", "Inloggen gelukt voor activeren app met een andere app", "SSO authenticatie domein MijnOverheid gelukt", "Inloggen met DigiD app met ID-check gelukt bij webdienst MijnOverheid", "Inloggen met identiteitskaart succesvol voor webdienst Mijn DigiD", "DigiD app geactiveerd" };

	private readonly List<string> _optionsEN = new List<string> { "Views usage history", "Pin code successfully entered in DigiD app with ID check for web service My DigiD (telephone)", "Sign in successful for activating app with another app", "SSO authentication domain MijnOverheid succeeded", "SendAsync in with DigiD app with ID check successful at web service MijnOverheid", "Successful login with identity card for web service My DigiD", "DigiD app activated" };

	public UsageHistoryApi(IGeneralPreferences preferences, ILogger<UsageHistoryApi> logger)
		: base(logger)
	{
		_preferences = preferences;
		int @int = RandomNumberGenerator.GetInt32(0, 6);
		for (int i = 1; i <= 50; i++)
		{
			_recordsNL.Add(new UsageHistoryModel
			{
				DateTime = DateTime.Now.AddDays(-i),
				Message = _optionsNL[@int]
			});
			_recordsEN.Add(new UsageHistoryModel
			{
				DateTime = DateTime.Now.AddDays(-i),
				Message = _optionsEN[@int]
			});
		}
	}

	public async Task<List<UsageHistoryModel>> GetUsageHistory(int pageIndex = 0)
	{
		await Task.Delay(100);
		UsageHistoryRequestModel model = new UsageHistoryRequestModel
		{
			Language = _preferences.Language.ToUpper(),
			PageId = pageIndex
		};
		UsageHistoryResponseModel response = new UsageHistoryResponseModel
		{
			Items = ((model.Language == "NL") ? _recordsNL : _recordsEN).Skip(model.PageId * 10).Take(10).ToList()
		};
		return SendAsync("/apps/logs/get_logs", model, response).Items;
	}
}
