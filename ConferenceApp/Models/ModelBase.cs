using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConferenceApp
{
    public class ModelBase : INotifyPropertyChanged
    {
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            field = value;
            this.OnPropertyChanged(propertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
