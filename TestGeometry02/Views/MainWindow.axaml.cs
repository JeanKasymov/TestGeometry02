using Avalonia.Controls;
using TestGeometry02.ViewModels;

namespace TestGeometry02.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}