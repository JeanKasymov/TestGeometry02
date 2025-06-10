using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using System.Reactive;
using System.Windows.Input;

namespace TestGeometry02.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private Geometry _geom;
        [ObservableProperty]
        private string _size;
        public string Greeting { get; } = "Welcome to Avalonia!";
        public MainWindowViewModel()
        {
        }
        public void CreateGeometry()
        {
            var doubleSize = double.Parse(Size);
            Geom = new EllipseGeometry() { RadiusX = doubleSize / 2, RadiusY = doubleSize / 2 };
        }

    }
}
