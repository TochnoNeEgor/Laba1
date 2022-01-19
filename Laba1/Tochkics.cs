using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Laba1
{
    internal class Tochkics
    { static void Toch(double[] args)
        {    double x;
             double y;

            System.Drawing.Point point = new System.Drawing.Point(x, y);
            Ellipse elipse = new Ellipse();
            elipse.Width = 4;
            elipse.Height = 4;
            elipse.StrokeThickness = 2;
            elipse.Stroke = Brushes.Black;
            elipse.Margin = new Thickness(x, y, 0, 0);
            canvas.Children.Add(elipse);
        }
    }
}
