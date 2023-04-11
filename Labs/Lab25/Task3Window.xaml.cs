using System;
using System.Collections.Generic;
using System.Windows;

namespace Lab25
{
    public partial class Task3Window
    {
        private int[,] _matrix;

        public Task3Window()
        {
            InitializeComponent();
            ResetMatrix();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (_matrix == null)
            {
                return;
            }
            
            int maxElement = _matrix[0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_matrix[i, j] > maxElement)
                    {
                        maxElement = _matrix[i, j];
                    }
                }
            }
            
            string matrixText = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixText += _matrix[i, j] + "\t";
                }

                matrixText += "\n";
            }

            MessageBox.Show(matrixText + "\nНаибольший элемент: " + maxElement);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetMatrix();
        }

        private void ResetMatrix()
        {
            _matrix = new int[4, 3];

            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _matrix[i, j] = random.Next(-50, 50);
                }
            }

            List<int[]> rows = new List<int[]>();
            for (int i = 0; i < 4; i++)
            {
                int[] row = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    row[j] = _matrix[i, j];
                }

                rows.Add(row);
            }

            matrixGrid.ItemsSource = rows;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}