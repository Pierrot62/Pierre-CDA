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

namespace WpfTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnNumerique_Click(object sender, RoutedEventArgs e)
        {
            Tbx_affichage.Text += ((Button)sender).Content;
        }

        //Remise a 0 de l'affichage
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Tbx_affichage.Text = "";
        }
    }
}
