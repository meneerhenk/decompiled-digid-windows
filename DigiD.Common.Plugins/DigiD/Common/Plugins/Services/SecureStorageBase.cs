using System;
using System.Text.Json;
using System.Threading;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Helpers;
using Microsoft.Maui.Storage;

namespace DigiD.Common.Plugins.Services;

public class SecureStorageBase : ISecureStorageService
{
	private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

	public void Delete(string key)
	{
		SecureStorage.Default.Remove(key);
	}

	public bool TryGetValue<T>(string key, out T? value)
	{
		string text = AsyncUtil.RunSync(() => SecureStorage.Default.GetAsync(key));
		if (text != null)
		{
			if (typeof(T) == typeof(string))
			{
				value = (T)Convert.ChangeType(text, typeof(string));
			}
			else
			{
				value = JsonSerializer.Deserialize<T>(text);
			}
		}
		else
		{
			value = default(T);
		}
		return value != null;
	}

	public void SetValue<T>(string key, T? value)
	{
		if (value == null)
		{
			SecureStorage.Default.Remove(key);
		}
		else if (typeof(T) == typeof(string))
		{
			AsyncUtil.RunSync(async delegate
			{
				await _semaphore.WaitAsync();
				await SecureStorage.Default.SetAsync(key, (value as string) ?? string.Empty);
				_semaphore.Release();
			});
		}
		else
		{
			AsyncUtil.RunSync(async delegate
			{
				await _semaphore.WaitAsync();
				await SecureStorage.Default.SetAsync(key, JsonSerializer.Serialize(value));
				_semaphore.Release();
			});
		}
	}
}
