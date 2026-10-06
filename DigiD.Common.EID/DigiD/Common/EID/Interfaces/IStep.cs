using System.Threading.Tasks;

namespace DigiD.Common.EID.Interfaces;

public interface IStep
{
	Task<bool> Execute();
}
