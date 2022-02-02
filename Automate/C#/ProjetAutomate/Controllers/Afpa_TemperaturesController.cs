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
    public class Afpa_TemperaturesController : ControllerBase
    {

        private readonly Afpa_TemperaturesServices _service;
        private readonly IMapper _mapper;

        public Afpa_TemperaturesController(Afpa_TemperaturesServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Afpa_Temperatures
        [HttpGet]
        public ActionResult<IEnumerable<Afpa_TemperaturesDTOOut>> GetAllAfpa_Temperatures()
        {
            IEnumerable<Afpa_Temperature> listeAfpa_Temperatures = _service.GetAllAfpa_Temperatures();
            return Ok(_mapper.Map<IEnumerable<Afpa_TemperaturesDTOOut>>(listeAfpa_Temperatures));
        }

        //GET api/Afpa_Temperatures/{i}
        [HttpGet("{id}", Name = "GetAfpa_TemperatureById")]
        public ActionResult<Afpa_TemperaturesDTOOut> GetAfpa_TemperatureById(int id)
        {
            Afpa_Temperature commandItem = _service.GetAfpa_TemperatureById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<Afpa_TemperaturesDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Afpa_Temperatures
        [HttpPost]
        public ActionResult<Afpa_TemperaturesDTOOut> CreateAfpa_Temperature(Afpa_TemperaturesDTOIn objIn)
        {
            Afpa_Temperature obj = _mapper.Map<Afpa_Temperature>(objIn);
            _service.AddAfpa_Temperature(obj);
            return CreatedAtRoute(nameof(GetAfpa_TemperatureById), new { Id = obj.IdTemperature }, obj);
        }

        //POST api/Afpa_Temperatures/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAfpa_Temperature(int id, Afpa_TemperaturesDTOIn obj)
        {
            Afpa_Temperature objFromRepo = _service.GetAfpa_TemperatureById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAfpa_Temperature(objFromRepo);
            return NoContent();
        }

        //DELETE api/Afpa_Temperatures/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAfpa_Temperature(int id)
        {
            Afpa_Temperature obj = _service.GetAfpa_TemperatureById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAfpa_Temperature(obj);
            return NoContent();
        }


    }
}
