using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_CadencesServices
    {

        private readonly AutomateContext _context;

        public Afpa_CadencesServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Cadence(Afpa_Cadence obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Cadences.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Cadence(Afpa_Cadence obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Cadences.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Cadence> GetAllAfpa_Cadences()
        {
            return _context.Afpa_Cadences.ToList();
        }

        public Afpa_Cadence GetAfpa_CadenceById(int id)
        {
            return _context.Afpa_Cadences.FirstOrDefault(obj => obj.IdCadence == id);
        }

        public void UpdateAfpa_Cadence(Afpa_Cadence obj)
        {
            _context.SaveChanges();
        }


    }
}
