using System;
using System.Threading.Tasks;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Responses;

namespace DigiD.Common.Interfaces;

public interface IRdaService
{
	Task<bool> RequestCancel();

	Task<RdaSessionResponse> GetRdaSessionUrl();

	Task<InitSessionResponse> InitSession();

	Task StartSession(RdaSessionResponse session, Func<RdaResult, Task> completeAction, Func<Task>? retryAction = null, Func<Task>? cancelAction = null);
}
