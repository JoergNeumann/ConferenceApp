using System;
using System.Collections.Generic;

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
			var a = 0;
			var b = 1 / a;
		}
	}
}
