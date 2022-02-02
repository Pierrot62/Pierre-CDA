using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_TemperaturesServices
    {

        private readonly AutomateContext _context;

        public Afpa_TemperaturesServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Temperature(Afpa_Temperature obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Temperatures.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Temperature(Afpa_Temperature obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Temperatures.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Temperature> GetAllAfpa_Temperatures()
        {
            return _context.Afpa_Temperatures.ToList();
        }

        public Afpa_Temperature GetAfpa_TemperatureById(int id)
        {
            return _context.Afpa_Temperatures.FirstOrDefault(obj => obj.IdTemperature == id);
        }

        public void UpdateAfpa_Temperature(Afpa_Temperature obj)
        {
            _context.SaveChanges();
        }


    }
}
