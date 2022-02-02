using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_ErreursServices
    {

        private readonly AutomateContext _context;

        public Afpa_ErreursServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Erreur(Afpa_Erreur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Erreurs.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Erreur(Afpa_Erreur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Erreurs.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Erreur> GetAllAfpa_Erreurs()
        {
            return _context.Afpa_Erreurs.ToList();
        }

        public Afpa_Erreur GetAfpa_ErreurById(int id)
        {
            return _context.Afpa_Erreurs.FirstOrDefault(obj => obj.IdErreur == id);
        }

        public void UpdateAfpa_Erreur(Afpa_Erreur obj)
        {
            _context.SaveChanges();
        }


    }
}
