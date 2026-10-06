using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DigiD.Common.Enums;

namespace DigiD.Common.Converters.Json;

public class EmailStatusConverter : JsonConverter<EmailStatus>
{
	public override EmailStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string text = reader.GetString();
		string text2 = text;
		if (!(text2 == "NOT_VERIFIED"))
		{
			if (text2 == "VERIFIED")
			{
				return EmailStatus.Verified;
			}
			return EmailStatus.None;
		}
		return EmailStatus.NotVerified;
	}

	public override void Write(Utf8JsonWriter writer, EmailStatus value, JsonSerializerOptions options)
	{
		switch (value)
		{
		case EmailStatus.NotVerified:
			writer.WriteStringValue("NOT_VERIFIED");
			break;
		case EmailStatus.Verified:
			writer.WriteStringValue("VERIFIED");
			break;
		default:
			writer.WriteStringValue("NONE");
			break;
		}
	}
}
