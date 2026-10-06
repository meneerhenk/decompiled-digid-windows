namespace DigiD.Common.EID.Models.CardFiles;

public class EFCVCA : File
{
	public EFCVCA(byte[] data)
		: base(data, "EF.CVCA")
	{
	}

	public override bool Parse()
	{
		return true;
	}
}
