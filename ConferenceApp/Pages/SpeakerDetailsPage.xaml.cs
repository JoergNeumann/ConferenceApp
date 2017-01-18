using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace ConferenceApp
{
	public partial class SpeakerDetailsPage : ContentPage
	{
		public SpeakerDetailsPage(Speaker speaker)
		{
			InitializeComponent();
			this.BindingContext = speaker;
		}
	}
}

