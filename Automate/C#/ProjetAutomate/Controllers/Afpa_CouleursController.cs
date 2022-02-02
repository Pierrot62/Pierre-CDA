using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetAutomate.Data.Dtos;
using ProjetAutomate.Data.Models;
using ProjetAutomate.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetAutomate.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Afpa_CouleursController:ControllerBase
    {

        private readonly Afpa_CouleursServices _service;
        private readonly IMapper _mapper;

        public Afpa_CouleursController(Afpa_CouleursServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Couleurs
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_CouleursDTOOut>> GetAllAfpa_Couleurs()
        {
            IEnumerable<Afpa_Couleur> listeAfpa_Couleurs = _service.GetAllAfpa_Couleurs();
            return Ok(_mapper.Map<IEnumerable<Afpa_CouleursDTOOut>>(listeAfpa_Couleurs));
        }

        //GET api/Afpa_Couleurs/{i}
        [HttpGet("{id}", Name = "GetAfpa_CouleurById")]
        public ActionResult<Afpa_CouleursDTOOut> GetAfpa_CouleurById(int id)
        {
            Afpa_Couleur commandItem = _service.GetAfpa_CouleurById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_CouleursDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Couleurs
        [HttpPost]
        public ActionResult<Afpa_CouleursDTOIn> CreateAfpa_Couleur(Afpa_CouleursDTOIn objIn)
        {
            Afpa_Couleur obj = _mapper.Map<Afpa_Couleur>(objIn);
            _service.AddAfpa_Couleur(obj);
            return CreatedAtRoute(nameof(GetAfpa_CouleurById), new { Id = obj.IdCouleur }, obj);
        }

        //POST api/Afpa_Couleurs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Couleur(int id, Afpa_CouleursDTOIn obj)
        {
            Afpa_Couleur objFromRepo = _service.GetAfpa_CouleurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Couleur(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Couleurs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Couleur(int id)
        {
            Afpa_Couleur obj = _service.GetAfpa_CouleurById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Couleur(obj);
            return NoContent();
        }


    }
}
