using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiD.Common.EID.Interfaces;

public interface ICardOperation
{
	List<IStep> Steps { get; }

	Task<bool> Execute();
}
