using System.Collections.Generic;
using System.Threading.Tasks;
using DigiD.Common.Models;

namespace DigiD.Common.Interfaces;

public interface IUsageHistoryApi
{
	Task<List<UsageHistoryModel>> GetUsageHistory(int pageIndex = 0);
}
