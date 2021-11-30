using GestionCommandes.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionCommandes.Data.Services
{
    public class PreparationServices
    {

        private readonly GestionCommandeContext _context;

        public PreparationServices(GestionCommandeContext context)
        {
            _context = context;
        }

        public void AddPreparation(Preparation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Preparations.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePreparation(Preparation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Preparations.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Preparation> GetAllPreparation()
        {
            return _context.Preparations.Include("Produits").ToList();
        }

        public Preparation GetPreparationById(int id)
        {
            return _context.Preparations.FirstOrDefault(obj => obj.IdPreparation == id);
        }

        public void UpdatePreparation(Preparation obj)
        {
            _context.SaveChanges();
        }


    }
}
