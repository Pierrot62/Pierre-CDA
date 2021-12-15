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
        public MainWindow Accueil { get; set; }
        public FormAdd(MainWindow fenetre)
        {
            InitializeComponent();
            this.Accueil = fenetre;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnCTION_Click(object sender, RoutedEventArgs e)
        {
            Accueil.AjouterProduits(LibelleProduit.Text, int.Parse(Quantite.Text), double.Parse(Prix.Text), int.Parse(NbVente.Text));
            this.Close();
        }
    }
}
