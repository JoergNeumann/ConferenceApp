using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Analytics;
using Xamarin.Forms;

namespace ConferenceApp
{
	public partial class FeedbackPage : ContentPage
	{
		public FeedbackPage()
		{
			InitializeComponent();
		}

		private async void OnSubmitButtonClicked(object sender, EventArgs e)
		{
			await this.DisplayAlert("Danke!", "Dein Feedback wurde gesendet!", "OK");

			// Custom analytics event auslösen
			Analytics.TrackEvent ("Feedback button clicked", new Dictionary<string, string> {
				{ "Category", "Feedback" },
				{ "Vote", "5" } //this.ratingView.Vote
			});

			// Exception auslösen
			//var a = 0;
			//var b = 1 / a;
		}
	}
}
