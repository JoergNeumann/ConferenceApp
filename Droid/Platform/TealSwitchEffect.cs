using Android.Graphics;
using ConferenceApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(TealSwitchEffect), "TealSwitchEffect")]
namespace ConferenceApp.Droid
{
	public class TealSwitchEffect : PlatformEffect
	{
		public TealSwitchEffect()
		{
		}

		protected override void OnAttached()
		{
			var view = (Android.Support.V7.Widget.SwitchCompat)Control;
			view.ThumbDrawable.SetColorFilter(new PorterDuffColorFilter(Xamarin.Forms.Color.Teal.ToAndroid(), PorterDuff.Mode.SrcIn));
			view.TrackDrawable.SetColorFilter(new PorterDuffColorFilter(Xamarin.Forms.Color.Teal.ToAndroid(), PorterDuff.Mode.SrcIn));
		}

		protected override void OnDetached()
		{

		}
	}
}