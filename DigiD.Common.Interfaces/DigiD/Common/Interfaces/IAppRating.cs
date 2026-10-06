using System.Threading.Tasks;

namespace DigiD.Common.Interfaces;

public interface IAppRating
{
	bool ThrowErrors { get; set; }

	Task PerformInAppRateAsync();

	Task PerformRatingOnStoreAsync(string packageName = "", string applicationId = "", string productId = "");

	Task PerformRatingOnStoreAsync(string appId);
}
