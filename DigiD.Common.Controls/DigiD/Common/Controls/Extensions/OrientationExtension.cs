using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Devices;

namespace DigiD.Common.Controls.Extensions;

[RequireService(new Type[] { typeof(IProvideValueTarget) })]
public abstract class OrientationExtension<T> : IMarkupExtension
{
	public T? Landscape { get; set; }

	public T? Portrait { get; set; }

	public virtual object? ProvideValue(IServiceProvider serviceProvider)
	{
		IProvideValueTarget requiredService = serviceProvider.GetRequiredService<IProvideValueTarget>();
		if (requiredService != null)
		{
			object targetObject = requiredService.TargetObject;
			BindableObject targetObject2 = targetObject as BindableObject;
			if (targetObject2 != null)
			{
				object targetProperty = requiredService.TargetProperty;
				BindableProperty targetProperty2 = targetProperty as BindableProperty;
				if (targetProperty2 != null)
				{
					DeviceDisplay.MainDisplayInfoChanged += delegate
					{
						T value = GetValue();
						targetObject2.SetValue(targetProperty2, value);
					};
				}
			}
		}
		return GetValue();
	}

	protected T? GetValue()
	{
		return (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape) ? Landscape : Portrait;
	}
}
