using ConferenceApp.Contracts;
using ConferenceApp.iOS;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(UserPreferences))]

namespace ConferenceApp.iOS
{
    public class UserPreferences : IUserPreferences
    {
		NSUserDefaults _plist;

		public UserPreferences()
		{
			_plist = NSUserDefaults.StandardUserDefaults;
		}

		public void SetString(string key, string value)
        {
			_plist.SetString(value, key);
			_plist.Synchronize();
        }

        public string GetString(string key)
        {
			return _plist.StringForKey(key);
        }
    }
}
