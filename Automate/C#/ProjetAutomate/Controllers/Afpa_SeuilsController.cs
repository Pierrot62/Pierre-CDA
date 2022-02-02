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
    public class Afpa_SeuilsController : ControllerBase
    {

        private readonly Afpa_SeuilsServices _service;
        private readonly IMapper _mapper;

        public Afpa_SeuilsController(Afpa_SeuilsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Seuils
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_SeuilsDTOOut>> GetAllAfpa_Seuils()
        {
            IEnumerable<Afpa_Seuil> listeAfpa_Seuils = _service.GetAllAfpa_Seuils();
            return Ok(_mapper.Map<IEnumerable<Afpa_SeuilsDTOOut>>(listeAfpa_Seuils));
        }

        //GET api/Afpa_Seuils/{i}
        [HttpGet("{id}", Name = "GetAfpa_SeuilById")]
        public ActionResult<Afpa_SeuilsDTOOut> GetAfpa_SeuilById(int id)
        {
            Afpa_Seuil commandItem = _service.GetAfpa_SeuilById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_SeuilsDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Seuils
        [HttpPost]
        public ActionResult<Afpa_SeuilsDTOOut> CreateAfpa_Seuil(Afpa_SeuilsDTOIn objIn)
        {
            Afpa_Seuil obj = _mapper.Map<Afpa_Seuil>(objIn);
            _service.AddAfpa_Seuil(obj);
            return CreatedAtRoute(nameof(GetAfpa_SeuilById), new { Id = obj.IdSeuil }, obj);
        }

        //POST api/Afpa_Seuils/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Seuil(int id, Afpa_SeuilsDTOIn obj)
        {
            Afpa_Seuil objFromRepo = _service.GetAfpa_SeuilById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Seuil(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Seuils/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Seuil(int id)
        {
            Afpa_Seuil obj = _service.GetAfpa_SeuilById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Seuil(obj);
            return NoContent();
        }


    }
}
