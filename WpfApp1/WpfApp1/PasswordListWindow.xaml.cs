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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PasswordListWindow.xaml
    /// </summary>
    public partial class PasswordListWindow : Window
    {
        public PasswordListWindow(List<string> passwords)
        {
            InitializeComponent();
            foreach (var password in passwords)
            {
                PasswordListBox.Items.Add(password);
            }
        }
    }
}
