namespace DigiD.Common.EID.Models.CardFiles;

public class DG12 : File
{
	public DG12(byte[] data)
		: base(data, "DG12")
	{
	}

	public override bool Parse()
	{
		return true;
	}
}
