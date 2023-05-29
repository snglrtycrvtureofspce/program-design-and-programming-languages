using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Articles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string articleFilePath = "article.txt"; // путь к файлу со статьей
        private readonly string articleImagePath = "articleImage.png"; // путь к файлу с изображением из статьи

        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            LoadArticle();
            LoadImage();
        }

        private void LoadArticle()
        {
            // загрузка текста статьи из файла
            string articleText = File.ReadAllText(articleFilePath);
            ArticleText.Text = articleText;
        }

        private void LoadImage()
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(articleImagePath, UriKind.RelativeOrAbsolute);
            image.EndInit();
            ArticleImage.Source = image;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string articleText = ArticleText.Text;
            File.WriteAllText("fileSave.txt", articleText);
            MessageBox.Show("Файл успешно сохранён!");
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument document = new FlowDocument(new Paragraph(new Run(ArticleText.Text)));
                printDialog.PrintDocument(((IDocumentPaginatorSource)document).DocumentPaginator, "Статья");
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchData = SearchTextBox.Text;
            string articleText = ArticleText.Text;
            if (string.IsNullOrEmpty(searchData) || string.IsNullOrEmpty(ArticleText.Text))
            {
                MessageBox.Show("Введите данные для поиска и загрузите статью");
                return;
            }

            int index = articleText.IndexOf(searchData, StringComparison.CurrentCultureIgnoreCase);
            if (index >= 0)
            {
                MessageBox.Show("Найдено");
                ArticleText.Inlines.Clear();

                while (index >= 0)
                {
                    // добавить Run с текстом до найденного слова
                    ArticleText.Inlines.Add(new Run(articleText.Substring(0, index)));

                    // добавить Run с найденным словом
                    Run highlightRun = new Run(articleText.Substring(index, searchData.Length))
                    {
                        Background = Brushes.Yellow,
                        Foreground = Brushes.Black
                    };
                    ArticleText.Inlines.Add(highlightRun);

                    // обновить оставшийся текст и продолжить поиск
                    articleText = articleText.Substring(index + searchData.Length);
                    index = articleText.IndexOf(searchData, StringComparison.CurrentCultureIgnoreCase);
                }

                // добавить оставшийся текст после последнего найденного слова
                if (!string.IsNullOrEmpty(articleText))
                {
                    ArticleText.Inlines.Add(new Run(articleText));
                }
            }
            else
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // закрытие текущего окна и переход на главное окно
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            // закрытие приложения
            Application.Current.Shutdown();
        }
    }
}
