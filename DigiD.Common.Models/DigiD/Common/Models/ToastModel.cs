using System;
using System.Runtime.CompilerServices;
using DigiD.Common.Resources;

namespace DigiD.Common.Models;

public record ToastModel
{
	public string Message { get; init; }

	public string? Title { get; init; }

	public ToastType Type { get; init; }

	public DateTime CreationTime { get; }

	public ToastPriority Priority { get; set; }

	public string TitleForAccessibility
	{
		get
		{
			if (Title != null)
			{
				return Title;
			}
			return Type switch
			{
				ToastType.Warning => DigiDAppResources.DG087_Warning_Title, 
				ToastType.Error => CommonResources.Alg_Error, 
				_ => "", 
			};
		}
	}

	public ToastModel(string Message, string? Title, ToastType Type, ToastPriority Priority)
	{
		this.Message = Message;
		this.Title = Title;
		this.Type = Type;
		CreationTime = DateTime.UtcNow;
		this.Priority = Priority;
		base._002Ector();
	}

	[CompilerGenerated]
	public void Deconstruct(out string Message, out string? Title, out ToastType Type, out ToastPriority Priority)
	{
		Message = this.Message;
		Title = this.Title;
		Type = this.Type;
		Priority = this.Priority;
	}
}
