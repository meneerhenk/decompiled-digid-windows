using System;

namespace DigiD.Common.Interfaces;

public interface IExceptionService
{
	Exception Cast(Exception ex);
}
