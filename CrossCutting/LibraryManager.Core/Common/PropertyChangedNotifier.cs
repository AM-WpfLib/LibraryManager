using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LibraryManager.Core.Common
{
    public abstract class PropertyChangedNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged(params string[] names)
        {
            OnPropertyChanged((IEnumerable<string>)names);
        }

        protected virtual void OnPropertyChanged(IEnumerable<string> names)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged == null)
            {
                return;
            }

            foreach (string name in names)
            {
                propertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
