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

namespace WpfApp3
{
   
    public partial class MainWindow : Window
    {
        private HashSet<string> names = new HashSet<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Пожалуйста, введите имя и фамилию.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string fullName = $"{firstName} {lastName}";

            if (names.Contains(fullName))
            {
                lstWarnings.Items.Add($"Имя '{fullName}' уже добавлено.");
            }
            else
            {
                names.Add(fullName);
                lstWarnings.Items.Add($"Имя '{fullName}' успешно добавлено.");
                txtFirstName.Clear();
                txtLastName.Clear();
            }
        }

        private void btnShowNames_Click(object sender, RoutedEventArgs e)
        {
            NamesWindow namesWindow = new NamesWindow(names);
            namesWindow.Show();
        }
    }
}