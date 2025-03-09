using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> validationResults = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            string series = txtSeries.Text.Trim();
            string numberText = txtNumber.Text.Trim();

            if (IsValidPassport(series, numberText))
            {
                lstResults.Items.Add($"Паспорт {series} {numberText} - корректен");
            }
            else
            {
                lstResults.Items.Add(new ListBoxItem
                {
                    Content = $"Паспорт {series} {numberText} - некорректен",
                    Foreground = Brushes.Red
                });
            }

            // Очищаем текстовые поля после проверки
            txtSeries.Clear();
            txtNumber.Clear();
        }

        private bool IsValidPassport(string series, string number)
        {
            // Проверка серии
            if (series.Length != 5 || !int.TryParse(series.Substring(0, 2), out int seriesStart) ||
                !int.TryParse(series.Substring(3), out int seriesEnd) ||
                seriesStart < 69 || seriesStart > 69 || seriesEnd < 1 || seriesEnd > 4)
            {
                return false;
            }

            // Проверка номера
            if (!int.TryParse(number, out int passportNumber) || passportNumber < 100000 || passportNumber > 800000)
            {
                return false;
            }

            return true;
        }

        private void btnShowResults_Click(object sender, RoutedEventArgs e)
        {
            ResultsWindow resultsWindow = new ResultsWindow(validationResults);

            resultsWindow.Show();
        }
    }
}