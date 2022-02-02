using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_CouleursServices
    {

        private readonly AutomateContext _context;

        public Afpa_CouleursServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Couleur(Afpa_Couleur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Couleurs.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Couleur(Afpa_Couleur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Couleurs.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Couleur> GetAllAfpa_Couleurs()
        {
            return _context.Afpa_Couleurs.ToList();
        }

        public Afpa_Couleur GetAfpa_CouleurById(int id)
        {
            return _context.Afpa_Couleurs.FirstOrDefault(obj => obj.IdCouleur == id);
        }

        public void UpdateAfpa_Couleur(Afpa_Couleur obj)
        {
            _context.SaveChanges();
        }


    }
}
