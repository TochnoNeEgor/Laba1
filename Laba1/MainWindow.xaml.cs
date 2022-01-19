using System;
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

namespace Laba1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double x;
        private double y;
        public MainWindow()
        {
            InitializeComponent();
            button1.Visibility = Visibility.Hidden;
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (checkBox2.IsChecked == true)
            {



                x = Convert.ToDouble(textBox.Text);
                y = Convert.ToDouble(textBox1.Text);
                Point point = new Point(x, y);
                Ellipse elipse = new Ellipse();
                elipse.Width = 4;
                elipse.Height = 4;
                elipse.StrokeThickness = 2;
                elipse.Stroke = Brushes.Black;
                elipse.Margin = new Thickness(x, y, 0, 0);
                canvas.Children.Add(elipse);

                button.Visibility = Visibility.Hidden;
                button1.Visibility = Visibility.Visible;
            }
            else
            {
                if (checkBox.IsChecked == true)
                {

                }
            }
        }

            private void button1_Click(object sender, RoutedEventArgs e)
            {
                
                if (checkBox2.IsChecked == true)

                {
                    double z, q;
                    z = Convert.ToDouble(textBox.Text);
                    q = Convert.ToDouble(textBox1.Text);
                    Point point = new Point(z, q);
                    Ellipse elipse = new Ellipse();
                    elipse.Width = 4;
                    elipse.Height = 4;
                    elipse.StrokeThickness = 2;
                    elipse.Stroke = Brushes.Black;
                    elipse.Margin = new Thickness(z, q, 0, 0);

                    canvas.Children.Add(elipse);
                    float af = (float)(x - z);
                    float af2 = (float)(y - q);
                    float af3 = MathF.Pow(af, 2);
                    float af4 = MathF.Pow(af2, 2);
                    double d = (Math.Sqrt(af3 + af4));
                    textBox2.Text = Convert.ToString(d);
                    button1.Visibility = Visibility.Hidden;
                    button.Visibility = Visibility.Visible;
                    canvas.Children.Clear();
                }

            }

        

        
    }
}
