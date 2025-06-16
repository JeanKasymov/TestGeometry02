using Avalonia.Controls.Shapes;
using Avalonia.Media;
using System.Collections.ObjectModel;
using TestGeometry02.Models;

namespace TestGeometry02.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<ShapeElement> ShapeElementss { get; } = new ObservableCollection<ShapeElement>();
        public ObservableCollection<Shape> VisualShapes { get; } = new ObservableCollection<Shape>();
        public void AddShape(string shapeName)
        {
            ShapeElement shape;
            if (!string.IsNullOrEmpty(shapeName))
            {
                if(shapeName == "Circle")
                {
                    shape = new CircleElement();
                }
                else if(shapeName== "Rectangle")
                {
                    shape = new RectangleElement();
                }
                else
                {
                    shape = new TriangleElement();
                }
                // Устанавливаем позицию
                shape.X = 50 + ShapeElementss.Count * 70;
                shape.Y = 50;

                ShapeElementss.Add(shape);

                // Создаем визуальное представление
                var visual = shape.CreateVisual();
                VisualShapes.Add(visual);

                // Привязка позиции через трансформацию
                visual.RenderTransform = new TranslateTransform(shape.X, shape.Y);

                // Реакция на изменение позиции
                shape.PropertyChanged += (s, e) =>
                {
                    if (e.PropertyName == nameof(ShapeElement.X) || e.PropertyName == nameof(ShapeElement.Y))
                    {
                        ((TranslateTransform)visual.RenderTransform).X = shape.X;
                        ((TranslateTransform)visual.RenderTransform).Y = shape.Y;
                    }
                };
            }
        }

    }
}
