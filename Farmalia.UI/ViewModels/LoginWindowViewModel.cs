using System;
using System.Windows;
using System.Windows.Input;
using Farmalia.UI;
using Farmalia.UI.Views;

namespace Farmalia.UI.ViewModels
{
    public class LoginWindowViewModel : BaseViewModel
    {
        private string _username = "";
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password = "";
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; }

        public LoginWindowViewModel()
        {
            LoginCommand = new RelayCommand(_ => ExecuteLogin());
        }

        private void ExecuteLogin()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve parola girin.",
                                "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // TODO: Gerçek kimlik doğrulama eklenecek
            var main = new MainWindow();
            Application.Current.MainWindow = main;
            main.DataContext = new MainWindowViewModel();
            main.Show();

            // LoginWindow’ı kapat
            foreach (Window w in Application.Current.Windows)
                if (w is LoginWindow) { w.Close(); break; }
        }
    }
}
