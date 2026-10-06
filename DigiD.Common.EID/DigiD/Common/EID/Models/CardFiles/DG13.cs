namespace DigiD.Common.EID.Models.CardFiles;

public class DG13 : File
{
	public DG13(byte[] data)
		: base(data, "DG13")
	{
	}

	public override bool Parse()
	{
		return true;
	}
}
