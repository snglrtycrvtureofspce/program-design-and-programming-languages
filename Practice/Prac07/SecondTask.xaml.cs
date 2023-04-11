using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prac07
{
    /// <summary>
    /// Логика взаимодействия для SecondTask.xaml
    /// </summary>
    public partial class SecondTask : Window
    {
        public SecondTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = { 0, 1, 2, 3, -5, 6, -7, 8, 9, 10, -11, 12, -13, 14 };
            var sum = 0;
            int i;
            for (i = 0; i < arr.Length && arr[i] >= 0; i++)
            {
                sum += arr[i];
            }
            this.TextBoxResult.Clear();
            this.TextBoxResult.Text += $"Сумма элементов до первого отрицательного: {sum}" +
                                       $"{Environment.NewLine}";
            this.TextBoxResult.Text += $"Исходный массив: {Environment.NewLine}";
            for (i = 0; i < arr.Length; i++)
            {
                this.TextBoxResult.Text += arr[i] + " ";
            }
        }
    }
}
