using GestionAeroport.Data.Dtos;
using GestionAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport.Data.Services
{
    public class AvionServices
    {

        private readonly AeroportContext _context;

        public AvionServices(AeroportContext context)
        {
            _context = context;
        }

        public void AddAvion(AvionDTOIn obj)
        {
            if (obj == null)

            {
                throw new ArgumentNullException(nameof(obj));
            }
            var ent = new Avion
            {
                Compagnie = obj.Compagnie,
                Type = obj.Type
            };
            _context.Avions.Add(ent);
            _context.SaveChanges();
        }

        public void DeleteAvion(Avion obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Avions.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Avion> GetAllAvion()
        {
            return _context.Avions.ToList();
        }

        public Avion GetAvionById(int id)
        {
            return _context.Avions.FirstOrDefault(obj => obj.IdAvion == id);
        }

        public void UpdateAvion(Avion obj)
        {
            _context.SaveChanges();
        }


    }
}
