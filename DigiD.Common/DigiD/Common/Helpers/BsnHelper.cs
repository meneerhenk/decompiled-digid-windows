namespace DigiD.Common.Helpers;

public static class BsnHelper
{
	public static bool IsValidBsn(this string bsn)
	{
		if (!int.TryParse(bsn, out var _))
		{
			return false;
		}
		if (bsn.Length != 9)
		{
			return false;
		}
		int num = 9;
		int num2 = 0;
		for (int i = 0; i < 8; i++)
		{
			num2 += int.Parse(bsn[i].ToString()) * num;
			num--;
		}
		int num3 = int.Parse(bsn[8].ToString());
		return num2 % 11 == num3;
	}
}
