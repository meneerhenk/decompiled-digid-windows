using System.Reflection;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;

namespace DigiD.Common.BaseClasses;

public class BaseAppSettings(ISecureStorageService store)
{
	protected ISecureStorageService Store { get; } = store;

	public T GetValue<T>(T defaultValue, [CallerMemberName] string key = "")
	{
		if (Store.TryGetValue<T>(key, out T value) && value != null)
		{
			return value;
		}
		return defaultValue;
	}

	public void SetValue<T>(T value, [CallerMemberName] string key = "")
	{
		if (value == null)
		{
			Store.Delete(key);
		}
		else
		{
			Store.SetValue(key, value);
		}
	}

	public virtual void Reset()
	{
		PropertyInfo[] properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			Store.Delete(propertyInfo.Name);
		}
		WeakReferenceMessenger.Default.Send(new ScreenshotSettingsChangedMessage(enabled: false));
	}
}
