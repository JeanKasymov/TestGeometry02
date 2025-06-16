using Avalonia.Controls.Shapes;
using Avalonia.Media;

namespace TestGeometry02.Models
{
    public class TriangleElement : ShapeElement
    {
        public TriangleElement() => Name = "Triangle";

        public override Shape CreateVisual()
        {
            var polygon = new Polygon
            {
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            polygon.Points.Add(new Avalonia.Point(0, 40));
            polygon.Points.Add(new Avalonia.Point(30, 0));
            polygon.Points.Add(new Avalonia.Point(60, 40));

            return polygon;
        }
    }
}
