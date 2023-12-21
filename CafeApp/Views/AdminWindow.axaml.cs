using Avalonia.Controls;
using CafeApp.ViewModels;

namespace CafeApp.Views
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            DataContext = new AdminWindowVM();
            InitializeComponent();
        }
    }
}
