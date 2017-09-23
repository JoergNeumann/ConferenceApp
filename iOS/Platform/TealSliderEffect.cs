using ConferenceApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("ConferenceApp")]
[assembly: ExportEffect(typeof(TealSliderEffect), "TealSliderEffect")]
namespace ConferenceApp.iOS
{
	public class TealSliderEffect : PlatformEffect
	{
		public TealSliderEffect()
		{
		}

		protected override void OnAttached()
		{
			var slider = (UISlider)Control;
			slider.ThumbTintColor = UIColor.FromRGB(0, 121, 107);
			slider.MinimumTrackTintColor = UIColor.FromRGB(0, 150, 136);
			slider.MaximumTrackTintColor = UIColor.FromRGB(0, 121, 107);
		}

		protected override void OnDetached()
		{

		}
	}
}

