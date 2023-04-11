using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Lab25
{
    public partial class Task2Window
    {
        public Task2Window()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = InputTextBox.Text;
                List<double> xList = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => double.Parse(s)).ToList();

                List<double> yList = new List<double>();
                foreach (double x in xList)
                {
                    var y = 6.85 * Math.Pow(x, 2) - 1.5 * x;
                    if (y < 0)
                    {
                        var a = Math.Pow(x, 3) - 0.62;
                        yList.Add(a);
                    }
                    else
                    {
                        var b = 1 / Math.Pow(x, 2);
                        yList.Add(b);
                    }
                }

                ResultListBox.ItemsSource = yList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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