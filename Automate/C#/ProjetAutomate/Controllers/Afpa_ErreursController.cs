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
    public class Afpa_ErreursController : ControllerBase
    {

        private readonly Afpa_ErreursServices _service;
        private readonly IMapper _mapper;

        public Afpa_ErreursController(Afpa_ErreursServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Erreurs
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_ErreursDTOOut>> GetAllAfpa_Erreurs()
        {
            IEnumerable<Afpa_Erreur> listeAfpa_Erreurs = _service.GetAllAfpa_Erreurs();
            return Ok(_mapper.Map<IEnumerable<Afpa_ErreursDTOOut>>(listeAfpa_Erreurs));
        }

        //GET api/Afpa_Erreurs/{i}
        [HttpGet("{id}", Name = "GetAfpa_ErreurById")]
        public ActionResult<Afpa_ErreursDTOOut> GetAfpa_ErreurById(int id)
        {
            Afpa_Erreur commandItem = _service.GetAfpa_ErreurById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_ErreursDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Erreurs
        [HttpPost]
        public ActionResult<Afpa_ErreursDTOOut> CreateAfpa_Erreur(Afpa_ErreursDTOIn objIn)
        {
            Afpa_Erreur obj = _mapper.Map<Afpa_Erreur>(objIn);
            _service.AddAfpa_Erreur(obj);
            return CreatedAtRoute(nameof(GetAfpa_ErreurById), new { Id = obj.IdErreur }, obj);
        }

        //POST api/Afpa_Erreurs/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Erreur(int id, Afpa_ErreursDTOIn obj)
        {
            Afpa_Erreur objFromRepo = _service.GetAfpa_ErreurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Erreur(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Erreurs/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Erreur(int id)
        {
            Afpa_Erreur obj = _service.GetAfpa_ErreurById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Erreur(obj);
            return NoContent();
        }


    }
}
