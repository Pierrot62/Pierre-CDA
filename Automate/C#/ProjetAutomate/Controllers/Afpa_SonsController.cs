using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetAutomate.Data.Models;
using ProjetAutomate.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjetAutomate.Data.Dtos.Afpa_SonsDTO;

namespace ProjetAutomate.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Afpa_SonsController : ControllerBase
    {

        private readonly Afpa_SonsServices _service;
        private readonly IMapper _mapper;

        public Afpa_SonsController(Afpa_SonsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Sons
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_SonsDTOOut>> GetAllAfpa_Sons()
        {
            IEnumerable<Afpa_Son> listeAfpa_Sons = _service.GetAllAfpa_Sons();
            return Ok(_mapper.Map<IEnumerable<Afpa_SonsDTOOut>>(listeAfpa_Sons));
        }

        //GET api/Afpa_Sons/{i}
        [HttpGet("{id}", Name = "GetAfpa_SonById")]
        public ActionResult<Afpa_SonsDTOOut> GetAfpa_SonById(int id)
        {
            Afpa_Son commandItem = _service.GetAfpa_SonById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_SonsDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Sons
        [HttpPost]
        public ActionResult<Afpa_SonsDTOOut> CreateAfpa_Son(Afpa_SonsDTOIn objIn)
        {
            Afpa_Son obj = _mapper.Map<Afpa_Son>(objIn);
            _service.AddAfpa_Son(obj);
            return CreatedAtRoute(nameof(GetAfpa_SonById), new { Id = obj.IdSon }, obj);
        }

        //POST api/Afpa_Sons/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Son(int id, Afpa_SonsDTOIn obj)
        {
            Afpa_Son objFromRepo = _service.GetAfpa_SonById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Son(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Sons/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Son(int id)
        {
            Afpa_Son obj = _service.GetAfpa_SonById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Son(obj);
            return NoContent();
        }


    }
}
