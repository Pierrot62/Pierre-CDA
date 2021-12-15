namespace GestionProduits
{
    public class Produits
    {
        public int IdProduit { get; set; }
        public string LibelleProduit { get; set; }
        public int Quantite { get; set; }
        public double Prix { get; set; }
        public int NbVente { get; set; }

        public Produits(int idProduit, string libelleProduit, int quantite, double prix, int nbVente)
        {
            IdProduit = idProduit;
            LibelleProduit = libelleProduit;
            Quantite = quantite;
            Prix = prix;
            NbVente = nbVente;
        }
    }
}