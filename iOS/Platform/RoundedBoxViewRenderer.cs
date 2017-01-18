using UIKit;
using ConferenceApp;
using ConferenceApp.iOS;
using System.ComponentModel;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]
namespace ConferenceApp.iOS
{
    public class RoundedBoxViewRenderer : ViewRenderer<RoundedBoxView, UIView>
    {
        private UIView _childView;

        protected override void OnElementChanged(ElementChangedEventArgs<RoundedBoxView> e)
        {
            base.OnElementChanged(e);

            var view = e.NewElement;
            if (view != null)
            {
                var shadowView = new UIView();
                _childView = new UIView()
                {
                    BackgroundColor = view.Color.ToUIColor(),
                    Layer =
                    {
                        CornerRadius = (float)view.CornerRadius,
                        BorderColor = view.Stroke.ToCGColor(),
                        BorderWidth = (float)view.StrokeThickness,
                        MasksToBounds = true
                    },
                    AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight
                };
                shadowView.Add(_childView);

                if (view.HasShadow)
                {
                    shadowView.Layer.ShadowColor = UIColor.Black.CGColor;
                    shadowView.Layer.ShadowOffset = new SizeF(3, 3);
                    shadowView.Layer.ShadowOpacity = 1;
                    shadowView.Layer.ShadowRadius = 5;
                }

                this.SetNativeControl(shadowView);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == RoundedBoxView.CornerRadiusProperty.PropertyName)
            {
                _childView.Layer.CornerRadius = (float)this.Element.CornerRadius;
            }
            else if (e.PropertyName == RoundedBoxView.StrokeProperty.PropertyName)
            {
                _childView.Layer.BorderColor = this.Element.Stroke.ToCGColor();
            }
            else if (e.PropertyName == RoundedBoxView.StrokeThicknessProperty.PropertyName)
            {
                _childView.Layer.BorderWidth = (float)this.Element.StrokeThickness;
            }
            else if (e.PropertyName == BoxView.ColorProperty.PropertyName)
            {
                _childView.BackgroundColor = this.Element.Color.ToUIColor();
            }
            else if (e.PropertyName == RoundedBoxView.HasShadowProperty.PropertyName)
            {
                if (this.Element.HasShadow)
                {
                    this.NativeView.Layer.ShadowColor = UIColor.Black.CGColor;
                    this.NativeView.Layer.ShadowOffset = new SizeF(3, 3);
                    this.NativeView.Layer.ShadowOpacity = 1;
                    this.NativeView.Layer.ShadowRadius = 5;
                }
                else
                {
                    this.NativeView.Layer.ShadowColor = UIColor.Clear.CGColor;
                    this.NativeView.Layer.ShadowOffset = new SizeF();
                    this.NativeView.Layer.ShadowOpacity = 0;
                    this.NativeView.Layer.ShadowRadius = 0;
                }
            }
        }
    }
}

