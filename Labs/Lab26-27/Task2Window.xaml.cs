using System.Windows;

namespace Lab26_27
{
    /// <summary>
    /// Логика взаимодействия для Task2Window.xaml
    /// </summary>
    public partial class Task2Window : Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxOne.Text == "" && TextBoxTwo.Text == "")
            {
                this.Close();
            }
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e)
        {
            TextBoxOne.Clear();
            TextBoxTwo.Clear();
        }
    }
}
