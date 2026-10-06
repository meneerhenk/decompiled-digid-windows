using Microsoft.Maui.Controls;

namespace DigiD.Common.Controls;

public static class TemplateSelector
{
	public static ControlTemplate CurrentTemplate => new ControlTemplate(typeof(DefaultTemplate));

	public static ControlTemplate NoScrollViewTemplate => new ControlTemplate(typeof(NoScrollViewTemplate));
}
