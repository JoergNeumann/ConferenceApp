using Android.Graphics;
using Android.Widget;
using ConferenceApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("ConferenceApp")]
[assembly: ExportEffect(typeof(TealSliderEffect), "TealSliderEffect")]
namespace ConferenceApp.Droid
{
	public class TealSliderEffect : PlatformEffect
	{
		public TealSliderEffect()
		{
		}

		protected override void OnAttached()
		{
			var seekBar = (SeekBar)Control;
			seekBar.ProgressDrawable.SetColorFilter(new PorterDuffColorFilter(Xamarin.Forms.Color.Teal.ToAndroid(), PorterDuff.Mode.SrcIn));
			seekBar.Thumb.SetColorFilter(new PorterDuffColorFilter(Xamarin.Forms.Color.Teal.ToAndroid(), PorterDuff.Mode.SrcIn));
		}

		protected override void OnDetached()
		{

		}
	}
}