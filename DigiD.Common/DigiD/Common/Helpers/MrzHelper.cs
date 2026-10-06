using System.Linq;

namespace DigiD.Common.Helpers;

public static class MrzHelper
{
	public static string GetMrzInfo(string documentNumber, string dateOfBirth, string expiryDate)
	{
		string text = CalculateCheckDigit(documentNumber);
		string text2 = CalculateCheckDigit(dateOfBirth);
		string text3 = CalculateCheckDigit(expiryDate);
		return text + text2 + text3;
	}

	private static string CalculateCheckDigit(string data)
	{
		int[] array = new int[3] { 7, 3, 1 };
		int num = 0;
		int num2 = 0;
		foreach (int item in data.Select((char c) => char.IsNumber(c) ? ((int)char.GetNumericValue(c)) : (c - 55)))
		{
			if (num == 3)
			{
				num = 0;
			}
			num2 += item * array[num];
			num++;
		}
		return data + num2 % 10;
	}
}
