using System.Windows;
using System.Windows.Media;

namespace Lab23_1
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
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.DarkViolet;
            textBox.Text = "+++++";
        }
        private void fillButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "******";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }
    }
}
