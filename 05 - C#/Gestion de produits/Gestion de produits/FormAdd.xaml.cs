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

namespace Gestion_de_produits
{
    /// <summary>
    /// Logique d'interaction pour FormAdd.xaml
    /// </summary>
    public partial class FormAdd : Window
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btnadd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.AjouterProduits(LibelleProduit.Text, int.Parse(Quantite.Text), double.Parse(Prix.Text), int.Parse(NbVente.Text));
        }

        //private void AjouterValeur()
        //{
        //    File.WriteAllText(path, JsonConvert.SerializeObject(liste, Formatting.Indented));
        //}
    }
}
