using System;
using System.Collections.Generic;

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

