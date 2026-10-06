using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CommunityToolkit.Maui.Markup;

[GeneratedCode("CommunityToolkit.Maui.Markup.SourceGenerators.TextAlignmentExtensionsGenerator", "1.0.0.0")]
[ExcludeFromCodeCoverage]
internal static class TextAlignmentExtensions_Picker
{
	public static TAssignable TextJustify<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.Justify;
		return textAlignmentControl;
	}

	public static TAssignable TextStart<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.Start;
		return textAlignmentControl;
	}

	public static TAssignable TextCenterHorizontal<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.Center;
		return textAlignmentControl;
	}

	public static TAssignable TextEnd<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.End;
		return textAlignmentControl;
	}

	public static TAssignable TextTop<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.VerticalTextAlignment = TextAlignment.Start;
		return textAlignmentControl;
	}

	public static TAssignable TextCenterVertical<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.VerticalTextAlignment = TextAlignment.Center;
		return textAlignmentControl;
	}

	public static TAssignable TextBottom<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.VerticalTextAlignment = TextAlignment.End;
		return textAlignmentControl;
	}

	public static TAssignable TextCenter<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Picker
	{
		return TextCenterVertical(TextCenterHorizontal(textAlignmentControl));
	}
}
