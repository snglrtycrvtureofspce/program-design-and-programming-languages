using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Prac08
{
    /// <summary>
    /// Логика взаимодействия для FirstTask.xaml
    /// </summary>
    public partial class FirstTask : Window
    {
        public FirstTask()
        {
            InitializeComponent();
            
            GradientStopCollection gradientStops = new GradientStopCollection
            {
                new GradientStop(Colors.LightPink, 0.0),
                new GradientStop(Colors.White, 1.0)
            };
            textBox1.Background = new LinearGradientBrush(gradientStops, new Point(0, 0), new Point(0, 1));
            textBox2.Background = new LinearGradientBrush(gradientStops, new Point(0, 0), new Point(0, 1));
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                this.Close();
            }
        }
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontFamily = ((ComboBoxItem)comboBox1.SelectedItem).Content.ToString();
            textBox1.FontFamily = new FontFamily(fontFamily);
            textBox2.FontFamily = new FontFamily(fontFamily);

            if (fontFamily == "Arial")
            {
                textBox1.Foreground = Brushes.Blue;
                textBox2.Foreground = Brushes.Blue;
            }
            else if (fontFamily == "Times New Roman")
            {
                textBox1.Foreground = Brushes.Green;
                textBox2.Foreground = Brushes.Green;
            }
            else if (fontFamily == "Calibri")
            {
                textBox1.Foreground = Brushes.Red;
                textBox2.Foreground = Brushes.Red;
            }
        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                closeButton.IsEnabled = true;
            }
            else
            {
                closeButton.IsEnabled = false;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
