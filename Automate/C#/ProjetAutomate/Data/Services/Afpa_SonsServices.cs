using ProjetAutomate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Data.Services
{
    public class Afpa_SonsServices
    {

        private readonly AutomateContext _context;

        public Afpa_SonsServices(AutomateContext context)
        {
            _context = context;
        }

        public void AddAfpa_Son(Afpa_Son obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Sons.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAfpa_Son(Afpa_Son obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Afpa_Sons.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Afpa_Son> GetAllAfpa_Sons()
        {
            return _context.Afpa_Sons.ToList();
        }

        public Afpa_Son GetAfpa_SonById(int id)
        {
            return _context.Afpa_Sons.FirstOrDefault(obj => obj.IdSon == id);
        }

        public void UpdateAfpa_Son(Afpa_Son obj)
        {
            _context.SaveChanges();
        }


    }
}
