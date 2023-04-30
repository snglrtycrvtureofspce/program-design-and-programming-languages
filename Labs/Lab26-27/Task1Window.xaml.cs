using System.Windows;

namespace Lab26_27
{
    /// <summary>
    /// Логика взаимодействия для Task1Window.xaml
    /// </summary>
    public partial class Task1Window : Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void textBoxOne_GotFocus(object sender, RoutedEventArgs e)
        {
            ((FrameworkElement)sender).Style = (Style)Resources["ActiveTextBoxStyle"];
        }

        private void textBoxOne_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["InactiveTextBoxStyle"];
        }
    }
}
