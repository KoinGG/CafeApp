using Avalonia.Controls;
using CafeApp.ViewModels;

namespace CafeApp.Views
{
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            DataContext = new AuthWindowVM();
            InitializeComponent();
        }
    }
}
