
using DemoEF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEF.Data.Services
{
    public class MatchsServices
    {
        private readonly MyDbContext _context;
       
        public MatchsServices(MyDbContext context)
        {
            _context = context;
          
        }

        public void AddMatchs(Matchs p)
        {
            if (p==null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Add(p);
            _context.SaveChanges();

        }

        public IEnumerable<Matchs> GetAllMatchs()
        {
            return _context.ecoach_matchs.ToList();
        }

        public void DeleteMatchs(Matchs p)
        {
            //si l'objet personne est null, on renvoi une exception
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            // on met à jour le context
            _context.ecoach_matchs.Remove(p);
            _context.SaveChanges();
        }

        

        public Matchs GetMatchsById(int id)
        {
            return _context.ecoach_matchs.FirstOrDefault(p => p.id == id);
        }

        public void UpdatePersonne(Matchs p)
        {
            // le context est modifié automatiquement, on persiste les changements
            _context.SaveChanges();

        }
    }
}

