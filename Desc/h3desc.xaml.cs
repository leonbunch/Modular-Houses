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

namespace ModulHouses.Desc
{
    /// <summary>
    /// Interaction logic for h3desc.xaml
    /// </summary>
    public partial class h3desc : Window
    {
        public h3desc()
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
