﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConferenceApp
{
	public partial class SpeakerPage : ContentPage
	{
		public SpeakerPage()
		{
			InitializeComponent();

			if (Device.RuntimePlatform == Device.WinPhone)
			{
				this.listView.RowHeight = 60;
			}
			else if (Device.RuntimePlatform == Device.Android)
			{
				this.listView.RowHeight = 60;
			}
		}

		private void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			var page = new SpeakerDetailsPage(e.Item as Speaker);
			this.Navigation.PushAsync(page);
		}
	}
}

