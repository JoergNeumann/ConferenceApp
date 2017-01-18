using ConferenceApp.Models;
using Xamarin.Forms;

namespace ConferenceApp
{
	public partial class SessionDetailsPage : ContentPage
	{
		public SessionDetailsPage(Session session)
		{
			InitializeComponent();
			this.BindingContext = session;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			// Effect per Code zuweisen
			this.votingSlider.Effects.Add(Effect.Resolve("ConferenceApp.TealSliderEffect"));

			// Ist Session als Favorit markiert?
			if (SessionService.Current.IsFavorite(this.BindingContext as Session))
			{
				this.favoriteSwitch.IsToggled = true;
			}

			this.favoriteSwitch.Toggled += OnFavoriteSwitchToggled;
		}

		private void OnFavoriteSwitchToggled(object sender, ToggledEventArgs e)
		{
			if (e.Value)
			{
				SessionService.Current.AddFavorite(this.BindingContext as Session);
			}
			else
			{
				SessionService.Current.RemoveFavorite(this.BindingContext as Session);
			}
		}

		private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
		{
			var text = "";
			switch ((int)e.NewValue)
			{
				case 0:
					text = "(nicht bewertet)";
					break;
				case 1:
					text = "ungenügend";
					break;
				case 2:
					text = "mangelhaft";
					break;
				case 3:
					text = "ausreichend";
					break;
				case 4:
					text = "befriedigend";
					break;
				case 5:
					text = "gut";
					break;
				case 6:
					text = "sehr gut";
					break;
			}
			this.votingLabel.Text = text;
		}
	}
}

