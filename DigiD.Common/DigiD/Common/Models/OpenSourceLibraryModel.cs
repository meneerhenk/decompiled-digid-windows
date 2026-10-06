using System;

namespace DigiD.Common.Models;

public class OpenSourceLibraryModel
{
	public string Title { get; set; } = string.Empty;

	public string Description { get; set; } = string.Empty;

	public Uri? ProjectUrl { get; set; }

	public Uri? LicenseUrl { get; set; }
}
