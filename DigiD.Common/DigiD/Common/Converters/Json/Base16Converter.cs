using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using DigiD.Common.Models.Helpers;

namespace DigiD.Common.Converters.Json;

public class Base16Converter : JsonConverter<byte[]>
{
	public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		return reader.GetString().ToBytes();
	}

	public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToBase16());
	}
}
