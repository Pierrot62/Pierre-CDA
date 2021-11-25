using APISurPlusieurTables.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISurPlusieurTables.Data.Services
{
    public class EmployerServices
    {
        private readonly MyDbContext _context;
        public EmployerServices(MyDbContext context)
        {
            _context = context;
        }

        //Add
        public void AddEmployer(Employer e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.Employer.Add(e);
            _context.SaveChanges();
        }

        //Delete
        public void DeleteEmployer(Employer e, Voiture v)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }
            _context.Employer.Remove(e);
            _context.Voiture.Remove(v);
            _context.SaveChanges();
        }

        //FindAll
        public IEnumerable<Employer> GetAllEmployers()
        {
            var liste = (from e1 in _context.Employer
                        join e2 in _context.Voiture
                        on e1.IdVoiture equals e2.IdVoiture
                        select new Employer
                        {
                            IdEmployer = e1.IdEmployer,
                            NomEmployer = e1.NomEmployer,
                            PrenomEmployer = e1.PrenomEmployer,
                            IdVoiture = e2.IdVoiture,
                            Tuture = e2
                        }).ToList();
            return liste;
        }

        //FindById
        public Employer GetEmployerById(int id)
        {
            var liste = (from e1 in _context.Employer
                         join e2 in _context.Voiture
                         on e1.IdVoiture equals e2.IdVoiture
                         select new Employer
                         {
                             IdEmployer = e1.IdEmployer,
                             NomEmployer = e1.NomEmployer,
                             PrenomEmployer = e1.PrenomEmployer,
                             IdVoiture = e2.IdVoiture,
                             Tuture = e2
                         }).FirstOrDefault(e => e.IdEmployer == id);
            return liste;
        }

        //Update
        public void UpdateEmployer(Employer e)
        {

            _context.SaveChanges();
        }

    }
}
