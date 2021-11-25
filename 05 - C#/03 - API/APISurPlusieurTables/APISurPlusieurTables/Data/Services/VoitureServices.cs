using APISurPlusieurTables.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Services
{
    public class VoitureServices
    {
        private readonly MyDbContext _context;
        public VoitureServices(MyDbContext context)
        {
            _context = context;
        }

        //Add
        public void AddVoiture(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }
            _context.Voiture.Add(v);
            _context.SaveChanges();
        }

        //Delete
        public void DeleteVoiture(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }
            _context.Voiture.Remove(v);
            _context.SaveChanges();
        }

        //FindAll
        public IEnumerable<Voiture> GetAllVoitures()
        {
            return _context.Voiture.ToList();
        }

        //FIndById
        public Voiture GetVoitureById(int id)
        {
            return _context.Voiture.FirstOrDefault(v => v.IdVoiture == id);
        }

        //public Voiture GetEmployeByVoiture(int id)
        //{
        //    return _context.Employer.FirstOrDefault(e => e.IdVoiture == id);
        //}

        //Update
        public void UpdateVoiture(Voiture e)
        {
            _context.SaveChanges();
        }
    }
}
