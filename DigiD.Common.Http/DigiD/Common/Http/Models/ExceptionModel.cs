using System;
using System.Collections.Generic;

namespace DigiD.Common.Http.Models;

public class ExceptionModel(Exception exception, Dictionary<string, string> properties)
{
	public Exception Exception { get; } = exception;

	public Dictionary<string, string> Properties { get; } = properties;
}
