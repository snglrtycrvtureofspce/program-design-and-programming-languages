using System.Windows;
using System.Windows.Media;

namespace Lab28
{
    public partial class FirstTask : Window
    {
        public FirstTask()
        {
            InitializeComponent();
        }

        private void ZoomSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double zoom = e.NewValue;
            ScaleTransform scaleTransform = new ScaleTransform(zoom, zoom);
            MainGrid.LayoutTransform = scaleTransform;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}