using System;
using System.Windows;

namespace Lab25
{
    public partial class Task1Window
    {
        public Task1Window()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var x0 = double.Parse(this.x0TextBox.Text);
            var xk = double.Parse(this.xkTextBox.Text);
            var dx = double.Parse(this.dxTextBox.Text);
            var x = double.Parse(this.xTextBox.Text);
            var d = double.Parse(this.dTextBox.Text);
            for (var i = x0; i < xk; i += dx)
            {
                var y = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - d);
                this.resultTextBox.Text += $"x={i.ToString()}; y={y.ToString()}\n";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.x0TextBox.Text = "4,6";
            this.xkTextBox.Text = "5,8";
            this.dxTextBox.Text = "0,2";
            this.xTextBox.Text = "2";
            this.dTextBox.Text = "1,3";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
