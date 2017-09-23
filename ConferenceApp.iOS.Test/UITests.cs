using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;

namespace ConferenceApp.iOS.Test
{
    [TestFixture]
    public class UITests
    {
        iOSApp app;
        [SetUp]
        public void SetUp()
        {
			app = ConfigureApp
				.iOS
				.StartApp ();
			//app = ConfigureApp.iOS.AppBundle("/Users/administrator/Desktop/BASTA/HockeyApp/iOS/bin/iPhoneSimulator/Release/xtr-xtr-ConferenceApp.iOS.app").StartApp();
        }

        [Test]
        public void NewTest()
        {
            app.Tap(x => x.Marked(".NET-Programmierer und Architekten: Strategien 2017"));
            app.Screenshot("Tapped on view with class: UILabel marked: .NET-Programmierer und Architekten: Strategien 2017");
            app.Tap(x => x.Class("UISwitch"));
            app.Screenshot("Tapped on view with class: UISwitch");
            app.SetSliderValue(x => x.Class("UISlider"), 6000000);
            app.Tap(x => x.Class("UINavigationItemButtonView"));
            app.Screenshot("Tapped on view with class: UINavigationItemButtonView");
            app.Tap(x => x.Id("favorites.png"));
            app.Screenshot("Tapped on view with class: UITabBarSwappableImageView");
            app.Tap(x => x.Id("speakers.png"));
            app.Screenshot("Tapped on view with class: UITabBarSwappableImageView");
            app.Tap(x => x.Marked("Dominick Baier"));
            app.Screenshot("Tapped on view with class: UILabel marked: Dominick Baier");
            app.Tap(x => x.Text("Conference App"));
            app.Screenshot("Tapped on view with class: UILabel marked: Conference App");
            app.Tap(x => x.Id("Feedback.png"));
            app.Screenshot("Tapped on view with class: UITabBarSwappableImageView");
            //app.Tap(x => x.Class("UIImageView").Index(22));
            //app.Screenshot("Tapped on view with class: UIImageView");
            app.Tap(x => x.Marked("E-Mail"));
            app.Screenshot("Tapped on view with class: UITextFieldLabel marked: E-Mail");
            app.EnterText(x => x.Class("UITextField"), "Joergneumann@acando.de");
            app.Tap(x => x.Marked("Alter"));
            app.Screenshot("Tapped on view with class: UITextFieldLabel marked: Alter");
            app.EnterText(x => x.Class("UITextField").Index(1), "45");
            app.Tap(x => x.Marked("Geschlecht"));
            app.Screenshot("Tapped on view with class: UITextFieldLabel marked: Geschlecht");
            app.Tap(x => x.Marked("Mann").Index(1));
            app.Screenshot("Tapped on view with class: UILabel marked: Mann");
            app.Tap(x => x.Marked("Done"));
            app.Screenshot("Tapped on view with class: UIToolbarTextButton marked: Done");
            app.Tap(x => x.Text("Senden"));
            app.Screenshot("Tapped on view with class: UIButtonLabel marked: Senden");
            app.Tap(x => x.Marked("OK"));
            app.Screenshot("Tapped on view with class: _UIAlertControllerActionView marked: OK");
        }

    }
}
