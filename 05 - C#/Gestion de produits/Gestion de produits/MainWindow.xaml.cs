using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gestion_de_produits
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string path = @"../../../MonFichier.txt";
            string[] tab = new string[10];
            string[] tabRecu = new string[10];
            RemplireTab();

            void RemplireTab()
            //remplit un tableau
            {
                for (int i = 0; i < 10; i++)
                {
                    tab[i] = i + " Produit " + " Alimentaire " + i+5;
                }
                File.WriteAllLines(path, tab);
            }
            // Ecris dans le fichier  

            tabRecu = File.ReadAllLines(path);



            // List<Produits> CreerListe()
            //{
            //    List<Produits> liste = new List<Produits>();

            //    for (int i = 0; i < tabRecu.length; i++)
            //    {
            //        Produits prod = new Produits(i, tabRecu[i][1], tabRecu[i][2], tabRecu[i][3]);
            //        liste.Add(prod);
            //    }
            //    return liste;
            //}
       }
    }
}
