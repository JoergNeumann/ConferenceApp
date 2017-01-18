using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ConferenceApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabPage = new TabbedPage();
			tabPage.Title = "Conference App";
			tabPage.Children.Add(new SessionPage() { Icon = "sessions.png" });
			tabPage.Children.Add(new SpeakerPage() { Icon = "speakers.png" });
			tabPage.Children.Add(new FavoritesPage() { Icon = "favorites.png" });
			tabPage.Children.Add(new FeedbackPage() { Icon = "Feedback.png" });
			MainPage = new NavigationPage(tabPage);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

