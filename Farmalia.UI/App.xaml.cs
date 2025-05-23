using System.Windows;
// Eğer LoginWindow root altında ise, aşağıdaki satıra gerek yok:
// using Farmalia.UI; 
// Eğer Views klasöründeyse:
using Farmalia.UI.Views;

namespace Farmalia.UI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // LoginWindow ya da Views.LoginWindow
            var login = new LoginWindow();
            login.Show();
        }
    }
}
