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

namespace ModulHouses.Desc
{
    /// <summary>
    /// Interaction logic for h7desc.xaml
    /// </summary>
    public partial class h7desc : Window
    {
        public h7desc()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация отправлена");
            Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}