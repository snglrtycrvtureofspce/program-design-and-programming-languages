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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prac06
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            TextBox textBox = (TextBox)LogicalTreeHelper.FindLogicalNode(this, "textBox" + button.Name.Substring(6));
            Label label = (Label)LogicalTreeHelper.FindLogicalNode(this, "label" + button.Name.Substring(6));
            label.Content = textBox.Text;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.BlueViolet;
        }
    }
}
