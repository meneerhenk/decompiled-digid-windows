using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Core.Extensions;
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls;

[GeneratedCode("CommunityToolkit.Maui.SourceGenerators.Generators.TextColorToGenerator", "15.0.1.0")]
[ExcludeFromCodeCoverage]
internal static class ColorAnimationExtensions_InputView
{
	public static Task<bool> TextColorTo(this InputView element, Color color, uint rate = 16u, uint length = 250u, Easing? easing = null, CancellationToken token = default(CancellationToken))
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
		catch (ArgumentException)
		{
			animationCompletionSource.SetResult(result: false);
		}
		return animationCompletionSource.Task.WaitAsync(token);
		static Animation GetAlphaTransformAnimation(InputView inputView, float targetAlpha)
		{
			return new Animation(delegate(double v)
			{
				inputView.TextColor = inputView.TextColor.WithAlpha((float)v);
			}, inputView.TextColor.Alpha, targetAlpha);
		}
		static Animation GetBlueTransformAnimation(InputView inputView, float targetBlue)
		{
			return new Animation(delegate(double v)
			{
				inputView.TextColor = inputView.TextColor.WithBlue(v);
			}, inputView.TextColor.Blue, targetBlue);
		}
		static Animation GetGreenTransformAnimation(InputView inputView, float targetGreen)
		{
			return new Animation(delegate(double v)
			{
				inputView.TextColor = inputView.TextColor.WithGreen(v);
			}, inputView.TextColor.Green, targetGreen);
		}
		static Animation GetRedTransformAnimation(InputView inputView, float targetRed)
		{
			return new Animation(delegate(double v)
			{
				inputView.TextColor = inputView.TextColor.WithRed(v);
			}, inputView.TextColor.Red, targetRed);
		}
	}
}
