using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesignPatternsPaint
{
    class Triangle : Shape
    {
        public Polygon obj;
        //Stroke = Brushes.Black;

        public override void Init(Canvas grid)
        {
            obj = new Polygon
            {
                Stroke = Brushes.Black,
                StrokeThickness = 3
            };

            Canvas.SetLeft(obj, startPoint.X);
            Canvas.SetTop(obj, startPoint.Y);
            grid.Children.Add(obj);
        }

        public override void Draw(object sender, MouseEventArgs e, Canvas grid)
        {
            Point Point1 = startPoint;
            Point Point2 = new Point(10, 80);
            Point Point3 = new Point(50, 50);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            obj.Points = myPointCollection;
        }

        public override void Done()
        {
            obj = null;
        }
    }
}
