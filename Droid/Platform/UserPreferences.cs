using ConferenceApp.Contracts;
using ConferenceApp.Droid;
using Android.App;
using Android.Content;

[assembly: Xamarin.Forms.Dependency(typeof(UserPreferences))]

namespace ConferenceApp.Droid
{
    public class UserPreferences : IUserPreferences
    {
		public void SetString(string key, string value)
        {
			var prefs = Application.Context.GetSharedPreferences("ConferenceApp", FileCreationMode.Private);
			var prefEditor = prefs.Edit();
			prefEditor.PutString(key, value);
			prefEditor.Commit();
		}

        public string GetString(string key)
        {
			var prefs = Application.Context.GetSharedPreferences("ConferenceApp", FileCreationMode.Private);
			return prefs.GetString(key, null);
        }
    }
}
