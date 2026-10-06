using System;
using System.Threading.Tasks;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Interfaces;

public interface IAlertService
{
	Task<bool?> DisplayAlert(AlertMessageType type, TimeSpan? autoHideDelay = null);
}
