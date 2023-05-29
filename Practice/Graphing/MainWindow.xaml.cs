using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
            DrawGraph();
        }

        private void DrawGraph()
        {
            Canvas canvas = new Canvas
            {
                Width = 500,
                Height = 500
            };
            double minX = -1;
            double maxX = 1;
            double minY = -1;
            double maxY = 1;
            double stepSize = 0.1;
            DrawAxes(canvas, minX, maxX, minY, maxY);
            DrawGraphPoints(canvas, minX, maxX, minY, maxY, stepSize);
            DrawGraphPointsRight(canvas, minX, maxX, minY, maxY, stepSize);
            AddFormulaText(canvas);
            Content = canvas;
        }

        private static void DrawAxes(Canvas canvas, double minX, double maxX, double minY, double maxY)
        {
            double canvasWidth = canvas.Width;
            double canvasHeight = canvas.Height;

            Line xAxis = new Line
            {
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                X1 = 0,
                Y1 = MapYCoordinate(canvasHeight, minY, maxY, 0),
                X2 = canvasWidth,
                Y2 = MapYCoordinate(canvasHeight, minY, maxY, 0)
            };
            canvas.Children.Add(xAxis);

            Line yAxis = new Line
            {
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                X1 = MapXCoordinate(canvasWidth, minX, maxX, 0),
                Y1 = 0,
                X2 = MapXCoordinate(canvasWidth, minX, maxX, 0),
                Y2 = canvasHeight
            };
            canvas.Children.Add(yAxis);

            for (double x = minX; x <= maxX; x += Math.Abs(0.1))
            {
                double canvasX = MapXCoordinate(canvasWidth, minX, maxX, x);
                double canvasY = MapYCoordinate(canvasHeight, minY, maxY, 0);

                Line tick = new Line
                {
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    X1 = canvasX,
                    Y1 = canvasY - 5,
                    X2 = canvasX,
                    Y2 = canvasY + 5
                };
                canvas.Children.Add(tick);

                TextBlock label = new TextBlock
                {
                    Text = x.ToString()
                };
                Canvas.SetLeft(label, canvasX - 0.1);
                Canvas.SetTop(label, canvasY + 0.1);
                canvas.Children.Add(label);
            }

            for (double y = minY; y <= maxY; y += Math.Abs(0.1))
            {
                double canvasX = MapXCoordinate(canvasWidth, minX, maxX, 0);
                double canvasY = MapYCoordinate(canvasHeight, minY, maxY, y);
                var tick = new Line
                {
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    X1 = canvasX - 5,
                    Y1 = canvasY,
                    X2 = canvasX + 5,
                    Y2 = canvasY
                };
                canvas.Children.Add(tick);
                TextBlock label = new TextBlock
                {
                    Text = y.ToString()
                };
                Canvas.SetLeft(label, canvasX + 0.1);
                Canvas.SetTop(label, canvasY - 0.1);
                canvas.Children.Add(label);
            }
        }

        private static void DrawGraphPoints(Canvas canvas, double minX, double maxX, double minY, double maxY, double stepSize)
        {
            for (double x = minX; x <= maxX; x += stepSize)
            {
                double y = Math.Abs(x) / x;
                double canvasX = MapXCoordinate(canvas.Width, minX, maxX, x);
                double canvasY = MapYCoordinate(canvas.Height, minY, maxY, y);
                Ellipse point = new Ellipse
                {
                    Fill = Brushes.Red,
                    Width = 3,
                    Height = 3
                };
                Canvas.SetLeft(point, canvasX - point.Width / 2);
                Canvas.SetTop(point, canvasY - point.Height / 2);
                canvas.Children.Add(point);
            }
        }
        private static void DrawGraphPointsRight(Canvas canvas, double minX, double maxX, double minY, double maxY, double stepSize)
        {
            double canvasWidth = canvas.Width;
            double canvasHeight = canvas.Height;
            double offsetX = canvasWidth / 5;
            for (double x = minX; x <= maxX; x += stepSize)
            {
                double y = Math.Abs(x) / x;
                double canvasX = MapXCoordinate(canvasWidth, minX, maxX, x) + offsetX;
                double canvasY = MapYCoordinate(canvasHeight, minY, maxY, y);
                Ellipse point = new Ellipse
                {
                    Fill = Brushes.Green,
                    Width = 3,
                    Height = 3
                };
                Canvas.SetLeft(point, canvasX - point.Width / 2);
                Canvas.SetTop(point, canvasY - point.Height / 2);
                canvas.Children.Add(point);
            }
        }
        private static void AddFormulaText(Canvas canvas)
        {
            TextBlock formulaText = new TextBlock
            {
                Text = "Функция: y = |x| / x",
                FontSize = 16
            };
            Canvas.SetLeft(formulaText, 10);
            Canvas.SetTop(formulaText, 10);
            canvas.Children.Add(formulaText);
        }
        private static double MapXCoordinate(double canvasWidth, double minX, double maxX, double x)
        {
            return (x - minX) * canvasWidth / (maxX - minX);
        }
        private static double MapYCoordinate(double canvasHeight, double minY, double maxY, double y)
        {
            return canvasHeight - (y - minY) * canvasHeight / (maxY - minY);
        }
    }
}
