using Avalonia.Controls;
using CafeApp.ViewModels;

namespace CafeApp.Views
{
    public partial class WaiterWindow : Window
    {
        public WaiterWindow()
        {
            DataContext = new WaiterWindowVM();
            InitializeComponent();
        }
    }
}
