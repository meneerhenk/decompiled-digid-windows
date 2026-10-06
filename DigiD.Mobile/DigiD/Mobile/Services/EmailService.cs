using System;
using System.Threading.Tasks;
using DigiD.Common.Enums;
using DigiD.Common.Interfaces;
using DigiD.Common.Models;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.ResponseModels;
using DigiD.Mobile.Interfaces;
using DigiD.Mobile.Pages;
using DigiD.Mobile.ViewModels;

namespace DigiD.Mobile.Services;

public class EmailService(IEmailApi api, INavigationService navigationService, IAlertService alertService) : IEmailService
{
	private Func<Task>? _completeTask;

	private async Task Complete(bool success)
	{
		if (success)
		{
			await alertService.DisplayAlert(AlertMessageType.FM070);
		}
		if (_completeTask != null)
		{
			await _completeTask();
		}
	}

	public async Task Manage(Func<Task> completeTask, bool isAuthentication = false)
	{
		_completeTask = completeTask;
		EmailStatusResponse emailStatus = await api.Status();
		if (emailStatus.EmailStatus == EmailStatus.None && !isAuthentication)
		{
			await navigationService.NavigateAsync<DG033, DG033ViewModel>(delegate(DG033ViewModel vm)
			{
				vm.Initialize(new RegisterEmailModel(Complete));
			});
		}
		else if ((isAuthentication && !emailStatus.UserActionNeeded) || emailStatus.ApiResult != ApiResult.Ok)
		{
			await completeTask();
		}
		else if (emailStatus.EmailStatus != EmailStatus.None)
		{
			RegisterEmailModel model = new RegisterEmailModel(async delegate(bool isVerified)
			{
				if (isVerified)
				{
					await api.Confirm(isValid: true);
					await _completeTask();
				}
				else
				{
					bool? result = await alertService.DisplayAlert(AlertMessageType.FM074);
					if (result.HasValue && result.Value && (await api.Register(emailStatus.NoVerifiedEmailAddress)).ErrorMessage == "too_many_emails")
					{
						await alertService.DisplayAlert(AlertMessageType.FM047);
					}
					else
					{
						RegisterEmailModel model2 = new RegisterEmailModel(async delegate(bool s)
						{
							await Complete(s);
						}, async delegate
						{
							await _completeTask();
						}, emailStatus.NoVerifiedEmailAddress);
						await navigationService.NavigateAsync<DG034, DG034ViewModel>(delegate(DG034ViewModel vm)
						{
							vm.Initialize(model2);
						});
					}
				}
			}, async delegate
			{
				RegisterEmailModel model2 = new RegisterEmailModel(async delegate(bool s)
				{
					await Complete(s);
				}, async delegate
				{
					await _completeTask();
				});
				await navigationService.NavigateAsync<DG033, DG033ViewModel>(delegate(DG033ViewModel vm)
				{
					vm.Initialize(model2);
				});
			})
			{
				EmailAddress = ((emailStatus.EmailStatus == EmailStatus.Verified) ? emailStatus.EmailAddress : emailStatus.NoVerifiedEmailAddress),
				Verified = (emailStatus.EmailStatus == EmailStatus.Verified)
			};
			await navigationService.NavigateAsync<DG054, DG054ViewModel>(delegate(DG054ViewModel vm)
			{
				vm.Initialize(model);
			});
		}
		else
		{
			await navigationService.NavigateAsync<DG033, DG033ViewModel>(delegate(DG033ViewModel vm)
			{
				vm.Initialize(new RegisterEmailModel(Complete));
			});
		}
	}
}
