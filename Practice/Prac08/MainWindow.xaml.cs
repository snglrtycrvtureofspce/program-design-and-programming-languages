using System.Windows;

namespace Prac08
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

        private void FirstTask_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FirstTask firstTask = new FirstTask();
            firstTask.Show();
        }

        private void SecondTask_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SecondTask secondTask = new SecondTask();
            secondTask.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
