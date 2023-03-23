using System.Windows;

namespace Lab23_2
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
        private void Input_Click(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            inputDialog.Owner = this;
            inputDialog.ShowDialog();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            CalcDialog calcDialog = new CalcDialog();
            calcDialog.Owner = this;
            calcDialog.ShowDialog();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Привет! Меня зовут Саша, мне 18 лет.");
        }
    }
}
