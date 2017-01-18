﻿using Xamarin.Forms;

namespace ConferenceApp
{
    public class MaxLengthValidator : Behavior<Entry>
    {
        public static readonly BindableProperty MaxLengthProperty = 
			BindableProperty.Create("MaxLength", typeof(int), typeof(MaxLengthValidator), 0);

        public int MaxLength
        {
            get { return (int)GetValue(MaxLengthProperty); }
            set { SetValue(MaxLengthProperty, value); }
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
			if (e.NewTextValue.Length > 0 && e.NewTextValue.Length > MaxLength)
				((Entry)sender).Text = e.NewTextValue.Substring(0, MaxLength);
		}
	}
}
