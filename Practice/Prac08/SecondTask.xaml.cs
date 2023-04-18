using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Prac08
{
    /// <summary>
    /// Логика взаимодействия для SecondTask.xaml
    /// </summary>
    public partial class SecondTask : Window
    {
        public SecondTask()
        {
            InitializeComponent();
            PulsarRectangleAnimation();
        }

        private void PulsarRectangleAnimation()
        {
            RadialGradientBrush brush = new RadialGradientBrush();
            brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.0));
            brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.5));
            GradientStop gradientStop = new GradientStop(Colors.Red, 1.0);
            brush.GradientStops.Add(gradientStop);
            Rectangle.Fill = brush;

            ColorAnimation animation = new ColorAnimation
            {
                From = Colors.Yellow,
                To = Colors.Red,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            gradientStop.BeginAnimation(GradientStop.ColorProperty, animation);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
