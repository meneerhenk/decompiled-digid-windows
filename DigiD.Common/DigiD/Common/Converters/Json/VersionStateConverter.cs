using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Converters.Json;

internal class VersionStateConverter : JsonConverter<VersionState>
{
	public override VersionState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return reader.GetString() switch
		{
			"active" => VersionState.Active, 
			"update_warning" => VersionState.Warning, 
			"force_update" => VersionState.ForcedUpdate, 
			"kill_app" => VersionState.Kill, 
			_ => VersionState.Unknown, 
		};
	}

	public override void Write(Utf8JsonWriter writer, VersionState value, JsonSerializerOptions options)
	{
		switch (value)
		{
		case VersionState.Active:
			writer.WriteStringValue("active");
			break;
		case VersionState.Warning:
			writer.WriteStringValue("update_warning");
			break;
		case VersionState.ForcedUpdate:
			writer.WriteStringValue("force_update");
			break;
		case VersionState.Kill:
			writer.WriteStringValue("kill_app");
			break;
		default:
			writer.WriteStringValue("UNKNOWN");
			break;
		}
	}
}
