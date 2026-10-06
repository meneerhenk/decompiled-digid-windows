#define TRACE
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core.Extensions;
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls;

[GeneratedCode("CommunityToolkit.Maui.SourceGenerators.Generators.TextColorToGenerator", "15.0.1.0")]
[ExcludeFromCodeCoverage]
internal static class ColorAnimationExtensions_RadioButton
{
	public static Task<bool> TextColorTo(this RadioButton element, Color color, uint rate = 16u, uint length = 250u, Easing? easing = null, CancellationToken token = default(CancellationToken))
	{
		token.ThrowIfCancellationRequested();
		ArgumentNullException.ThrowIfNull(element, "element");
		ArgumentNullException.ThrowIfNull(color, "color");
		if (element == null)
		{
			throw new ArgumentException("Element must implement ITextStyle", "element");
		}
		if (element.TextColor == null)
		{
			Color color2 = (element.TextColor = Colors.Transparent);
		}
		TaskCompletionSource<bool> animationCompletionSource = new TaskCompletionSource<bool>();
		try
		{
			Animation animation = new Animation();
			animation.Add(0.0, 1.0, GetRedTransformAnimation(element, color.Red));
			animation.Add(0.0, 1.0, GetGreenTransformAnimation(element, color.Green));
			animation.Add(0.0, 1.0, GetBlueTransformAnimation(element, color.Blue));
			animation.Add(0.0, 1.0, GetAlphaTransformAnimation(element, color.Alpha));
			animation.Commit(element, "TextColorTo", rate, length, easing, delegate
			{
				animationCompletionSource.SetResult(result: true);
			});
		}
		catch (ArgumentException ex)
		{
			Trace.WriteLine($"{ex.GetType().Name} thrown in {typeof(ColorAnimationExtensions_RadioButton).FullName}: {ex.Message}");
			animationCompletionSource.SetResult(result: false);
		}
		return animationCompletionSource.Task.WaitAsync(token);
		static Animation GetAlphaTransformAnimation(RadioButton radioButton, float targetAlpha)
		{
			return new Animation(delegate(double v)
			{
				radioButton.TextColor = radioButton.TextColor.WithAlpha((float)v);
			}, radioButton.TextColor.Alpha, targetAlpha);
		}
		static Animation GetBlueTransformAnimation(RadioButton radioButton, float targetBlue)
		{
			return new Animation(delegate(double v)
			{
				radioButton.TextColor = radioButton.TextColor.WithBlue(v);
			}, radioButton.TextColor.Blue, targetBlue);
		}
		static Animation GetGreenTransformAnimation(RadioButton radioButton, float targetGreen)
		{
			return new Animation(delegate(double v)
			{
				radioButton.TextColor = radioButton.TextColor.WithGreen(v);
			}, radioButton.TextColor.Green, targetGreen);
		}
		static Animation GetRedTransformAnimation(RadioButton radioButton, float targetRed)
		{
			return new Animation(delegate(double v)
			{
				radioButton.TextColor = radioButton.TextColor.WithRed(v);
			}, radioButton.TextColor.Red, targetRed);
		}
	}
}
