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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ModulHouses.Desc;

namespace ModulHouses
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

        private void house1_Click(object sender, RoutedEventArgs e)
        {
            h1desc h1Desc = new h1desc();
            h1Desc.Show();
        }

        private void house2_Click(object sender, RoutedEventArgs e)
        {
            h2desc h2Desc = new h2desc();
            h2Desc.Show();
        }

        private void house3_Click(object sender, RoutedEventArgs e)
        {
            h3desc h3Desc = new h3desc();
            h3Desc.Show();
        }

        private void house4_Click(object sender, RoutedEventArgs e)
        {
            h4desc h4Desc = new h4desc();
            h4Desc.Show();
        }

        private void house5_Click(object sender, RoutedEventArgs e)
        {
            h5desc h5Desc = new h5desc();
            h5Desc.Show();
        }

        private void house6_Click(object sender, RoutedEventArgs e)
        {
            h6desc h6Desc = new h6desc();
            h6Desc.Show();
        }

        private void house7_Click(object sender, RoutedEventArgs e)
        {
            h7desc h7Desc = new h7desc();
            h7Desc.Show();
        }

        private void house8_Click(object sender, RoutedEventArgs e)
        {
            h8desc h8Desc = new h8desc();
            h8Desc.Show();
        }

        private void house9_Click(object sender, RoutedEventArgs e)
        {
            h9desc h9Desc = new h9desc();
            h9Desc.Show();
        }

        private void house10_Click(object sender, RoutedEventArgs e)
        {
            h10desc h10Desc = new h10desc();
            h10Desc.Show();
        }

        private void house11_Click(object sender, RoutedEventArgs e)
        {
            h11desc h11Desc = new h11desc();
            h11Desc.Show();
        }

        private void house12_Click(object sender, RoutedEventArgs e)
        {
            h12desc h12Desc = new h12desc();
            h12Desc.Show();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void house13_Click(object sender, RoutedEventArgs e)
        {
            h13desc h13Desc = new h13desc();
            h13Desc.Show();
        }
    }
}
