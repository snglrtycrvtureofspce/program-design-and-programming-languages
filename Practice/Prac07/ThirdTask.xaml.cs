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
    /// Логика взаимодействия для ThirdTask.xaml
    /// </summary>
    public partial class ThirdTask : Window
    {
        public ThirdTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[,] A = new int[12, 12];
            var sum = 0;
            this.TextBoxResult.Clear();
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    A[i, j] = rand.Next(1, 51);
                    this.TextBoxResult.Text += $"{A[i, j]}" + $" ";
                }
                this.TextBoxResult.Text += $"{Environment.NewLine}";
            }
            
            for (int i = 0; i < 12; i++)
            {
                for (int j = i + 1; j < 12; j++)
                {
                    sum += A[i, j];
                }
            }
            
            this.TextBoxResult.Text += $"Сумма элементов над главной диагональю: {sum}";
        }
    }
}
