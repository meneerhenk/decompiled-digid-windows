using System;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace DigiD.Common.BaseClasses;

public class BasePopup<TViewModel> : BasePage<TViewModel> where TViewModel : CommonBaseViewModel, IPopupViewModel
{
	private int maxWidth = 420;

	private int maxHeight = 640;

	private int padding = 20;

	private readonly WeakEventManager weakEventManager = new WeakEventManager();

	public int MaxWidth
	{
		get
		{
			Application? current = Application.Current;
			return (current != null && current.Windows.Count > 0) ? ((int)Application.Current.Windows[0].Width) : maxWidth;
		}
		set
		{
			maxWidth = value;
			SetSize();
		}
	}

	public int MaxHeight
	{
		get
		{
			Application? current = Application.Current;
			return (current != null && current.Windows.Count > 0) ? ((int)Application.Current.Windows[0].Height) : maxHeight;
		}
		set
		{
			maxHeight = value;
			SetSize();
		}
	}

	public new int Padding
	{
		get
		{
			return padding;
		}
		set
		{
			padding = value;
			SetSize();
		}
	}

	public new event EventHandler SizeChanged
	{
		add
		{
			weakEventManager.AddEventHandler(value, "SizeChanged");
		}
		remove
		{
			weakEventManager.RemoveEventHandler(value, "SizeChanged");
		}
	}

	public BasePopup(TViewModel? viewModel = null)
		: base(viewModel)
	{
		if (base.BindingContext != null)
		{
			base.BindingContext.CloseClicked += BindingContext_CloseClicked;
		}
		DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
		SetSize();
	}

	private void BindingContext_CloseClicked(object? sender, EventArgs e)
	{
		DeviceDisplay.MainDisplayInfoChanged -= DeviceDisplay_MainDisplayInfoChanged;
		if (base.BindingContext != null)
		{
			base.BindingContext.CloseClicked -= BindingContext_CloseClicked;
		}
	}

	private void DeviceDisplay_MainDisplayInfoChanged(object? sender, DisplayInfoChangedEventArgs e)
	{
		SetSize();
	}

	private void SetSize()
	{
		int num = 2 * Padding;
		int num2 = MaxWidth;
		int num3 = MaxHeight;
		int num4 = (int)DisplayHelper.Height;
		int num5 = (int)DisplayHelper.Width;
		if (MaxWidth + num > num5)
		{
			num2 = num5 - num;
		}
		if (MaxHeight + num > num4)
		{
			num3 = num4 - num;
		}
		base.WidthRequest = num2;
		base.HeightRequest = num3;
		weakEventManager.HandleEvent(this, EventArgs.Empty, "SizeChanged");
	}
}
