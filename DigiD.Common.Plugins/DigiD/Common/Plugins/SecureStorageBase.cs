using System;
using System.Text.Json;

namespace DigiD.Common.Plugins;

public abstract class SecureStorageBase
{
	protected abstract void Insert(string value, string key);

	public void SetValue<T>(string key, T value)
	{
		if (value != null)
		{
			if (typeof(T) == typeof(string))
			{
				Insert(value as string, key);
				return;
			}
			string value2 = JsonSerializer.Serialize(value);
			Insert(value2, key);
		}
	}

	protected static bool TryGetValue<T>(string? stored, out T? value)
	{
		if (string.IsNullOrEmpty(stored))
		{
			value = default(T);
			return false;
		}
		if (typeof(T) == typeof(string))
		{
			value = (T)Convert.ChangeType(stored, typeof(string));
		}
		else
		{
			if (typeof(T) == typeof(bool))
			{
				stored = stored.ToLowerInvariant();
			}
			try
			{
				T val = JsonSerializer.Deserialize<T>(stored);
				value = val;
			}
			catch (Exception)
			{
				value = (T)Convert.ChangeType(stored, typeof(T));
			}
		}
		return true;
	}
}
