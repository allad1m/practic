﻿using System;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для NamesWindow.xaml
    /// </summary>
    public partial class NamesWindow : Window
    {
        public NamesWindow(HashSet<string> names)
        {
            InitializeComponent();
            foreach (var name in names)
            {
                lstNames.Items.Add(name);
            }
        }
    }
}
