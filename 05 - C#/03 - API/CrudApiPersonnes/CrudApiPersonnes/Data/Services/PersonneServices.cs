using CrudApiPersonnes.Data.Models;
using CrudApiPersonnes.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiPersonnes.Data.Services
{
    public class PersonneServices
    {
        private readonly MyDbContext _context;
        public PersonneServices(MyDbContext context)
        {
            _context = context;
        }

        //Ajout
        public void AddPersonne(Personne p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Personnes.Add(p);
            _context.SaveChanges();
        }

        public void DeletePersonne(Personne p)
        {
            if (p == null)
            {
                throw new ArgumentNullException(nameof(p));
            }
            _context.Personnes.Remove(p);
            _context.SaveChanges();

        }

        public IEnumerable<Personne> GetAllPersonnes()
        {
            return _context.Personnes.ToList();
        }

        public Personne GetPersonneById(int id)
        {
            return _context.Personnes.FirstOrDefault(p => p.Id == id);
        }

        public void UpdatePersonne(Personne p)
        {
            _context.SaveChanges();
        }
    }
}
