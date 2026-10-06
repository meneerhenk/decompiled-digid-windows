using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DigiD.Mobile.ViewModels;

public class HLP009ViewModel : CarouselViewModel
{
	public event EventHandler ResetFocus
	{
		add
		{
			WeakEventManager.AddEventHandler(value, "ResetFocus");
		}
		remove
		{
			WeakEventManager.RemoveEventHandler(value, "ResetFocus");
		}
	}

	public HLP009ViewModel()
	{
		base.CloseButtonVisible = false;
	}

	protected override Task OnAppearing()
	{
		WeakEventManager.HandleEvent(this, EventArgs.Empty, "ResetFocus");
		return base.OnAppearing();
	}

	protected override void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		base.OnPropertyChanged(e);
		if (e.PropertyName == "CurrentIndex")
		{
			WeakEventManager.HandleEvent(this, EventArgs.Empty, "ResetFocus");
		}
	}
}
