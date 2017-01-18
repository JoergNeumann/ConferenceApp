using Android.Graphics;
using ConferenceApp;
using ConferenceApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRendererAttribute(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]
namespace ConferenceApp.Droid
{
    public class RoundedBoxViewRenderer : BoxRenderer
    {
        public RoundedBoxViewRenderer()
        {
            this.SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            var rbv = this.Element as RoundedBoxView;

            var rc = new Rect();
            this.GetDrawingRect(rc);

            var interior = rc;
            interior.Inset((int)rbv.StrokeThickness, (int)rbv.StrokeThickness);

            var p = new Paint()
            {
                Color = rbv.Color.ToAndroid(),
                AntiAlias = true,
            };

            canvas.DrawRoundRect(new RectF(interior), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);

            p.Color = rbv.Stroke.ToAndroid();
            p.StrokeWidth = (float)rbv.StrokeThickness;
            p.SetStyle(Paint.Style.Stroke);

            canvas.DrawRoundRect(new RectF(rc), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == RoundedBoxView.CornerRadiusProperty.PropertyName
                || e.PropertyName == RoundedBoxView.StrokeProperty.PropertyName
                || e.PropertyName == RoundedBoxView.StrokeThicknessProperty.PropertyName
                || e.PropertyName == RoundedBoxView.HasShadowProperty.PropertyName)
            {
                this.Invalidate();
            }
        }
    }
}

