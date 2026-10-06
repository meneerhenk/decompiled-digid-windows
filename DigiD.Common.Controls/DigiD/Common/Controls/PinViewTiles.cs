using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using CommunityToolkit.Mvvm.Messaging;
using DigiD.Common.Controls.Enums;
using DigiD.Common.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Messages;
using DigiD.Common.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using WinRT;
using WinRT.DigiD_Common_ControlsVtableClasses;

namespace DigiD.Common.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.Data.INotifyPropertyChanged")]
[WinRTExposedType(typeof(DigiD_Common_Controls_CustomPickerWinRTTypeDetails))]
public class PinViewTiles : Grid
{
	public static readonly BindableProperty NumberOfTilesProperty = BindableProperty.Create("NumberOfTiles", typeof(int), typeof(PinViewTiles), 0, BindingMode.OneWay, null, RenderTiles);

	public static readonly BindableProperty HidePinStarProperty = BindableProperty.Create("HidePinStar", typeof(bool), typeof(PinViewTiles), false, BindingMode.OneWay, null, RenderTiles);

	public static readonly BindableProperty LockedProperty = BindableProperty.Create("Locked", typeof(bool), typeof(PinViewTiles), false, BindingMode.OneWay, null, UpdateTiles);

	public static readonly BindableProperty PinProperty = BindableProperty.Create("Pin", typeof(SecureString), typeof(PinViewTiles), null, BindingMode.OneWay, null, UpdateTiles);

	private bool hasSemanticFeedback = true;

	private readonly Border border;

	public int NumberOfTiles
	{
		get
		{
			return (int)GetValue(NumberOfTilesProperty);
		}
		set
		{
			SetValue(NumberOfTilesProperty, value);
		}
	}

	public SecureString? Pin
	{
		get
		{
			return (SecureString)GetValue(PinProperty);
		}
		set
		{
			SetValue(PinProperty, value);
		}
	}

	public bool HidePinStar
	{
		get
		{
			return (bool)GetValue(HidePinStarProperty);
		}
		set
		{
			SetValue(HidePinStarProperty, value);
		}
	}

	public bool Locked
	{
		get
		{
			return (bool)GetValue(LockedProperty);
		}
		set
		{
			SetValue(LockedProperty, value);
		}
	}

	private static void RenderTiles(BindableObject bindable, object oldValue, object newValue)
	{
		PinViewTiles pinViewTiles = (PinViewTiles)bindable;
		pinViewTiles.RenderTiles();
	}

	private static void UpdateTiles(BindableObject bindable, object oldValue, object newValue)
	{
		PinViewTiles pinViewTiles = (PinViewTiles)bindable;
		pinViewTiles.UpdateTiles();
	}

	public PinViewTiles()
	{
		WeakReferenceMessenger.Default.Register(this, delegate(object _, SemanticFeedbackMessage msg)
		{
			hasSemanticFeedback = msg.HasSemanticFeedback;
		});
		border = new Border
		{
			StrokeThickness = 2.0
		};
		border.Stroke = ((!base.IsFocused) ? Colors.Transparent : (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black));
		base.Focused -= OnFocusChanged;
		base.Focused += OnFocusChanged;
		base.Unfocused -= OnFocusChanged;
		base.Unfocused += OnFocusChanged;
	}

	private void OnFocusChanged(object? sender, FocusEventArgs e)
	{
		border.Stroke = ((!e.IsFocused) ? Colors.Transparent : (ThemeHelper.IsInDarkMode ? Colors.White : Colors.Black));
	}

	public void UpdateTiles()
	{
		int num = 0;
		foreach (PinTile item in base.Children.OfType<PinTile>())
		{
			if (Locked)
			{
				item.State = PinTileState.Locked;
			}
			else if (num == 0 && Pin != null)
			{
				item.State = PinTileState.Current;
			}
			else
			{
				item.State = PinTileState.Inactive;
			}
			num++;
		}
	}

	public void Update(bool next)
	{
		int num = Pin?.Length ?? 0;
		if (num == 0)
		{
			PinTile pinTile = (PinTile)base.Children[num];
			pinTile.State = PinTileState.Current;
			pinTile.Text = null;
			IList<IView> children = base.Children;
			if (children != null && children.Count > 0)
			{
				PinTile pinTile2 = (PinTile)base.Children[1];
				pinTile2.State = PinTileState.Inactive;
			}
			UpdatePinSemantics();
			return;
		}
		if (NumberOfTiles > num)
		{
			PinTile pinTile3 = (PinTile)base.Children[num];
			pinTile3.State = PinTileState.Current;
			pinTile3.Text = null;
		}
		if (next)
		{
			PinTile pinTile4 = (PinTile)base.Children[num - 1];
			pinTile4.State = PinTileState.Active;
			if (HidePinStar)
			{
				string text = ToPlain(Pin);
				if (text != null)
				{
					pinTile4.Text = text[num - 1].ToString();
				}
			}
		}
		else if (num + 1 < NumberOfTiles)
		{
			PinTile pinTile5 = (PinTile)base.Children[num + 1];
			pinTile5.State = PinTileState.Inactive;
			pinTile5.Text = null;
		}
		UpdatePinSemantics();
	}

	private void UpdatePinSemantics()
	{
		int? value = ToPlain(Pin)?.Length;
		string text = $"{value} {CommonResources.AccessibilityOf} {NumberOfTiles}";
		if (hasSemanticFeedback)
		{
			((IApp)Application.Current).A11YService.Speak(text);
		}
		UpdatePinSemanticsNative(text);
	}

	public void RenderTiles()
	{
		base.Padding = new Thickness(0.0);
		base.ColumnDefinitions.Clear();
		base.Children.Clear();
		for (int i = 0; i < NumberOfTiles; i++)
		{
			AddColumnDefinition(new ColumnDefinition(new GridLength(1.0, GridUnitType.Star)));
		}
		for (int j = 0; j < NumberOfTiles; j++)
		{
			PinTile view = new PinTile(NumberOfTiles, j, HidePinStar);
			this.Add(view, j);
		}
		Add(border);
		Grid.SetColumn((BindableObject)border, 0);
		Grid.SetColumnSpan((BindableObject)border, NumberOfTiles);
	}

	private static string? ToPlain(SecureString? value)
	{
		if (value == null)
		{
			return null;
		}
		nint num = IntPtr.Zero;
		try
		{
			num = Marshal.SecureStringToGlobalAllocUnicode(value);
			return Marshal.PtrToStringUni(num);
		}
		finally
		{
			Marshal.ZeroFreeGlobalAllocUnicode(num);
		}
	}

	private void UpdatePinSemanticsNative(string text)
	{
	}
}
