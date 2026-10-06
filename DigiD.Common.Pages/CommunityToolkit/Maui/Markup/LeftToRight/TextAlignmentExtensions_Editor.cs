using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace CommunityToolkit.Maui.Markup.LeftToRight;

[GeneratedCode("CommunityToolkit.Maui.Markup.SourceGenerators.TextAlignmentExtensionsGenerator", "1.0.0.0")]
[ExcludeFromCodeCoverage]
internal static class TextAlignmentExtensions_Editor
{
	public static TAssignable TextLeft<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Editor
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.Start;
		return textAlignmentControl;
	}

	public static TAssignable TextRight<TAssignable>(this TAssignable textAlignmentControl) where TAssignable : Editor
	{
		ArgumentNullException.ThrowIfNull(textAlignmentControl, "textAlignmentControl");
		if (textAlignmentControl == null)
		{
			throw new ArgumentException("Element must implement ITextAlignment", "textAlignmentControl");
		}
		textAlignmentControl.HorizontalTextAlignment = TextAlignment.End;
		return textAlignmentControl;
	}
}
