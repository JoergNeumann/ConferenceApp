
namespace ConferenceApp.Contracts
{
    public interface IUserPreferences
    {
        void SetString(string key, string value);
        string GetString(string key);
    }
}
