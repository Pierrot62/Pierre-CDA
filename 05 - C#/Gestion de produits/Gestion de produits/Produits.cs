using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_produits
{
    class Produits
    {
        public int IdProduit { get;  set; }
        public string Libelle { get; set; }
        public string Categorie { get; set; }
        public string Rayon { get; set; }

        public Produits(int idProduit, string libelle, string categorie, string rayon)
        {
            IdProduit = idProduit;
            Libelle = libelle;
            Categorie = categorie;
            Rayon = rayon;
        }
    }
}
