using Magasin.Data.Dtos;
using Magasin.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Services
{
    public class ProduitServices
    {

        private readonly Context _context;

        public ProduitServices(Context context)
        {
            _context = context;
        }

        public void AddProduit(ProduitDTOIn obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            var ent = new Produit()
            {
                LibelleProduit = obj.LibelleProduit,
                PrixProduit = obj.PrixProduit,
                QuantiteProduit = obj.QuantiteProduit,
                IdCategorie = obj.IdCategorie
            };
            _context.Produits.Add(ent);
            _context.SaveChanges();
        }

        public void DeleteProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAllProduit()
        {
            var liste = (from e1 in _context.Produits
                         join e2 in _context.Categories
                         on e1.IdCategorie equals e2.IdCategorie
                         select new Produit
                         {
                             IdProduit = e1.IdProduit,
                             LibelleProduit = e1.LibelleProduit,
                             PrixProduit = e1.PrixProduit,
                             QuantiteProduit = e1.QuantiteProduit,
                             IdCategorie = e2.IdCategorie,
                             CatProduit = e2
                         }).ToList();
            return liste;

            //return _context.Produits.ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _context.Produits.FirstOrDefault(obj => obj.IdProduit == id);
        }

        public void UpdateProduit(Produit obj)
        {
            _context.SaveChanges();
        }


    }
}
