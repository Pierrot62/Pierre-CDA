using GestionGroupeDeMusique.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionGroupeDeMusique.Data.Services
{
    class MusiciensServices
    {
        private readonly EcfContext _context;

        public MusiciensServices(EcfContext context)
        {
            _context = context;
        }

        public void AddMusicien(Musicien obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Musiciens.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteMusicien(Musicien obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Musiciens.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Musicien> GetAllMusiciens()
        {
            return _context.Musiciens.ToList();
        }

        public IEnumerable<Musicien> GetAllMusiciensAvecGroupe()
        {
            return _context.Musiciens.Include("Groupe").ToList();
        }

        public Musicien GetMusicienById(int id)
        {
            return _context.Musiciens.FirstOrDefault(obj => obj.IdMusicien == id);
        }

        public void UpdateMusicien(Musicien obj)
        {
            _context.SaveChanges();
        }


    }
}
