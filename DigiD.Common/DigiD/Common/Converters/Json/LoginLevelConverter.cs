using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Enums;

namespace DigiD.Common.Converters.Json;

public class LoginLevelConverter : JsonConverter<LoginLevel>
{
	public override LoginLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		int num = 0;
		try
		{
			num = int.Parse(reader.GetString());
		}
		catch
		{
			try
			{
				if (reader.TryGetInt32(out var value))
				{
					num = value;
				}
			}
			catch
			{
				return LoginLevel.Unknown;
			}
		}
		return num switch
		{
			10 => LoginLevel.Basis, 
			20 => LoginLevel.Midden, 
			25 => LoginLevel.Substantieel, 
			30 => LoginLevel.Hoog, 
			_ => LoginLevel.Unknown, 
		};
	}

	public override void Write(Utf8JsonWriter writer, LoginLevel value, JsonSerializerOptions options)
	{
		switch (value)
		{
		case LoginLevel.Basis:
			writer.WriteNumberValue(10);
			break;
		case LoginLevel.Midden:
			writer.WriteNumberValue(20);
			break;
		case LoginLevel.Substantieel:
			writer.WriteNumberValue(25);
			break;
		case LoginLevel.Hoog:
			writer.WriteNumberValue(30);
			break;
		default:
			writer.WriteNumberValue(0);
			break;
		}
	}
}
