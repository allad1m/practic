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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> generatedPasswords = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            PasswordLengthTextBox.TextChanged += PasswordLengthTextBox_TextChanged;
        }

        private void PasswordLengthTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (int.TryParse(PasswordLengthTextBox.Text, out int length) && length >= 4 && length <= 50)
            {
                int latinCount = string.IsNullOrEmpty(LatinCharsTextBox.Text) ? 0 : int.Parse(LatinCharsTextBox.Text);
                int digitCount = string.IsNullOrEmpty(DigitsTextBox.Text) ? 0 : int.Parse(DigitsTextBox.Text);
                int specialCount = length - latinCount - digitCount;

                SpecialCharsTextBox.Text = specialCount >= 0 ? specialCount.ToString() : "0";
            }
            else
            {
                SpecialCharsTextBox.Text = "0";
            }
        }

        private void GeneratePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(PasswordLengthTextBox.Text, out int totalLength) &&
                int.TryParse(LatinCharsTextBox.Text, out int latinCount) &&
                int.TryParse(DigitsTextBox.Text, out int digitCount))
            {
                int specialCount = totalLength - latinCount - digitCount;

                if (specialCount >= 0)
                {
                    string password = GeneratePassword(latinCount, digitCount, specialCount);
                    generatedPasswords.Add(password);
                    MessageBox.Show($"Сгенерированный пароль: {password}");
                }
                else
                {
                    MessageBox.Show("Количество символов не может быть отрицательным.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения.");
            }
        }
        private string GeneratePassword(int latinCount, int digitCount, int specialCount)
        {
            var random = new Random();
            var passwordChars = new StringBuilder();

            const string latinChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digits = "0123456789";
            const string specialChars = "@#+-()";

            for (int i = 0; i < latinCount; i++)
                passwordChars.Append(latinChars[random.Next(latinChars.Length)]);

            for (int i = 0; i < digitCount; i++)
                passwordChars.Append(digits[random.Next(digits.Length)]);

            for (int i = 0; i < specialCount; i++)
                passwordChars.Append(specialChars[random.Next(specialChars.Length)]);

            return new string(passwordChars.ToString().OrderBy(c => random.Next()).ToArray());
        }

        private void ShowSavedPasswordsButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordListWindow passwordListWindow = new PasswordListWindow(generatedPasswords);
            passwordListWindow.ShowDialog();
        }
    }
}
