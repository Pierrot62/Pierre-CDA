using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_SeuilsServices
    {

        private readonly AutomateContext _context;

        public Afpa_SeuilsServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Seuil(Afpa_Seuil obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Seuils.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Seuil(Afpa_Seuil obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Seuils.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Seuil> GetAllAfpa_Seuils()
        {
            return _context.Afpa_Seuils.ToList();
        }

        public Afpa_Seuil GetAfpa_SeuilById(int id)
        {
            return _context.Afpa_Seuils.FirstOrDefault(obj => obj.IdSeuil == id);
        }

        public void UpdateAfpa_Seuil(Afpa_Seuil obj)
        {
            _context.SaveChanges();
        }


    }
}
