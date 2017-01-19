using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Azure.Mobile;
using UIKit;

namespace ConferenceApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			// App bei Mobile Center registrieren
			MobileCenter.Configure (MobileCenterAppSecret.ConferenceApp_iOS);

			ImageCircle.Forms.Plugin.iOS.ImageCircleRenderer.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
