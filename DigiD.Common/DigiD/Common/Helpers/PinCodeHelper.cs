using System;
using System.Globalization;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using DigiD.Common.EID.Helpers;
using DigiD.Common.Models;
using DigiD.Common.Resources;

namespace DigiD.Common.Helpers;

public static class PinCodeHelper
{
	public static PinCodeValidationResult IsPinCodeComplexEnough(SecureString pin)
	{
		PinCodeValidationResult pinCodeValidationResult = new PinCodeValidationResult
		{
			Success = true,
			Header = CommonResources.Alg_ChoosePincode
		};
		if (!pin.IsIncreasing() && !pin.IsDecreasing() && !pin.AreEqual())
		{
			return pinCodeValidationResult;
		}
		pinCodeValidationResult.Success = false;
		pinCodeValidationResult.Message = CommonResources.FM034_Melding;
		return pinCodeValidationResult;
	}

	public static string GenerateMaskCode()
	{
		byte[] bytes = RandomNumberGenerator.GetBytes(5);
		int value = BitConverter.ToInt32(bytes, 0);
		return Math.Abs(value).ToString(CultureInfo.InvariantCulture).Substring(0, 5);
	}

	public static string MaskPin(SecureString pin, string mask)
	{
		ArgumentNullException.ThrowIfNull(pin, "pin");
		char[] array = mask.ToCharArray();
		char[] array2 = pin.ToPlain().ToCharArray();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 5; i++)
		{
			try
			{
				int num = int.Parse(array[i].ToString(), CultureInfo.InvariantCulture);
				int num2 = int.Parse(array2[i].ToString(), CultureInfo.InvariantCulture);
				int num3 = num + num2;
				stringBuilder.Append(num3 % 10);
			}
			catch (Exception)
			{
			}
		}
		return stringBuilder.ToString();
	}
}
