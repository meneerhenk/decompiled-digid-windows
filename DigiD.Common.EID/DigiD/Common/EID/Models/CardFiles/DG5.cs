namespace DigiD.Common.EID.Models.CardFiles;

public class DG5 : File
{
	public DG5(byte[] data)
		: base(data, "DG5")
	{
	}

	public override bool Parse()
	{
		return true;
	}
}
