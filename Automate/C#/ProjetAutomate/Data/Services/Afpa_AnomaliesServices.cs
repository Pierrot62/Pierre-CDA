using Microsoft.EntityFrameworkCore;
using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_AnomaliesServices
    {

        private readonly AutomateContext _context;

        public Afpa_AnomaliesServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Anomalie(Afpa_Anomalie obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Anomalies.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Anomalie(Afpa_Anomalie obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Anomalies.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Anomalie> GetAllAfpa_Anomalies()
        {
            return _context.Afpa_Anomalies.Include("Erreur").ToList();
        }

        public Afpa_Anomalie GetAfpa_AnomalieById(int id)
        {
            return _context.Afpa_Anomalies.Include("Erreur").FirstOrDefault(obj => obj.IdAnomalie == id);
        }

        public void UpdateAfpa_Anomalie(Afpa_Anomalie obj)
        {
            _context.SaveChanges();
        }
    }
}
