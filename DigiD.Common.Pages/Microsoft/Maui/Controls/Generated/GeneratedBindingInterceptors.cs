using System.CodeDom.Compiler;

namespace Microsoft.Maui.Controls.Generated;

[GeneratedCode("Microsoft.Maui.Controls.BindingSourceGen, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", "10.0.0.0")]
internal static class GeneratedBindingInterceptors
{
	private static bool ShouldUseSetter(BindingMode mode, BindableProperty bindableProperty)
	{
		int result;
		switch (mode)
		{
		case BindingMode.Default:
			result = ((bindableProperty.DefaultBindingMode == BindingMode.OneWayToSource || bindableProperty.DefaultBindingMode == BindingMode.TwoWay) ? 1 : 0);
			break;
		default:
			result = 0;
			break;
		case BindingMode.TwoWay:
		case BindingMode.OneWayToSource:
			result = 1;
			break;
		}
		return (byte)result != 0;
	}

	private static bool ShouldUseSetter(BindingMode mode)
	{
		return mode == BindingMode.OneWayToSource || mode == BindingMode.TwoWay || mode == BindingMode.Default;
	}
}
