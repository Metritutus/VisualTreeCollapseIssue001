using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VisualTreeCollapseIssue001.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id
        {
            get => _Id;
            set
            {
                _Id = value;
                OnPropertyChanged();
            }
        }
        private int _Id;

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
        private string _Name;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
