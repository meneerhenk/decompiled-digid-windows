namespace DigiD.Common.EID.Models.CardFiles;

public class DG11 : File
{
	public DG11(byte[] data)
		: base(data, "DG11")
	{
	}

	public override bool Parse()
	{
		return true;
	}
}
