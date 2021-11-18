using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Gestion_de_produits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produits> liste;
        string path = @"../../../JeSaisPas.json";

        public MainWindow()
        {
            InitializeComponent();
            liste = TransformeJson();
            RemplirGrid();

        }
        public void RemplirGrid()
        {
            DgProduits.ItemsSource = liste;
        }

        private void CreerFichier()
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(liste, Formatting.Indented));
        }

        private string LireFichier()
        // Renvoi un tableau de chaine contenant les informations stockées dans le fichier 
        {
            string chaine;
            try
            {
                // Lecture et stockage dans chaine
                chaine = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Indiquer le path :");
                path = Console.ReadLine();
                chaine = LireFichier();
            }
            return chaine;
        }

        public List<Produits> TransformeJson()
        {
            string chaine = LireFichier();
            List<Produits> liste = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return liste;
        }

        private void BtnAction_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.7;
            FormAdd add = new FormAdd(this, ((Button).sender).Content);
            add.ShowDialog();
            this.Opacity = 1;
        }

        public void AjouterProduits(string LibelleProduit, int Quantite, double Prix, int NbVente)
        {
            Produits p = new Produits(1, LibelleProduit, Quantite, Prix, NbVente);
            liste = TransformeJson();
            liste.Add(p);
            CreerFichier();
            RemplirGrid();
        }

        public static List<Produits> ModifierListe(Produits p, List<Produits> liste)
        {
            liste.Add(p);
            return liste;
        }

        private void BtnAction_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
