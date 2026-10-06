using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using DigiD.Common.EID.Helpers;
using DigiD.Common.Interfaces;
using DigiD.Common.Models.Enums;
using DigiD.Common.Models.Nfc;
using Microsoft.Maui.Storage;
using Windows.Devices.Enumeration;
using Windows.Devices.SmartCards;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;

namespace DigiD.Common.Plugins.Services;

public class NfcService : INfcService
{
	private SmartCardReader? _cardReader;

	private SmartCard? _card;

	private string SelectedReader
	{
		get
		{
			return Microsoft.Maui.Storage.Preferences.Get("SelectedReader", string.Empty);
		}
		set
		{
			Microsoft.Maui.Storage.Preferences.Set("SelectedReader", value);
		}
	}

	public bool IsNFCEnabled => false;

	public bool IsCancelled { get; set; }

	public string? SelectedAID { get; set; }

	public AntennaLocation? AntennaLocation => null;

	public bool HasNFCSupport()
	{
		return false;
	}

	public async Task<string[]> GetReaders()
	{
		return (await DeviceInformation.FindAllAsync(SmartCardReader.GetDeviceSelector())).Select((DeviceInformation x) => x.Name).ToArray();
	}

	public void OpenNFCSettings()
	{
		throw new NotImplementedException();
	}

	public async Task<bool> StartScanningAsync(Func<Task> tagFoundAction, Func<NfcError, Task> errorAction, string? message = null)
	{
		DeviceInformationCollection availableReaders = await DeviceInformation.FindAllAsync(SmartCardReader.GetDeviceSelector());
		bool flag = availableReaders.Any((DeviceInformation x) => x.Id == SelectedReader);
		bool flag2 = flag;
		if (flag2)
		{
			flag2 = await ConnectReader(SelectedReader, tagFoundAction);
		}
		if (flag2)
		{
			return true;
		}
		foreach (DeviceInformation deviceInfo in availableReaders)
		{
			if (await ConnectReader(deviceInfo.Id, tagFoundAction))
			{
				return true;
			}
		}
		return false;
	}

	private async Task<bool> ConnectReader(string readerName, Func<Task> tagFoundAction)
	{
		_cardReader = await SmartCardReader.FromIdAsync(readerName);
		IReadOnlyList<SmartCard> cards = await _cardReader.FindAllCardsAsync();
		if (cards.Count != 0)
		{
			_card = cards[0];
			if (await this.ReadCard() != null)
			{
				SelectedReader = readerName;
				await tagFoundAction();
				return true;
			}
		}
		return false;
	}

	public Task StopScanningAsync(string? message = null, bool waitForDisconnect = false)
	{
		return Task.Run(delegate
		{
			if (!(_cardReader == null))
			{
				_cardReader = null;
				_card = null;
			}
		});
	}

	public async Task<TransceiveResult> SendApduAsync(byte[] command)
	{
		TransceiveResult result = new TransceiveResult();
		if (IsCancelled)
		{
			result.Exception = new TaskCanceledException();
			return result;
		}
		try
		{
			ArgumentNullException.ThrowIfNull(_card, "_card");
			SmartCardStatus smartCardStatus = await _card.GetStatusAsync();
			if ((smartCardStatus == SmartCardStatus.Disconnected || smartCardStatus == SmartCardStatus.Unresponsive) ? true : false)
			{
				result.Exception = new CardLostException();
				return result;
			}
			using SmartCardConnection connection = await _card.ConnectAsync();
			IBuffer apduToSend = CryptographicBuffer.CreateFromByteArray(command);
			result.Data = (await connection.TransmitAsync(apduToSend)).ToArray();
			return result;
		}
		catch (Exception)
		{
			result.Exception = new CardLostException();
			return result;
		}
	}

	public async Task<bool> IsTagConnected()
	{
		if (_card == null)
		{
			return false;
		}
		SmartCardStatus status = await _card.GetStatusAsync();
		return (_card != null && status == SmartCardStatus.Ready) || status == SmartCardStatus.Shared;
	}

	public void Disconnect()
	{
		_card = null;
	}

	public void UpdateStatus(double percentage)
	{
	}
}
