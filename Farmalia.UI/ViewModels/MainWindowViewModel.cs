using System.Windows;
using System.Windows.Input;
using Farmalia.UI.Views;

namespace Farmalia.UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private object? _currentView;
        public object? CurrentView
        {
            get => _currentView;
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand ShowDashboardCommand { get; }
        public ICommand ShowInventoryCommand { get; }
        public ICommand ShowSalesCommand { get; }
        public ICommand ShowPrescriptionsCommand { get; }
        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowSuppliersCommand { get; }
        public ICommand ShowReportsCommand { get; }
        public ICommand ExitCommand { get; }

        public MainWindowViewModel()
        {
            // Navigasyon komutlarını tanımla
            ShowDashboardCommand = new RelayCommand(_ => CurrentView = new DashboardView());
            ShowInventoryCommand = new RelayCommand(_ => CurrentView = new InventoryView());
            ShowSalesCommand = new RelayCommand(_ => CurrentView = new SalesView());
            ShowPrescriptionsCommand = new RelayCommand(_ => CurrentView = new PrescriptionsView());
            ShowCustomersCommand = new RelayCommand(_ => CurrentView = new CustomersView());
            ShowSuppliersCommand = new RelayCommand(_ => CurrentView = new SuppliersView());
            ShowReportsCommand = new RelayCommand(_ => CurrentView = new ReportsView());

            ExitCommand = new RelayCommand(_ => Application.Current.Shutdown());

            // Uygulama ilk açıldığında Dashboard gösterilsin
            CurrentView = new DashboardView();
        }
    }
}
