<<<<<<< HEAD
﻿using Magasin.Data.Dtos;
using Magasin.Data.Models;
using Microsoft.EntityFrameworkCore;
=======
﻿using Magasin.Data.Models;
>>>>>>> f650741cef75b3a7f2e4e30f943c8d2d8d7f3d02
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

<<<<<<< HEAD
        public void AddProduit(ProduitDTOIn obj)
=======
        public void AddProduit(Produit obj)
>>>>>>> f650741cef75b3a7f2e4e30f943c8d2d8d7f3d02
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
<<<<<<< HEAD
            var ent = new Produit()
            {
                LibelleProduit = obj.LibelleProduit,
                PrixProduit = obj.PrixProduit,
                QuantiteProduit = obj.QuantiteProduit,
                IdCategorie = obj.IdCategorie
            };
            _context.Produits.Add(ent);
=======
            _context.Produit.Add(obj);
>>>>>>> f650741cef75b3a7f2e4e30f943c8d2d8d7f3d02
            _context.SaveChanges();
        }

        public void DeleteProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
<<<<<<< HEAD
            _context.Produits.Remove(obj);
=======
            _context.Produit.Remove(obj);
>>>>>>> f650741cef75b3a7f2e4e30f943c8d2d8d7f3d02
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAllProduit()
        {
<<<<<<< HEAD
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
=======
            return _context.Produit.ToList();
>>>>>>> f650741cef75b3a7f2e4e30f943c8d2d8d7f3d02
        }

        public Produit GetProduitById(int id)
        {
<<<<<<< HEAD
            return _context.Produits.FirstOrDefault(obj => obj.IdProduit == id);
=======
            return _context.Produit.FirstOrDefault(obj => obj.IdProduit == id);
>>>>>>> f650741cef75b3a7f2e4e30f943c8d2d8d7f3d02
        }

        public void UpdateProduit(Produit obj)
        {
            _context.SaveChanges();
        }


    }
}
