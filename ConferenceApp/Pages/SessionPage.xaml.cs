using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConferenceApp
{
	public partial class SessionPage : ContentPage
	{
		public SessionPage()
		{
			InitializeComponent();
		}

		private void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			var page = new SessionDetailsPage(e.Item as Session);
			this.Navigation.PushAsync(page);
		}
	}
}

