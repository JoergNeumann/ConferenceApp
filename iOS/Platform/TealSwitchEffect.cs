using ConferenceApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(TealSwitchEffect), "TealSwitchEffect")]
namespace ConferenceApp.iOS
{
	public class TealSwitchEffect : PlatformEffect
	{
		public TealSwitchEffect()
		{
		}

		protected override void OnAttached()
		{
			var view = (UISwitch)Control;
			view.ThumbTintColor = UIColor.FromRGB(0, 121, 107);
			view.OnTintColor = UIColor.FromRGB(0, 150, 136);
		}

		protected override void OnDetached()
		{

		}
	}
}

