using DigiD.Common.Models.Helpers;

namespace DigiD.Common.EID.Models.CardFiles;

public abstract class File(byte[]? data, string name)
{
	public byte[]? Bytes { get; } = data;

	public string Name { get; } = name;

	public string Base64Encoded => Bytes.ToBase64();

	public abstract bool Parse();
}
