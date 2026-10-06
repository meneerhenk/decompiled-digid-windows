using System;
using DigiD.Common.Interfaces;
using Microsoft.Maui;
using Microsoft.UI.Xaml.Input;
using Windows.System;

namespace DigiD.Common.Plugins.Services;

public class KeyboardService : IKeyboardService
{
	private readonly WeakEventManager weakEventManager = new WeakEventManager();

	protected readonly IDeviceLockService? DeviceLockService;

	public event EventHandler<int> NumberPressed
	{
		add
		{
			weakEventManager.AddEventHandler((Delegate?)value, "NumberPressed");
		}
		remove
		{
			weakEventManager.RemoveEventHandler((Delegate?)value, "NumberPressed");
		}
	}

	public event EventHandler<string> KeyPressed
	{
		add
		{
			weakEventManager.AddEventHandler((Delegate?)value, "KeyPressed");
		}
		remove
		{
			weakEventManager.RemoveEventHandler((Delegate?)value, "KeyPressed");
		}
	}

	public event EventHandler EnterPressed
	{
		add
		{
			weakEventManager.AddEventHandler(value, "EnterPressed");
		}
		remove
		{
			weakEventManager.RemoveEventHandler(value, "EnterPressed");
		}
	}

	public KeyboardService(IDeviceLockService? deviceLockService = null)
	{
		DeviceLockService = deviceLockService;
		base._002Ector();
	}

	protected void InvokeKeyPressed(int number)
	{
		weakEventManager.HandleEvent(this, number, "NumberPressed");
	}

	public void KeyDown(KeyRoutedEventArgs keyArgs)
	{
		DeviceLockService?.Update();
		VirtualKey key = keyArgs.Key;
		if ((key == VirtualKey.Back || key == VirtualKey.Delete) ? true : false)
		{
			InvokeNumberPressed(11, keyArgs);
			return;
		}
		VirtualKey key2 = keyArgs.Key;
		VirtualKey virtualKey = key2;
		int key3 = (int)keyArgs.Key;
		switch (key3)
		{
		case 65:
		case 66:
		case 67:
		case 68:
		case 69:
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 76:
		case 77:
		case 78:
		case 79:
		case 80:
		case 81:
		case 82:
		case 83:
		case 84:
		case 85:
		case 86:
		case 87:
		case 88:
		case 89:
		case 90:
			InvokeKeyPressed(key3.ToString(), keyArgs);
			break;
		case 96:
		case 97:
		case 98:
		case 99:
		case 100:
		case 101:
		case 102:
		case 103:
		case 104:
		case 105:
			InvokeNumberPressed(key3 - 96, keyArgs);
			break;
		case 48:
		case 49:
		case 50:
		case 51:
		case 52:
		case 53:
		case 54:
		case 55:
		case 56:
		case 57:
			InvokeNumberPressed(key3 - 48, keyArgs);
			break;
		}
	}

	public void PreviewKeyDown(KeyRoutedEventArgs keyArgs)
	{
		DeviceLockService?.Update();
		if (keyArgs.Key == VirtualKey.Enter)
		{
			InvokeEnterPressed(keyArgs);
		}
	}

	private void InvokeKeyPressed(string key, KeyRoutedEventArgs keyArgs)
	{
		keyArgs.Handled = true;
		weakEventManager.HandleEvent(this, key, "KeyPressed");
	}

	private void InvokeNumberPressed(int number, KeyRoutedEventArgs keyArgs)
	{
		keyArgs.Handled = true;
		InvokeKeyPressed(number);
	}

	private void InvokeEnterPressed(KeyRoutedEventArgs keyArgs)
	{
		keyArgs.Handled = true;
		weakEventManager.HandleEvent(this, null, "EnterPressed");
	}
}
