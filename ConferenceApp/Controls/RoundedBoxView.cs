using Xamarin.Forms;

namespace ConferenceApp
{
    public class RoundedBoxView : BoxView
    {
		public static readonly BindableProperty CornerRadiusProperty =
			BindableProperty.Create("CornerRadius", typeof(double), typeof(RoundedBoxView), 0d);

        public double CornerRadius
        {
            get { return (double)base.GetValue(CornerRadiusProperty); }
            set { base.SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty StrokeProperty =
            BindableProperty.Create("Stroke", typeof(Color), typeof(RoundedBoxView), Color.Transparent);

        public Color Stroke
        {
            get { return (Color)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static readonly BindableProperty StrokeThicknessProperty =
            BindableProperty.Create("StrokeThickness", typeof(double), typeof(RoundedBoxView), 0d);

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }

        public static readonly BindableProperty HasShadowProperty =
            BindableProperty.Create("HasShadow", typeof(bool), typeof(RoundedBoxView), false);

        public bool HasShadow
        {
            get { return (bool)GetValue(HasShadowProperty); }
            set { SetValue(HasShadowProperty, value); }
        }
    }
}

