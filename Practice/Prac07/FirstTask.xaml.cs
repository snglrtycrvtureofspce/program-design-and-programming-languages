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
    /// Логика взаимодействия для FirstTask.xaml
    /// </summary>
    public partial class FirstTask : Window
    {
        public FirstTask()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var xk = 0.15;
            var dx = 0.05;
            var b = 6.74;
            for (var x0 = -0.05; x0 < xk; x0 += dx)
            {
                var y = 0.8 * Math.Pow(10, -5) * Math.Pow((Math.Pow(x0, 3) + Math.Pow(b, 3)), 7.0 / 6.0);
                this.TextBoxResult.Text += $"x0 = {x0} | y = {y} {Environment.NewLine}";
            }
        }
    }
}