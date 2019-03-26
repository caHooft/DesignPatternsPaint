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
    class Square : Shape
    {
        public Rectangle obj;
        //Stroke = Brushes.Black;

        public override void Init(Canvas grid)
        {
            obj = new Rectangle
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
            if (e.LeftButton == MouseButtonState.Released || obj == null)
                return;

            var pos = e.GetPosition(grid);

            var x = Math.Min(pos.X, startPoint.X);
            var y = Math.Min(pos.Y, startPoint.Y);

            var w = Math.Max(pos.X, startPoint.X) - x;
            var h = Math.Max(pos.Y, startPoint.Y) - y;

            obj.Width = w;
            obj.Height = h;

            Canvas.SetLeft(obj, x);
            Canvas.SetTop(obj, y);
        }

        public override void Done()
        {
            obj = null;
        }
    }
}
