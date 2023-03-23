using System.Windows;

namespace Lab23_2
{
    /// <summary>
    /// Логика взаимодействия для CalcDialog.xaml
    /// </summary>
    public partial class CalcDialog : Window
    {
        public CalcDialog()
        {
            InitializeComponent();
        }
        public int Result { get; set; }

        public CalcDialog(int result)
        {
            InitializeComponent();
            DataContext = this;
            Result = result;
        }
    }
}
