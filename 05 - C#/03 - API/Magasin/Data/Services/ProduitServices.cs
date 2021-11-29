using Magasin.Data.Models;
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

        public void AddProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produit.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteProduit(Produit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Produit.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAllProduit()
        {
            return _context.Produit.ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _context.Produit.FirstOrDefault(obj => obj.IdProduit == id);
        }

        public void UpdateProduit(Produit obj)
        {
            _context.SaveChanges();
        }


    }
}
