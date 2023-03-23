using System;
using System.Windows;

namespace Lab24
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
            try
            {
                string input = textBox.Text;
                int latinCount = 0;
                int russianCount = 0;

                foreach (char c in input)
                {
                    if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    {
                        latinCount++;
                    }
                    else if ((c >= 'а' && c <= 'я') || (c >= 'А' && c <= 'Я'))
                    {
                        russianCount++;
                    }
                }

                resultTextBlock.Text = $"Количество латинских букв: {latinCount}\n" +
                                       $"Количество русских букв: {russianCount}";
            }
            catch (Exception ex)
            {
                resultTextBlock.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
