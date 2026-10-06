using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CommunityToolkit.Maui.Markup.RightToLeft;

internal static class TextAlignmentExtensions_EntryCell
{
	public static TAssignable TextLeft<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : EntryCell
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.End;
		return textAlignmentControl;
	}

	public static TAssignable TextRight<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : EntryCell
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.Start;
		return textAlignmentControl;
	}
}
