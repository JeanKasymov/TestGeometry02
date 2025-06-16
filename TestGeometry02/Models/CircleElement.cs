using Avalonia.Controls.Shapes;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeometry02.Models
{
    public class CircleElement : ShapeElement
    {
        private double _radius = 30;

        public double Radius
        {
            get => _radius;
            set { _radius = value; OnPropertyChanged(nameof(Radius)); }
        }

        public CircleElement()
        {
            Name = "Circle";
        }

        // Полиморфизм через переопределение
        public override Shape CreateVisual()
        {
            return new Ellipse
            {
                Width = Radius * 2,
                Height = Radius * 2,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
        }
    }
}
