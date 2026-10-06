using System;
using System.IO;
using System.Threading.Tasks;
using DigiD.Common.EID.Models;
using DigiD.Common.EID.Models.CardFiles;
using DigiD.Common.NFC.Models;

namespace DigiD.Common.EID.Helpers;

public static class SelectAndReadFile
{
	public static async Task<T?> Execute<T>(CardFile file, SMContext? context = null) where T : DigiD.Common.EID.Models.CardFiles.File
	{
		ResponseApdu response = await CommandApduBuilder.SendAPDU(command: CommandApduBuilder.GetSelectFileCommand(file, context), header: "Select file: " + file.Identifier, context: context);
		if (response.SW == 36864 && (context == null || !context.IsBAC || response.IsValidResponse(context)))
		{
			using (MemoryStream s = new MemoryStream())
			{
				T result;
				await using (BinaryWriter bw = new BinaryWriter(s))
				{
					int i = 1;
					while (true)
					{
						response = await CommandApduBuilder.SendAPDU(command: CommandApduBuilder.ReadSelectedFileCommand((int)s.Length, context), header: $"Part {i} read", context: context, autoDecrypt: false);
						switch (response.SW)
						{
						case 0:
							result = null;
							goto end_IL_03b5;
						case 36864:
							if (context != null)
							{
								response = (context.IsBAC ? response.DecryptDES(context) : response.DecryptAES(context));
							}
							break;
						}
						if (response.SW == 36864)
						{
							bw.Write(response.Data);
						}
						if (response.Nr < ((context != null) ? 223 : 255))
						{
							byte[] bytes = s.ToArray();
							T result2 = (T)Activator.CreateInstance(typeof(T), bytes);
							if (result2.Parse())
							{
								result = result2;
								break;
							}
						}
						i++;
						continue;
						end_IL_03b5:
						break;
					}
				}
				return result;
			}
		}
		return null;
	}
}
