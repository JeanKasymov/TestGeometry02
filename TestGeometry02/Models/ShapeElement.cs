using Avalonia.Controls.Shapes;
using System.ComponentModel;

namespace TestGeometry02.Models
{
    public abstract class ShapeElement : INotifyPropertyChanged
    {
        private double _x;
        private double _y;
        private string _name;

        public double X
        {
            get => _x;
            set { _x = value; OnPropertyChanged(nameof(X)); }
        }

        public double Y
        {
            get => _y;
            set { _y = value; OnPropertyChanged(nameof(Y)); }
        }

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public abstract Shape CreateVisual();

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
