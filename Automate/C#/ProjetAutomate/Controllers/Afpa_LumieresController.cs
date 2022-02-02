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
    public class Afpa_LumieresController:ControllerBase
    {

        private readonly Afpa_LumieresServices _service;
        private readonly IMapper _mapper;

        public Afpa_LumieresController(Afpa_LumieresServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Lumieres
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_LumieresDTOOut>> GetAllAfpa_Lumieres()
        {
            IEnumerable<Afpa_Lumiere> listeAfpa_Lumieres = _service.GetAllAfpa_Lumieres();
            return Ok(_mapper.Map<IEnumerable<Afpa_LumieresDTOOut>>(listeAfpa_Lumieres));
        }

        //GET api/Afpa_Lumieres/{i}
        [HttpGet("{id}", Name = "GetAfpa_LumiereById")]
        public ActionResult<Afpa_LumieresDTOOut> GetAfpa_LumiereById(int id)
        {
            Afpa_Lumiere commandItem = _service.GetAfpa_LumiereById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_LumieresDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Lumieres
        [HttpPost]
        public ActionResult<Afpa_LumieresDTOIn> CreateAfpa_Lumiere(Afpa_LumieresDTOIn objIn)
        {
            Afpa_Lumiere obj = _mapper.Map<Afpa_Lumiere>(objIn);
            _service.AddAfpa_Lumiere(obj);
            return CreatedAtRoute(nameof(GetAfpa_LumiereById), new { Id = obj.IdLumiere }, obj);
        }

        //POST api/Afpa_Lumieres/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Lumiere(int id, Afpa_LumieresDTOIn obj)
        {
            Afpa_Lumiere objFromRepo = _service.GetAfpa_LumiereById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Lumiere(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Lumieres/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Lumiere(int id)
        {
            Afpa_Lumiere obj = _service.GetAfpa_LumiereById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Lumiere(obj);
            return NoContent();
        }
    }
}
