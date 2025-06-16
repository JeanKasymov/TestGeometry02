using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace TestGeometry02.Models
{
    public class RectangleElement : ShapeElement
    {
        private double _width = 60;
        private double _height = 40;

        public double Width
        {
            get => _width;
            set { _width = value; OnPropertyChanged(nameof(Width)); }
        }

        public double Height
        {
            get => _height;
            set { _height = value; OnPropertyChanged(nameof(Height)); }
        }

        public RectangleElement()
        {
            Name = "Rectangle";
        }

        public override Shape CreateVisual()
        {
            return new Avalonia.Controls.Shapes.Rectangle
            {
                Width = Width,
                Height = Height,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                RadiusX = 5,
                RadiusY = 5
            };
        }
    }
}
