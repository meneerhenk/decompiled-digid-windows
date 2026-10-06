using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sentry.CompilerServices;

namespace Sentry.Generated;

[GeneratedCode("Sentry.Compiler.Extensions", "6.10.0.0")]
internal static class BuildPropertyInitializer
{
	[ModuleInitializer]
	internal static void Initialize()
	{
		BuildProperties.Initialize(new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
		{
			{ "cswinrtmergereferencedactivationfactories", "" },
			{ "enablepreviewfeatures", "" },
			{ "cswinrtrcwfactoryfallbackgeneratorforceoptout", "" },
			{ "enablemauixamldiagnostics", "" },
			{ "mauixamllineinfo", "" },
			{ "rootnamespace", "DigiD.Mobile" },
			{ "_mvvmtoolkitisusingwindowsruntimepack", "true" },
			{ "publishselfcontained", "true" },
			{ "mauixamlhotreload", "" },
			{ "sentrydisablesourcegenerator", "" },
			{ "projecttypeguids", "9A19103F-16F7-4668-BE54-9A1E7A4F7556" },
			{ "entrypointfilepath", "" },
			{ "usedotnetnativetoolchain", "" },
			{ "mauixamlnowarn", "" },
			{ "enforceextendedanalyzerrules", "" },
			{ "cswinrtaotwarninglevel", "" },
			{ "cswinrtaotexportsenabled", "" },
			{ "targetframeworkidentifier", ".NETCoreApp" },
			{ "configuration", "Production" },
			{ "cswinrtaotoptimizerenabled", "true" },
			{ "targetframework", "net10.0-windows10.0.22621.0" },
			{ "targetplatformminversion", "10.0.22000.0" },
			{ "targetframeworkversion", "v10.0" },
			{ "enablecodestyleseverity", "" },
			{ "invariantglobalization", "" },
			{ "platformneutralassembly", "" },
			{ "effectiveanalysislevelstyle", "10.0" },
			{ "mvvmtoolkitenableinotifypropertychangingsupport", "true" },
			{ "projectdir", "C:\\agents\\win25buildagent\\_work\\1\\s\\Source\\" },
			{ "_ispublishing", "true" },
			{ "enablecomhosting", "" },
			{ "enablegeneratedcominterfacecomimportinterop", "" },
			{ "publishtrimmed", "" },
			{ "cswinrtccwlookuptablegeneratorenabled", "true" },
			{ "_supportedplatformlist", "Linux,macOS,Windows" },
			{ "cswinrtusewindowsuixamlprojections", "false" },
			{ "cswinrtrcwfactoryfallbackgeneratorforceoptin", "" },
			{ "usingmicrosoftnetsdkweb", "" },
			{ "cswinrtcomponent", "" },
			{ "publishaot", "" }
		});
	}
}
