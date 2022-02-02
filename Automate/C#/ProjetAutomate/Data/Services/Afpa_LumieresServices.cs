using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_LumieresServices
    {

        private readonly AutomateContext _context;

        public Afpa_LumieresServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Lumiere(Afpa_Lumiere obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Lumieres.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Lumiere(Afpa_Lumiere obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Lumieres.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Lumiere> GetAllAfpa_Lumieres()
        {
            return _context.Afpa_Lumieres.ToList();
        }

        public Afpa_Lumiere GetAfpa_LumiereById(int id)
        {
            return _context.Afpa_Lumieres.FirstOrDefault(obj => obj.IdLumiere == id);
        }

        public void UpdateAfpa_Lumiere(Afpa_Lumiere obj)
        {
            _context.SaveChanges();
        }



    }
}
