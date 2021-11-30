using GestionAeroport.Data.Dtos;
using GestionAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAeroport.Data.Services
{
    public class PiloteServices
    {

        private readonly AeroportContext _context;

        public PiloteServices(AeroportContext context)
        {
            _context = context;
        }

        public void AddPilote(PiloteDTOIn obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Pilotes.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePilote(Pilote obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Pilotes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Pilote> GetAllPilote()
        {
            return _context.Pilotes.ToList();
        }

        public Pilote GetPiloteById(int id)
        {
            return _context.Pilotes.FirstOrDefault(obj => obj.IdPilote == id);
        }

        public void UpdatePilote(Pilote obj)
        {
            _context.SaveChanges();
        }


    }
}
