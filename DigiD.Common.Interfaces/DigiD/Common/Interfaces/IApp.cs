using System;

namespace DigiD.Common.Interfaces;

public interface IApp
{
	IGeneralPreferences GeneralPreferences { get; }

	IA11YService A11YService { get; }

	IServiceProvider ServiceProvider { get; }
}
