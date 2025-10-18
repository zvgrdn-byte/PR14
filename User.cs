using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ControlsPractice.Models
{
    public class User : INotifyPropertyChanged
    {
        private string? _name;
        private string? _age;
        private string? _country;
        private bool _isSubscribed;

        public string? Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }

        public string? Age
        {
            get => _age;
            set { _age = value; OnPropertyChanged(); }
        }

        public string? Country
        {
            get => _country;
            set { _country = value; OnPropertyChanged(); }
        }

        public bool IsSubscribed
        {
            get => _isSubscribed;
            set { _isSubscribed = value; OnPropertyChanged(); }
        }

        public string Display => $"{Name}, {Age} лет, {Country}" + (IsSubscribed ? " (подписан)" : "");
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
