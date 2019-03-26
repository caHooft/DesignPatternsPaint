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
    class Shape
    {
        //public List<Shape> children;
        public Point startPoint;
        
        public virtual void Init(Canvas grid)
        {
        }

        public virtual void Draw(object sender, MouseEventArgs e, Canvas grid)
        {
        }

        public virtual void Done()
        {
        }
    }
}
