using System;
using Microsoft.UI.Xaml.Input;

namespace DigiD.Common.Interfaces;

public interface IKeyboardService
{
	event EventHandler<int> NumberPressed;

	event EventHandler<string> KeyPressed;

	event EventHandler EnterPressed;

	void KeyDown(KeyRoutedEventArgs keyArgs);

	void PreviewKeyDown(KeyRoutedEventArgs keyArgs);
}
