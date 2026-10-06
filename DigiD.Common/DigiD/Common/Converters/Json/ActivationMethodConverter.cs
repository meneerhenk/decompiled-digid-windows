using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Converters.Json;

public class ActivationMethodConverter : JsonConverter<ActivationMethod>
{
	public override ActivationMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return reader.GetString() switch
		{
			"standalone" => ActivationMethod.SMS, 
			"request_for_account" => ActivationMethod.AccountAndApp, 
			"password" => ActivationMethod.Password, 
			_ => ActivationMethod.Unsupported, 
		};
	}

	public override void Write(Utf8JsonWriter writer, ActivationMethod value, JsonSerializerOptions options)
	{
		switch (value)
		{
		case ActivationMethod.SMS:
			writer.WriteStringValue("standalone");
			break;
		case ActivationMethod.AccountAndApp:
			writer.WriteStringValue("request_for_account");
			break;
		case ActivationMethod.Password:
			writer.WriteStringValue("password");
			break;
		}
	}
}
