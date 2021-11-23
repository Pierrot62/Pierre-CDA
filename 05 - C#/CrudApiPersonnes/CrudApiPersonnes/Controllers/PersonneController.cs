using AutoMapper;
using CrudApiPersonnes.Data.Dtos;
using CrudApiPersonnes.Data.Services;
using CrudApiPersonnes.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApiPersonnes.Controllers
{
    [Route("api/Personnes")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private readonly PersonneServices _service;
        private readonly IMapper _mapper;

        public PersonneController(PersonneServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonneDTO>> GetAllPersonnes()
        {
            var listePersonnes = _service.GetAllPersonnes();
            return Ok(_mapper.Map<IEnumerable<PersonneDTO>>(listePersonnes));
        }

        [HttpGet("{id}", Name = "GetPersonneById")]
        public ActionResult<PersonneDTO> GetPersonneById(int id)
        {
            var commandItem = _service.GetPersonneById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<PersonneDTO>(commandItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PersonneDTO> CreatePersonne(Personne personne)
        { //on ajoute l’objet à la base de données
            _service.AddPersonne(personne);
            //on retourne le chemin de findById avec l'objet créé
            return CreatedAtRoute(nameof(GetPersonneById), new { Id = personne.Id }, personne);
        }

        //PUT api/personnes/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePersonne(int id, PersonneDTO personne)
        {
            var personneFromRepo = _service.GetPersonneById(id);
            if (personneFromRepo == null)
            {
                return NotFound();
            }
            personneFromRepo.Dump();
            _mapper.Map(personne, personneFromRepo);
            personneFromRepo.Dump();
            personne.Dump();
            // inutile puisque la fonction ne fait rien, mais garde la cohérence
            _service.UpdatePersonne(personneFromRepo);
            return NoContent(); 
        }

        //DELETE api/personnes/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePersonne(int id)
        {
            var personneModelFromRepo = _service.GetPersonneById(id);
            if (personneModelFromRepo == null)
            {
                return NotFound();
            }
            _service.DeletePersonne(personneModelFromRepo); 
            return NoContent(); 
        }

    }
}
