using System.Windows;

namespace Lab23_2
{
    /// <summary>
    /// Логика взаимодействия для InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        public InputDialog()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int number1, number2, number3;
            if (!int.TryParse(Number1TextBox.Text, out number1) ||
                !int.TryParse(Number2TextBox.Text, out number2) ||
                !int.TryParse(Number3TextBox.Text, out number3))
            {
                MessageBox.Show("Неверный Ввод. Пожалуйста, введите действительные числа.");
                return;
            }

            int result = 0;
            if (SummCheckBox.IsChecked == true)
            {
                result += number1 + number2 + number3;
            }

            if (LeastMultipleCheckBox.IsChecked == true)
            {
                result += LeastCommonMultiple(number1, number2);
            }

            CalcDialog calcDialog = new CalcDialog(result);
            calcDialog.Owner = this;
            calcDialog.ShowDialog();
        }

        private int LeastCommonMultiple(int a, int b) // НОК
        {
            int gcd = GreatestCommonDivisor(a, b);
            return (a / gcd) * b;
        }

        private int GreatestCommonDivisor(int a, int b) // НОД
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}