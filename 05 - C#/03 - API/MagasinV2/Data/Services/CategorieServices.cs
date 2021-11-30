using Magasin.Data.Dtos;
using Magasin.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magasin.Data.Services
{
    public class CategorieServices
    {

        private readonly Context _context;

        public CategorieServices(Context context)
        {
            _context = context;
        }

        public void AddCategorie(CategorieDTOIn obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            var ent = new Categorie()
            {
                LibelleCategorie = obj.LibelleCategorie
        };
            _context.Add(ent);
            _context.SaveChanges();
        }

        public void DeleteCategorie(Categorie obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Categorie> GetAllCategorie()
        {
            return _context.Categories.ToList();
        }

        public Categorie GetCategorieById(int id)
        {
            return _context.Categories.FirstOrDefault(obj => obj.IdCategorie == id);
        }

        public void UpdateCategorie(Categorie obj)
        {
            _context.SaveChanges();
        }
    }
}