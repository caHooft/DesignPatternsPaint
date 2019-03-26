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
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
        }

        private Shape currentShape = null;

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Button button = sender as Button;
			string txt = Convert.ToString(button.Content);
            switch(txt)
            {
                case "Square":
                    currentShape = new Square();
                    break;
                case "Circle":
                    currentShape = new Circle();
                    break;
                case "Triangle":
                    currentShape = new Triangle();
                    break;
                case "Text":
                    break;
                default:
                    break;
            }
			//MessageBox.Show("So you want to draw a " + txt + "!");
		}

		private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
		{
            if (currentShape != null)
            {
                currentShape.startPoint = e.GetPosition(grid);
                currentShape.Init(grid);
            }
		}

		private void Grid_MouseMove(object sender, MouseEventArgs e)
		{
            if(e.LeftButton == MouseButtonState.Pressed && currentShape != null)
                currentShape.Draw(sender, e, grid);
		}

		private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
		{
            if(currentShape != null)
                currentShape.Done();

            currentShape = null;
		}
	}
}
