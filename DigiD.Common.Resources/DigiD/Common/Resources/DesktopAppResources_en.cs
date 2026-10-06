using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DigiD.Common.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.1.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
public class DesktopAppResources_en
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (object.Equals(null, resourceMan))
			{
				ResourceManager resourceManager = new ResourceManager("DigiD.Common.Resources.DesktopAppResources_en", typeof(DesktopAppResources_en).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	public static string Settings => ResourceManager.GetString("Settings", resourceCulture);

	public static string Language => ResourceManager.GetString("Language", resourceCulture);

	public static string Theme => ResourceManager.GetString("Theme", resourceCulture);

	public static string DyslexiaFont => ResourceManager.GetString("DyslexiaFont", resourceCulture);

	public static string Statistics => ResourceManager.GetString("Statistics", resourceCulture);

	public static string Help => ResourceManager.GetString("Help", resourceCulture);

	public static string Contact => ResourceManager.GetString("Contact", resourceCulture);

	public static string Support => ResourceManager.GetString("Support", resourceCulture);

	public static string A11y => ResourceManager.GetString("A11y", resourceCulture);

	public static string Dutch => ResourceManager.GetString("Dutch", resourceCulture);

	public static string English => ResourceManager.GetString("English", resourceCulture);

	public static string On => ResourceManager.GetString("On", resourceCulture);

	public static string Off => ResourceManager.GetString("Off", resourceCulture);

	public static string ContactForm => ResourceManager.GetString("ContactForm", resourceCulture);

	public static string AppVersion => ResourceManager.GetString("AppVersion", resourceCulture);

	public static string ChangePincode => ResourceManager.GetString("ChangePincode", resourceCulture);

	public static string Back => ResourceManager.GetString("Back", resourceCulture);

	public static string AppCode => ResourceManager.GetString("AppCode", resourceCulture);

	public static string Pincode => ResourceManager.GetString("Pincode", resourceCulture);

	public static string Success => ResourceManager.GetString("Success", resourceCulture);

	public static string DA112_Message => ResourceManager.GetString("DA112_Message", resourceCulture);

	public static string DA117_Message => ResourceManager.GetString("DA117_Message", resourceCulture);

	public static string DA117_Header => ResourceManager.GetString("DA117_Header", resourceCulture);

	public static string DA037_Header => ResourceManager.GetString("DA037_Header", resourceCulture);

	public static string DA037_Message => ResourceManager.GetString("DA037_Message", resourceCulture);

	internal DesktopAppResources_en()
	{
	}
}
