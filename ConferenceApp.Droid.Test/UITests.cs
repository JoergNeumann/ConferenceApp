using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace ConferenceApp.Droid.Test
{
    [TestFixture]
    public class UITests
    {
        AndroidApp app;
        [SetUp]
        public void SetUp()
        {
            app = ConfigureApp
				.Android
				.StartApp ();
			//app = ConfigureApp.Android.ApkFile("/Users/administrator/Desktop/neumann.conferenceapp.apk").StartApp();
        }

        [Test]
        public void NewTest()
        {
            app.Tap(x => x.Text("09:00 bis 17.00 Uhr"));
            app.Screenshot("Tapped on view with class: FormsTextView");
            app.Tap(x => x.Class("SwitchCompat"));
            app.Screenshot("Tapped on view with class: SwitchCompat");
            app.SetSliderValue(x => x.Class("FormsSeekBar"), 1000);
            app.Tap(x => x.Class("ImageButton"));
            app.Screenshot("Tapped on view with class: ImageButton");
            app.Tap(x => x.Text("Sprecher"));
            app.Screenshot("Tapped on view with class: AppCompatTextView");
            app.Tap(x => x.Text("Dominick Baier"));
            app.Screenshot("Tapped on view with class: FormsTextView");
            app.Tap(x => x.Class("ImageButton"));
            app.Screenshot("Tapped on view with class: ImageButton");
            app.Tap(x => x.Text("Favoriten"));
            app.Screenshot("Tapped on view with class: AppCompatTextView");
            app.Tap(x => x.Class("AppCompatImageView").Index(3));
            app.Screenshot("Tapped on view with class: AppCompatImageView");
            app.Tap(x => x.Class("EntryEditText"));
            app.Screenshot("Tapped on view with class: EntryEditText");
            app.EnterText(x => x.Class("EntryEditText"), "joerg.neumann@acando.de");

			app.Tap(x => x.Class("FormsImageView").Index(5));
            app.Screenshot("Tapped on view with class: FormsImageView");
            app.Tap(x => x.Text("Senden"));
            app.Screenshot("Tapped on view with class: AppCompatButton");
            app.Tap(x => x.Id("button2"));
            app.Screenshot("Tapped on view with class: AppCompatButton");
        }

    }
}
