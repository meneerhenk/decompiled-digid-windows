namespace DigiD.Common.Interfaces;

public interface ISecureStorageService
{
	void Delete(string key);

	bool TryGetValue<T>(string key, out T? value);

	void SetValue<T>(string key, T value);
}
