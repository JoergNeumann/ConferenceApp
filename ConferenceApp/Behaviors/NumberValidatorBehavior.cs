using Xamarin.Forms;

namespace ConferenceApp
{
    public class NumberValidatorBehavior : Behavior<Entry> 
    {
        private static readonly BindablePropertyKey IsValidPropertyKey = 
			BindableProperty.CreateReadOnly("IsValid", typeof(bool), typeof(NumberValidatorBehavior), false);

        public static readonly BindableProperty IsValidProperty = IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)base.GetValue(IsValidProperty); }
            private set { base.SetValue(IsValidPropertyKey, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += this.OnTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= this.OnTextChanged;
        }

		private void OnTextChanged(object sender, TextChangedEventArgs e)
		{
			double result;
			IsValid = double.TryParse(e.NewTextValue, out result);
			((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;

		}
	}
}
