using Avalonia.Controls;
using CafeApp.ViewModels;

namespace CafeApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new MainViewModel();
        InitializeComponent();
    }
}
