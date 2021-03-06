﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ConferenceApp
{
	public partial class App : Application
	{
		public App()
		{
			// Analytics & Crash Reporting konfigurieren
			MobileCenter.Start (typeof (Analytics), typeof (Crashes));

			InitializeComponent();

			var tabPage = new TabbedPage();
			tabPage.Title = "Conference App";
			tabPage.Children.Add(new SessionPage() { Icon = "sessions.png" });
			tabPage.Children.Add(new SpeakerPage() { Icon = "speakers.png" });
			tabPage.Children.Add(new FavoritesPage() { Icon = "favorites.png" });
			tabPage.Children.Add(new FeedbackPage() { Icon = "Feedback.png" });
			MainPage = new NavigationPage(tabPage);
		}

		protected async override void OnStart()
		{
			await Analytics.IsEnabledAsync();
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

