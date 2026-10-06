using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using DigiD.Common.Resources;
using DigiD.Mobile.Models;
using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace DigiD.Mobile.ViewModels;

public class HLP010ViewModel : CarouselViewModel
{
	public HLP010ViewModel()
	{
		base.PageId = "HLP010";
		int num = 5;
		List<CarouselViewItemModel> list = new List<CarouselViewItemModel>(num);
		CollectionsMarshal.SetCount(list, num);
		Span<CarouselViewItemModel> span = CollectionsMarshal.AsSpan(list);
		span[0] = new CarouselViewItemModel
		{
			TitleText = DigiDAppResources.HLP10_1Titel,
			BodyText = DigiDAppResources.HLP10_1Body,
			Source = "digid_afbeelding_idcheck.png"
		};
		span[1] = new CarouselViewItemModel
		{
			TitleText = DigiDAppResources.HLP10_2Titel,
			BodyText = DigiDAppResources.HLP10_2Body,
			Source = "digid_afbeelding_checkid_app.png"
		};
		span[2] = new CarouselViewItemModel
		{
			TitleText = DigiDAppResources.HLP10_3Titel,
			BodyText = DigiDAppResources.HLP10_3Body,
			Source = "digid_afbeelding_checkid_nfc_digid.png"
		};
		span[3] = new CarouselViewItemModel
		{
			TitleText = DigiDAppResources.HLP10_4Titel,
			BodyText = DigiDAppResources.HLP10_4Body,
			Source = "digid_afbeelding_idcheck_toegevoegd.png"
		};
		span[4] = new CarouselViewItemModel
		{
			TitleText = DigiDAppResources.HLP10_5Titel,
			BodyText = DigiDAppResources.HLP10_5Body,
			Source = "digid_afbeelding_informatie_delen.png",
			LinkText = DigiDAppResources.HLP10_5Knop,
			Command = new AsyncRelayCommand((Func<Task>)async delegate
			{
				await Share.Default.RequestAsync(new ShareTextRequest
				{
					Text = DigiDAppResources.HLP10_Email,
					Title = DigiDAppResources.HLP10_ShareTitle,
					Subject = DigiDAppResources.HLP10_ShareTitle
				});
			})
		};
		base.Items = list;
	}
}
