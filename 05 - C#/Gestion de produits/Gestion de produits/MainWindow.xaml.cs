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
            liste = CreerListe();
            RemplirGrid();
            //CreerFichier();
            liste = TransformeJson();

        }
        public void RemplirGrid()
        {
            DgProduits.ItemsSource = liste;
        }

        private List<Produits> CreerListe()
        {
            List<Produits> liste = new List<Produits>();

            for (int i = 1; i < 15; i++)
            {
                Produits p = new Produits(1, "Produit" + i, i * 2, Math.Round(i * 45.8, 2), i * 478);
                liste.Add(p);
            }

            liste.Dump();
            return liste;
        }

        //private void CreerFichier()
        //{
        //    File.WriteAllText(path, JsonConvert.SerializeObject(liste, Formatting.Indented));
        //}

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

        private List<Produits> TransformeJson()
        {
            string chaine = LireFichier();
            List<Produits> liste = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return liste;
        }

        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.7;
            FormAdd add = new FormAdd();
            add.ShowDialog();
            this.Opacity = 1;
        }

        public static void AjouterProduits(string LibelleProduit, int Quantite, double Prix, int NbVente)
        {
            Produits prod = new Produits(1, LibelleProduit, Quantite,Prix, NbVente);
            Console.WriteLine(prod.LibelleProduit);
            //return List<Produits>
        }



    }
}
