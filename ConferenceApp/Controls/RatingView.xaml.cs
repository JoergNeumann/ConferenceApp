using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ConferenceApp
{
	public partial class RatingView : ContentView
	{
		public RatingView()
		{
			InitializeComponent();
		}

		public string Vote
		{
			get { return this.ratingLabel.Text; }
		}

		public int Rating
		{
			get { return this.starFive.Rating; }
		}

	}
}
