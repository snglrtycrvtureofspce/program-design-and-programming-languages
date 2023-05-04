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

namespace Graphing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlotButton_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();

            string formula = formulaTextBox.Text;

            double minX = -5;
            double maxX = 5;

            double xStep = 0.1;
            for (double x = minX; x <= maxX; x += xStep)
            {
                double y = CalculateYValue(formula, x);

                // plot the point
                double pointSize = 2;
                Ellipse point = new Ellipse
                {
                    Width = pointSize,
                    Height = pointSize,
                    Fill = Brushes.Black
                };
                Canvas.SetLeft(point, x * 50 + 250);
                Canvas.SetBottom(point, y * 50 + 175);
                canvas.Children.Add(point);
            }

            Polyline polyline = new Polyline
            {
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            for (double x = minX; x <= maxX; x += xStep)
            {
                double y = CalculateYValue(formula, x);
                polyline.Points.Add(new Point(x * 50 + 250, y * 50 + 175));
            }
            canvas.Children.Add(polyline);

            formulaTextBlock.Text = "f(x) = " + formula;
        }

        private double CalculateYValue(string formula, double x)
        {
            return Math.Sin(x);
        }
    }
}
